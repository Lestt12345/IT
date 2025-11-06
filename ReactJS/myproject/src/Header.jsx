import { Link, useLocation } from 'react-router-dom';
import useHeaderHeight from './custom_hooks/useHeaderHeight';

function Header() {
    const location = useLocation();
    const headerHeight = useHeaderHeight();
    const isActive = (path) => {
        if (path === '/products/:id') {
            return location.pathname.startsWith('/products/') && location.pathname !== '/products';
        }
        return location.pathname === path;
    };

    return (
        <>
            <header className="bg-slate-800 p-4 fixed top-0 left-0 right-0 z-50">
                <nav className="flex justify-center items-center">
                    <div className="flex items-center">
                        <Link to="/" className="sm:text-2xl text-xl font-bold text-white px-[5vw]">
                            Main
                        </Link>
                        {isActive('/products') ? <div className="w-[2px] sm:h-[2.5rem] h-[2rem] bg-blue-500" /> : null}
                        <div>
                            <Link 
                                to="/products" 
                                className={`sm:text-2xl text-xl font-bold pl-[5vw] ${!isActive('/products/:id') ? 'pr-[5vw]' : 'pr-[0]'} transition-colors duration-200 text-white`}
                            >
                                Products
                            </Link>
                            {isActive('/products/:id') ? <span className="sm:text-xl text-lg text-white border-l-2 border-blue-500 border-r-2 px-1 mx-1 sm:py-1 pt-0 pb-[1px]">{location.pathname.substring(location.pathname.lastIndexOf('/'))}</span> : null}
                        </div>
                        {isActive('/products') || isActive('/about') ? <div className={`${!isActive('/products/:id') ? 'ml-[0]' : 'ml-[5vw]'} w-[2px] sm:h-[2.5rem] h-[2rem] bg-blue-500`} /> : null}
                        <Link 
                            to="/about" 
                            className={`sm:text-2xl text-xl font-bold text-white px-[5vw] transition-colors duration-200`}
                        >
                            About
                        </Link>
                        {isActive('/about') ? <div className="w-[2px] sm:h-[2.5rem] h-[2rem] bg-blue-500" /> : null}
                    </div>
                </nav>
            </header>
            <div className="w-full top-0" style={{ height: `${headerHeight}px` }} />
        </>
    );
}

export default Header;
