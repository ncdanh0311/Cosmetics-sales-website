// Bootstrap validation
(function () {
  'use strict';
  const form = document.querySelector('.needs-validation');
  form.addEventListener('submit', function (e) {
    // check confirm password
    const pwd = document.getElementById('password');
    const cf = document.getElementById('confirm');
    if (pwd.value !== cf.value) {
      cf.setCustomValidity('Passwords do not match');
    } else {
      cf.setCustomValidity('');
    }
    if (!form.checkValidity()) {
      e.preventDefault(); e.stopPropagation();
    }
    form.classList.add('was-validated');
  }, false);
})();

// toggle show/hide password
const toggle = (btnId, inputId) => {
  const btn = document.getElementById(btnId);
  const input = document.getElementById(inputId);
  btn.addEventListener('click', () => {
    const isPwd = input.getAttribute('type') === 'password';
    input.setAttribute('type', isPwd ? 'text' : 'password');
    btn.querySelector('i').classList.toggle('fa-eye');
    btn.querySelector('i').classList.toggle('fa-eye-slash');
  });
};
toggle('togglePwd', 'password');
toggle('toggleConfirm', 'confirm');

// tooltips
const tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'))
tooltipTriggerList.map(el => new bootstrap.Tooltip(el));