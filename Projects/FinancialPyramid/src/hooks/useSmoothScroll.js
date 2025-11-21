import { useEffect, useRef } from "react";

export default function useSmoothScroll(speed = 1, ease = 0.1) {
  const targetScroll = useRef(window.scrollY);
  const startTouchY = useRef(0);

  useEffect(() => {
    let currentScroll = window.scrollY;
    let animationFrame;

    const update = () => {
      currentScroll += (targetScroll.current - currentScroll) * ease;
      window.scrollTo(0, currentScroll);
      animationFrame = requestAnimationFrame(update);
    };

    // wheel для ПК
    const onWheel = (e) => {
      e.preventDefault();
      targetScroll.current += e.deltaY * speed;
      targetScroll.current = Math.max(
        0,
        Math.min(targetScroll.current, document.body.scrollHeight - window.innerHeight)
      );
    };

    // touch для мобильных
    const onTouchStart = (e) => {
      startTouchY.current = e.touches[0].clientY;
    };

    const onTouchMove = (e) => {
      e.preventDefault();
      const touchY = e.touches[0].clientY;
      const deltaY = startTouchY.current - touchY;
      targetScroll.current += deltaY * speed;
      targetScroll.current = Math.max(
        0,
        Math.min(targetScroll.current, document.body.scrollHeight - window.innerHeight)
      );
      startTouchY.current = touchY;
    };

    window.addEventListener("wheel", onWheel, { passive: false });
    window.addEventListener("touchstart", onTouchStart, { passive: false });
    window.addEventListener("touchmove", onTouchMove, { passive: false });

    animationFrame = requestAnimationFrame(update);

    return () => {
      window.removeEventListener("wheel", onWheel);
      window.removeEventListener("touchstart", onTouchStart);
      window.removeEventListener("touchmove", onTouchMove);
      cancelAnimationFrame(animationFrame);
    };
  }, [speed, ease]);

  const scrollTo = (value = 0) => {
    targetScroll.current = value;
  };

  return { scrollTo };
}
