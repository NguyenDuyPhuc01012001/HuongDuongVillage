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

    // Necessary for successful deploy to Heroku, along with adding the heroku-postbuild that goes into client, runs npm install and npm build, and adding config keys in Heroku project settings
    if (process.env.NODE_ENV) {
        // Serve static files from the React frontend app
        app.use(express.static(path.join(__dirname, '../../frontend/build')))

        // AFTER defining routes: Anything that doesn't match what's above, send back index.html; (the beginning slash ('/') in the string is important!)
        app.get('*', (req, res) => {
            res.sendFile(path.join(__dirname + '/../../frontend/build/index.html'))
        })
    }
}

initApp()
    .then(() => bannerLogger(log))
    .catch((error) => log.error('Application is crashed: ' + error))
