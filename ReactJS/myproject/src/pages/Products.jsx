import Header from "../Header";
import useHeaderHeight from "../custom_hooks/useHeaderHeight";
import { useState, useEffect } from "react";
import useDbImitation from "../custom_hooks/useDbImitation";
import { Link } from "react-router-dom";
import Skeleton from "../Skeleton";
import { Description, Dialog, DialogPanel, DialogTitle } from '@headlessui/react'
import { IoCloseSharp } from "react-icons/io5";
import photo1 from '../imgs/photo1.png';
import { button } from "@material-tailwind/react";

function Products() {
    const headerHeight = useHeaderHeight();
    const {filteredProducts, categories} = useDbImitation();
    const [products, setProducts] = useState([]);
    const [filter, setFilter] = useState('all');
    const [category, setCategory] = useState(null);
    const [priceOption, setPriceOption] = useState('toLow');
    const skeltonArray = Array(10).fill(null);
    const [loading, setLoading] = useState(false);
    const [openModal, setOpenModal] = useState(false);
    const [modalProductId, setModalProductId] = useState(null);

    useEffect(() => {
        if (categories.length > 0) {
            setLoading(true);
            setTimeout(() => {
                setProducts(filteredProducts('all', null));
                setLoading(false);
            }, 2000);
        }
    }, [categories]);

    const handleSearch = () => {
        setLoading(true);
        document.getElementById('products').scrollTo(0, 0);
        setTimeout(() => {
            if (filter === 'price') {
                setProducts(filteredProducts(filter, priceOption));
            } else if (filter === 'category') {
                setProducts(filteredProducts(filter, category));
            } else {
                setProducts(filteredProducts(filter));
            }
            setLoading(false);
        }, 2000);
    }

    return (
        <>
            <Header />
            <div className="w-full flex flex-col gap-2" style={{ height: `calc(100vh - ${headerHeight}px)` }}>
                <div className="w-full p-5 flex items-center gap-6 border-b-2 border-slate-400">
                    <div className="flex items-center gap-2 relative">
                        <label className="sm:text-xl text-lg font-bold text-white" htmlFor="filter">Filter:</label>
                        <div className="relative inline-block">
                            <select 
                                className="sm:text-md text-sm rounded-md font-bold text-black outline-none appearance-none pr-8 pl-1 py-[2px] bg-white" 
                                id="filter" 
                                name="filter" 
                                onChange={(e) => setFilter(e.target.value)}
                                value={filter}
                            >
                                <option value="all"></option>
                                <option value="name">Name</option>
                                <option value="price">Price</option>
                                <option className="rounded-b-md border-b-0 border-x-0 border-t-1 border-slate-400" value="category">Category</option>
                            </select>
                            <div className="absolute right-2 top-1/2 transform -translate-y-1/2 pointer-events-none">
                                <svg className="w-3 h-3 text-gray-600" fill="none" stroke="currentColor" viewBox="0 0 20 20" xmlns="http://www.w3.org/2000/svg">
                                    <path strokeLinecap="round" strokeLinejoin="round" strokeWidth={2} d="M19 9l-7 7-7-7" />
                                </svg>
                            </div>
                        </div>
                    </div>
                    {filter === 'category' && (
                        <div className="flex items-center gap-2">
                            <label className="sm:text-xl text-lg font-bold text-white" htmlFor="category">Category:</label>
                            <div className="relative inline-block">
                                <select className="sm:text-md text-sm rounded-md font-bold text-black outline-none appearance-none pr-8 pl-1 py-[2px] bg-white" id="category" name="category" onChange={(e) => setCategory(e.target.value.toLowerCase())}>
                                    {categories.map((category, index) => (
                                        <option key={index} value={category}>{category.charAt(0).toUpperCase() + category.slice(1)}</option>
                                    ))}
                                </select>
                                <div className="absolute right-2 top-1/2 transform -translate-y-1/2 pointer-events-none">
                                    <svg className="w-3 h-3 text-gray-600" fill="none" stroke="currentColor" viewBox="0 0 20 20" xmlns="http://www.w3.org/2000/svg">
                                        <path strokeLinecap="round" strokeLinejoin="round" strokeWidth={2} d="M19 9l-7 7-7-7" />
                                    </svg>
                                </div>
                            </div>
                        </div>
                    )}
                    {filter === 'price' && (
                        <button className="sm:text-xl text-lg font-bold text-white bg-slate-600 rounded-xl transition-all duration-100 hover:bg-slate-500 px-2 border-2 border-slate-400 active:bg-slate-400" name="search" onClick={() => setPriceOption(priceOption === 'toLow' ? 'toHigh' : 'toLow')}>{priceOption === 'toLow' ? <span className="flex items-center gap-2">From low <span className="text-2xl">↓</span></span> : <span className="flex items-center gap-2">From high <span className="text-2xl">↑</span></span>}</button>
                    )}
                    <button className="sm:text-xl text-lg font-bold text-white bg-slate-600 rounded-xl transition-all duration-100 hover:bg-slate-500 px-2 border-2 border-slate-400 active:bg-slate-400" name="search" onClick={handleSearch}>Search</button>
                </div>
                <div id="products" className="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4 gap-4 p-5 overflow-y-scroll custom-scrollbar" style={{ height: `100%` }}>
                    {loading ? (
                        skeltonArray.map((_, index) => (
                            <div key={index} className="bg-slate-600 rounded-xl p-4 w-[23vw] min-w-[250px] max-w-[400px] mx-auto">
                                <div className="w-full flex justify-center items-center">
                                    <Skeleton width="200px" height="130px" />
                                </div>
                                <div className="w-full h-4"></div>
                                <Skeleton width="150px" height="30px" />
                                <div className="w-full h-4"></div>
                                <Skeleton width="full" height="50px" />
                                <div className="w-full h-4"></div>
                                <div className="flex justify-between items-center mt-3">
                                    <Skeleton className="mt-2" width="70px" height="20px" />
                                    <Skeleton className="mt-2" width="80px" height="20px" />
                                </div>
                            </div>
                        ))
                    ) : products.length === 0 || products === undefined || products === null ? (
                        <p className="text-gray-600 font-bold text-lg">No products found</p>
                    ) : products.map(product => (
                        <div key={product.id} className="bg-slate-600 rounded-xl p-4 max-w-[400px] mx-auto">
                            <div className="w-full flex justify-center items-center">
                                <div className='w-[200px] h-[130px] overflow-hidden flex items-center justify-center border-2 border-slate-400 rounded-xl'>
                                    <img src={photo1} alt="product photo" className="object-cover w-full h-full" />
                                </div>
                            </div>
                            <h2 className="text-lg font-bold text-white mt-2">{product.name}</h2>
                            <p className="text-white mt-2">{product.description.slice(0, 50)}...</p>
                            <div className="flex justify-between items-center mt-3">
                                <button
                                    onClick={() => {
                                        setModalProductId(product.id);
                                        setOpenModal(true);
                                    }}
                                    className="text-md font-bold text-white bg-slate-600 rounded-xl transition-all duration-100 hover:bg-slate-500 px-2 border-2 border-slate-400 active:bg-slate-400"
                                >Read more</button>
                                <p className="text-lg text-green-500 font-bold">{product.price}₴</p>
                            </div>
                        </div>
                    ))}
                </div>
            </div>
            <Dialog open={openModal} onClose={() => setOpenModal(false)} className="relative z-50">
                <div className="fixed inset-0 flex w-screen items-center justify-center p-4 bg-[rgba(0,0,0,0.3)]">
                    <DialogPanel className="max-w-lg space-y-4 border rounded-lg bg-slate-500 p-12 relative">
                        <div className="absolute top-2 right-2 cursor-pointer text-2xl text-red-400" onClick={() => setOpenModal(false)}><IoCloseSharp /></div>
                        {(() => {
                            const product = products.find(p => p.id === modalProductId);
                            if (!product) return <p className="text-red-500 text-2xl">Product not found</p>;
                            return (
                                <>
                                    <DialogTitle className="font-bold text-xl">{product.name}</DialogTitle>
                                    <Description className="text-gray-700">{product.description}</Description>
                                    <div className="w-full flex justify-center items-center mt-3">
                                        <Link
                                            to={`/products/${product.id}`}
                                            className="text-lg font-bold flex items-center gap-2  text-white bg-slate-600 rounded-xl transition-all duration-100 hover:bg-slate-500 px-2 border-2 border-slate-400 active:bg-slate-400"
                                            onClick={() => setOpenModal(false)}
                                        >
                                            More details <span className="text-2xl pb-1">→</span>
                                        </Link>
                                    </div>
                                </>
                            );
                        })()}
                    </DialogPanel>
                </div>
            </Dialog>
        </>
    );
}

export default Products;