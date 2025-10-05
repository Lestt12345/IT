import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import { Routes, Route, BrowserRouter } from 'react-router-dom'
import './index.css'
import ChoiceTask from './ChoiceTask.jsx'
import UserCard from './UserCard.jsx'
import CounterButton from './CounterButton.jsx'
import FormWithHoversFocuses from './FormWithHoversFocuses.jsx'
import ResponsiveMessage from './ResponsiveMessage.jsx'
import InteractiveCard from './InteractiveCard.jsx'

createRoot(document.getElementById('root')).render(
  <StrictMode>
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<ChoiceTask />} />
        <Route path="/usercard" element={<UserCard />} />
        <Route path="/counterbutton" element={<CounterButton />} />
        <Route path="/formwithhoversfocuses" element={<FormWithHoversFocuses />} />
        <Route path="/responsive" element={<ResponsiveMessage />} />
        <Route path="/interactivecard" element={<InteractiveCard />} />
      </Routes>
    </BrowserRouter>
  </StrictMode>
)