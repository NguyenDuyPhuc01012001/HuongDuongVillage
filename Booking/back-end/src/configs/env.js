const dotenv = require('dotenv')
const path = require('path')

const pkg = require('../../package.json')
const { getOsEnvOptional, getOsEnv, normalizePort, toBool, toNumber } = require('../libs/os')

/**
 * Load .env file or for tests the .env.test, .env.production file.
 */
dotenv.config({ path: path.join(process.cwd(), `.env${process.env.NODE_ENV === 'test' ? '.test' : ''}`) })

/**
 * Environment variables
 */

const env = {
    node: process.env.NODE_ENV || 'development',
    isProduction: process.env.NODE_ENV === 'production',
    isTest: process.env.NODE_ENV === 'test',
    isDevelopment: process.env.NODE_ENV === 'development',
    app: {
        name: getOsEnv('APP_NAME'),
        version: pkg.version,
        description: pkg.description,
        host: getOsEnv('APP_HOST'),
        schema: getOsEnv('APP_SCHEMA'),
        routePrefix: getOsEnv('APP_ROUTE_PREFIX'),
        port: normalizePort(process.env.PORT || getOsEnv('APP_PORT')),
        banner: toBool(getOsEnv('APP_BANNER')),
    },
    database: {
        config: {
            authentication: {
                options: {
                    userName: getOsEnv('DB_USERNAME'),
                    password: getOsEnv('DB_PASSWORD'),
                },
                type: 'default',
            },
            server: getOsEnv('DB_SERVER'),
            database: getOsEnv('DB_DATABASE'),
            options: {
                trustedConnection: true,
                encrypt: true,
                packetSize: 16368,
            },
        },
    },
    email: {
        config: {
            host: 'smtp.gmail.com',
            port: 465,
            secure: true,
            auth: {
                type: 'OAuth2',
                user: getOsEnv('EMAIL_USER'),
                clientId: '381583500205-b8tj5fms52uq1oimc4oie8m7gkk50upb.apps.googleusercontent.com',
                clientSecret: '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',
                refreshToken:
                    '1//04dfNFG8Qs5miCgYIARAAGAQSNwF-L9IrxkJmY6J121JWBCqQwzyBiQOaSW0-DFvb9K7J-jrbc09aI3ETDTYD4YG4HxQCCqNoia8',
                // accessToken: 'ya29.a0ARrdaM_GH4yENLe7gj7AQcUK6w9MLCLLQweeYuP5IFgoV5dP4pbf3p815OW3ql8sRLivEH_JbeJNyN373pDtrDJjpWtq9vigvEpUwep2QwWPyUivs84oeAInrTObXjW1H69gllpvNGNVgduosi30HYdS8XnH',
                // expires: 1484314697598
            },
        },
    },
    log: {
        level: getOsEnv('LOG_LEVEL'),
        json: toBool(getOsEnvOptional('LOG_JSON')),
        output: getOsEnv('LOG_OUTPUT'),
    },
    monitor: {
        enabled: toBool(getOsEnv('MONITOR_ENABLED')),
        route: getOsEnv('MONITOR_ROUTE'),
        username: getOsEnv('MONITOR_USERNAME'),
        password: getOsEnv('MONITOR_PASSWORD'),
    },
    passport: {
        jwtToken: getOsEnv('PASSPORT_JWT'),
        google: {
            clientID: getOsEnv('GOOGLE_CLIENT_ID'),
            clientSecret: getOsEnv('GOOGLE_CLIENT_SECRET'),
        },
        facebook: {
            clientID: getOsEnv('FACEBOOK_CLIENT_ID'),
            clientSecret: getOsEnv('FACEBOOK_CLIENT_SECRET'),
        },
        jwtAccessExpired: toNumber(getOsEnv('PASSPORT_JWT_ACCESS_EXPIRED')),
        jwtRefreshExpired: toNumber(getOsEnv('PASSPORT_JWT_REFRESH_EXPIRED')),
    },
    swagger: {
        enabled: toBool(getOsEnv('SWAGGER_ENABLED')),
        route: getOsEnv('SWAGGER_ROUTE'),
        username: getOsEnv('SWAGGER_USERNAME'),
        password: getOsEnv('SWAGGER_PASSWORD'),
    },
}

module.exports = env
