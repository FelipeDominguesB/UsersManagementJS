const e = require('express');
const express = require('express');
const router = express.Router();
const User = require('../members.js');


router.get('/', (req, res)=>{
    console.log('Fui acessado');
    res.json(User);
});

router.post('/', (req, res)=>{
   
    let status = req.body.ativo == 'true' ? true : false

    try{
        if(!req.body.nome || !req.body.email || !req.body.idade) throw "Argumentos insuficientes";

        if(isNaN(req.body.idade)) throw 'Informe a idade apenas em números';

        const newUser = {

            nome: req.body.nome,
            email: req.body.email,
            idade: parseInt(req.body.idade),
            ativo: status
        }
        User.push(newUser);
        res.status(200).json(
        {
            msg: 'Enviado com sucesso',
            User
        });
    }
    catch(e)
    {
        return res.status(400).json(
            {
                msg: e
            }
        );
    }
    
    
});

module.exports = router;