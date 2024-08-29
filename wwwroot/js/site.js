// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


var animation = lottie.loadAnimation({
    container: document.getElementById('lottie-container'),
    renderer: 'svg',
    loop: true,
    autoplay: true,
    path: '/lt/me.json'
});




function checkRouteAndApplyMargin() {
    const path = window.location.pathname;
    const mMainElement2 = document.querySelector('main');


    const body = document.getElementById('main-body');

    if (body) {

        body.classList.remove('bg-pink-500', 'bg-blue-500', 'bg-opacity-25');
        body.classList.add('h-24', 'bg-gradient-to-r', 'from-blue-300', 'to-blue-400');
    }

}

document.addEventListener('DOMContentLoaded', checkRouteAndApplyMargin);
window.addEventListener('popstate', checkRouteAndApplyMargin);




const menuButton = document.getElementById('menuButton');
const mobileMenu = document.getElementById('mobileMenu');
const closeMenuButton = document.getElementById('closeMenu');

menuButton.addEventListener('click', () => {
    mobileMenu.classList.toggle('hidden');
});

closeMenuButton.addEventListener('click', () => {
    mobileMenu.classList.add('hidden');
});

document.addEventListener('click', (event) => {
    if (!mobileMenu.contains(event.target) && !menuButton.contains(event.target)) {
        mobileMenu.classList.add('hidden');
    }
});



document.addEventListener('DOMContentLoaded', function () {
    setTimeout(function () {
        var successMessage = document.getElementById('success-message');
        var errorMessage = document.getElementById('error-message');

        if (successMessage) {
            successMessage.classList.add('hidden');
        }

        if (errorMessage) {
            errorMessage.classList.add('hidden');
        }
    }, 5000); 
});