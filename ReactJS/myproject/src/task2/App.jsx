import { Routes, Route } from "react-router-dom";
import Main from "./_Main";
import { Suspense, lazy } from "react";
import Skeleton from "../Skeleton";

function App() {
    const UserProfile = lazy(() => import("./UserProfile"));

    return (
        <Routes>
            <Route index element={<Main />} />
            <Route path="user/:id" element={<Suspense fallback={<div className="flex justify-center items-center w-full h-screen">
                <div className="flex justify-center items-center w-full h-screen">
                    <div className="flex flex-col gap-5 w-[700px] h-[700px] bg-slate-500 rounded-lg p-5">
                        <Skeleton width="200px" height="25px" dark />
                        <Skeleton width="200px" height="25px" dark />
                        <Skeleton width="200px" height="25px" dark />
                        <Skeleton width="200px" height="25px" dark />
                        <Skeleton width="50px" height="25px" dark />
                        <Skeleton width="630px" height="500px" dark />
                    </div>
                </div>
            </div>}><UserProfile /></Suspense>} />
        </Routes>
    );
}

export default App
