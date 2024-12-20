import { Injectable } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';

@Injectable({
  providedIn: 'root',
})
export class LoadingServiceService {
  loadingBusyRequest = 0;

  constructor(private spinnerService: NgxSpinnerService) {}

  loadingBusy() {
    this.loadingBusyRequest++;
    this.spinnerService;
    this.spinnerService.show(undefined, {
      type: 'ball-scale-ripple',
      bdColor: 'rgba(0, 0, 0, 0.8)',
      color: '#fff',
      size: 'default',
    });
  }
  idle() {
    this.loadingBusyRequest--;
    if (this.loadingBusyRequest <= 0) {
      this.loadingBusyRequest = 0;
      this.spinnerService.hide();
    }
  }
}
