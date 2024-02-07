import { CommonModule } from '@angular/common';
import { Component, NgModule } from '@angular/core';
import { ActivatedRoute, Router, RouterModule } from '@angular/router';
import { DxFormModule } from 'devextreme-angular/ui/form';
import { DxLoadIndicatorModule } from 'devextreme-angular/ui/load-indicator';
import notify from 'devextreme/ui/notify';
import { AuthService } from '../../services';
import { first } from 'rxjs';


@Component({
  selector: 'app-login-form',
  templateUrl: './login-form.component.html',
  styleUrls: ['./login-form.component.scss']
})
export class LoginFormComponent {
  loading = false;
  formData: any = {};
  error = '';

  constructor(private authService: AuthService, private router: Router, private route: ActivatedRoute) { }

  async onSubmit(e: Event) {
    e.preventDefault();
    const { email, password } = this.formData;
    ///this.loading = true;

    this.authService.logIn(email, password)
    .pipe(first())
    .subscribe({
        next: () => {
            // get return url from route parameters or default to '/'
            const url = this.route.snapshot.queryParams['returnUrl'] || '/home';
            this.router.navigate([url]);
        },
        error: error => {
            this.error = error.error.Message;
            console.log(this.error);
            this.loading = false;
            notify(this.error, 'error', 5000);
        }
    });
  }


  onCreateAccountClick = () => {
    this.router.navigate(['/create-account']);
  }
}
@NgModule({
  imports: [
    CommonModule,
    RouterModule,
    DxFormModule,
    DxLoadIndicatorModule
  ],
  declarations: [ LoginFormComponent ],
  exports: [ LoginFormComponent ]
})
export class LoginFormModule { }
