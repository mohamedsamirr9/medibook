import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { IAppointmentResponse } from '../models/iappointment-response';
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
