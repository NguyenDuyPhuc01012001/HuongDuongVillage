const httpStatus = require('http-status')

const catchAsync = require('../../utils/catch-async')
const { contactService } = require('../services')

const sendEmail=catchAsync(async (req, res, next) => {
    const email=await contactService.sendEmail(req.body)
    return res.status(httpStatus.OK).send(email)
})

module.exports = {
    sendEmail,
}
