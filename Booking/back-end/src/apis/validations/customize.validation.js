const objectId = (value, helpers) => {
    if (!value.match(/^[0-9a-fA-F]{24}$/)) {
        return helpers.message('"{{#label}}" must be a valid id format')
    }
    return value
}

const password = (value, helpers) => {
    if (value.length < 6) {
        return helpers.message('password must be at least 6 characters')
    }
    if (!value.match(/\d/) || !value.match(/[A-Z]/)) {
        return helpers.message('password must contain at least 1 uppercase letter and 1 number')
    }
    return value
}
const cardNumber = (value, helpers) => {
    console.log(value.length)
    if (!(value.length === 9 || value.length === 12)) {
        return helpers.message('CardNumber must be 9 characters or 12 characters')
    }
    if (!value.match(/\d/)) {
        return helpers.message('password must contain numbers')
    }
    return value
}

module.exports = {
    objectId,
    password,
    cardNumber,
}
