const mongoose = require('mongoose')

const CustomerSchema = mongoose.Schema(
    {
        fullName: {
            type: String,
            required: true,
        },
        email: {
            type: String,
            required: true,
            unique: true,
            trim: true,
            lowercase: true,
        },
        phone: {
            type: String,
            trim: true,
            maxlength: 10,
        },
        cardNumber: {
            type: String,
            required: true,
            unique: true,
            minLength: 9,
            maxLength: 12,
        },
    },
    {
        timestamps: true,
    }
)

const Customer = mongoose.model('user', UserSchema)

module.exports = {
    CustomerSchema,
    Customer,
}
