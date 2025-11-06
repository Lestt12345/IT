import Header from '../Header';
import useHeaderHeight from '../custom_hooks/useHeaderHeight';

function About() {
    const headerHeight = useHeaderHeight();

    return (
        <>
            <Header />
            <div className="w-full flex items-center justify-center flex-col gap-2" style={{ height: `calc(100vh - ${headerHeight}px)` }}>
                <h1 className="text-4xl font-bold text-gray-300">This is About Page...</h1>
                <p className="text-gray-300">I wanna get mark: <span className="text-red-500">12</span>)))</p>
            </div>
        </>
    );
}

export default About;