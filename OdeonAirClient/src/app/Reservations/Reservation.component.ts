import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ReservationService } from '../shared/Reservation.service';

@Component({
  selector: 'Reservation-root',
  templateUrl: './Reservation.component.html'
})
export class ReservationComponent implements OnInit {
  public Hotel_ID: number;
  public Room_Number: number;
  reservations: any = [];
  public hotel: any = {};
  constructor(private reservation_service: ReservationService, private router: Router) { }
  getRoomCustomer()
  {
    this.hotel = JSON.parse(localStorage.getItem('Hotel'));
    return this.reservation_service.GetReservationByRoomNumber(this.hotel.HotelId, this.Room_Number).subscribe(
     (data: any) => {

        this.reservations = data;
     
      }
    );
  }
  ngOnInit() {
    this.getRoomCustomer();
  }
}

