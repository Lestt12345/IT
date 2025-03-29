import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom'
import Main_ from './Main_.jsx'
import Login_Register_ from './Login_Register_.jsx'
import Terms_ from './Terms_.jsx'

createRoot(document.getElementById('root')).render(
  <StrictMode>
    <Router>
      <Routes>
        <Route path="/" element={<Main_ />} />
        <Route path="/auth" element={<Login_Register_ />} />
        <Route path="/terms" element={<Terms_ />} />
      </Routes>
    </Router>
  </StrictMode>,
)
