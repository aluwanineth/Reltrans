import { Injectable } from '@angular/core';
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { AuthenticationService } from '../shared/services/account.service';

@Injectable({ providedIn: 'root' })
export class AuthGuard implements CanActivate {
    constructor(
        private router: Router,
        private authenticationService: AuthenticationService
    ) { }

    canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
        const defaultPath = '/';
        const user = this.authenticationService.userValue;
        const isAuthForm = [
            'login-form',
            'reset-password',
            'create-account',
            'change-password/:recoveryCode'
          ].includes(route.routeConfig?.path || '/');

          if (user && isAuthForm) {
            this.authenticationService.lastAuthenticatedPath = defaultPath;
            this.router.navigate([defaultPath]);
            return false;
          }
        
          if (!user && !isAuthForm) {
            this.router.navigate(['/login-form']);
          }
        
        if (user) {
            // logged in so return true
            this.authenticationService.lastAuthenticatedPath = route.routeConfig?.path || defaultPath;
            return true;
        } else {
            // not logged in so redirect to login page with the return url
            this.router.navigate(['/login-form']);
           // this.router.navigate(['/login-form'], { queryParams: { returnUrl: state.url } });
            return false;
        }
    }
}
