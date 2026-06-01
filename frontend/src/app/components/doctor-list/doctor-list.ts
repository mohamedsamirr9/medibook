import { Component, inject, OnInit } from '@angular/core';
import { DoctorService } from '../../services/doctor-service';
import { IDoctor } from '../../models/idoctor';
import { CommonModule } from '@angular/common';
@Component({
  selector: 'app-doctor-list',
  imports: [CommonModule],
  templateUrl: './doctor-list.html',
  styleUrl: './doctor-list.css',
})
export class DoctorList implements OnInit {
  private doctorService = inject(DoctorService);
  doctors: IDoctor[] = [];
  isLoading = false;

  ngOnInit() {
    this.isLoading = true;
    this.doctorService.getAllDoctors().subscribe({
      next: (data) => {
        this.doctors = data;
        this.isLoading = false;
      },
      error: () => {
        this.isLoading = false;
      },
    });
  }

  filterDoctors(event: any) {
    const specialty = event.target.value;
    this.isLoading = true;

    if (specialty === 'all') {
      this.doctorService.getAllDoctors().subscribe({
        next: (data) => {
          this.doctors = data;
          this.isLoading = false;
        },
        error: () => (this.isLoading = false),
      });
    } else {
      this.doctorService.getDoctorsBySpecialty(specialty).subscribe({
        next: (data) => {
          this.doctors = data;
          this.isLoading = false;
        },
        error: () => (this.isLoading = false),
      });
    }
  }
}
