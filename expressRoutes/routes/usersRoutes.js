const express = require('express');
const router = express.Router();
const neDB = require('nedb');

let db = new neDB
(
    {
        filename: 'banco.db',
        autoload: true
    }
);

router.get('/', (req, res)=>{

    let User;
    db.find({}, function (err, usuarios) {
        if(err)return console.log(err);
        res.status(200).json(usuarios);
    });
});

router.post('/', (req, res)=>{
    try
    {
        if(!req.body.nome || !req.body.email || !req.body.idade) throw "Argumentos insuficientes";

        if(isNaN(req.body.idade)) throw 'Informe a idade apenas em números';
        
        var usuario = {
            nome: req.body.nome,
            idade: parseInt(req.body.idade),
            email: req.body.email,
            ativo: req.body.ativo == 'true' ? true : false
        };

        db.insert(usuario, (err) => {
            if(err) throw 'Erro ao inserir no banco de dados';
            res.status(200).json(
            {
                msg: 'Enviado com sucesso',
                usuario
            });

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