import { Injectable } from '@angular/core';

import { HttpClient } from "@angular/common/http";
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class RackService
{
  public rootURL = 'http://localhost:49725/api';
  constructor(private _http: HttpClient, private router: Router) { }
  GetRacks(otel_id) {
    return this._http.get(this.rootURL + '/Rack?Otel_Id=' + otel_id);
  }
}
