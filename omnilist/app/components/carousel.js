'use client';
import { useState } from "react";
import Image from "next/image";
import { FaChevronLeft, FaChevronRight } from "react-icons/fa";

function ImageCarousel({ carouselImages }) {
  const [currentIndex, setCurrentIndex] = useState(0);
  const [isTransitioning, setIsTransitioning] = useState(false);

  const handleNext = () => {
    setIsTransitioning(true);
    setTimeout(() => {
      setCurrentIndex((prevIndex) => (prevIndex + 1) % carouselImages.length);
      setIsTransitioning(false);
    }, 300);
  };

  const handlePrev = () => {
    setIsTransitioning(true);
    setTimeout(() => {
      setCurrentIndex((prevIndex) =>
        prevIndex === 0 ? carouselImages.length - 1 : prevIndex - 1
      );
      setIsTransitioning(false);
    }, 300);
  };

  return (
    <section className="p-4">
      <div className="relative flex justify-center items-center">
        <FaChevronLeft
          className="absolute left-0 text-3xl text-green cursor-pointer hover:text-6xl"
          onClick={handlePrev}
        />
        <div className={`transition-opacity duration-500 ${isTransitioning ? 'opacity-0' : 'opacity-100'}`}>
          <Image
            className="rounded-2xl"
            src={carouselImages[currentIndex].url}
            alt={carouselImages[currentIndex].title}
            width={280}
            height={414}
          />
        </div>
        <FaChevronRight
          className="absolute right-0 text-3xl text-green cursor-pointer hover:text-6xl"
          onClick={handleNext}
        /> 
      </div>
      <div className="flex justify-center mt-4">
        <h1 className="text-green text-3xl font-bold">
          {carouselImages[currentIndex].title}
        </h1>
      </div>
    </section>
  );
}

export default ImageCarousel;
