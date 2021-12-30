const { Connection } = require("tedious");

const env = require('../configs/env')
const Logger = require('../libs/logger')

const log = new Logger(__filename)

module.exports = async () => {
    try {
        const connection = new Connection(env.database.config);

        // Attempt to connect and execute queries if connection goes through
        connection.on("connect", err => {
            if (err) {
                log.error(`Failed to connect to AzureSQLDB - ${err.message}`)
                throw new Error(`Failed to connect to AzureSQLDB`)
            }
        });

        await connection.connect();
        log.info('Successfully for AzureSQLDB connected!!')
    } catch (err) {
        log.error(`Failed to connect to AzureSQLDB - ${err.message}`)
        throw new Error(`Failed to connect to AzureSQLDB`)
    }
}
