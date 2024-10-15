//Routing
function navigate(event, path) {
  event.preventDefault();
  history.pushState({}, "", path);
  updateContent(path);
}

function updateContent(path) {
  const content = document.getElementById('content');
  switch (path) {
    case "/":
      content.innerHTML = "<h1>Home Page</h1><p>Welcome to the Home Page.</p>";
      break;
    case "/about":
      content.innerHTML = "<h1>About Page</h1><p>Welcome to the About Page.</p>"
      break;
    case "/bikes":
      content.innerHTML = "<h1>Bikes Page</h1><p>Welcome to the Bikes Page.</p>"
      break;
    case "/contact":
      content.innerHTML = "<h1>Contact Page</h1><p>Welcome to the Contact Page.</p>"
      break;
    default:
      content.innerHTML = "<h1>404 Not Found</h1><p>Page Not Available</p>"
      break;
  }
}

onpopstate = () => {
  updateContent(location.pathname);
}

updateContent(location.pathname);