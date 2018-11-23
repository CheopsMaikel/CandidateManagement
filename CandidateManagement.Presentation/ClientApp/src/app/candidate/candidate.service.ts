import { OnInit, Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Candidate } from './candidate.model';

@Injectable()
export class CandidateService {

  private GetURL: string = "https://localhost:44337/api/candidate/GetCandidates";
  private CreateURL: string = "https://localhost:44337/api/candidate/Create";
  private _http: HttpClient;

  constructor(private http: HttpClient) {
    this._http = http;
  }

  getCandidates() {
    return this.http.get(this.GetURL);
  }

  createCandidate(candidate: Candidate) {
    return this.http.post<Candidate>(this.CreateURL, candidate).subscribe(r =>console.log(r));
  }


}
