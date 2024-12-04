 import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44312/',
  redirectUri: baseUrl,
  clientId: 'OpenQueue_App',
  responseType: 'code',
  scope: 'offline_access OpenQueue',
  requireHttps: true,
};

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'OpenQueue',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44312',
      rootNamespace: 'OpenQueue',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
} as Environment;
