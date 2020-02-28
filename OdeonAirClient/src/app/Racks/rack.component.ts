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
  public myModel: string = '';
  public isim: string = '';
  public sayac: number = 0;
  constructor(private rack_service: RackService, private router: Router) { }
  AllRacks()
  {

    this.hotel = JSON.parse(localStorage.getItem('Hotel'));

    return this.rack_service.GetRacks(this.hotel.HotelId).subscribe((data) => this.racks = data);
  }
  Racks_By_Filter()
  {
    this.hotel = JSON.parse(localStorage.getItem('Hotel'));
    return this.rack_service.RackFilter(this.hotel.HotelId, this.myModel, this.isim).subscribe((data) => { this.racks = data; this.Bos_Oda_Saydir() });
  }
  Bos_Oda_Saydir() {
    this.sayac = 0;
    for (let i = 0; i < this.racks.length; i++) {

      if (this.racks[i].In_name == null) {
        this.sayac++;
      }
    }
  }
  ngOnInit() {
    this.AllRacks();
    this.Racks_By_Filter();

  }
}
