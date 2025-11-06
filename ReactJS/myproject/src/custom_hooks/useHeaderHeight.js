import { useLayoutEffect, useState } from 'react';

function useHeaderHeight() {
    const [height, setHeight] = useState(0);
    useLayoutEffect(() => {
        const header = document.querySelector('header');
        if (header) setHeight(header.offsetHeight);
    }, []);
    return height;
}

export default useHeaderHeight;
