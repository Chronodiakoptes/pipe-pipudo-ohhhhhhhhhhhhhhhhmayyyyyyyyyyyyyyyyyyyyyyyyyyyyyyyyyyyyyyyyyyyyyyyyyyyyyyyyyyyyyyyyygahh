const nav = document.querySelector('nav')
const backgroundHome = document.querySelector('#background')
const body = document.querySelector('body')
const date = new Date()
const hours = date.getHours()
const minutes = date.getMinutes()
if((hours<=5 && minutes<= 59)||(horas>=17 && minutes<=59)){
    backgroundHome.style.backgroundImage = "url('/assets/img/background2.jpg')"
    body.style.backgroundColor = '#0c1220'
    window.addEventListener('scroll', function(){
        nav.classList.toggle('scrolldark',window.scrollY)
    })}else{
        window.addEventListener('scroll', function(){
            nav.classList.toggle('scrolldark',window.scrollY)
        })
}