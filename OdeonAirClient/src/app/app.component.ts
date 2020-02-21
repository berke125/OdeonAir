import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { CustomerService } from './shared/customer.service';
import { isNullOrUndefined } from 'util';
import { UserService } from './shared/USER.service';
import { NestedTreeControl } from '@angular/cdk/tree';
import { MatTreeNestedDataSource } from '@angular/material/tree';
import { HotelService } from './shared/Hotel.service';
import { RackService } from './shared/Rack.service';
interface Activities
{
  name: string;
  children?: Activities[];
}
const TREE_DATA: Activities[] = [
  {
    name: 'Activities',
    children: [
      { name: 'Sports' },
      { name: 'SPA' },
      { name: 'Beach' },
      { name: 'Dances'},
    ]
  },  
];
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],

})
export class AppComponent implements OnInit {
  treeControl = new NestedTreeControl<Activities>(node => node.children);
  dataSource = new MatTreeNestedDataSource<Activities>();
  myDate = Date.now();
  mydate2: Date;
  title = 'Welcome to '
  title2: any = {
    //'Id': 0,
    //'NameSurname': '',
    //'EMail': '',
    //'Password': ''
    'HotelId': 0,
    'HotelName': ''

  };

  opened: boolean = false;
  constructor(public customerService: CustomerService, public userService: UserService, public hotelService: HotelService, public rack_service: RackService) {
    this.dataSource.data = TREE_DATA;
  }
  hasChild = (_: number, node: Activities) => !!node.children && node.children.length > 0;
  ngOnInit() {

    if ((isNullOrUndefined(localStorage.getItem('Hotel'))) == true)
      this.title2 = {
        'HotelId': 0,
        'HotelName': ''      
      };
    else
      this.title2 = JSON.parse(localStorage.getItem('Hotel'));
    this.timer();
  }
  timer() {
    setInterval(() => {
      this.mydate2 = new Date();
      console.log(this.mydate2);
    }, 1000);
  }
  go() {
    if (this.opened)
      this.opened = false;
    else
      this.opened = true;
  }
  logout() {
    this.hotelService.Logout()
    this.title2.HotelName = {};
    location.reload();
  }
}
