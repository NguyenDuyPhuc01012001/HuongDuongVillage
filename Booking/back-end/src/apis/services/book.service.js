const httpStatus = require('http-status')
var sql = require("mssql");
const { log } = require('../../configs/env');
const env = require('../../configs/env')
var config = env.database.config
const CustomError = require('../../utils/custom-error')

const createBooking = async (bookingBody) => {
    try {
        let pool = await sql.connect(config);
        let insertBook = await pool.request()
            .input('roomID', sql.Int, bookingBody.roomID)
            .input('cusID', sql.Int, bookingBody.cusID)
            .input('dateCheckIn', sql.SmallDateTime, bookingBody.dateCheckIn)
            .input('dateCheckOut', sql.SmallDateTime, bookingBody.dateCheckOut)
            .execute("USP_InsertBooking");
        // sql.close();
        return insertBook.recordsets[0];
    }
    catch (err) {
        throw new CustomError(httpStatus.BAD_REQUEST, `Failed to connect to AzureSQLDB - ${err.message}`)
    }
}

module.exports = {
    createBooking,
}
