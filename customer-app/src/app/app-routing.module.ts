import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginFormComponent, ResetPasswordFormComponent, CreateAccountFormComponent, ChangePasswordFormComponent } from './shared/components';
import { AuthGuardService } from './shared/services';
import { HomeComponent } from './pages/home/home.component';
import { ProfileComponent } from './pages/profile/profile.component';
import { TasksComponent } from './pages/tasks/tasks.component';
import { DxAccordionModule, DxBoxModule, DxButtonModule, DxChartModule, DxDataGridModule, DxDateBoxModule, DxDropDownBoxModule, DxFormModule, DxListModule, DxLoadIndicatorModule, DxLoadPanelModule, DxPopupModule, DxSelectBoxModule, DxTabPanelModule, DxTemplateModule, DxTextAreaModule, DxTreeViewComponent, DxTreeViewModule, DxValidationSummaryModule } from 'devextreme-angular';
import { AuthGuard } from './_helpers';
import { CustomerUserComponent } from './pages/customer-user/customer-user.component';
import { CustomerRegisterComponent } from './pages/customer-register/customer-register.component';
import { CustomerOrderComponent } from './pages/customer-order/customer-order.component';
import { CustomerListComponent } from './pages/customer-list/customer-list.component';
import { CustomerOrderHistoryComponent } from './pages/customer-order-history/customer-order-history.component';
import { CustomerInvoiceComponent } from './pages/customer-invoice/customer-invoice.component';
import { CustomerStatementComponent } from './pages/customer-statement/customer-statement.component';
import { FormsModule } from '@angular/forms';

const routes: Routes = [
  {
    path: 'tasks',
    component: TasksComponent,
    canActivate: [ AuthGuard ]
  },
  {
    path: 'profile',
    component: ProfileComponent,
    canActivate: [ AuthGuard ]
  },
  {
    path: 'home',
    component: HomeComponent,
    canActivate: [ AuthGuard ]
  },
  {
    path: 'login-form',
    component: LoginFormComponent
  },
  {
    path: 'reset-password',
    component: ResetPasswordFormComponent,
    canActivate: [ AuthGuard ]
  },
  {
    path: 'create-account',
    component: CreateAccountFormComponent
  },
  {
    path: 'change-password/:recoveryCode',
    component: ChangePasswordFormComponent,
    canActivate: [ AuthGuard ]
  },
  { path: 'user-data', component: CustomerUserComponent, canActivate: [AuthGuard] },
  { path: 'create-customer', component: CustomerUserComponent, canActivate: [AuthGuard] },
  { path: 'open-orders', component: CustomerOrderComponent, canActivate: [AuthGuard] },
  { path: 'customer-list', component: CustomerListComponent, canActivate: [AuthGuard] },
  { path: 'customer-order-history', component: CustomerOrderHistoryComponent, canActivate: [AuthGuard] },
  { path: 'customer-invoice', component: CustomerInvoiceComponent, canActivate: [AuthGuard] },
  { path: 'customer-statement', component: CustomerStatementComponent, canActivate: [AuthGuard] },
  
  {
    path: '**',
    redirectTo: '',
    canActivate: [AuthGuard]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { useHash: true }), DxDataGridModule, DxFormModule, 
    DxButtonModule,
    DxPopupModule,
    DxLoadIndicatorModule,
    DxDropDownBoxModule,
    DxTreeViewModule,
    DxDataGridModule,
    DxLoadPanelModule,
    DxValidationSummaryModule,
    DxSelectBoxModule,
    DxChartModule,
    DxAccordionModule,
    DxTabPanelModule,
    DxTextAreaModule,
    DxBoxModule,
    FormsModule,
    DxListModule,
    DxTemplateModule,
    DxTabPanelModule,
    DxDateBoxModule,
    DxTreeViewModule],
    
  providers: [AuthGuard],
  exports: [RouterModule],
  declarations: [
    HomeComponent,
    ProfileComponent,
    TasksComponent,
    CustomerUserComponent,
    CustomerRegisterComponent,
    CustomerOrderComponent,
    CustomerListComponent,
    CustomerStatementComponent,
    CustomerInvoiceComponent,
    CustomerOrderHistoryComponent
  ]
})
export class AppRoutingModule { }
