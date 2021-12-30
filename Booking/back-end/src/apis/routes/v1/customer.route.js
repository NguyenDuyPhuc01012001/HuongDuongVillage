const express = require('express')
const { customerController } = require('../../controllers')

const router = express.Router()

router.post('/', customerController.setCustomer)
router.get('/:cusIDcard', customerController.getCustomer)

module.exports = router
