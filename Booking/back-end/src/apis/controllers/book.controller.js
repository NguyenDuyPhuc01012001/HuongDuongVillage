const httpStatus = require('http-status')

const catchAsync = require('../../utils/catch-async')
const { bookService } = require('../services')

const createBooking=catchAsync(async (req, res, next) => {
    const booking=await bookService.createBooking(req.body)
    return res.status(httpStatus.OK).json(booking)
})

module.exports = {
    createBooking,
}
