import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

import { AppComponent } from './app.component';
import { ConfiguratorComponent } from './configurator/configurator.component';

import { CrestronAPIService } from './crestron-api.service';
import { HttpClient } from '@angular/common/http';
import { AppNavbarComponent } from './app-navbar/app-navbar.component';

@NgModule({
  declarations: [
    AppComponent,
    ConfiguratorComponent,
    AppNavbarComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    ReactiveFormsModule,
    NgbModule.forRoot()
  ],
  providers: [CrestronAPIService],
  bootstrap: [AppComponent]
})
export class AppModule { }
