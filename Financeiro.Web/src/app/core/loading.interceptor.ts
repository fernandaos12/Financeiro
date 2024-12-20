import { HttpInterceptorFn } from '@angular/common/http';
import { inject } from '@angular/core';
import { LoadingServiceService } from '../services/loading-service.service';
import { delay, finalize } from 'rxjs';

export const loadingInterceptor: HttpInterceptorFn = (req, next) => {
  const loadingService = inject(LoadingServiceService);
  loadingService.loadingBusy();
  return next(req).pipe(finalize(() => loadingService.idle()));
};
