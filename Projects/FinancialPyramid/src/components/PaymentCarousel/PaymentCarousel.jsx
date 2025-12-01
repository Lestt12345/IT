import { useRef, useEffect } from "react";
import EPayCore from "../../assets/EPayCore.png";
import Stellar from "../../assets/Stellar.png";
import Dogecoin from "../../assets/Dogecoin.png";
import Tron from "../../assets/Tron.png";
import Tether from "../../assets/Tether.png";
import Bitcoin from "../../assets/Bitcoin.png";
import Litecoin from "../../assets/Litecoin.png";
import Etherium from "../../assets/Etherium.png";
import Dash from "../../assets/Dash.png";
import Ripple from "../../assets/Ripple.png";

const payments = [
  { name: "EPayCore", img: EPayCore },
  { name: "Stellar", img: Stellar },
  { name: "Dogecoin", img: Dogecoin },
  { name: "Tron", img: Tron },
  { name: "Tether", img: Tether },
  { name: "Bitcoin", img: Bitcoin },
  { name: "Litecoin", img: Litecoin },
  { name: "Etherium", img: Etherium },
  { name: "Dash", img: Dash },
  { name: "Ripple", img: Ripple },
];

export default function AutoScrollCarousel() {
  const containerRef = useRef(null);
  const scrollRef = useRef({ isDragging: false, startX: 0, scrollLeft: 0 });

  useEffect(() => {
    const container = containerRef.current;
    if (!container) return;

    // Автоскролл
    let animationFrame;
    const speed = 0.5; // px за кадр

    const animate = () => {
      if (!scrollRef.current.isDragging) {
        container.scrollLeft += speed;
        if (container.scrollLeft >= container.scrollWidth / 2) {
          container.scrollLeft = 0;
        }
      }
      animationFrame = requestAnimationFrame(animate);
    };
    animationFrame = requestAnimationFrame(animate);

    return () => cancelAnimationFrame(animationFrame);
  }, []);

  // Drag / Touch Handlers
  const startDrag = (pageX) => {
    scrollRef.current.isDragging = true;
    scrollRef.current.startX = pageX - containerRef.current.offsetLeft;
    scrollRef.current.scrollLeft = containerRef.current.scrollLeft;
  };

  const handleMouseDown = (e) => startDrag(e.pageX);
  const handleMouseMove = (e) => {
    if (!scrollRef.current.isDragging) return;
    e.preventDefault();
    const x = e.pageX - containerRef.current.offsetLeft;
    const walk = x - scrollRef.current.startX;
    containerRef.current.scrollLeft = scrollRef.current.scrollLeft - walk;
  };
  const handleMouseUp = () => (scrollRef.current.isDragging = false);

  const handleTouchStart = (e) => startDrag(e.touches[0].pageX);
  const handleTouchMove = (e) => {
    if (!scrollRef.current.isDragging) return;
    const x = e.touches[0].pageX - containerRef.current.offsetLeft;
    const walk = x - scrollRef.current.startX;
    containerRef.current.scrollLeft = scrollRef.current.scrollLeft - walk;
  };
  const handleTouchEnd = () => (scrollRef.current.isDragging = false);

  // Дублируем элементы для бесконечного эффекта
  const items = [...payments, ...payments];

  return (
    <div
      ref={containerRef}
      className="flex overflow-x-hidden cursor-grab active:cursor-grabbing select-none gap-4"
      onMouseDown={handleMouseDown}
      onMouseMove={handleMouseMove}
      onMouseUp={handleMouseUp}
      onMouseLeave={handleMouseUp}
      onTouchStart={handleTouchStart}
      onTouchMove={handleTouchMove}
      onTouchEnd={handleTouchEnd}
    >
      {items.map((pay, idx) => (
        <div
          key={idx}
          className="flex-shrink-0 lg:w-[210px] sm:w-[190px] w-[155px] flex items-center justify-center gap-2 sm:h-[70px] h-[60px] border-2 border-[#B1BEFF] rounded-lg relative"
        >
          <img
            src={pay.img}
            alt={pay.name}
            className="sm:w-16 sm:h-16 w-14 h-14 object-contain absolute left-[-2px]"
            draggable={false}
          />
          <h3 className="font-medium text-center ml-[64px] absolute lg:text-2xl text-lg">{pay.name}</h3>
        </div>
      ))}
    </div>
  );
}
