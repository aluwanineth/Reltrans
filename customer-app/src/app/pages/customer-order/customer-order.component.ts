import { Component, OnInit } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';
import notify from 'devextreme/ui/notify';
import { Customer } from 'src/app/shared/models/customer.model';
import { AuthService } from 'src/app/shared/services';
import { CustomerService } from 'src/app/shared/services/customer.service';

@Component({
  selector: 'app-customer-order',
  templateUrl: './customer-order.component.html',
  styleUrls: ['./customer-order.component.scss']
})
export class CustomerOrderComponent implements OnInit{
  currentUser: Customer | null = { email: '',firstName: '',surname:'', accNo: '', companyName:'',contactTelNo:'', memberType: [] };
  accNo: string = '';
  dataSource: any;
  loadingVisible: boolean = false;

  constructor(private router: Router, private customerService: CustomerService,
    private authService: AuthService) {
    this.authService.user.subscribe(x => this.currentUser = x);
    if (this.currentUser) {
      this.accNo =  this.currentUser.accNo;
    }
  }
  
  ngOnInit(): void {
    this.loadData();
  }

  loadData() {
    this.customerService.getCustomerOrder(this.accNo)
    .subscribe( data => {
      this.dataSource = data.result;
      console.log(this.dataSource);
    },
    error => {
      this.loadingVisible = false;
      notify({ message: error.error.Message, width: 300, shading: true }, 'error', 5000);
    });
  }
}
