'use client';
import { useState } from "react";
import Image from "next/image";
import { FaChevronLeft, FaChevronRight } from "react-icons/fa";

function ImageCarousel({ carouselImages }) {
  const [currentIndex, setCurrentIndex] = useState(0);

  const handleNext = () => {
    setCurrentIndex((prevIndex) => (prevIndex + 1) % carouselImages.length);
  };

  const handlePrev = () => {
    setCurrentIndex((prevIndex) =>
      prevIndex === 0 ? carouselImages.length - 1 : prevIndex - 1
    );
  };

  return (
    <section className="p-4">
      <div className="relative flex justify-center items-center">
        <FaChevronLeft
          className="absolute left-0 text-3xl text-green cursor-pointer hover:text-6xl"
          onClick={handlePrev}
        />
        <Image
          src={carouselImages[currentIndex].url}
          alt={carouselImages[currentIndex].title}
          width={280}
          height={414}
        />
        <FaChevronRight
          className="absolute right-0 text-3xl text-green cursor-pointer hover:text-6xl"
          onClick={handleNext}
        />
      </div>
      <div className="flex justify-center mt-4">
        <h2 className="text-black text-xl font-bold">
          {carouselImages[currentIndex].title}
        </h2>
      </div>
    </section>
  );
}

export default ImageCarousel;
