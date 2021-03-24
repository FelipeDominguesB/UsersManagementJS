class webSiteControl{

    constructor()
    {
    
        let getInformation = new getUserData();
        this.initMenu();
    }

    initMenu()
    {
        let homeButton = document.getElementById('homeButton');
        let listButton = document.getElementById('listButton');
        let addButton = document.getElementById('addButton');

        homeButton.addEventListener('click', e=>{
            
            e.preventDefault();
            document.getElementById('homeContent').classList.remove('invisible'); 
            document.getElementById('formSend').classList.add('invisible'); 
            document.getElementById('tableUsers').classList.add('invisible'); 
        });

        listButton.addEventListener('click', e=>{
            
            e.preventDefault();
            document.getElementById('homeContent').classList.add('invisible'); 
            document.getElementById('formSend').classList.remove('invisible'); 
            document.getElementById('tableUsers').classList.add('invisible'); 
        });

        addButton.addEventListener('click', e=>{
            
            e.preventDefault();
            document.getElementById('formSend').classList.add('invisible'); 
            document.getElementById('tableUsers').classList.remove('invisible');            
            document.getElementById('homeContent').classList.add('invisible'); 

        });

    }


}