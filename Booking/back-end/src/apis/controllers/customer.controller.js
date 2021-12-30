const httpStatus = require('http-status')

const catchAsync = require('../../utils/catch-async')
const { customerService } = require('../services')

const getCustomer=catchAsync(async (req, res, next) => {
    const customer=await customerService.getCustomer(req.params.cusIDcard)
    return res.status(httpStatus.OK).send(customer[0])
})

const setCustomer=catchAsync(async (req, res, next) => {
    await customerService.setCustomer(req.body)
    return res.status(httpStatus.OK)
})

module.exports = {
    getCustomer,
    setCustomer,
}
