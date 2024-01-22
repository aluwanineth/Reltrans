import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { environment } from "src/environments/environment";

@Injectable({ providedIn: 'root' })
export class CustomerService {
    constructor(private http: HttpClient) { }
  // Http Headers
    httpOptions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
      })
    };

    getCustomerByCompanyName(companyName: string) {
        return this.http.get<any>(`${environment.customerApi}/getCustomers?companyName=${companyName}`);
    }

    getCustomerByEmail(email: string) {
        return this.http.get<any>(`${environment.customerApi}/getCustomerByEmail?email=${email}`);
    }

    getCustomerOrder(accNo: string) {
        return this.http.get<any>(`${environment.customerApi}/getCustomerOrders?accNo=${accNo}`);
    }
}
