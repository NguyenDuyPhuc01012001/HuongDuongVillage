const express = require('express')

const bookingRoute=require('./v1/book.route')
const customerRoute = require('./v1/customer.route')
const roomTypeRoute = require('./v1/roomType.route')
const roomRoute = require('./v1/room.route')
const contactRoute = require('./v1/contact.route')
const router = express.Router()

router.use('/v1/book',bookingRoute)
router.use('/v1/customer',customerRoute)
router.use('/v1/roomType', roomTypeRoute)
router.use('/v1/room', roomRoute)
router.use('/v1/contact', contactRoute)

module.exports = router
