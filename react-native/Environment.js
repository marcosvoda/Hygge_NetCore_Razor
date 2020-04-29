const ENV = {
  dev: {
    apiUrl: 'http://localhost:44379',
    oAuthConfig: {
      issuer: 'http://localhost:44379',
      clientId: 'Hygge_App',
      clientSecret: '1q2w3e*',
      scope: 'Hygge',
    },
    localization: {
      defaultResourceName: 'Hygge',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44379',
    oAuthConfig: {
      issuer: 'http://localhost:44379',
      clientId: 'Hygge_App',
      clientSecret: '1q2w3e*',
      scope: 'Hygge',
    },
    localization: {
      defaultResourceName: 'Hygge',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
