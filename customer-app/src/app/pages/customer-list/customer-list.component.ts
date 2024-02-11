import { Component, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { DxDataGridComponent } from 'devextreme-angular';
import { Customer } from 'src/app/shared/models/customer.model';
import { CustomerService } from 'src/app/shared/services/customer.service';
import { confirm } from 'devextreme/ui/dialog';
import notify from 'devextreme/ui/notify';
import { first } from 'rxjs';
import Swal from 'sweetalert2';
import { AuthService } from 'src/app/shared/services';

@Component({
  selector: 'app-customer-list',
  templateUrl: './customer-list.component.html',
  styleUrls: ['./customer-list.component.scss']
})
export class CustomerListComponent {
  @ViewChild(DxDataGridComponent, { static: false })
  dataGrid!: DxDataGridComponent;
  currentUser: Customer | null = { email: '',firstName: '',surname:'', accNo: '', companyName:'',contactTelNo:'', memberType: [] };
  dataSource: any;
  activeData: any;
  pendingData: any;
  loadingVisible: boolean = false;
  focusedRowKey = 117;
  autoNavigateToFocusedRow = true;
  constructor(private router: Router, private customerService: CustomerService,
    private authService: AuthService) {
    this.authService.user.subscribe(x => this.currentUser = x);
    if (this.currentUser) {
    }
  }
  
  ngOnInit(): void {
    this.loadData();
  }

  loadData() {
    this.customerService.getCustomers()
    .subscribe( data => {
      this.dataSource = data.result;
      this.activeData = this.dataSource.filter((cust: { status: string; }) => cust.status == 'Active');
      this.pendingData = this.dataSource.filter((cust: { status: string; }) => cust.status == 'Pending');
    },
    error => {
      this.loadingVisible = false;
      notify({ message: error.error.Message, width: 300, shading: true }, 'error', 5000);
    });
  }

  onFocusedRowChanging(e: any) {
    
  }

  onFocusedRowChanged(e: any) {
    const data = e.row.data;
    console.log('selc', data);
  }

  onActivteCustomer(e: any) {
    const data = e.row.data;
    const userId = data.userId;
    Swal.fire({
      title: 'Are you sure? ',
      text: 'You want to register ' + data.email + 'customer',
      icon: 'warning',
      showCancelButton: true,
      confirmButtonColor: '#3085d6',
      cancelButtonColor: '#d33',
      confirmButtonText: 'Yes, Register!'
    }).then((result) => {
      if (result.value) {
        this.authService.confirmRegistration(userId)
        .subscribe(
            data => {
              this.loadData();
            },
            error => {
              notify({ message: error, width: 300, shading: true }, 'error', 5000);
            }
        );
      }else if (result.dismiss === Swal.DismissReason.cancel) {
        // User clicked "Cancel"
        Swal.fire({
          title: 'Registration Canceled',
          icon: 'info',
        });
      }
    });
  }

  confirmCustomer(userId: string) {
    this.authService.confirmRegistration(userId)
            .pipe(first())
            .subscribe(
                data => {
                  this.loadData();
                },
                error => {
                  notify({ message: error, width: 300, shading: true }, 'error', 5000);
                }
            );
  }
}
