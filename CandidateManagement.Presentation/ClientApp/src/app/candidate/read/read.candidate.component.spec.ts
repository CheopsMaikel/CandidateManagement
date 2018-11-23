import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { ReadCandidateComponent } from './read.candidate.component';

describe('ReadCandidateComponent', () => {
  let component: ReadCandidateComponent;
  let fixture: ComponentFixture<ReadCandidateComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ReadCandidateComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ReadCandidateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should display a title', async(() => {
    const titleText = fixture.nativeElement.querySelector('h1').textContent;
    expect(titleText).toEqual('Candidate');
  }));

  it('should start with count 0, then increments by 1 when clicked', async(() => {
    const countElement = fixture.nativeElement.querySelector('strong');
    expect(countElement.textContent).toEqual('0');

    const incrementButton = fixture.nativeElement.querySelector('button');
    incrementButton.click();
    fixture.detectChanges();
    expect(countElement.textContent).toEqual('1');
  }));
});
