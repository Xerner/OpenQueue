import { CoreModule } from '@abp/ng.core';
import { LoaderBarComponent, provideAbpThemeShared, ThemeSharedModule } from '@abp/ng.theme.shared';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  template: `
    <abp-loader-bar></abp-loader-bar>
    <abp-dynamic-layout></abp-dynamic-layout>
  `,
  providers: [
  ],
  imports: [
    ThemeSharedModule,
    CoreModule,
  ]
})
export class AppComponent {}
