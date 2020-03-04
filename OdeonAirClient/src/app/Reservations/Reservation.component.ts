import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ReservationService } from '../shared/Reservation.service';
import { ReservationClient } from '../model/ReservationClient.model';

@Component({
  selector: 'Reservation-root',
  templateUrl: './Reservation.component.html'
})
export class ReservationComponent implements OnInit {
  public Hotel_ID: number;
  public Room_Number: number;
  
  public hotel: any = {};
  public reservation: any = {};
  public reservationclient: ReservationClient;
  constructor(private reservation_service: ReservationService, private router: Router) { }
  getRoomCustomer()
  {
    this.hotel = JSON.parse(localStorage.getItem('Hotel'));
    return this.reservation_service.GetReservationById(this.reservationclient.Id).subscribe(
     (data: any) => {

        this.reservation = data;
     
      }
    );
  }
  ngOnInit() {
    this.reservationclient = JSON.parse(localStorage.getItem("ReservationClient"));
    this.getRoomCustomer();

  }
}

