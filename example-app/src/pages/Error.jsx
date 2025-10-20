import { motion } from 'framer-motion';
import { Link } from 'react-router-dom';
import { Home } from 'lucide-react';

const Error = () => {
  const containerVariants = {
    hidden: { opacity: 0 },
    visible: {
      opacity: 1,
      transition: {
        duration: 0.6,
        staggerChildren: 0.2,
        delay: 0.3,
      },
    },
  };

  const itemVariants = {
    hidden: { opacity: 0, y: 20 },
    visible: {
      opacity: 1,
      y: 0,
      transition: { duration: 0.6 },
    },
  };

  return (
    <motion.div
      className="container mx-auto px-4 py-16 text-center"
      variants={containerVariants}
      initial="hidden"
      animate="visible"
      exit="hidden"
    >
      <motion.h1
        variants={itemVariants}
        className="text-6xl md:text-8xl font-bold gradient-text mb-4"
      >
        404
      </motion.h1>
      <motion.p
        variants={itemVariants}
        className="text-xl md:text-2xl text-gray-600 dark:text-gray-400 mb-8"
      >
        Page Not Found
      </motion.p>
      <motion.div variants={itemVariants}>
        <Link
          to="/"
          className="inline-flex items-center gap-2 btn-primary"
        >
          <Home className="w-5 h-5" />
          Back to Home
        </Link>
      </motion.div>
    </motion.div>
  );
};

export default Error;
