const httpStatus = require('http-status')
var nodemailer = require('nodemailer')

const CustomError = require('../../utils/custom-error')
const env = require('../../configs/env')
var config = env.email.config

const sendEmail = async (emailBody) => {
    var transporter = nodemailer.createTransport(config)
    var mailOptions = {
        from: process.env.EMAIL_USER,
        to: process.env.EMAIL_USER,
        subject: emailBody.subject,
        html:
            `<div>` +
            emailBody.content +
            `</div>` +
            `<div>This email is send from ` +
            emailBody.name +
            ` - <strong>` +
            emailBody.from +
            `</strong></div>`,
    }

    transporter.sendMail(mailOptions, function (error, info) {
        if (error) {
            throw new CustomError(httpStatus.INTERNAL_SERVER_ERROR, error.message)
        } else {
            console.log('Email sent: ' + info.response)
        }
    })
}

module.exports = {
    sendEmail,
}
