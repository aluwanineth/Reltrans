import { Injectable } from "@angular/core";
import { Router } from "@angular/router";
import { BehaviorSubject, Observable, catchError, map, retry, throwError } from "rxjs";
import { Customer } from "../models/customer.model";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { environment } from "src/environments/environment";
import { AuthResponse } from "../models/login.response.model";

@Injectable({ providedIn: 'root' })
export class AuthenticationService {
    private userSubject: BehaviorSubject<Customer | null>;
    public user: Observable<Customer | null>;
    private tokenSubject: BehaviorSubject<AuthResponse | null>;
    public token: Observable<AuthResponse | null>;

    private _lastAuthenticatedPath: string = '/home';
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


    login(email: string, password: string) {
        return this.http.post<any>(`${environment.apiUrl}/api/Account/login`, { email, password }, { withCredentials: true })
            .pipe(map(user => {
                this.userSubject.next(user.result.customer);
                this.tokenSubject.next(user);
                console.log(user);
              //  this.startRefreshTokenTimer();
                return user.result;
            }));
    }

    register(customer: any): Observable<any> {
        console.log(customer);
        return this.http.post<any>(`${environment.apiUrl}/api/Account/registerAdministrator`, customer, this.httpOptions)
        // tslint:disable-next-line: no-shadowed-variable
        .pipe(
          retry(1),
          catchError(this.errorHandl)
        );
      }

    logout() {
        console.log('logout')
       // this.http.post<any>(`${environment.apiUrl}/users/revoke-token`, {}, { withCredentials: true }).subscribe();
      // this.stopRefreshTokenTimer();
        this.userSubject.next(null);
        this.tokenSubject.next(null);
        this.router.navigate(['/login-form']);
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
        .pipe(
          retry(1),
          catchError(this.errorHandl)
        );
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
        return this.http.delete(`${environment.apiUrl}/api/Account/delete/${id}`);
    }

    update(request: any): Observable<any>{
      return this.http.put<any>(`${environment.apiUrl}/api/Account/update`, request, this.httpOptions)
      .pipe(
        retry(1),
        catchError(this.errorHandl)
      );
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

    // helper methods
    errorHandl(error: any) {
        let errorMessage = '';
        if (error.error instanceof ErrorEvent) {
          // Get client-side error
          errorMessage = error.error.message;
        } else {
          // Get server-side error
          errorMessage = `Error Code: ${error.status}\nMessage: ${error.title}`;
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