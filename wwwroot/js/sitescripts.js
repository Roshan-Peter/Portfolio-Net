document.addEventListener('DOMContentLoaded', function () {

    var links = document.querySelectorAll('.links');
    links.forEach(function (item) {
        item.style.setProperty('color', 'white', 'important');
    });



    menuButton.classList.add('text-white');

    window.addEventListener('scroll', function () {
        var navElement = document.getElementById('mainNav');
        var scrollPosition = window.scrollY || document.documentElement.scrollTop;


        if (scrollPosition === 0) {
            links.forEach(function (item) {
                item.style.setProperty('color', 'white');
            });
            menuButton.classList.remove('text-black');
            menuButton.classList.add('text-white');
            navElement.classList.remove('bg-white');
        } else {
            links.forEach(function (item) {
                item.style.setProperty('color', 'black');
            });
            menuButton.classList.remove('text-white');
            menuButton.classList.add('text-black');
            navElement.classList.add('bg-white');
        }
    });
});
