const express = require('express')
const Account = require('../models/account')
const auth = require('../middleware/auth')
const router = new express.Router()

//GET share

router.post('/account', async (req, res) => {
    const account = new Account({
        ...req.body,
    })
    try {
        await account.save()
        res.status(201).send(account)
    } catch (e) {
        res.status(400).send({message:e.message})
    }
})


router.get('/share', auth, async (req, res) => {
    try {
        const account = await Account.findOne({ accountOwner:req.id })
        if (!account) {
            return res.status(404).send({message:"Account not found"})
        }

        res.status(200).send({shareBalance:parseFloat(account.shareBalance.toFixed(2))})
    } catch (e) {
        res.status(500).send({message:"Could not process request"})
    }
})

//GET balance

router.get('/cash', auth, async (req, res) => {
    console.log("Request",req.id)
    try {
        const account = await Account.findOne({ accountOwner:req.id })

        if (!account) {
            return res.status(404).send({message:"Account not found"})
        }

        res.status(200).send({cashBalance: parseFloat(account.cashBalance.toFixed(2))})
    } catch (e) {
        res.status(500).send({message:e.message})
    }
})


//PUT balance (withdraw or deposit)

router.put('/cashtransaction', auth, async (req, res) => {
    try {
        const account = await Account.findOne({ accountOwner: req.id})

        if (!account) {
            return res.status(404).send({message:'Account Not Found'})
        }
        if(req.body.amount<0){
            if(account.cashBalance + req.body.amount < 0){
                return res.status(400).send({
                    message:"Insufficient Balance"
                })
            }
            account.cashBalance = account.cashBalance + req.body.amount        
            await account.save()
            return res.send(account)
        }
        account.cashBalance = account.cashBalance + req.body.amount        
        await account.save()
        res.send(account)
    } catch (e) {
        res.status(400).send({message:e.message})
    }
})

//PUT share (sell or buy)


router.put('/sharetransaction', auth, async (req, res) => {
    try {
        const account = await Account.findOne({ accountOwner: req.id})

        if (!account) {
            return res.status(404).send({message:'Account Not Found'})
        }
        if(req.body.amount<0){
            if(account.shareBalance + req.body.amount < 0){
                return res.status(400).send({
                    message:"Insufficient Balance"
                })
            }
            account.shareBalance=account.shareBalance+req.body.amount
            account.cashBalance=account.cashBalance + Math.abs(req.body.amount)
            await account.save()
            return res.send(account)
        }
        if(req.body.amount>account.cashBalance){
            return res.status(400).send({
                message:"Insufficient Balance"
            })
        }

        account.cashBalance = account.cashBalance - req.body.amount   
        account.shareBalance = account.shareBalance + req.body.amount     
        await account.save()
        res.send(account)
    } catch (e) {
        res.status(400).send({message:e.message})
    }
})

module.exports = router