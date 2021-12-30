const express = require('express')
const { roomController } = require('../../controllers')

const router = express.Router()

router.get('/:roomTypeID', roomController.getRoom)

module.exports = router
