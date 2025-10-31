import { StrictMode } from 'react';
import { createRoot } from 'react-dom/client';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import './index.css';
import ChoiceTask from './ChoiceTask.jsx';
import Task1 from './task1/App.jsx';
import Task2 from './task2/App.jsx';
import Task3 from './task3/App.jsx';

createRoot(document.getElementById('root')).render(
  <StrictMode>
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<ChoiceTask />} />
        <Route path="/task1/*" element={<Task1 />} />
        <Route path="/task2/*" element={<Task2 />} />
        <Route path="/task3/*" element={<Task3 />} />
      </Routes>
    </BrowserRouter>
  </StrictMode>
);

const handleKeyDown = (event) => {
  if (event.altKey && event.key.toLowerCase() === 'q') {
    event.preventDefault();
    window.location.href = "/";
  }
};
document.addEventListener("keydown", handleKeyDown);
if (import.meta.hot) {
  import.meta.hot.dispose(() => {
    document.removeEventListener("keydown", handleKeyDown);
  });
}