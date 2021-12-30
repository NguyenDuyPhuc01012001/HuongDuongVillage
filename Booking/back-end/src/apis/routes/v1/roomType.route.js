const express = require('express')
const { roomTypeController } = require('../../controllers')

const router = express.Router()

router.get('/all', roomTypeController.getAllRoomType)
router.get('/available', roomTypeController.getRoomTypeAvailable)

module.exports = router
