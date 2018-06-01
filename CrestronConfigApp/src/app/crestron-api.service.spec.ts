import { TestBed, inject } from '@angular/core/testing';

import { CrestronAPIService } from './crestron-api.service';

describe('CrestronAPIService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [CrestronAPIService]
    });
  });

  it('should be created', inject([CrestronAPIService], (service: CrestronAPIService) => {
    expect(service).toBeTruthy();
  }));
});
