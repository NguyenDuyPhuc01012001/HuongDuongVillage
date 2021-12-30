const httpStatus = require('http-status')
var sql = require("mssql");
const env = require('../../configs/env')
var config = env.database.config
const CustomError = require('../../utils/custom-error')

async function getRoom(roomTypeID) {
    try {
        let pool = await sql.connect(config);
        let products = await pool.request()
        .input('roomTypeID', sql.Int, roomTypeID)
        .query("SELECT * FROM Room WHERE roomTypeID = @roomTypeID AND roomStatus = 'Available' AND isDelete=0");
        // sql.close();
        return products.recordsets[0];
    }
    catch (err) {
        throw new CustomError(httpStatus.BAD_REQUEST, `Failed to connect to AzureSQLDB - ${err.message}`)
    }
}

module.exports = {
    getRoom,
}
