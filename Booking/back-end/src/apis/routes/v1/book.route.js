const express = require('express')
const { bookController } = require('../../controllers')

const router = express.Router()

router.post('/', bookController.createBooking)

module.exports = router
