import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { PhoneNumberType } from '../model/phone-number-type.model';

@Injectable({
  providedIn: 'root'
})
export class PhoneNumberTypeService {

  url: String = 'PhoneNumberType';

  constructor(private httpClient: HttpClient) { }

  public getAll(): Observable<PhoneNumberType[]> {
    const headers: HttpHeaders = this.getHeaders();
    return this.httpClient.get<PhoneNumberType[]>(environment.API + `${this.url}`, { headers: headers, responseType: 'json' });
  }

  public getById(id: any): Observable<PhoneNumberType> {
    const headers: HttpHeaders = this.getHeaders();
    return this.httpClient.get<PhoneNumberType>(environment.API + `${this.url}/${'GetById'}/${id}`, { headers: headers, responseType: 'json' });
  }

  public create(model: PhoneNumberType): Observable<PhoneNumberType> {
    const headers: HttpHeaders = this.getHeaders();
    return this.httpClient.post<PhoneNumberType>(environment.API + `${this.url}`, model, { headers: headers, responseType: 'json' });
  }

  public update(model: PhoneNumberType): Observable<PhoneNumberType> {
    const headers: HttpHeaders = this.getHeaders();
    return this.httpClient.put<PhoneNumberType>(environment.API + `${this.url}`, model, { headers: headers, responseType: 'json' });
  }

  public delete(model: PhoneNumberType): Observable<PhoneNumberType> {
    const headers: HttpHeaders = this.getHeaders();
    return this.httpClient.delete<PhoneNumberType>(environment.API + `${this.url}` + '/' + model, { headers: headers, responseType : 'json'});
  }

  getHeaders(): HttpHeaders {
    return new HttpHeaders()
      .set('content-type', 'application/json');
  }
}
