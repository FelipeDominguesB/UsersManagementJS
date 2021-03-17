const express = require('express');

const app = express();
const port  = 3000;

app.use('/', require('./routes/usersRoutes.js'));

app.listen(port, ()=>{
    console.log('Ouvindo na porta: ', port);
})