import { Component, Input } from '@angular/core';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import { exportDataGrid } from 'devextreme/excel_exporter';
import * as ExcelJS from 'exceljs';
import { saveAs } from 'file-saver';
import { AuthService } from 'src/app/shared/services';
import { CustomerService } from 'src/app/shared/services/customer.service';

@Component({
  selector: 'app-customer-invoice',
  templateUrl: './customer-invoice.component.html',
  styleUrls: ['./customer-invoice.component.scss']
})
export class CustomerInvoiceComponent {
  currentUser: any;
  startDate: Date = new Date();
  //startDate: string = '';
  dataSource: any;
  loadingVisible: boolean = false;
  mySubscription: any;
  companyName: string = '';
  formattedDate: any;

  constructor(private router: Router, private customerService: CustomerService,
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
      this.companyName =  this.currentUser.accNo; 
    }
  }
  ngOnInit(): void {
    const invoice = this.route.snapshot.paramMap.get('invoiceNo');
    this.loadingVisible = true;
    this.customerService.getCustomerOrderInvoice(this.companyName, invoice)
    .subscribe( data => {
      this.dataSource = data.result;
      console.log(this.dataSource);
      this.loadingVisible = false;
    });
  }

  onExporting(e: any) {
    const workbook = new ExcelJS.Workbook();
    const ws = workbook.addWorksheet('Order Data');

    exportDataGrid({
      component: e.component,
      worksheet: ws,
      autoFilterEnabled: true
    // tslint:disable-next-line: only-arrow-functions
    }).then(function() {
      // https://github.com/exceljs/exceljs#writing-xlsx
      // tslint:disable-next-line: only-arrow-functions
      workbook.xlsx.writeBuffer().then(function(buffer: any) {
        saveAs(new Blob([buffer], { type: 'application/octet-stream' }), 'OrderHistory.xlsx');
      });
    });
    e.cancel = true;
  }
  goBack() {
    this.router.navigate(['/customer-statement'])
  }
}
