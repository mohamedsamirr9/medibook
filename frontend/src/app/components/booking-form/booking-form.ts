import { Component, inject, OnInit, signal } from '@angular/core';
import { AbstractControl, FormsModule } from '@angular/forms';
import { AppointmentService } from '../../services/appointment-service';
import { IAppointmentCreate } from '../../models/iappointment-create';
import { ReactiveFormsModule, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { IDoctor } from '../../models/idoctor';
import { DoctorService } from '../../services/doctor-service';
@Component({
  selector: 'app-booking-form',
  imports: [FormsModule, ReactiveFormsModule],
  templateUrl: './booking-form.html',
  styleUrl: './booking-form.css',
})
export class BookingForm implements OnInit {
  bookingForm!: FormGroup;
  doctors: IDoctor[] = [];
  isLoading = false;
  successData: any = null;
  errorMessage: string | null = null;

  specialties = ['General', 'Cardiology', 'Dermatology', 'Pediatrics', 'Orthopedics', 'Neurology'];

  constructor(
    private fb: FormBuilder,
    private appointmentService: AppointmentService,
    private doctorservice: DoctorService,
  ) {}

  ngOnInit() {
    this.bookingForm = this.fb.group({
      fullName: ['', [Validators.required, Validators.minLength(3)]],
      phone: ['', [Validators.required, Validators.pattern(/^01[0125][0-9]{8}$/)]],
      email: ['', [Validators.required, Validators.email]],
      appointmentDate: [
        '',
        [
          Validators.required,
          (control: AbstractControl) => (control.value < this.minDate ? { minDate: true } : null),
        ],
      ],
      specialty: ['', Validators.required],
      doctorId: ['', Validators.required],
      notes: [''],
    });
  }

  onSpecialtyChange() {
    const specialty = this.bookingForm.get('specialty')?.value;
    this.bookingForm.patchValue({ doctorId: '' });
    this.doctors = [];

    if (specialty) {
      this.doctorservice.getDoctorsBySpecialty(specialty).subscribe({
        next: (data) => (this.doctors = data),
        error: () => (this.errorMessage = 'Failed to load doctors.'),
      });
    }
  }

  get fullName() {
    return this.bookingForm.get('fullName');
  }
  get phone() {
    return this.bookingForm.get('phone');
  }
  get email() {
    return this.bookingForm.get('email');
  }
  get appointmentDate() {
    return this.bookingForm.get('appointmentDate');
  }
  get specialty() {
    return this.bookingForm.get('specialty');
  }
  get doctorId() {
    return this.bookingForm.get('doctorId');
  }

  onSubmit() {
    if (this.bookingForm.invalid) return;

    this.isLoading = true;
    this.errorMessage = null;

    this.appointmentService.createAppointment(this.bookingForm.value).subscribe({
      next: (data) => {
        this.successData = data;
        this.bookingForm.reset();
        this.doctors = [];
        this.isLoading = false;
      },
      error: () => {
        this.errorMessage = 'Something went wrong. Please try again.';
        this.isLoading = false;
      },
    });
  }

  get minDate(): string {
    return new Date().toISOString().split('T')[0];
  }
}
