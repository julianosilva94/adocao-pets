import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import {Pet} from '../models/pet';

@Injectable({
  providedIn: 'root'
})
export class PetService {

  private readonly baseUrl = 'http://localhost:5000/v1/pets';

  constructor(private http: HttpClient) {
  }

  getAll(): Observable<Pet[]> {
    return this.http.get<Pet[]>(this.baseUrl);
  }
}
