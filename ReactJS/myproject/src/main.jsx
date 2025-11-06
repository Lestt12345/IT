import { StrictMode, lazy, Suspense } from 'react';
import { createRoot } from 'react-dom/client';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import './index.css';
import App from './App.jsx';
const Products = lazy(() => import('./pages/Products.jsx'));
const ProductDetail = lazy(() => import('./pages/ProductDetail.jsx'));
const About = lazy(() => import('./pages/About.jsx'));

createRoot(document.getElementById('root')).render(
  <StrictMode>
    <BrowserRouter>
      <Suspense fallback={
        <div className='w-screen h-screen flex items-center justify-center top-0 left-0'>
          <div className='w-[200px] h-[200px] border-2 border-gray-300 rounded-xl flex items-center justify-center bg-slate-100 animate-pulse'>
            <h1 className='text-2xl font-bold text-gray-500'>Loading...</h1>
          </div>
        </div>
      }>
        <Routes>
          <Route path="/" element={<App />} />
          <Route path="/products" element={<Products />} />
          <Route path="/products/:id" element={<ProductDetail />} />
          <Route path="/about" element={<About />} />
        </Routes>
      </Suspense>
    </BrowserRouter>
  </StrictMode>
);