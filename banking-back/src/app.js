
const express = require('express')
require('./db/mongoose')
require('dotenv').config()
const accountRouter = require('./routers/account')
const customerRouter = require('./routers/customer')

const app = express()

app.use(express.json())
app.use(accountRouter)
app.use(customerRouter)

module.exports = app