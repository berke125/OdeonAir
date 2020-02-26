import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { RackService } from '../shared/Rack.service';

@Component({
  selector: 'Rack-root',
  templateUrl: './Rack.component.html'
})
export class RackComponent implements OnInit
{
  public hotel: any = {};
  racks: any = [];
  constructor(private rack_service: RackService, private router: Router) { }
  AllRacks()
  {

    this.hotel = JSON.parse(localStorage.getItem('Hotel'));

    return this.rack_service.GetRacks(this.hotel.HotelId).subscribe((data) => this.racks = data);
  }
  ngOnInit() {
    this.AllRacks();
    

  }
}
