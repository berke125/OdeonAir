import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ReservationService } from '../shared/Reservation.service';

@Component({
  selector: 'Reservation-root',
  templateUrl: './Reservation.component.html'
})
export class ReservationComponent implements OnInit {
  constructor(private reservation_service: ReservationService, private router: Router) { }

  ngOnInit() {

  }
}

