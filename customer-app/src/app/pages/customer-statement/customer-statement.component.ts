import { Component } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';
import { AuthenticationService } from 'src/app/shared/services/account.service';
import { CustomerService } from 'src/app/shared/services/customer.service';

@Component({
  selector: 'app-customer-statement',
  templateUrl: './customer-statement.component.html',
  styleUrls: ['./customer-statement.component.scss']
})
export class CustomerStatementComponent {
  currentUser: any;
  startDate: Date = new Date();
  endDate: Date = new Date();
  dataSource: any;
  loadingVisible: boolean = false;
  mySubscription: any;
  companyName: string = '';
  startDateformattedDate: any;
  endDateformattedDate: any;

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
      this.companyName =  this.currentUser.accNo; 
    }
  }
  ngOnInit(): void {
   // const toDate = date.format('yyyy/MM/DD');
   console.log(this.currentUser);
  }

  onStartDateValueChanged(e: any) {
    console.log(e.previousValue);
    console.log(e.value);
    this.startDateformattedDate = e.value.toLocaleDateString('en-US', { year: 'numeric', month: '2-digit', day: '2-digit' });
 }
 onEndDateValueChanged(e: any) {
  console.log(e.previousValue);
  console.log(e.value);
  this.endDateformattedDate = e.value.toLocaleDateString('en-US', { year: 'numeric', month: '2-digit', day: '2-digit' });
 }
 search() {
  
 }
}
