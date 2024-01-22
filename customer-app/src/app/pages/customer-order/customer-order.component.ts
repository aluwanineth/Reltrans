import { Component } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';
import { Customer } from 'src/app/shared/models/customer.model';
import { AuthenticationService } from 'src/app/shared/services/account.service';
import { CustomerService } from 'src/app/shared/services/customer.service';

@Component({
  selector: 'app-customer-order',
  templateUrl: './customer-order.component.html',
  styleUrls: ['./customer-order.component.scss']
})
export class CustomerOrderComponent {
  currentUser: Customer | null = { email: '',firstName: '',surname:'', accNo: '', companyName:'',contactTelNo:'', memberType: [] };
  accNo: string = '';
  dataSource: any;
  loadingVisible: boolean = false;

  constructor(private router: Router, private customerService: CustomerService,
    private authService: AuthenticationService) {
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
    });
  }
}
