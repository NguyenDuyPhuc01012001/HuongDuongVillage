const httpStatus = require('http-status')
var sql = require('mssql')
const env = require('../../configs/env')
var config = env.database.config
const CustomError = require('../../utils/custom-error')

async function getRoomTypeAvailable() {
    try {
        let query =
            'SELECT DISTINCT(roomType),roomType.id,roomPrice ' +
            'FROM room INNER JOIN roomType ON room.roomTypeID=roomType.id ' +
            "WHERE roomStatus='Available' AND room.isDelete=0 " +
            'ORDER BY roomPrice DESC'
        let pool = await sql.connect(config)
        let products = await pool.request().query(query)
        // sql.close();
        return products.recordsets[0]
    } catch (err) {
        throw new CustomError(httpStatus.BAD_REQUEST, `Failed to connect to AzureSQLDB - ${err.message}`)
    }
}

async function getAllRoomType() {
    try {
        let query = 'SELECT * FROM roomType WHERE isDelete=0'
        let pool = await sql.connect(config)
        let products = await pool.request().query(query)
        // sql.close();
        return products.recordsets[0]
    } catch (err) {
        throw new CustomError(httpStatus.BAD_REQUEST, `Failed to connect to AzureSQLDB - ${err.message}`)
    }
}

module.exports = {
    getRoomTypeAvailable,
    getAllRoomType,
}
