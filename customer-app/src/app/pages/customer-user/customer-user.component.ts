import { Component, OnInit } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';
import notify from 'devextreme/ui/notify';
import { first } from 'rxjs';
import { AuthService } from 'src/app/shared/services';
import { CustomerService } from 'src/app/shared/services/customer.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-customer-user',
  templateUrl: './customer-user.component.html',
  styleUrls: ['./customer-user.component.scss']
})
export class CustomerUserComponent implements OnInit {
  currentUser: any;
  dataSource: any;
  popupVisible: boolean = false;
  mySubscription: any;
  companyName: string = '';
  contactTelNo: string = ''; 
  customer: Array<any> = [];
  memberTypes: string[] = ["Administrator", "Accountant", "Project Manager", "Buyer"];

  
  constructor(private router: Router, private customerService: CustomerService,
      private authService: AuthService) {
      this.authService.user.subscribe(x => this.currentUser = x);
      // tslint:disable-next-line: only-arrow-functions
      this.router.routeReuseStrategy.shouldReuseRoute = function() {
          return false;
      };

      this.mySubscription = this.router.events.subscribe((event) => {
          if (event instanceof NavigationEnd) {
          // Trick the Router into believing it's last link wasn't previously loaded
          this.router.navigated = false;
          }
      });
      if (this.currentUser) {
        this.companyName =  this.currentUser.companyName; 
        this.contactTelNo = this.currentUser.contactTelNo;
      }
  }
  ngOnInit(): void {
    console.log(this.currentUser);
   // this.companyName = this.currentUser[0].companyName;
    this.loadData(this.companyName);
  }

  loadData(companyName: string) {
    this.customerService.getCustomerByCompanyName(companyName)
    .subscribe( data => {
      this.dataSource = data.result;
      console.log(this.dataSource);
    },
    error => {
      notify({ message: error.error.Message, width: 300, shading: true }, 'error', 5000);
    });
  }

  register() {
    this.popupVisible = true;
  }

  onRowUserUpdated(e: any) {
    let memberType: string[] = [e.data.memberType];
    if (e.data.memberType === 'Administrator') {
      Swal.fire(
        '',
        'You cant update system admin'
        ,
        'info'
      );
      this.loadData(this.companyName);
    } else {
    this.customer.push(e.data);
    const customerData = {
      id: e.data.id,
      firstName: e.data.firstName,
      surname: e.data.surname,
      contactTelNo: e.data.contactTelNo,
      memberType: memberType,
      email: e.data.email
    };
    console.log(JSON.stringify(customerData));
    this.authService.update(customerData)
    .pipe(first())
    .subscribe( data => {
      Swal.fire(
        '',
        'Successfully Updated',
        'success'
      );
    }, error => {
      console.log(error);
     // notify({ message: error, width: 300, shading: true }, 'error', 5000);
      Swal.fire(
        '',
        error || 'Internal Server Error'
        ,
        'error'
      );
    });
  }
  }

  onDeleteCustomer(e: any) {
    const id = e.data.id;
    const username  = e.data.email;
    if (e.data.id === 'Administrator') {
      Swal.fire(
        '',
        'You cant delete system admin'
        ,
        'info'
      );
      this.loadData(this.companyName);
    } else {
      Swal.fire({
        title: 'Are you sure? ',
        text: 'You want to delete ' + username + ' username?',
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
      }).then((result) => {
        if (result.value) {
          this.authService.delete(id)
                .pipe(first())
                  .subscribe( data => {
                    const audit = {
                      action: 'Deleting user (' + username + ')',
                      actionId: e.data.username,
                      createdDate: Date.now(),
                      username: this.currentUser.username,
                      type: 'User'
                    };
                  }, error => {
                    console.log(error);
                    // notify({ message: error, width: 300, shading: true }, 'error', 5000);
                    Swal.fire(
                      '',
                      error || 'Internal Server Error'
                      ,
                      'error'
                    );
                  });
        }
      });
    }
  }
}

