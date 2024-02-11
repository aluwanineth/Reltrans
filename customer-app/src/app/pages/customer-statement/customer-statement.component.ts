import { Component } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';
import { CustomerService } from 'src/app/shared/services/customer.service';
import { exportDataGrid } from 'devextreme/excel_exporter';
import * as ExcelJS from 'exceljs';
import { saveAs } from 'file-saver'
import Swal from 'sweetalert2';
import { AuthService } from 'src/app/shared/services';
import notify from 'devextreme/ui/notify';

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
  popupVisible: boolean = false;
  mySubscription: any;
  companyName: string = '';
  startDateformattedDate: any;
  endDateformattedDate: any;
 

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
      this.companyName =  this.currentUser.accNo; 
    }
    this.viewInvoiceOnClick = this.viewInvoiceOnClick.bind(this);
    this.isViewInvoice = this.isViewInvoice.bind(this);
  }

  ngOnInit(): void {
    const now = new Date();
    const eDate = new Date();
    const currentMonth = eDate.getMonth();
    const previousMonth = currentMonth - 1;
    this.startDate = new Date(now.getFullYear(), now.getMonth() - 1, 1);
    this.endDate = new Date(eDate.getFullYear(), previousMonth, 30);
    this.startDateformattedDate = this.startDate.toLocaleDateString('en-US', { year: 'numeric', month: '2-digit', day: '2-digit' });
    this.endDateformattedDate = this.endDate.toLocaleDateString('en-US', { year: 'numeric', month: '2-digit', day: '2-digit' });
   // this.endDate.setDate(0);
   this.search();
  }

  onStartDateValueChanged(e: any) {
    this.startDateformattedDate = e.value.toLocaleDateString('en-US', { year: 'numeric', month: '2-digit', day: '2-digit' });
 }
 onEndDateValueChanged(e: any) {
  this.endDateformattedDate = e.value.toLocaleDateString('en-US', { year: 'numeric', month: '2-digit', day: '2-digit' });
 }
 search() {
     this.loadingVisible = true;
    this.customerService.getCustomerStatement(this.companyName, this.startDateformattedDate, this.endDateformattedDate)
    .subscribe( data => {
      this.dataSource = data.result;
      console.log(JSON.stringify(this.dataSource));
      this.loadingVisible = false;
    },
    error => {
      this.loadingVisible = false;
      notify({ message: error.error.Message, width: 300, shading: true }, 'error', 5000);
    });
 }

 viewInvoiceOnClick(e: any){
  const data = e.row.data;

  if(data.ourRef.includes('INV')) {
     const invoiceNo = data.ourRef;
     //this.popupVisible = true;
     this.router.navigate(['/customer-invoice',invoiceNo]);
     console.log(invoiceNo)
  } else {
    Swal.fire(
      '',
      'Please select an invoive'
      ,
      'info'
    );
  }
 }

 private static isChief(position: any) {
  return position && ['CEO', 'CMO'].indexOf(position.trim().toUpperCase()) >= 0;
 }

 isViewInvoice(e: any) {
  console.log(e.data.ourRef.includes('INV'));
  if(e.data.ourRef.includes('INV'))
     return true;
    else
       return false;
 }

 shouldShowInvoiceButton(): boolean {
  // Your condition here to check if 'ourRef' column contains 'INV'
  // For example, assuming you have an array of items bound to the grid called 'gridData':
  return this.dataSource.some((item: { ourRef: string | string[]; }) => item.ourRef.includes('INV'));
}
 
 onExporting(e: any) {
  const workbook = new ExcelJS.Workbook();
  const ws = workbook.addWorksheet('Statement Data');

  exportDataGrid({
    component: e.component,
    worksheet: ws,
    autoFilterEnabled: true
  // tslint:disable-next-line: only-arrow-functions
  }).then(function() {
    // https://github.com/exceljs/exceljs#writing-xlsx
    // tslint:disable-next-line: only-arrow-functions
    workbook.xlsx.writeBuffer().then(function(buffer: any) {
      saveAs(new Blob([buffer], { type: 'application/octet-stream' }), 'Statement.xlsx');
    });
  });
  e.cancel = true;
 }
 customizeText(value: any) {
  return new Intl.NumberFormat('en-US', { minimumFractionDigits: 2, maximumFractionDigits: 2 }).format(value);
}
}
