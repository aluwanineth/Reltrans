import { Component, OnInit } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';
import { first } from 'rxjs';
import { AuthenticationService } from 'src/app/shared/services/account.service';
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
      private authService: AuthenticationService) {
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
    });
  }

  register() {
    this.popupVisible = true;
  }

  onRowUserUpdated(e: any) {
    if (e.data.id === 1) {
      Swal(
        '',
        'You cant update system admin'
        ,
        'info'
      );
      this.loadData(this.companyName);
    } else {
    this.customer.push(e.data);
    const customerData = {
      firstName: e.data.firstName,
      surname: e.data.surname,
      contactTelNo: e.data.contactTelNo,
      memberType: e.data.memberType,
      email: e.data.email
    };
    console.log(JSON.stringify(customerData));
    this.authService.update(customerData)
    .pipe(first())
    .subscribe( data => {
      Swal(
        '',
        'Successfully Updated',
        'success'
      );
    }, error => {
      console.log(error);
     // notify({ message: error, width: 300, shading: true }, 'error', 5000);
      Swal(
        '',
        error || 'Internal Server Error'
        ,
        'error'
      );
    });
  }
  }

  onRowRemoving(e: any) {
    const id = e.data.id;
    const email  = e.data.email;
    if (e.data.id === 1) {
      Swal(
        '',
        'You cant delete system admin'
        ,
        'info'
      );
      this.loadData(this.companyName);
    } else {
      // Swal.({
      //   title: "Are you sure?",
      //   text: "Are you sure that you want to leave this page?",
      //   icon: "warning",
      //   dangerMode: true,
      // })
      // .then(willDelete => {
      //   if (willDelete) {
      //     this.authService.delete(id)
      //     .pipe(first())
      //       .subscribe( data => {
      //         this.swal(
      //           'Deleted!',
      //           'User has been deleted.',
      //           'success'
      //         );
      //       }, error => {
      //         console.log(error);
      //         // notify({ message: error, width: 300, shading: true }, 'error', 5000);
      //         Swal(
      //           '',
      //           error || 'Internal Server Error'
      //           ,
      //           'error'
      //         );
      //       });
      //   }
      // });
    }
  }
}

