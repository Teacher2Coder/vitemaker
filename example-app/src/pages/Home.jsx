import { motion } from 'framer-motion'

const Home = () => {

const containerVariants = {
  hidden: { opacity: 0 },
  visible: {
    opacity: 1,
    transition: {
      duration: 0.6,
      staggerChildren: 0.2,
      delay: 0.3,
    },
  }
};

  const itemVarients = {
    hidden: { opacity: 0, y: 20 },
    visible: {
      opacity: 1,
      y: 0,
      transition: { duration: 0.6 },
    },
  };

  return (
    <motion.div
      variants={containerVariants}
      initial="hidden"
      animate="visible"
      exit="hidden"
    >
      <motion.h1
        variants={itemVarients}
        initial="hidden"
        animate="visible"
        className="text-4xl font-bold gradient-text text-center"
      >
        Welcome to the Home Page for example-app
      </motion.h1>
      <motion.img
        variants={itemVarients}
        initial="hidden"
        animate="visible"
        src="/logo.svg"
        alt="example-app"
        className="w-1/2 mx-auto"
      />
    </motion.div>
  );
};

export default Home;
