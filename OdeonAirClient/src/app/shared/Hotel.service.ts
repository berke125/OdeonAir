import { Injectable } from '@angular/core';

import { HttpClient } from "@angular/common/http";
import { Router } from '@angular/router';


@Injectable({
  providedIn: 'root'
})
export class HotelService
{
  private login: number=0;
  public rootURL = 'http://localhost:49725/api';
  public otel: any = {};
  isLoggedin = false;
  constructor(private _http: HttpClient, private router: Router) { }
  GetHotelLogin(id)
  {
    return this._http.get(this.rootURL + '/Hotel?otel_id=' + id);
  }
  LoggedIn() {
    return !!localStorage.getItem('Hotel')
  }
  Logout() {
    localStorage.removeItem('Hotel')
    this.router.navigateByUrl('/Home')
  }
}
