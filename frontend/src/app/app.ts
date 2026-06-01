import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Header } from './components/header/header';
import { HeroSection } from './components/hero-section/hero-section';
import { Specialties } from './components/specialties/specialties';
import { DoctorList } from './components/doctor-list/doctor-list';
import { BookingForm } from './components/booking-form/booking-form';
import { Footer } from './components/footer/footer';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, Header, HeroSection, Specialties, DoctorList, BookingForm, Footer],
  templateUrl: './app.html',
  styleUrl: './app.css',
})
export class App {
  protected readonly title = signal('frontend');
}
