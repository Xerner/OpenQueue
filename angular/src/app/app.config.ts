import { provideAccountConfig } from "@abp/ng.account/config";
import { CoreModule, provideAbpCore, withOptions } from "@abp/ng.core";
import { registerLocale } from "@abp/ng.core/locale";
import { provideIdentityConfig } from "@abp/ng.identity/config";
import { provideAbpOAuth } from "@abp/ng.oauth";
import { provideSettingManagementConfig } from "@abp/ng.setting-management/config";
import { provideTenantManagementConfig } from "@abp/ng.tenant-management/config";
import { provideAbpThemeShared, ThemeSharedModule } from "@abp/ng.theme.shared";
import { ApplicationConfig } from "@angular/core";
import { environment } from "src/environments/environment";
import { APP_ROUTE_PROVIDER } from "./route.provider";
import { provideFeatureManagementConfig } from '@abp/ng.feature-management';
import { provideRouter } from "@angular/router";
import { APP_ROUTES } from "./app.routes";
import { provideAnimations } from "@angular/platform-browser/animations";
import { ThemeLeptonXModule } from "@abp/ng.theme.lepton-x";
import { SideMenuLayoutModule } from "@abp/ng.theme.lepton-x/layouts";
import { provideHttpClient } from "@angular/common/http";

export const APP_CONFIG: ApplicationConfig = {
  providers: [
    // general
    provideRouter(APP_ROUTES),
    provideAnimations(),
    provideHttpClient(),

    // routing
    APP_ROUTE_PROVIDER,

    // abp
    provideAbpCore(
      withOptions({
        environment,
        registerLocaleFn: registerLocale(),
      }),
    ),
    provideAbpOAuth(),
    provideIdentityConfig(),
    provideSettingManagementConfig(),
    provideFeatureManagementConfig(),
    provideAccountConfig(),
    provideTenantManagementConfig(),
    provideAbpThemeShared(),
    ThemeLeptonXModule.forRoot().providers,
    SideMenuLayoutModule.forRoot().providers,
  ]
}
