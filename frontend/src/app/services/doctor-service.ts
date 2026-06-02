import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { IDoctor } from '../models/idoctor';

@Injectable({
  providedIn: 'root',
})
export class DoctorService {
  constructor(private http: HttpClient) {}

  private apiUrl = `${environment.apiUrl}/doctors`;

  getAllDoctors(): Observable<IDoctor[]> {
    return this.http.get<IDoctor[]>(this.apiUrl);
  }

  getDoctorsBySpecialty(specialty: string): Observable<IDoctor[]> {
    return this.http.get<IDoctor[]>(`${this.apiUrl}/specialty/${specialty}`);
  }
}
