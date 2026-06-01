import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment.development';
import { IDoctor } from '../models/idoctor';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class DoctorService {
  constructor(private http: HttpClient) {}
  private apiUrl = `${environment.apiUrl}/doctors`;

  getAllDoctors(): Observable<IDoctor[]> {
    return this.http.get<IDoctor[]>(this.apiUrl);
  }

  getDoctorBySpecialty(specialty: string): Observable<IDoctor[]> {
    return this.http.get<IDoctor[]>(`${this.apiUrl}/specialty/${specialty}`);
  }
}
