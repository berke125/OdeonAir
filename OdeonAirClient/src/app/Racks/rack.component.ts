import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { RackService } from '../shared/Rack.service';

@Component({
  selector: 'Rack-root',
  templateUrl: './Rack.component.html'
})
export class RackComponent implements OnInit
{
  racks: any = [];
  constructor(private rack_service: RackService, private router: Router) { }
  AllRacks()
  {
    return this.rack_service.GetRacks().subscribe((data) =>  this.racks = data );
  }
  ngOnInit() {
    this.AllRacks();
    

  }
}
