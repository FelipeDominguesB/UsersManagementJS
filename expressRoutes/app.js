const express = require('express');
const cors = require('cors');


const app = express();
const port  = 3000;


app.use(cors());
app.use(express.json());
app.use(express.urlencoded({extended: false}));


app.use('/', require('./routes/usersRoutes.js'));

app.listen(port, ()=>{
    console.log('Ouvindo na porta: ', port);
})