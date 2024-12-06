import { RoutesService, eLayoutType } from '@abp/ng.core';
import { inject } from '@angular/core';

export function configureRoutes() {
  const routes: RoutesService = inject(RoutesService);
  routes.add([
    {
      path: '/',
      name: '::Menu:Home',
      iconClass: 'fas fa-home',
      order: 1,
      layout: eLayoutType.application,
    },
    {
      path: '/books',
      name: '::Menu:Books',
      iconClass: 'fas fa-book',
      layout: eLayoutType.application,
      requiredPolicy: 'OpenQueue.Books',
    },
  ]);
}
