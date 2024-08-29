document.addEventListener('DOMContentLoaded', function () {

    var links = document.querySelectorAll('.links');
    links.forEach(function (item) {
        item.style.setProperty('color', 'white', 'important');
    });



    window.addEventListener('scroll', function () {
        var navElement = document.getElementById('mainNav');
        var scrollPosition = window.scrollY || document.documentElement.scrollTop;


        if (scrollPosition === 0) {
            links.forEach(function (item) {
                item.style.setProperty('color', 'white');
            });
            navElement.classList.remove('bg-white');
        } else {
            links.forEach(function (item) {
                item.style.setProperty('color', 'black'); 
            });
            navElement.classList.add('bg-white');
        }
    });
});
