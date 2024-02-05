import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { MenuResponseResults } from '../models/menu.response.results.model';

@Injectable({
  providedIn: 'root',
})
export class MenuService {
  private apiUrl = 'your-api-endpoint'; // Replace with your API endpoint

  constructor(private http: HttpClient) {}

  getMenuByType(menuType: string): Observable<MenuResponseResults> {
    const url = `${environment.apiUrl}/api/v1.0/Menus/getMenus?menuType=${menuType}`;
    return this.http.get<MenuResponseResults>(url);
  }
}