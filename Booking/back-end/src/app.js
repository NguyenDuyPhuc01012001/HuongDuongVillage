const Logger = require('./libs/logger')

const bannerLogger = require('./libs/banner')

const expressLoader = require('./loaders/express.loader')
const azureLoader = require('./loaders/azure.loader')
const monitorLoader = require('./loaders/monitor.loader')
// const passportLoader = require('./loaders/passport.loader')
const publicLoader = require('./loaders/public.loader')
const swaggerLoader = require('./loaders/swagger.loader')
const winstonLoader = require('./loaders/winston.loader')

const log = new Logger(__filename)

// Init loaders
async function initApp() {
    // logging
    winstonLoader()

    // Database with azure
    await azureLoader()

    // express
    const app = expressLoader()

    // monitor
    monitorLoader(app)

    // swagger
    swaggerLoader(app)

    // passport init
    // passportLoader(app)

    // public Url
    publicLoader(app)
}

initApp()
    .then(() => bannerLogger(log))
    .catch((error) => log.error('Application is crashed: ' + error))
