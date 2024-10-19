//Login & Register form

const modal = document.getElementById("authModal");
const loginBtn = document.getElementById("loginBtn");
const closeBtn = document.getElementsByClassName("close")[0];
const loginForm = document.getElementById("loginForm");
const registerForm = document.getElementById("registerForm");
const showRegisterLink = document.getElementById("showRegister");
const showLoginLink = document.getElementById("showLogin");

loginBtn.onclick = () => {
  modal.style.display = "block";
}

closeBtn.onclick = () => {
  modal.style.display = "none";
}

onclick = (event) => {
  if (event.target == modal) {
    modal.style.display = "none";
  }
}

showRegisterLink.onclick = function (e) {
  e.preventDefault();
  loginForm.style.display = "none";
  registerForm.style.display = "block";
}

showLoginLink.onclick = function (e) {
  e.preventDefault();
  registerForm.style.display = "none";
  loginForm.style.display = "block";
}

document.querySelectorAll('form').forEach(form => {
  form.onsubmit = function (e) {
    e.preventDefault();
    alert('Form submitted! (This is a demo, no actual submission occurs)');
  }
});

//loginfunction
const adminUserName = 'admin';
const adminPassword = 'Admin@98Bike';

document.getElementById('loginForm').addEventListener('submit', (event) => {
  event.preventDefault();

  const userName = document.getElementById('loginUsername').value;
  const passWord = document.getElementById('loginPassword').value;

  if (userName === adminUserName && passWord === adminPassword) {
    localStorage.setItem("userType", "admin");
    localStorage.setItem("Username", userName);

    location.href = "/Admin DashBoard/index.html";
  }

  const storedUser = localStorage.getItem(userName);
  if(storedUser){
    const userData = JSON.parse(storedUser);

    if(userData.userName === userName){
      localStorage.setItem("userType", "customer");
      localStorage.setItem("userName", userName);

      location.href = "/Customer Page/index.html"
    }else{
      alert("Inncorrect UserName")
    }
  }else{
    alert("User Not Found! Register");

    document.querySelector('#loginForm').style.display = "none";
    document.querySelector('#registerForm').style.display = "block";
  }
})


//Registration Function
document.getElementById('registerForm').addEventListener('submit',(event) => {
  event.preventDefault();

  const email = document.getElementById('registerEmail').value;
  const userName = document.getElementById('registerUsername').value;
  const newPassword = document.getElementById('registerPassword').value;
  const confirmPassword = document.getElementById('confirmPassword').value;

  if(!validateEmail(email)){
    alert("Please Check the Email Address");
  }

  if(newPassword !== confirmPassword){
    alert("Password Doesn't Match");
  }
  else{
    const userData = {
      userName: userName,
      email: email,
      passWord: newPassword,
      userType: "Customer"
    }
  
    localStorage.setItem(userName, JSON.stringify(userData));
   
    alert("Registered Successfully! Now you Can login");

    switchToLogin();

  }
})
function switchToLogin(){
  document.querySelector('#registerForm').style.display = "none";
  document.querySelector('#loginForm').style.display = "block";
}

function validateEmail(email){
  const emailPattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
  return emailPattern.test(email);
}
//Animations & Reponisiveness

const menuBtn = document.getElementById("menu-btn");
const navLinks = document.getElementById("nav-links");
const menuBtnIcon = menuBtn.querySelector("i");

menuBtn.addEventListener("click", (e) => {
  navLinks.classList.toggle("open");

  const isOpen = navLinks.classList.contains("open");
  menuBtnIcon.setAttribute("class", isOpen ? "ri-close-line" : "ri-menu-line");
});

navLinks.addEventListener("click", (e) => {
  navLinks.classList.remove("open");
  menuBtnIcon.setAttribute("class", "ri-menu-line");
});

const scrollRevealOption = {
  origin: "bottom",
  distance: "50px",
  duration: 1000,
};

ScrollReveal().reveal(".header__container h1", {
  ...scrollRevealOption,
});
ScrollReveal().reveal(".header__container form", {
  ...scrollRevealOption,
  delay: 500,
});
ScrollReveal().reveal(".header__container img", {
  ...scrollRevealOption,
  delay: 1000,
});

ScrollReveal().reveal(".range__card", {
  duration: 1000,
  interval: 500,
});

ScrollReveal().reveal(".location__image img", {
  ...scrollRevealOption,
  origin: "right",
});
ScrollReveal().reveal(".location__content .section__header", {
  ...scrollRevealOption,
  delay: 500,
});
ScrollReveal().reveal(".location__content p", {
  ...scrollRevealOption,
  delay: 1000,
});
ScrollReveal().reveal(".location__content .location__btn", {
  ...scrollRevealOption,
  delay: 1500,
});

const selectCards = document.querySelectorAll(".select__card");
selectCards[0].classList.add("show__info");

const price = ["Rs 2250", "Rs 4550", "Rs 2750", "Rs 6250", "Rs 3950"];

const priceEl = document.getElementById("select-price");

function updateSwiperImage(eventName, args) {
  if (eventName === "slideChangeTransitionStart") {
    const index = args && args[0].realIndex;
    priceEl.innerText = price[index];
    selectCards.forEach((item) => {
      item.classList.remove("show__info");
    });
    selectCards[index].classList.add("show__info");
  }
}

const swiper = new Swiper(".swiper", {
  loop: true,
  effect: "coverflow",
  grabCursor: true,
  centeredSlides: true,
  slidesPerView: "auto",
  coverflowEffect: {
    rotate: 0,
    depth: 500,
    modifier: 1,
    scale: 0.75,
    slideShadows: false,
    stretch: -100,
  },

  onAny(event, ...args) {
    updateSwiperImage(event, args);
  },
});

ScrollReveal().reveal(".story__card", {
  ...scrollRevealOption,
  interval: 500,
});

const banner = document.querySelector(".banner__wrapper");

const bannerContent = Array.from(banner.children);

bannerContent.forEach((item) => {
  const duplicateNode = item.cloneNode(true);
  duplicateNode.setAttribute("aria-hidden", true);
  banner.appendChild(duplicateNode);
});

ScrollReveal().reveal(".download__image img", {
  ...scrollRevealOption,
  origin: "right",
});
ScrollReveal().reveal(".download__content .section__header", {
  ...scrollRevealOption,
  delay: 500,
});
ScrollReveal().reveal(".download__links", {
  ...scrollRevealOption,
  delay: 1000,
});