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
        return this.http.get<any>(`${environment.apiUrl}/api/v1.0/Customers/getCustomers?companyName=${companyName}`);
    }

    getCustomers() {
      return this.http.get<any>(`${environment.apiUrl}/api/v1.0/Customers/getAllCustomers`);
  }

    getCustomerByEmail(email: string) {
        return this.http.get<any>(`${environment.apiUrl}/api/v1.0/Customers/getCustomerByEmail?email=${email}`);
    }

    getCustomerOrder(accNo: string) {
        return this.http.get<any>(`${environment.apiUrl}/api/v1.0/Customers/getCustomerOrders?accNo=${accNo}`);
    }

    getCustomerOrderHistory(accNo: string, startDate:any) {
      return this.http.get<any>(`${environment.apiUrl}/api/v1.0/Customers/getCustomerOrderHistory?accountNo=${accNo}&startDate=${startDate}`);
  }

  getCustomerOrderInvoice(accNo: string) {
    return this.http.get<any>(`${environment.apiUrl}/api/v1.0/Customers/getCustomerOrders?accNo=${accNo}`);
  }

  getCustomerStatement(accNo: string, startDate: any, endDate: any) {
    return this.http.get<any>(`${environment.apiUrl}/api/v1.0/Customers/getCustomerStatement?company=${accNo}&endDate=${endDate}&startDate=${startDate}`);
  }
}
