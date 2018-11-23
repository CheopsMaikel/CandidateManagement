import { Component, OnInit } from '@angular/core';
import { CandidateService } from '../candidate.service';
import { Candidate } from '../candidate.model';

@Component({
  selector: 'app-candidate-component',
  templateUrl: './read.candidate.component.html'
})
export class ReadCandidateComponent implements OnInit {

  private _candidateService: CandidateService;
  private _candidates: Candidate[];
  private _message: string = "Hello world!";

  constructor(private candidateService: CandidateService) {
    this._candidateService = candidateService;
  }

  ngOnInit() {
    this._candidateService.getCandidates()
      .subscribe(result => this._candidates = result as Candidate[]);
  }
}
