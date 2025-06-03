const container = document.querySelector('.container');

document.querySelector('#reset-password-btn').addEventListener('click', (e) => {
    e.preventDefault();
    container.classList.add('reset');
});

document.querySelector('.back-to-login').addEventListener('click', (e) => {
    e.preventDefault();
    container.classList.remove('reset');
});
