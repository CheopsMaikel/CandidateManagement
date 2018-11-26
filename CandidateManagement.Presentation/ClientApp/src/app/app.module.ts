import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';

import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { CandidateService } from './candidate/candidate.service';
import { CreateCandidateComponent } from './candidate/create/create.candidate.component';
import { ReadCandidateComponent } from './candidate/read/read.candidate.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { HorNavMenuComponent } from './hor-nav-menu/hor-nav-menu.component';
import { VerNavMenuComponent } from './ver-nav-menu/ver-nav-menu.component';


@NgModule({
  declarations: [
    AppComponent,
    HorNavMenuComponent,
    VerNavMenuComponent,
    HomeComponent,
    DashboardComponent,
    CreateCandidateComponent,
    ReadCandidateComponent,
    FetchDataComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'candidate/create', component: CreateCandidateComponent },
      { path: 'dashboard', component: DashboardComponent },
      { path: 'candidate/read', component: ReadCandidateComponent },
      { path: 'fetch-data', component: FetchDataComponent },
    ])
  ],
  providers: [CandidateService],
  bootstrap: [AppComponent]
})
export class AppModule { }
