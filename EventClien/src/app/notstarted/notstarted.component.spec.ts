import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NotstartedComponent } from './notstarted.component';

describe('NotstartedComponent', () => {
  let component: NotstartedComponent;
  let fixture: ComponentFixture<NotstartedComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NotstartedComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NotstartedComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
