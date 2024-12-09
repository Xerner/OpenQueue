import { PageModule } from '@abp/ng.components/page';
import { AuthService, CoreModule } from '@abp/ng.core';
import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
  imports: [
    PageModule,
    CoreModule,
  ]
})
export class HomeComponent {
  get hasLoggedIn(): boolean {
    return this.authService.isAuthenticated
  }

  constructor(private authService: AuthService) { }

  login() {
    this.authService.navigateToLogin();
  }
}
