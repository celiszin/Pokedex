// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
filter('');

function filter(tipo) {
    // Alterando a visibilidade dos cards
    document.querySelectorAll('.poke').forEach(card => {
        card.style.display = "flex";
        if (!card.classList.contains(tipo) && tipo !== '')
            card.style.display = "none";
    })

    // Verificando se existem cards
    let cardCount = 0;
    document.querySelectorAll('.poke').forEach(card => {
        cardCount += card.style.display == "flex" ? 1 : 0;
    });
    let zeroPokemon = document.querySelector('#zeroPokemon');
    if (zeroPokemon != null) {
        if (cardCount == 0)
            zeroPokemon.classList.remove('d-none');
        else
            zeroPokemon.classList.add('d-none');
    }

    // Alterando a visibilidade dos botões de filtro
    document.querySelectorAll('.btn-filter').forEach(button => {
        button.classList.add('btn-sm');
        button.classList.remove('btn-md');
        if (button.id == `btn-${tipo}`) {
            button.classList.remove('btn-sm');
            button.classList.add('btn-md');

        }
    })
}