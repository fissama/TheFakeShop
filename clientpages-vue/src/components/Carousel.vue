<template>
  <div>
    <b-carousel
      :interval="4000"
      controls
      indicators
      img-width="1024"
      img-height="480"
    >
      <b-carousel-slide
        img-src="https://res.cloudinary.com/fissama/image/upload/v1617873815/TheFakeShop/slideshow_4_veagpx.webp"
      ></b-carousel-slide>
      <b-carousel-slide
        img-src="https://res.cloudinary.com/fissama/image/upload/v1617873815/TheFakeShop/slideshow_5_mgu7uj.webp"
      ></b-carousel-slide>
      <b-carousel-slide
        img-src="https://res.cloudinary.com/fissama/image/upload/v1617873815/TheFakeShop/slideshow_3_vtpuj3.webp"
      ></b-carousel-slide>
    </b-carousel>
  </div>
</template>

<script>
export default {
  data() {
    return {
      slide: 0,
      sliding: null,
    };
  },
  methods: {
    onSlideStart() {
      this.sliding = true;
    },
    onSlideEnd() {
      this.sliding = false;
    },
  },
};
</script>
