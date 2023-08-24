import React from "react";
import ImageCarousel from "./Carousel";

function MainPageImageCarousel() {
  const carouselImages = [
    { url: "/coldfish.jpg", title: "Coldfish" },
    { url: "/mario.jpg", title: "The Super Mario Bros. Movie" },
    { url: "/fastNfurious.jpg", title: "Fast & Furious X" },
    { url: "/theboogeyman.jpg", title: "The Boogeyman" },
  ];

  return <ImageCarousel carouselImages={carouselImages} />;
}

export default MainPageImageCarousel;
