import { Injectable } from '@angular/core';

import { HttpClient } from "@angular/common/http";
import { Router } from '@angular/router';


@Injectable({
  providedIn: 'root'
})
export class ReservationService
{
  
  public rootURL = 'http://localhost:49725/api';
  constructor(private _http: HttpClient, private router: Router) { }
  GetReservationByRoomNumber(otel_id: number,oda_no)
  {
    return this._http.get(this.rootURL + '/Reservation?Otel_Id=' + otel_id + '&room_number=' + oda_no);
  }

  GetReservationById(resid: number) {
    return this._http.get(this.rootURL + '/Reservation/' + resid.toString());
  }


}
