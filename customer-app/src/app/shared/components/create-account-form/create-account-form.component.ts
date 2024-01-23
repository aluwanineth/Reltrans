import { CommonModule } from '@angular/common';
import { Component, NgModule } from '@angular/core';
import { Router, RouterModule } from '@angular/router';
import { ValidationCallbackData } from 'devextreme-angular/common';
import { DxFormModule } from 'devextreme-angular/ui/form';
import { DxLoadIndicatorModule } from 'devextreme-angular/ui/load-indicator';
import notify from 'devextreme/ui/notify';
import { AuthService } from '../../services';
import { AuthenticationService } from '../../services/account.service';
import { first } from 'rxjs';


@Component({
  selector: 'app-create-account-form',
  templateUrl: './create-account-form.component.html',
  styleUrls: ['./create-account-form.component.scss']
})
export class CreateAccountFormComponent {
  loading = false;
  formData: any = {};

  constructor(private authService: AuthenticationService, private router: Router) { }

  async onSubmit(e: Event) {
    e.preventDefault();
    //const {firstName, surname, companyName, contactTelNo, email, password } = this.formData;
    let model = {
      "firstName": this.formData.firstName,
      "surname": this.formData.surname,
      "accNo": this.formData.companyName,
      "companyName": this.formData.companyName,
      "contactTelNo": this.formData.contactTelNo,
      "memberType": "Administrator",
      "email": this.formData.email,
      "password": this.formData.password,
      "confirmPassword": this.formData.confirmedPassword
    };
    console.log(JSON.stringify(model));
    this.loading = true;
    this.authService.register(model)
        .pipe(first())
        .subscribe(
            data => {
              notify({
                message: data.result.message,
                position: {
                    my: 'center top',
                    at: 'center top'
                }
              }, 'success', 5000);
              this.router.navigate(['/user-data']);
            },
            error => {
              notify({ message: error.error.Message, width: 300, shading: true }, 'error', 5000);
            }
        );
    this.loading = false;
  }

  confirmPassword = (e: ValidationCallbackData) => {
    return e.value === this.formData.password;
  }
}
@NgModule({
  imports: [
    CommonModule,
    RouterModule,
    DxFormModule,
    DxLoadIndicatorModule
  ],
  declarations: [ CreateAccountFormComponent ],
  exports: [ CreateAccountFormComponent ]
})
export class CreateAccountFormModule { }
