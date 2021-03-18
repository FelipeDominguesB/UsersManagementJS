//Banco de dados temporário, preciso de algo pra simular o JSON de uma empresa, também preciso idealizar qual vai ser o formato dos dados

//Nota pro futuro, adicionar ID pros funcionários, sinto que isso deveria ir pra rota, entretanto
const members = [
    {
        nome:'Shigeru Miyamoto',
        email: 'shigerumiyamoto@email.com',
        idade: 45,
        ativo: true
    },
    {
        nome:'Masashiro Sakurai',
        email: 'sakurai@smash.com',
        idade: 42,
        ativo: true
    },
    {
        nome:'Reggie Fils-Amie',
        email: 'MyBodyIsReady@email.com',
        idade: 38,
        ativo: false
    },
    {
        nome:'Doug Bowser',
        email: 'doug@bowser.com',
        idade: 32,
        ativo: true
    },
    {
        nome:'Satoru Iwata',
        email: 'satoruiwata@email.com',
        idade: 57,
        ativo: false
    },
];

module.exports = members;