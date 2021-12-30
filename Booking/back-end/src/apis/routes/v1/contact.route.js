const express = require('express')
const { contactController } = require('../../controllers')

const router = express.Router()

router.post('/', contactController.sendEmail)

module.exports = router
