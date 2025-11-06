import { Link } from "react-router-dom";

function App() {
    return (
        <div className="w-screen h-screen flex sm:flex-row flex-col items-center justify-around gap-5 p-5">
            <Link to="/products" className="sm:w-[40vw] w-[calc(100%-5vw)] sm:h-[40vw] h-full flex items-center justify-center bg-slate-600 rounded-xl transition-all duration-300 hover:bg-slate-500">
                <h1 className="text-3xl font-bold text-white">Products</h1>
            </Link>
            <Link to="/about" className="sm:w-[40vw] w-[calc(100%-5vw)] sm:h-[40vw] h-full flex items-center justify-center bg-slate-600 rounded-xl transition-all duration-300 hover:bg-slate-500">
                <h1 className="text-3xl font-bold text-white">About</h1>
            </Link>
        </div>
    );
}

export default App;
