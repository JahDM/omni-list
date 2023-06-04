'use client';

import { useState } from "react";
import Image from "next/image";

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
    <section>
      <div className="relative">
        <Image
          src={carouselImages[currentIndex].url}
          alt={carouselImages[currentIndex].title}
          width={280}
          height={414}
        />
        <div className="absolute top-1/2 left-2/4 transform -translate-y-1/2 -translate-x-2/4">
          <h2 className="text-black text-3xl font-bold">
            {carouselImages[currentIndex].title}
          </h2>
        </div>
      </div>
      <div className="flex justify-center mt-4">
        <button
          className="px-4 py-2 bg-gray-200 rounded-md mr-2"
          onClick={handlePrev}
        >
          Previous
        </button>
        <button
          className="px-4 py-2 bg-gray-200 rounded-md"
          onClick={handleNext}
        >
          Next
        </button>
      </div>
    </section>
  );
}

export default ImageCarousel;