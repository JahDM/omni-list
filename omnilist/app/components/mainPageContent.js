
import ImageCarousel from "./carousel";

function MainPageImageCarousel() {
  const carouselImages = [
    { url: "/coldfish.jpg", title: "Coldfish" },
    { url: "/mario.jpg", title: "The Super Mario Bros. Movie" },
    { url: "/fastNfurious.jpg", title: "Fast & Furious X" },
    { url: "/theboogeyman.jpg", title: "The Boogeyman" },
  ];

  return (
    <section>
      <ImageCarousel carouselImages={carouselImages} />
    </section>
  );
}

export default MainPageImageCarousel;