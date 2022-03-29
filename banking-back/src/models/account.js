const { Decimal128 } = require('mongodb')
const bcrypt = require('bcrypt')
const mongoose = require('mongoose')

const accountSchema = new mongoose.Schema({
    accountNumber: {
        type: Number,
        required: true,
        unique:true,
        trim: true
    },
    cashBalance: {
        type: Number,
        required:true,
        default:0
    },
    accountType: {
        type: String,
        required: true,
        default:'Savings'
    },
    pin:{
        type:String,
        required:true
    },
    shareBalance:{
        type:Number,
        required:true,
        default:0
    },
    accountOwner:{
        type: mongoose.Schema.Types.ObjectId,
        required: true,
        ref: 'Customer'
    }
}, {
    timestamps: true
})

// accountSchema.pre('save', async function (next) {
//     const user = this
//     try{
//         if (user.isModified('pin')) {
//             user.pin = await bcrypt.hash(user.pin, 8)
//         }
//     }catch(e){
//         console.log("Error",e)
//     }
   

//     next()
// })

const Account = mongoose.model('Account', accountSchema)

module.exports = Account