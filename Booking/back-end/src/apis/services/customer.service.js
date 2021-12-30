const httpStatus = require('http-status')
var sql = require('mssql')
const env = require('../../configs/env')
var config = env.database.config
const CustomError = require('../../utils/custom-error')

const createCustomer = async (customerBody, pool) => {
    try {
        let insertCustomer = await pool
            .request()
            .input('cusName', sql.NVarChar, customerBody.cusName)
            .input('cusIDcard', sql.VarChar, customerBody.cusIDcard)
            .input('cusPhone', sql.VarChar, customerBody.cusPhone)
            .execute('USP_InsertCustomer')
        return insertCustomer.recordsets
    } catch (err) {
        throw new CustomError(httpStatus.BAD_REQUEST, `Failed to connect to AzureSQLDB - ${err.message}`)
    }
}

const updateCustomer = async (customerBody, pool) => {
    try {
        let updateCustomer = await pool
            .request()
            .input('cusName', sql.NVarChar, customerBody.cusName)
            .input('cusIDcard', sql.VarChar, customerBody.cusIDcard)
            .input('cusPhone', sql.VarChar, customerBody.cusPhone)
            .execute('USP_UpdateCustomer')
        return updateCustomer.recordsets
    } catch (err) {
        throw new CustomError(httpStatus.BAD_REQUEST, `Failed to connect to AzureSQLDB - ${err.message}`)
    }
}

async function getCustomer(cusIdCard) {
    try {
        let pool = await sql.connect(config)
        let products = await pool
            .request()
            .input('cusIDcard', sql.VarChar, cusIdCard)
            .query('SELECT * FROM Customer WHERE cusIDcard = @cusIDcard')
        // sql.close()
        return products.recordsets[0]
    } catch (err) {
        throw new CustomError(httpStatus.BAD_REQUEST, `Failed to connect to AzureSQLDB - ${err.message}`)
    }
}

async function setCustomer(customerBody) {
    try {
        let pool = await sql.connect(config)
        let products = await pool
            .request()
            .input('cusIDcard', sql.VarChar, customerBody.cusIDcard)
            .query('SELECT * FROM Customer WHERE cusIDcard = @cusIDcard')

        if (products.recordsets[0].length == 0) createCustomer(customerBody, pool)
        else updateCustomer(customerBody, pool)
        // sql.close()
        return 
    } catch (err) {
        throw new CustomError(httpStatus.BAD_REQUEST, `Failed to connect to AzureSQLDB - ${err.message}`)
    }
}

module.exports = {
    getCustomer,
    setCustomer,
}
