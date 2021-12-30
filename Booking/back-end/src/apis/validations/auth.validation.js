const Joi = require('joi')

const { password, cardNumber, objectId } = require('./customize.validation')

const loginSchema = {
    body: Joi.object().keys({
        email: Joi.string().required(),
        password: Joi.string().required(),
    }),
}

const registerSchema = {
    body: Joi.object().keys({
        email: Joi.string().required(),
        password: Joi.string().required().custom(password),
        fullName: Joi.string().required(),
        image: Joi.string(),
        birthday: Joi.date(),
        sex: Joi.boolean().required(),
        cardNumber: Joi.string().min(9).max(12).custom(cardNumber),
        address: Joi.object().keys({
            province_Id: Joi.string().custom(objectId),
            district_Id: Joi.string().custom(objectId),
            ward_Id: Joi.string().custom(objectId),
        }),
        type: Joi.boolean(),
        role: Joi.string(),
        isVerifyEmail: Joi.boolean(),
    }),
}

const activateEmailTokenSchema = {
    body: Joi.object().keys({
        token: Joi.string(),
    }),
}

module.exports = {
    loginSchema,
    registerSchema,
    activateEmailTokenSchema,
}
