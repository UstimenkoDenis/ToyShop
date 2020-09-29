// Header background
(function () {
    const header = document.querySelector('.header')

    window.onscroll = () => {
        if (window.pageYOffset > 50) {
            header.classList.add('header-active')
        } else {
            header.classList.remove('header-active')
        }
    }
})();

//burger menu
(function () {
    const burger = document.querySelector('.burger'),
        burgerMenu = document.querySelector('.header__nav'),
        menuClose = document.querySelector('.header__nav-close')

    burger.addEventListener('click', () => {
        burgerMenu.classList.add('header__nav_active')
    })

    menuClose.addEventListener('click', () => {
        burgerMenu.classList.remove('header__nav_active')
    })

})()
