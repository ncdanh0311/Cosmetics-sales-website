// Bootstrap validation
(function(){
  'use strict';
  const form = document.querySelector('.needs-validation');
  form.addEventListener('submit', function(e){
    if(!form.checkValidity()){
      e.preventDefault(); e.stopPropagation();
    }
    form.classList.add('was-validated');
  }, false);
})();

// Hiện/ẩn mật khẩu
(function(){
  const btn = document.getElementById('togglePwd');
  const input = document.getElementById('password');
  btn.addEventListener('click', () => {
    const isPwd = input.type === 'password';
    input.type = isPwd ? 'text' : 'password';
    btn.querySelector('i').classList.toggle('fa-eye');
    btn.querySelector('i').classList.toggle('fa-eye-slash');
  });
})();