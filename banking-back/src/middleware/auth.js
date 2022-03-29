const jwt = require('jsonwebtoken')
const Customer = require('../models/customer')

const auth = async (req, res, next) => {
    try {
        const token = req.header('Authorization').replace('Bearer ', '')
        const decoded = jwt.verify(token, process.env.JWT_SECRET)
        req.token = token
        req.id = decoded._id
        next()
    } catch (e) {
        res.status(401).send({ error: "Invalid token" })
    }
}

module.exports = auth