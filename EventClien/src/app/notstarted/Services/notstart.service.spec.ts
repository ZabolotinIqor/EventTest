import { TestBed } from '@angular/core/testing';

import { NotstartService } from './notstart.service';

describe('NotstartService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: NotstartService = TestBed.get(NotstartService);
    expect(service).toBeTruthy();
  });
});
