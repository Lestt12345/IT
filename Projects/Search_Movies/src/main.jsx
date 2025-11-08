import { StrictMode } from 'react';
import { createRoot } from 'react-dom/client';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import './index.css';
import App from './App.jsx';
import { ThemeProvider } from './contexts/Theme';
import { CurrentTranslateOptionProvider } from './contexts/CurrentTranslateOption';

createRoot(document.getElementById('root')).render(
  <StrictMode>
    <BrowserRouter>
      <ThemeProvider>
        <CurrentTranslateOptionProvider>
          <Routes>
            <Route path="/" element={<App />} />
          </Routes>
        </CurrentTranslateOptionProvider>
      </ThemeProvider>
    </BrowserRouter>
  </StrictMode>
);