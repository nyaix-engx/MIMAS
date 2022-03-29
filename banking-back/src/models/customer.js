const mongoose = require('mongoose')
const jwt = require('jsonwebtoken')
const Account = require('../models/account')
const bcrypt=require('bcrypt')

const customerSchema = new mongoose.Schema({
    customerName: {
        type: String,
        default: false,
        required:true
    },
    customerAddress: {
        type: String,
        required: true,
        ref: 'User'
    },
    customerTelephone: {
        type: String,
        required: true,
    },
}, {
    timestamps: true
})

customerSchema.virtual('account', {
    ref: 'Account',
    localField: '_id',
    foreignField: 'accountOwner'
})

customerSchema.methods.generateAuthToken = async function () {
    const user = this
    const token = jwt.sign({ _id: user._id.toString() }, process.env.JWT_SECRET)
    return token
}

customerSchema.statics.findByCredentials = async (customerTelephone, pin) => {
    const customer = await Customer.findOne({ customerTelephone })

    if (!customer) {
        throw new Error('User not found')
    }
    const account = await Account.findOne({accountOwner:customer._id})

    if(!account){
        throw new Error('User not found')
    }
    if(pin.toString()!==account.pin){
        throw new Error('Incorrect Pin')
    }
    return customer
}



const Customer = mongoose.model('Customer', customerSchema)

module.exports = Customer