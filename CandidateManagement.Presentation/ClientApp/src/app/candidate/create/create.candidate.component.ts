import { Component, OnInit } from '@angular/core';
import { CandidateService } from '../candidate.service';
import { Candidate } from '../candidate.model';

@Component({
  selector: 'app-candidate-component',
  templateUrl: './create.candidate.component.html'
})
export class CreateCandidateComponent implements OnInit {

  private _candidateService: CandidateService;
  private _candidate: Candidate = new Candidate();
  private _message: string = "Hello world!";

  constructor(private candidateService: CandidateService) {
    this._candidateService = candidateService;
  }

  ngOnInit() {
  }

  submitData(candidate: Candidate) {
    this.candidateService.createCandidate(candidate);
  }
}
