import { useEffect, useState } from "react";
import './ScrollUpBtn.css';

export default function ScrollUpBtn( {handler} ) {
  const circle_length = 307.919;
  const [dashoffset, setDashoffset] = useState(circle_length);

  useEffect(() => {
    let ticking = false;

    const updateProgress = () => {
      const scrollTop = window.scrollY;
      const docHeight = document.body.scrollHeight - window.innerHeight;
      const progress = scrollTop / docHeight;
      const offset = circle_length - progress * circle_length;

      setDashoffset(offset);
      ticking = false;
    };

    const onScroll = () => {
      if (!ticking) {
        requestAnimationFrame(updateProgress);
        ticking = true;
      }
    };

    window.addEventListener("scroll", onScroll);
    return () => window.removeEventListener("scroll", onScroll);
  }, []);

  return (
    <div className="progress-wrap active-progress" onClick={handler} style={{ display: window.scrollY > 734 ? 'block' : 'none' }}>
      <svg
        className="progress-circle svg-content"
        width="100%"
        height="100%"
        viewBox="-1 -1 102 102"
      >
        <path
          d="M50,1 a49,49 0 0,1 0,98 a49,49 0 0,1 0,-98"
          style={{
            strokeDasharray: `${circle_length}, ${circle_length}`,
            strokeDashoffset: dashoffset,
            transition: "stroke-dashoffset 50ms linear"
          }}
        />
      </svg>
    </div>
  );
}
