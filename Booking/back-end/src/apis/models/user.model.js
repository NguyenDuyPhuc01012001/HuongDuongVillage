const mongoose = require('mongoose')
const bcrypt = require('bcryptjs')

const { AddressSchema } = require('./address.model')

const UserSchema = mongoose.Schema(
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

/**
 * Check if email is taken
 * @param {string} email - The user's email
 * @param {ObjectId} [excludeUserId] - The id of the user to be excluded
 * @returns {Promise<boolean>}
 */
UserSchema.statics.isEmailTaken = async function (email, excludeUserId) {
    const user = await this.findOne({ email, _id: { $ne: excludeUserId } })
    return !!user
}

/**
 * Check if password matches the user's password
 * @param {string} password
 * @returns {Promise<boolean>}
 */
UserSchema.methods.isPasswordMatch = async function (password) {
    const user = this
    return bcrypt.compare(password, user.password)
}

UserSchema.pre('save', async function (next) {
    const user = this
    if (user.isModified('password')) {
        user.password = await bcrypt.hash(user.password, 10)
    }
    next()
})

const User = mongoose.model('user', UserSchema)

module.exports = {
    UserSchema,
    User,
}
