const handleSmoothScroll = () => {
  setTimeout(() => {
    window.scrollTo({
      top: 0,
      left: 0,
      behavior: 'smooth',
    });
  }, 100);
};

export default handleSmoothScroll;
