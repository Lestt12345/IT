import Header from '../Header';
import { useParams } from 'react-router-dom';
import useDbImitation from '../custom_hooks/useDbImitation';
import useHeaderHeight from '../custom_hooks/useHeaderHeight';
import { useState, useEffect } from 'react';
import photo1 from '../imgs/photo1.png';
import photo2 from '../imgs/photo2.png';
import photo3 from '../imgs/photo3.png';
import { FaChevronLeft, FaChevronRight } from "react-icons/fa";

function ProductDetail() {
    const { id } = useParams();
    const { productDetail, categories } = useDbImitation();
    const [product, setProduct] = useState(null);
    const [loading, setLoading] = useState(false);
    const headerHeight = useHeaderHeight();
    const photos = [photo1, photo2, photo3];
    const [currentPhoto, setCurrentPhoto] = useState(0);

    const handlePrevPhoto = () => {
        setCurrentPhoto((prev) => prev - 1);
        if (currentPhoto < 1) {
            setCurrentPhoto(photos.length - 1);
        }
    };

    const handleNextPhoto = () => {
        setCurrentPhoto((prev) => prev + 1);
        if (currentPhoto > photos.length - 2) {
            setCurrentPhoto(0);
        }
    };

    useEffect(() => {
        if (categories.length > 0) {
            setLoading(true);
            const data = productDetail(Number(id));
            setProduct(data);
            setLoading(false);
        }
    }, [categories]);

    useEffect(() => {
        if (product && product.photo) {
            console.log(product.photo);
        }
    }, [product]);

    return (
        <>
            <Header />
            <div className="w-full flex flex-col gap-2 justify-center items-center" style={{ height: `calc(100vh - ${headerHeight}px)` }}>
                {loading ? (
                        <p className="text-gray-600 font-bold text-lg">Loading...</p>
                    ) : product ? (
                        <div className='w-full flex flex-col justify-center items-center gap-5'>
                            <div className='sm:w-[500px] w-full flex justify-center items-center bg-slate-600 rounded-xl relative'>
                                <img src={photos[currentPhoto]} alt="product photo" className="object-cover w-full sm:h-[300px] h-[60vw] rounded-xl" />
                                <button onClick={handlePrevPhoto} className="text-gray-600 font-bold text-lg absolute left-2 top-1/2 transform -translate-y-1/2"><FaChevronLeft className='text-5xl transition-all duration-150 p-2 pl-1 hover:bg-gray-300 rounded-full' /></button>
                                <button onClick={handleNextPhoto} className="text-gray-600 font-bold text-lg absolute right-2 top-1/2 transform -translate-y-1/2"><FaChevronRight className='text-5xl transition-all duration-150 p-2 pr-1 hover:bg-gray-300 rounded-full' /></button>
                            </div>
                            <div className='w-full flex flex-col w-[500px] gap-3'>
                                <h1 className="text-white text-3xl font-bold">{product.name}</h1>
                                <p className="text-white font-bold text-lg">{product.description}</p>
                                <p className="text-white font-bold text-xl">Category: <span className="text-blue-500">{product.category}</span></p>
                                <p className="text-white font-bold text-xl">Cost: <span className="text-green-500">{product.price}₴</span></p>
                            </div>
                        </div>
                    ) : (
                        <p className="text-gray-600 font-bold text-lg">No product found</p>
                )}
            </div>
        </>
    );
}

export default ProductDetail;
