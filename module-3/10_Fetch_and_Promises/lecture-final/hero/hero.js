const nerdyURL = 'http://api.icndb.com/jokes/random?exclude=explicit&limitTo=nerdy';
const randomURL = 'http://api.icndb.com/jokes/random?exclude=explicit';

document.addEventListener('DOMContentLoaded', () => {
    const nerdyBtn = document.getElementById('nerdButton');
    const randoBtn = document.getElementById('randomButton');
    const message  = document.getElementById('message');

    nerdyBtn.addEventListener('click', () => {
        fetch(nerdyURL)
        .then((response) => {
            return response.json();
        })
        .then((data) => {
            message.innerText = data.value.joke;
        })
    
    })

    randoBtn.addEventListener('click', () => {
        // Promises need .then() functions, so you know what to do when data is ready
        fetch(randomURL)              // fetch() returns Promise
        .then((response) => {         // Entire HTTP Response
            return response.json();   // .json() returns Promise
        }).then((data) => {                        // FINALLY have some JSON data
            message.innerText = data.value.joke;   // DOM manipulation
        })
        .catch((err) => {
            alert('There was a problem retrieving the Chuck quote!');
            console.error(err);
        }); 

    });
})