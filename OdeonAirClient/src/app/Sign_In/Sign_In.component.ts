import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { CustomerService } from '../shared/customer.service';
import { Location } from '@angular/common';
import { NgForm, FormControl, Validators, FormGroup, FormBuilder } from '@angular/forms';
import { HotelService } from '../shared/Hotel.service';
@Component({
  selector: 'Sign_In-root',
  templateUrl: './Sign_In.component.html'
})
export class Sign_InComponent {
  public id: number;
  constructor(private service: HotelService, private router: Router) { }
  isLoggedin=false;
  login() {
    this.service.GetHotelLogin(this.id).subscribe((hotel: any) => {
      if (hotel != null) {
        this.isLoggedin = true;
        alert('Başarıyla giriş yaptınız.' + hotel.HotelName);
        localStorage.setItem('Hotel', JSON.stringify(hotel));
        this.service.Hotel = hotel;
        location.reload();
        this.router.navigateByUrl('/Welcome');
      }
      else {
        this.isLoggedin = false;
        alert('Giriş başarısız.');
      }


    })




  }

}
