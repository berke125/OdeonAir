import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { Sign_InComponent } from './Sign_In/Sign_In.component';
import { Sign_UpComponent } from './Sign_Up/Sign_Up.component';
import { Hone_PageComponent } from './Home_Page/Home_Page.component';
import { WelcomeComponent } from './welcome/welcome.component';
import { CustomerListComponent } from './CustomerList/CustomerList.component';
import { ForgottenPasswordComponent } from './Forgotten_Password/Forgotten_Password.component';
import { ChangePasswordComponent } from './Change_Password/Change_Password.component';
import { RoomListComponent } from './Rooms/RoomList.component';
import { RackComponent } from './Racks/Rack.component';
import { ReservationComponent } from './Reservations/Reservation.component';


const routes: Routes = [
  { path: '', redirectTo: '/Home_Page', pathMatch: 'full' },
  { path: "Sign_In", component: Sign_InComponent },
  { path: "Sign_Up/:customerId", component: Sign_UpComponent },
  { path: "Home", component: Hone_PageComponent },
  { path: "CustomerList", component: CustomerListComponent },
  { path: "Forgotten_Password", component: ForgottenPasswordComponent },
  { path: "Change_Password", component: ChangePasswordComponent },
  { path: "RoomList", component: RoomListComponent },
  { path: 'Welcome', component: WelcomeComponent },
  { path: 'Racks', component: RackComponent },
  { path: 'Reservations', component: ReservationComponent },

  { path: '**', component: Hone_PageComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }


