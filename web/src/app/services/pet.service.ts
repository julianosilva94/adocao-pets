import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PetService {

  private readonly baseUrl = 'http://localhost:5000/v1/pets';

  constructor(private http: HttpClient) {}

  getAll(): Observable<object[]> {
    return this.http.get<object[]>(this.baseUrl);
  }
}
