import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ReservationService } from '../shared/Reservation.service';
import { ReservationClient } from '../model/ReservationClient.model';
import { RoomTypeService } from '../shared/RoomType.service';

interface RoomType {
  value: string;
  viewValue: string;
}
@Component({
  selector: 'Reservation-root',
  templateUrl: './Reservation.component.html'
})

export class ReservationComponent implements OnInit {
  public Hotel_ID: number;
  public Room_Number: number;
  public room_types: any = [];
  public hotel: any = {};
  public reservation: any = {};
  public selected: string = "type";

  public reservationclient: ReservationClient;
  constructor(private reservation_service: ReservationService, private router: Router, private room_type_service: RoomTypeService) { }
  getRoomCustomer()
  {
    this.hotel = JSON.parse(localStorage.getItem('Hotel'));
    return this.reservation_service.GetReservationById(this.reservationclient.Id).subscribe(
     (data: any) => {

        this.reservation = data;
     
      }
    );
  }
  getRoomTypes()
  {
    this.hotel = JSON.parse(localStorage.getItem('Hotel'));
    return this.room_type_service.GetHotelTypes(this.hotel.HotelId).subscribe(
      (data: any) => {

        this.room_types = data;
      }
    );
  }
  ngOnInit() {
    this.reservationclient = JSON.parse(localStorage.getItem("ReservationClient"));
    this.getRoomCustomer();
    this.getRoomTypes();
  }
}

