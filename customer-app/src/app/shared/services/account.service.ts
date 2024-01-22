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
        return this.http.post<any>(`${environment.apiUrl}Account/login`, { email, password }, { withCredentials: true })
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
        return this.http.post<any>(`${environment.apiUrl}Account/registerAdministrator`, customer, this.httpOptions)
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
        console.log(JSON.stringify(this.userSubject.value));
        this.router.navigate(['/login-form']);
    }

    refreshToken() {
        return this.http.post<any>(`${environment.apiUrl}/Account/refresh`, {}, { withCredentials: true })
            .pipe(map((user) => {
                this.userSubject.next(user);
              //  this.startRefreshTokenTimer();
                return user;
            }));
    }

    registerCustomer(customer: any): Observable<any> {
        console.log(customer);
        return this.http.post<any>(`${environment.apiUrl}Account/registerCustomer`, customer, this.httpOptions)
        // tslint:disable-next-line: no-shadowed-variable
        .pipe(
          retry(1),
          catchError(this.errorHandl)
        );
      }

      assignRoles(roles: any): Observable<any> {
        console.log(roles);
        return this.http.post<any>(`${environment.apiUrl}Account/assignRoles`, roles, this.httpOptions)
        // tslint:disable-next-line: no-shadowed-variable
        .pipe(
          retry(1),
          catchError(this.errorHandl)
        );
      }

      removeRoles(roles: any): Observable<any> {
        console.log(roles);
        return this.http.post<any>(`${environment.apiUrl}Account/removeRoles`, roles, this.httpOptions)
        // tslint:disable-next-line: no-shadowed-variable
        .pipe(
          retry(1),
          catchError(this.errorHandl)
        );
      }


    delete(id: number) {
        return this.http.delete(`${environment.apiUrl}Account/delete/${id}`);
    }

    update(request: any): Observable<any>{
      const data = {
        "firstName": request.firstName,
        "surname": request.surname,
        "contactTelNo": request.contactTelNo,
        "memberType": request.memberType,  
        "email": request.email
      };
      return this.http.put<any>(`${environment.apiUrl}Account/update`, data, this.httpOptions)
      .pipe(
        retry(1),
        catchError(this.errorHandl)
      );
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
    //     const jwtBase64 = this.userValue!.JWToken!.split('.')[1];
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