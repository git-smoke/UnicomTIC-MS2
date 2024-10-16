async function login(username, password) {
  const response = await fetch('/api/user/login', {
      method: 'POST',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify({ username, password })
  });

  if (response.ok) {
      const result = await response.json();
      if (result.Role === "Admin") {
          location.href = "FRONT_END/Admin DashBoard/index.html"; // Redirect to admin dashboard
      } else if (result.Role === "Customer") {
          location.href = "FRONT_END/Customer Page/index.html"; // Redirect to customer dashboard
      }
  } else {
      alert('Login failed. Please check your username and password.');
  }
}

// Example usage
document.getElementById('loginButton').addEventListener('click', function () {
  const username = document.getElementById('username').value;
  const password = document.getElementById('password').value;
  login(username, password);
});