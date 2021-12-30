const mongoose = require('mongoose')

const BookSchema = mongoose.Schema(
    {
        roomID: {
            type: mongoose.Schema.Types.ObjectId,
            ref: 'rooms',
        },
        email: {
            type: String,
            required: true,
            unique: true,
            trim: true,
            lowercase: true,
        },
        password: {
            type: String,
            required: true,
            trim: true,
            minlength: 6,
            private: true,
        },
        image: {
            type: String,
        },
        birthday: {
            type: Date,
        },
        sex: {
            type: Boolean,
            required: true,
        },
        cardNumber: {
            type: String,
            required: true,
            unique: true,
            minLength: 9,
            maxLength: 12,
        },
        address: {
            type: AddressSchema,
        },
        type: {
            type: Boolean,
            required: true,
        },
        role: {
            type: String,
            enum: ['USER', 'ADMIN'],
            default: 'USER',
        },
        isVerifyEmail: {
            type: Boolean,
            default: false,
        },
    },
    {
        timestamps: true,
        versionKey: false,
    }
)

const User = mongoose.model('user', UserSchema)

module.exports = {
    UserSchema,
    User,
}
