const express = require('express')
const router = new express.Router()
const Customer = require('../models/customer')

router.post('/customer/login', async (req, res) => {
    try {
        const customer = await Customer.findByCredentials(req.body.telephone,req.body.pin)
        if(!customer){
            res.status(400).send({message:"Invalid Credentials"})
        }
        const token = await customer.generateAuthToken()
        res.send({ customer, token })
    } catch (e) {
        res.status(400).send({message:e.message})
    }
})

router.post('/customer', async (req, res) => {  
    const customer = new Customer(req.body)

    try {
        await customer.save()
        const token = await customer.generateAuthToken()
        res.status(201).send({ customer, token })
    } catch (e) {
        console.log("Error",e)
        res.status(400).send({message:e.message})
    }
})

module.exports = router