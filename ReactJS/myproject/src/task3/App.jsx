import { Routes, Route } from "react-router-dom";
import { Suspense, lazy } from "react";
import Skeleton from "../Skeleton";
import NavBar from "./NavBar";

const News = lazy(() => import("./News"));
const Galery = lazy(() => import("./Galery"));
const FAQ = lazy(() => import("./FAQ"));

const LoadingFallback = () => (
  <>
    <NavBar />
    <div className="flex justify-center items-center w-screen h-screen">
      <Skeleton width="100px" height="25px" dark />
    </div>
  </>
);

function App() {
  return (
    <Routes>
      <Route index element={<NavBar />} />
      
      <Route 
        path="news" 
        element={
          <Suspense fallback={<LoadingFallback />}>
            <News />
          </Suspense>
        } 
      />
      
      <Route 
        path="galery" 
        element={
          <Suspense fallback={<LoadingFallback />}>
            <Galery />
          </Suspense>
        } 
      />
      
      <Route 
        path="faq" 
        element={
          <Suspense fallback={<LoadingFallback />}>
            <FAQ />
          </Suspense>
        } 
      />
    </Routes>
  );
}

export default App;
