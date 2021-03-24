class getUserData{
    constructor()
    {
        console.log('Classe getUserData construida');
        this.getData();
    }

    getData()
    {
        let request = new XMLHttpRequest();

        request.open('GET', 'http://localhost:3000/');
        request.send();

        request.onload = ()=>{
            console.log(request);

            if(request.status===200)
            {
                console.log(JSON.parse(request.response));
            }
            else
            {
                console.log(request.statusText);
            }
        }
    }
}