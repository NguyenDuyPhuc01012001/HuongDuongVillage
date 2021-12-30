const httpStatus = require('http-status')

const catchAsync = require('../../utils/catch-async')
const { roomService } = require('../services')

const getRoom=catchAsync(async (req, res, next) => {
    const room=await roomService.getRoom(req.params.roomTypeID)
    return res.status(httpStatus.OK).send(room[0])
})

module.exports = {
    getRoom,
}
