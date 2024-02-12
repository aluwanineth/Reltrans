import { Component } from '@angular/core';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import notify from 'devextreme/ui/notify';
import { AuthService } from 'src/app/shared/services';
import { DesignGAService } from 'src/app/shared/services/design.ga.service';

@Component({
  selector: 'app-customer-ga-history',
  templateUrl: './customer-ga-history.component.html',
  styleUrls: ['./customer-ga-history.component.scss']
})
export class CustomerGaHistoryComponent {
  currentUser: any;
  dataSource: any;
  loadingVisible: boolean = false;
  mySubscription: any;
  accNo: string = '';
  formattedDate: any;

  constructor(private router: Router, private designGAService: DesignGAService,
    private authService: AuthService, private route: ActivatedRoute) {
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
      this.accNo =  this.currentUser.accNo; 
    }
  }
  ngOnInit(): void {
    const invoice = this.route.snapshot.paramMap.get('invoiceNo');
    this.loadingVisible = true;
    this.designGAService.getDesignGAHistoryByAccNo(this.accNo)
    .subscribe( data => {
      this.dataSource = data.result;
      console.log(this.dataSource);
      this.loadingVisible = false;
    },
    error => {
      this.loadingVisible = false;
      notify({ message: 'Error Occurs', width: 300, shading: true }, 'error', 5000);
    }
    );
  }
}
