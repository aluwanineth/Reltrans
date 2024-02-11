import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment';

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

  uploadFile(formData: any) {
    const headers = new HttpHeaders();
    headers.append('Content-Type', 'multipart/form-data');
    headers.append('Accept', 'application/json');
    const httpOptions = { headers };
    return this.http.post(`${environment.apiUrl}}/api/v1.0/DesignGA/upload`, formData, httpOptions);
  }

 

  getDesignGAByAccNo(accNo: string) {
    return this.http.get<any>(`${environment.apiUrl}/api/v1.0/DesignGA/getDesignGAByAccNo?accNo=${accNo}`);
  }

  getDesignGAById(id: number) {
    return this.http.get<any>(`${environment.apiUrl}/api/v1.0/DesignGA/getDesignGA?id=${id}`);
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