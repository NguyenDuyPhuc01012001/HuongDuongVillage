const Joi = require('joi')

const { objectId } = require('./customize.validation')

const getDistrictByProvinceSchema = {
    params: Joi.object().keys({
        provinceID: Joi.string().required().custom(objectId),
    }),
}
const getWardsByDistrict = {
    params: Joi.object().keys({
        districtID: Joi.string().required().custom(objectId),
    }),
}

module.exports = {
    getDistrictByProvinceSchema,
    getWardsByDistrict,
}
