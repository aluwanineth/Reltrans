import { Injectable } from '@angular/core';
import { CanActivate, Router, ActivatedRouteSnapshot } from '@angular/router';
import { BehaviorSubject, Observable, catchError, map, retry, throwError } from "rxjs";
import { Customer } from "../models/customer.model";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { environment } from "src/environments/environment";
import { AuthResponse } from "../models/login.response.model";

export interface IUser {
  email: string;
  avatarUrl?: string;
}

const defaultPath = '/';
const defaultUser = {
  email: 'sandra@example.com',
  avatarUrl: 'https://js.devexpress.com/Demos/WidgetsGallery/JSDemos/images/employees/06.png'
};

@Injectable()
export class AuthService {
  private userSubject: BehaviorSubject<Customer | null>;
  public user: Observable<Customer | null>;
  private tokenSubject: BehaviorSubject<AuthResponse | null>;
  public token: Observable<AuthResponse | null>;

  private _lastAuthenticatedPath: string = defaultPath;
  set lastAuthenticatedPath(value: string) {
    this._lastAuthenticatedPath = value;
  }

  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  };
  
  constructor(
      private router: Router,
      private http: HttpClient
  ) {
      this.userSubject = new BehaviorSubject<Customer | null>(null);
      this.user = this.userSubject.asObservable();

      this.tokenSubject = new BehaviorSubject<AuthResponse | null>(null);
      this.token = this.tokenSubject.asObservable();
  }

  public get userValue() {
      return this.userSubject.value;
  }

  public get tokenValue() {
    return this.tokenSubject.value;
  }
  get loggedIn(): boolean {
    return !!this.tokenSubject.value;
  }

  logIn(email: string, password: string) {
    return this.http.post<any>(`${environment.apiUrl}/api/Account/login`, { email, password }, { withCredentials: true })
            .pipe(map(user => {
                this.userSubject.next(user.result.customer);
                this.tokenSubject.next(user);
                console.log(user);
              //  this.startRefreshTokenTimer();
              this.router.navigate([this._lastAuthenticatedPath]);
                return user.result;
            }));
  }

  async createAccount(email: string, password: string) {
    try {
      // Send request

      this.router.navigate(['/create-account']);
      return {
        isOk: true
      };
    }
    catch {
      return {
        isOk: false,
        message: "Failed to create account"
      };
    }
  }

  async changePassword(email: string, recoveryCode: string) {
    try {
      // Send request

      return {
        isOk: true
      };
    }
    catch {
      return {
        isOk: false,
        message: "Failed to change password"
      }
    }
  }

  async resetPassword(email: string) {
    try {
      // Send request

      return {
        isOk: true
      };
    }
    catch {
      return {
        isOk: false,
        message: "Failed to reset password"
      };
    }
  }

  async logOut() {
    this.userSubject.next(null);
    this.tokenSubject.next(null);
    this.router.navigate(['/login-form']);
  }

  register(customer: any): Observable<any> {
    console.log(customer);
    return this.http.post<any>(`${environment.apiUrl}/api/Account/registerAdministrator`, customer, this.httpOptions)
    // tslint:disable-next-line: no-shadowed-variable
  }

  refreshToken() {
    return this.http.post<any>(`${environment.apiUrl}/api/Account/refresh`, {}, { withCredentials: true })
        .pipe(map((user) => {
            this.userSubject.next(user);
          //  this.startRefreshTokenTimer();
            return user;
        }));
}

registerCustomer(customer: any): Observable<any> {
    console.log(customer);
    return this.http.post<any>(`${environment.apiUrl}/api/Account/registerCustomer`, customer, this.httpOptions)
    // tslint:disable-next-line: no-shadowed-variable
  }

  confirmRegistration(userId: string) {
    console.log('confinr', userId);
    return this.http.post(`${environment.apiUrl}/api/Account/confirm-Registration?userId=${userId}`,{}, this.httpOptions);
  }

  assignRoles(roles: any): Observable<any> {
    console.log(roles);
    return this.http.post<any>(`${environment.apiUrl}/api/Account/assignRoles`, roles, this.httpOptions)
    // tslint:disable-next-line: no-shadowed-variable
    .pipe(
      retry(1),
      catchError(this.errorHandl)
    );
  }

  removeRoles(roles: any): Observable<any> {
    console.log(roles);
    return this.http.post<any>(`${environment.apiUrl}/api/Account/removeRoles`, roles, this.httpOptions)
    // tslint:disable-next-line: no-shadowed-variable
    .pipe(
      retry(1),
      catchError(this.errorHandl)
    );
  }


delete(id: number) {
    return this.http.delete(`${environment.apiUrl}/api/Account/delete?id=${id}`);
}

update(request: any): Observable<any>{
  return this.http.put<any>(`${environment.apiUrl}/api/Account/update`, request, this.httpOptions)
}

// helper methods
errorHandl(error: any) {
    console.log(error);
    let errorMessage = '';
    if (error.error instanceof ErrorEvent) {
      // Get client-side error
      errorMessage = error.message;
    } else {
      // Get server-side error
      errorMessage = error.error.message;
      //errorMessage = `Error Code: ${error.status}\nMessage: ${error.title}`;
    }
    console.log(errorMessage);
    return throwError(errorMessage);
 }
// private refreshTokenTimeout?: NodeJS.Timeout;

// private startRefreshTokenTimer() {
//     // parse json object from base64 encoded jwt token
//     const jwtBase64 = this.tokenValue!.result.jwToken!.split('.')[1];
//     const jwtToken = JSON.parse(atob(jwtBase64));

//     // set a timeout to refresh the token a minute before it expires
//     const expires = new Date(jwtToken.exp * 1000);
//     const timeout = expires.getTime() - Date.now() - (60 * 1000);
//     this.refreshTokenTimeout = setTimeout(() => this.refreshToken().subscribe(), timeout);
// }

// private stopRefreshTokenTimer() {
//     clearTimeout(this.refreshTokenTimeout);
// }


}

@Injectable()
export class AuthGuardService implements CanActivate {
  constructor(private router: Router, private authService: AuthService) { }

  canActivate(route: ActivatedRouteSnapshot): boolean {
    const isLoggedIn = this.authService.loggedIn;
    const isAuthForm = [
      'login-form',
      'reset-password',
      'create-account',
      'change-password/:recoveryCode'
    ].includes(route.routeConfig?.path || defaultPath);

    if (isLoggedIn && isAuthForm) {
      this.authService.lastAuthenticatedPath = defaultPath;
      this.router.navigate([defaultPath]);
      return false;
    }

    if (!isLoggedIn && !isAuthForm) {
      this.router.navigate(['/login-form']);
    }

    if (isLoggedIn) {
      this.authService.lastAuthenticatedPath = route.routeConfig?.path || defaultPath;
    }

    console.log(isLoggedIn)
    return isLoggedIn || isAuthForm;
  }
}
