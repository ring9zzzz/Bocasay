import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BackendApiService {

  constructor(private httpClient: HttpClient) { }

  private prefixApi : string = "Bocasay"

  postExecute(url: string, data: any): Observable<any> {
    return this.httpClient.post(`${document.location.href}${this.prefixApi}/${url}`, data);
  }

  getExecute(url: string, data: any): Observable<any> {
    return this.httpClient.get(`${document.location.href}${this.prefixApi}/${url}`, data);
  }
}
