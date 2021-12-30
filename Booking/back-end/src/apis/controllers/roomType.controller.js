const httpStatus = require('http-status')

const catchAsync = require('../../utils/catch-async')
const { roomTypeService } = require('../services')

const getRoomTypeAvailable=catchAsync(async (req, res, next) => {
    var roomType=await roomTypeService.getRoomTypeAvailable()
    return res.status(httpStatus.OK).send(roomType)
})

const getAllRoomType=catchAsync(async (req, res, next) => {
    var roomType=await roomTypeService.getAllRoomType()
    return res.status(httpStatus.OK).send(roomType)
})

module.exports = {
    getRoomTypeAvailable,
    getAllRoomType,
}
