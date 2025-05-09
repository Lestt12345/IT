import React, { useState } from 'react';
import './styles/Login_Register_.css';
import {
  MDBContainer,
  MDBTabs,
  MDBTabsItem,
  MDBTabsLink,
  MDBTabsContent,
  MDBTabsPane,
  MDBBtn,
  MDBInput,
  MDBCheckbox,
} from 'mdb-react-ui-kit';
import config from './config'; // Импортируем конфиг

function Login_Register_() {
  const [justifyActive, setJustifyActive] = useState('tab1');
  const [message, setMessage] = useState('');

  const handleJustifyClick = (value) => {
    if (value === justifyActive) return;
    setJustifyActive(value);
    setMessage('');
  };

  const handleLogin = async () => {
    const email = document.getElementById('loginEmail').value.trim();
    const password = document.getElementById('loginPassword').value.trim();
    const rememberMe = document.getElementById('flexCheckDefault').checked;

    if (!email || !password) {
      alert('Пожалуйста, заполните оба поля');
      return;
    }

    try {
      const response = await fetch(`${config.apiBaseUrl}/api/auth/login`, { // Используем переменную из конфига
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ email, password }),
      });

      if (!response.ok) {
        const error = await response.json();
        throw new Error(error.message || 'Не удалось войти');
      }
      const data = await response.json();
      if (rememberMe) {
        localStorage.setItem('auth_token', data.token); // Используем токен, возвращаемый API
      } else {
        sessionStorage.setItem('auth_token', data.token);
      }
      sessionStorage.setItem('is_authenticated', 'true'); // Устанавливаем статус авторизации
      setIsAuthenticated(true);
      const lastVisitedPath = sessionStorage.getItem('last_visited_path') || '/'; // Получаем сохранённый путь
      window.location.href = lastVisitedPath; // Перенаправляем пользователя
      console.log('Пользователь вошёл:', data);
    } catch (error) {
      console.error(error);
      alert('Ошибка входа: ' + error.message);
    }
  };

  const handleRegister = async () => {
    const username = document.getElementById('registerUsername').value.trim();
    const email = document.getElementById('registerEmail').value.trim();
    const password = document.getElementById('registerPassword').value.trim();
    const termsAccepted = document.getElementById('registerTerms').checked;

    if (!username || !email || !password) {
      alert('Пожалуйста, заполните все поля');
      return;
    }

    if (!termsAccepted) {
      alert('Вы должны принять условия соглашения');
      return;
    }

    try {
      const response = await fetch(`${config.apiBaseUrl}/api/auth/register`, { // Используем переменную из конфига
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ username, email, password }),
      });

      if (!response.ok) {
        const error = await response.json();
        throw new Error(error.message || 'Не удалось зарегистрироваться');
      }

      const data = await response.json();
      alert('Регистрация выполнена успешно!');
      console.log('Пользователь зарегистрирован:', data);
    } catch (error) {
      console.error(error);
      alert('Ошибка регистрации: ' + error.message);
    }
  };

  return (
    <>
      <div className='d-flex items-center justify-content-center wh'>
        <MDBContainer className="d-flex flex-column MediaWidth">
          <MDBTabs pills justify className='mb-3 d-flex flex-row justify-content-between'>
            <MDBTabsItem className='mx-2'>
              <MDBTabsLink className="hov" onClick={() => handleJustifyClick('tab1')} active={justifyActive === 'tab1'}>
                Вход
              </MDBTabsLink>
            </MDBTabsItem>
            <MDBTabsItem>
              <MDBTabsLink className="hov" onClick={() => handleJustifyClick('tab2')} active={justifyActive === 'tab2'}>
                Регистрация
              </MDBTabsLink>
            </MDBTabsItem>
          </MDBTabs>

          <MDBTabsContent>
            <MDBTabsPane open={justifyActive === 'tab1'}>
              <MDBInput wrapperClass='mb-4' placeholder='Электронная почта' id='loginEmail' type='email' />
              <MDBInput wrapperClass='mb-4' placeholder='Пароль' id='loginPassword' type='password' />
              <div className="d-flex justify-content-between mx-4 mb-4">
                <MDBCheckbox name='flexCheck' value='' id='flexCheckDefault' label='Запомнить меня' />
                <a href="#" style={{ textDecoration: 'underline' }}>Забыли пароль?</a>
              </div>
              <MDBBtn className="mb-4 w-100" onClick={handleLogin}>Войти</MDBBtn>
            </MDBTabsPane>

            <MDBTabsPane open={justifyActive === 'tab2'}>
              <MDBInput wrapperClass='mb-4' placeholder='Логин' id='registerUsername' type='text' />
              <MDBInput wrapperClass='mb-4' placeholder='Электронная почта' id='registerEmail' type='email' />
              <MDBInput wrapperClass='mb-4' placeholder='Пароль' id='registerPassword' type='password' />
              <div className='d-flex justify-content-center mb-4'>
                <MDBCheckbox name='flexCheck' id='registerTerms' label='Я прочитал и согласен с' required />
                <a href="/terms" style={{ color: 'blue', marginLeft: '5px' }} target='_blank'>условиями</a>
              </div>
              <MDBBtn className="mb-4 w-100" onClick={handleRegister}>Зарегистрироваться</MDBBtn>
            </MDBTabsPane>
          </MDBTabsContent>
        </MDBContainer>
      </div>
    </>
  );
}

export default Login_Register_;
