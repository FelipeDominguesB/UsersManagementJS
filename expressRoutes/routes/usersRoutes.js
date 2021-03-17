const express = require('express');
const router = express.Router();

router.get('/', (req, res)=>{
    console.log('Fui acessado');
    res.json({
        nome: 'Felipe Domingues Bonfim',
        email: 'felipedom2001@hotmail.com',
        Idade: 19
    })
});

module.exports = router;