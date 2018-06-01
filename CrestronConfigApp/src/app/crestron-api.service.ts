import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { RootConfig } from './configuration';


const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type':  'application/json'
  })
};

@Injectable({
  providedIn: 'root'
})
export class CrestronAPIService {

  constructor(private http: HttpClient) { }

  getConfig(URL: string): Observable<RootConfig> {
    return this.http.get<RootConfig>(URL, httpOptions);
  }

  updateConfig(URL: string, rootConfig: RootConfig): Observable<any> {
    return this.http.put<RootConfig>(URL, JSON.stringify(rootConfig), httpOptions);
  }
}
