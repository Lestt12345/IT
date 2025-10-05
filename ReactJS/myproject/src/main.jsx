import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import ReactDOM from 'react-dom/client'
import { Routes, Route, Link, BrowserRouter } from 'react-router-dom'
import './index.css'
import ChoiceTask from './ChoiceTask.jsx'
import Count from './Count.jsx'
import ThemeChange from './ThemeChange.jsx'
import DispHideBlock from './DispHideBlock.jsx'
import ReactionForMood from './ReactionForMood.jsx'
import LikeDislike from './LikeDislike.jsx'
import TempMsg from './TempMsg.jsx'
import ProgressBar from './ProgressBar.jsx'

createRoot(document.getElementById('root')).render(
  <StrictMode>
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<ChoiceTask />} />
        <Route path='/count' element={<Count />} />
        <Route path='/theme' element={<ThemeChange />} />
        <Route path='/dispHideBlock' element={<DispHideBlock />} />
        <Route path='/reactionForMood' element={<ReactionForMood />} />
        <Route path='/likeDislike' element={<LikeDislike />} />
        <Route path='/tempMsg' element={<TempMsg />} />
        <Route path='/progressBar' element={<ProgressBar />} />
      </Routes>
    </BrowserRouter>
  </StrictMode>
)
