class GetInformation{
    constructor()
    {
        console.log('Classe get information construida');
        this.getData();
    }

    getData()
    {
        const Http = new XMLHttpRequest();
        const url='https://localhost:3000';
        Http.open("GET", url);
        Http.send();

        Http.onload= (e) => {
        console.log(Http.responseText)
        }
    }
}