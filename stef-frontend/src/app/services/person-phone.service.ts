import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { PersonPhone } from '../model/person-phone.model';

@Injectable({
  providedIn: 'root'
})
export class PersonPhoneService {
  
  url: String = 'PersonPhone';

  constructor(private httpClient: HttpClient) { }

  public getAll(): Observable<PersonPhone[]> {
    const headers: HttpHeaders = this.getHeaders();
    return this.httpClient.get<PersonPhone[]>(environment.API + `${this.url}`, { headers: headers, responseType: 'json' });
  }

  public getById(id: any): Observable<PersonPhone> {
    const headers: HttpHeaders = this.getHeaders();
    return this.httpClient.get<PersonPhone>(environment.API + `${this.url}/${id}`, { headers: headers, responseType: 'json' });
  }

  public create(model: PersonPhone): Observable<PersonPhone> {
    const headers: HttpHeaders = this.getHeaders();
    return this.httpClient.post<PersonPhone>(environment.API + `${this.url}`, model, { headers: headers, responseType: 'json' });
  }

  public update(model: PersonPhone): Observable<PersonPhone> {
    const headers: HttpHeaders = this.getHeaders();
    return this.httpClient.put<PersonPhone>(environment.API + `${this.url}`, model, { headers: headers, responseType: 'json' });
  }

  public delete(model: PersonPhone): Observable<PersonPhone> {
    const headers: HttpHeaders = this.getHeaders();
    return this.httpClient.delete<PersonPhone>(environment.API + `${this.url}` + '/' + model, { headers: headers, responseType : 'json'});
  }

  getHeaders(): HttpHeaders {
    return new HttpHeaders()
      .set('content-type', 'application/json');
  }
}
