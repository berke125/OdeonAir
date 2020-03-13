import { Injectable } from '@angular/core';

import { HttpClient } from "@angular/common/http";
import { Router } from '@angular/router';


@Injectable({
  providedIn: 'root'
})
export class RoomTypeService
{
  public rootURL = 'http://localhost:49725/api';
  constructor(private _http: HttpClient, private router: Router) { }
  GetHotelTypes(otel_id: number)
  {
    return this._http.get(this.rootURL + '/RoomType?otelId=' + otel_id);
  }
}
