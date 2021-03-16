const express = require('express');

const app = express();
const port  = 3000;

app.get('/', (req, res)=>{
    console.log('Fui acesso');
    res.send('Teste');
});

app.listen(port, ()=>{
    console.log('Ouvindo na porta: ', port);
})