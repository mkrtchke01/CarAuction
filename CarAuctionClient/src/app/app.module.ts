import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule} from '@angular/common/http';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CarAuctionComponent } from './car-auction/car-auction.component';
import { LoginRegisterComponent } from './login-register/login-register.component';
import { MyBidsComponent } from './my-bids/my-bids.component';
import { MyCarsComponent } from './my-cars/my-cars.component';
import { ReactiveFormsModule } from '@angular/forms';
import { RegisterComponent } from './login-register/register/register.component';
import { LoginComponent } from './login-register/login/login.component';
import { GetCarComponent } from './car-auction/get-car/get-car.component';
import { AdminComponent } from './admin/admin.component';
import { GetOneCarComponent } from './admin/get-one-car/get-one-car.component';
import { AddCarComponent } from './my-cars/add-car/add-car.component';
import { GetOneCarProfileComponent } from './my-cars/get-one-car-profile/get-one-car-profile.component';
import { HeaderComponent } from './header/header.component';
import {MatDialogModule} from '@angular/material/dialog';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ModalWindowComponent } from './car-auction/get-car/modal-window/modal-window.component';
import { NgSelectModule } from '@ng-select/ng-select';
import { ModalDeleteComponent } from './my-cars/get-one-car-profile/modal-delete/modal-delete.component';

@NgModule({
  declarations: [
    AppComponent,
    CarAuctionComponent,
    LoginRegisterComponent,
    MyBidsComponent,
    MyCarsComponent,
    RegisterComponent,
    LoginComponent,
    GetCarComponent,
    AdminComponent,
    GetOneCarComponent,
    AddCarComponent,
    GetOneCarProfileComponent,
    HeaderComponent,
    ModalWindowComponent,
    ModalDeleteComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    MatDialogModule,
    NgSelectModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
