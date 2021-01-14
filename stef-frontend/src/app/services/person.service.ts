import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Person } from '../model/person.model';

@Injectable({
  providedIn: 'root'
})
export class PersonService {
  url: String = 'Person';

  constructor(private _http: HttpClient) {}

  public getAll(): Observable<Person[]> {
    const headers: HttpHeaders = this.getHeaders();
    return this._http.get<Person[]>(environment.API + `${this.url}`, { headers: headers, responseType: 'json' });
  }

  public getById(id: any): Observable<Person> {
    const headers: HttpHeaders = this.getHeaders();
    return this._http.get<Person>(environment.API + `${this.url}/${'GetById'}/${id}`, { headers: headers, responseType: 'json' });
  }

  public create(model: Person): Observable<Person> {
    const headers: HttpHeaders = this.getHeaders();
    return this._http.post<Person>(environment.API + `${this.url}`, model, { headers: headers, responseType: 'json' });
  }

  public update(model: Person): Observable<Person> {
    const headers: HttpHeaders = this.getHeaders();
    return this._http.put<Person>(environment.API + `${this.url}`, model, { headers: headers, responseType: 'json' });
  }

  public delete(model: Person): Observable<Person> {
    const headers: HttpHeaders = this.getHeaders();
    return this._http.delete<Person>(environment.API + `${this.url}` + '/' + model, { headers: headers, responseType: 'json' });
  }

  getHeaders(): HttpHeaders {
    return new HttpHeaders()
      .set('content-type', 'application/json');
  }

}
