import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginFormComponent, ResetPasswordFormComponent, CreateAccountFormComponent, ChangePasswordFormComponent } from './shared/components';
import { AuthGuardService } from './shared/services';
import { HomeComponent } from './pages/home/home.component';
import { ProfileComponent } from './pages/profile/profile.component';
import { TasksComponent } from './pages/tasks/tasks.component';
import { DxButtonModule, DxDataGridModule, DxDropDownBoxModule, DxFormModule, DxLoadIndicatorModule, DxLoadPanelModule, DxPopupModule, DxTreeViewComponent, DxTreeViewModule } from 'devextreme-angular';
import { AuthGuard } from './_helpers';
import { CustomerUserComponent } from './pages/customer-user/customer-user.component';
import { CustomerRegisterComponent } from './pages/customer-register/customer-register.component';
import { CustomerOrderComponent } from './pages/customer-order/customer-order.component';

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
  { path: 'customer-orders', component: CustomerOrderComponent, canActivate: [AuthGuard] },
  
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
    DxLoadPanelModule],
    
  providers: [AuthGuardService],
  exports: [RouterModule],
  declarations: [
    HomeComponent,
    ProfileComponent,
    TasksComponent,
    CustomerUserComponent,
    CustomerRegisterComponent,
    CustomerOrderComponent

  ]
})
export class AppRoutingModule { }
