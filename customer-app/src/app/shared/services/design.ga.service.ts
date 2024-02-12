import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable, catchError, retry, throwError } from 'rxjs';

interface DownloadResponse {
  blob: Blob;
  fileName: string;
}

@Injectable({
  providedIn: 'root'
})
export class DesignGAService {
  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  };
  constructor(private http: HttpClient) {}

  downloadFile(id: number){
    return this.http.get(`${environment.apiUrl}/api/v1.0/DesignGA/downloadFile/${id}`,{
      responseType: 'arraybuffer'} 
     ).subscribe(response => this.downLoad(response, "application/pdf"));
  }

  uploadFile(formData: any, id: number) {
    const headers = new HttpHeaders();
    headers.append('Content-Type', 'multipart/form-data');
    headers.append('Accept', 'application/json');
    const httpOptions = { headers };
    console.log(httpOptions);
    return this.http.post(`${environment.apiUrl}/api/v1.0/DesignGA/upload?id=${id}`, formData, httpOptions);
  }

 

  getDesignGAByAccNo(accNo: string) {
    return this.http.get<any>(`${environment.apiUrl}/api/v1.0/DesignGA/getDesignGAByAccNo?accNo=${accNo}`);
  }

  getDesignGAById(id: number) {
    return this.http.get<any>(`${environment.apiUrl}/api/v1.0/DesignGA/getDesignGA?id=${id}`);
  }

  getDesignGAHistoryByAccNo(accNo: string) {
    return this.http.get<any>(`${environment.apiUrl}/api/v1.0/DesignGA/getDesignGAHistoryByAccNo?accNo=${accNo}`);
  }

  addDesignGAHistory(request : any) {
    return this.http.post(`${environment.apiUrl}/api/v1.0/DesignGA/addDesignGAHistory`,request, this.httpOptions);
  }
  update(request: any): Observable<any>{
    return this.http.put<any>(`${environment.apiUrl}/api/v1.0/DesignGA/updateDesignGA`, request, this.httpOptions)
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

  private downLoad(data: any, type: string) {
    let blob = new Blob([data], { type: type});
    let url = window.URL.createObjectURL(blob);
    let pwa = window.open(url);
    if (!pwa || pwa.closed || typeof pwa.closed == 'undefined') {
        alert( 'Please disable your Pop-up blocker and try again.');
    }
}
}