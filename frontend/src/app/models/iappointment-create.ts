export interface IAppointmentCreate {
  fullName: string;
  phone: string;
  email: string;
  appointmentDate: string;
  notes?: string;
  doctorId: number;
}
