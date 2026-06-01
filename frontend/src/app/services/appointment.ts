import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment.development';
import { HttpClient } from '@angular/common/http';
import { IAppointmentResponse } from '../models/iappointment-response';
import { Observable } from 'rxjs';
import { IAppointmentCreate } from '../models/iappointment-create';

@Injectable({
  providedIn: 'root',
})
export class AppointmentService {
  constructor(private http: HttpClient) {}
  private apiUrl = `${environment.apiUrl}/appointments`;

  getAllAppointments(): Observable<IAppointmentResponse[]> {
    return this.http.get<IAppointmentResponse[]>(this.apiUrl);
  }

  createAppointment(appointment: IAppointmentCreate): Observable<IAppointmentResponse> {
    return this.http.post<IAppointmentResponse>(this.apiUrl, appointment);
  }
}
