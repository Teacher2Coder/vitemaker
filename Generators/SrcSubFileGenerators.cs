using System;
using System.IO;
using System.Text;
using vitemaker.Questions;

namespace vitemaker.Generators;

public class SrcSubFileGenerators
{
  public static void CreateNavbarJsx(string path, Inputs inputs)
  {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Creating Navbar.jsx");
    
    StringBuilder navbarJsx = new StringBuilder();

    navbarJsx.AppendLine("import { useState, useEffect } from 'react';");
    navbarJsx.AppendLine("import { Link, useLocation } from 'react-router-dom';");
    navbarJsx.AppendLine("import { motion, AnimatePresence } from 'framer-motion';");
    navbarJsx.AppendLine("import { Menu, X } from 'lucide-react';");
    navbarJsx.AppendLine("import handleSmoothScroll from '../utils/handleSmoothScroll';");
    navbarJsx.AppendLine();
    navbarJsx.AppendLine("const Navbar = () => {");
    navbarJsx.AppendLine("  const [isOpen, setIsOpen] = useState(false);");
    navbarJsx.AppendLine("  const [isScrolled, setIsScrolled] = useState(false);");
    navbarJsx.AppendLine("  const location = useLocation();");
    navbarJsx.AppendLine();
    navbarJsx.AppendLine("  useEffect(() => {");
    navbarJsx.AppendLine("    const handleScroll = () => {");
    navbarJsx.AppendLine("      setIsScrolled(window.scrollY > 0);");
    navbarJsx.AppendLine("    };");
    navbarJsx.AppendLine("    window.addEventListener('scroll', handleScroll);");
    navbarJsx.AppendLine("    return () => window.removeEventListener('scroll', handleScroll);");
    navbarJsx.AppendLine("  }, []);");
    navbarJsx.AppendLine();
    navbarJsx.AppendLine("  useEffect(() => {");
    navbarJsx.AppendLine("    setIsOpen(false);");
    navbarJsx.AppendLine("  }, [location]);");
    navbarJsx.AppendLine();
    navbarJsx.AppendLine("  const navItems = [");
    navbarJsx.AppendLine("    { label: 'Home', path: '/' },");
    navbarJsx.AppendLine("  ];");
    navbarJsx.AppendLine();
    navbarJsx.AppendLine("  return (");
    navbarJsx.AppendLine("    <motion.nav");
    navbarJsx.AppendLine("      className={`fixed top-0 w-full z-50 transition-all duration-300 ${");
    navbarJsx.AppendLine("        isScrolled");
    navbarJsx.AppendLine("          ? 'bg-white/80 dark:bg-gray-900/80 backdrop-blur-lg shadow-lg'");
    navbarJsx.AppendLine("          : 'bg-transparent'");
    navbarJsx.AppendLine("      }`}");
    navbarJsx.AppendLine("      initial={{ y: -100 }}");
    navbarJsx.AppendLine("      animate={{ y: 0 }}");
    navbarJsx.AppendLine("      transition={{ duration: 0.6 }}");
    navbarJsx.AppendLine("    >");
    navbarJsx.AppendLine("      <div className=\"max-w-7xl mx-auto container-padding\">");
    navbarJsx.AppendLine("        <div className=\"flex justify-between items-center h-20\">");
    navbarJsx.AppendLine("          {/* Logo */}");
    navbarJsx.AppendLine("          <Link");
    navbarJsx.AppendLine("            to=\"/\"");
    navbarJsx.AppendLine("            className=\"flex items-center space-x-2 group\"");
    navbarJsx.AppendLine("            onClick={() => handleSmoothScroll()}");
    navbarJsx.AppendLine("          >");
    navbarJsx.AppendLine("            <div className=\"p-2 bg-gradient-to-r from-primary-600 to-accent-600 rounded-lg transform group-hover:scale-105 transition-transform duration-300\">");
    navbarJsx.AppendLine("              <img");
    navbarJsx.AppendLine($"                src=\"/logo.svg\"");
    navbarJsx.AppendLine($"                alt=\"{inputs.ProjectName}\"");
    navbarJsx.AppendLine("                className=\"w-6 h-6\"");
    navbarJsx.AppendLine("              />");
    navbarJsx.AppendLine("            </div>");
    navbarJsx.AppendLine("            <span className=\"font-bold text-xl gradient-text\">");
    navbarJsx.AppendLine($"              {inputs.ProjectName}");
    navbarJsx.AppendLine("            </span>");
    navbarJsx.AppendLine("          </Link>");
    navbarJsx.AppendLine();
    navbarJsx.AppendLine("          {/* Desktop Menu */}");
    navbarJsx.AppendLine("          <div className=\"hidden md:flex items-center space-x-8\">");
    navbarJsx.AppendLine("            {navItems.map((item) => (");
    navbarJsx.AppendLine("              <Link");
    navbarJsx.AppendLine("                key={item.path}");
    navbarJsx.AppendLine("                to={item.path}");
    navbarJsx.AppendLine("                className={`relative font-medium transition-colors duration-300 ${");
    navbarJsx.AppendLine("                  location.pathname === item.path");
    navbarJsx.AppendLine("                    ? 'text-primary-600 dark:text-primary-400'");
    navbarJsx.AppendLine("                    : 'text-gray-700 dark:text-gray-300 hover:text-primary-600 dark:hover:text-primary-400'");
    navbarJsx.AppendLine("                }`}");
    navbarJsx.AppendLine("                onClick={() => handleSmoothScroll()}");
    navbarJsx.AppendLine("              >");
    navbarJsx.AppendLine("                {item.label}");
    navbarJsx.AppendLine("                {location.pathname === item.path && (");
    navbarJsx.AppendLine("                  <motion.div");
    navbarJsx.AppendLine("                    className=\"absolute -bottom-1 left-0 w-full h-0.5 bg-gradient-to-r from-primary-600 to-accent-600\"");
    navbarJsx.AppendLine("                    layoutId=\"activeTab\"");
    navbarJsx.AppendLine("                    initial={false}");
    navbarJsx.AppendLine("                  />");
    navbarJsx.AppendLine("                )}");
    navbarJsx.AppendLine("              </Link>");
    navbarJsx.AppendLine("            ))}");
    navbarJsx.AppendLine("          </div>");
    navbarJsx.AppendLine();
    navbarJsx.AppendLine("          {/* Mobile Menu Button */}");
    navbarJsx.AppendLine("          <button");
    navbarJsx.AppendLine("            className=\"md:hidden p-2 rounded-lg hover:bg-gray-100 dark:hover:bg-gray-800 transition-colors duration-300\"");
    navbarJsx.AppendLine("            onClick={() => setIsOpen(!isOpen)}");
    navbarJsx.AppendLine("          >");
    navbarJsx.AppendLine("            {isOpen ? (");
    navbarJsx.AppendLine("              <X className=\"w-6 h-6\" />");
    navbarJsx.AppendLine("            ) : (");
    navbarJsx.AppendLine("              <Menu className=\"w-6 h-6\" />");
    navbarJsx.AppendLine("            )}");
    navbarJsx.AppendLine("          </button>");
    navbarJsx.AppendLine("        </div>");
    navbarJsx.AppendLine();
    navbarJsx.AppendLine("        {/* Mobile Menu */}");
    navbarJsx.AppendLine("        <AnimatePresence>");
    navbarJsx.AppendLine("          {isOpen && (");
    navbarJsx.AppendLine("            <motion.div");
    navbarJsx.AppendLine("              className=\"md:hidden absolute top-full left-0 w-full bg-white/95 dark:bg-gray-900/95 backdrop-blur-lg border-t border-gray-200 dark:border-gray-700\"");
    navbarJsx.AppendLine("              initial={{ opacity: 0, height: 0 }}");
    navbarJsx.AppendLine("              animate={{ opacity: 1, height: 'auto' }}");
    navbarJsx.AppendLine("              exit={{ opacity: 0, height: 0 }}");
    navbarJsx.AppendLine("              transition={{ duration: 0.3 }}");
    navbarJsx.AppendLine("            >");
    navbarJsx.AppendLine("              <div className=\"py-4 space-y-2 container-padding\">");
    navbarJsx.AppendLine("                {navItems.map((item, index) => (");
    navbarJsx.AppendLine("                  <motion.div");
    navbarJsx.AppendLine("                    key={item.path}");
    navbarJsx.AppendLine("                    initial={{ opacity: 0, x: -20 }}");
    navbarJsx.AppendLine("                    animate={{ opacity: 1, x: 0 }}");
    navbarJsx.AppendLine("                    transition={{ delay: index * 0.1 }}");
    navbarJsx.AppendLine("                  >");
    navbarJsx.AppendLine("                    <Link");
    navbarJsx.AppendLine("                      to={item.path}");
    navbarJsx.AppendLine("                      className={`block py-3 px-4 rounded-lg font-medium transition-colors duration-300 ${");
    navbarJsx.AppendLine("                        location.pathname === item.path");
    navbarJsx.AppendLine("                          ? 'bg-primary-50 text-primary-600 dark:bg-primary-900/20 dark:text-primary-400'");
    navbarJsx.AppendLine("                          : 'text-gray-700 dark:text-gray-300 hover:bg-gray-50 dark:hover:bg-gray-800'");
    navbarJsx.AppendLine("                      }`}");
    navbarJsx.AppendLine("                      onClick={() => handleSmoothScroll()}");
    navbarJsx.AppendLine("                    >");
    navbarJsx.AppendLine("                      {item.label}");
    navbarJsx.AppendLine("                    </Link>");
    navbarJsx.AppendLine("                  </motion.div>");
    navbarJsx.AppendLine("                ))}");
    navbarJsx.AppendLine("              </div>");
    navbarJsx.AppendLine("            </motion.div>");
    navbarJsx.AppendLine("          )}");
    navbarJsx.AppendLine("        </AnimatePresence>");
    navbarJsx.AppendLine("      </div>");
    navbarJsx.AppendLine("    </motion.nav>");
    navbarJsx.AppendLine("  );");
    navbarJsx.AppendLine("};");
    navbarJsx.AppendLine();
    navbarJsx.AppendLine("export default Navbar;");
    
    File.WriteAllText(Path.Combine(path, "Navbar.jsx"), navbarJsx.ToString());

    Console.WriteLine("Navbar.jsx created");
    Console.ResetColor();
  }

  public static void CreateFooterJsx(string path, Inputs inputs)
  {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Creating Footer.jsx");
    
    StringBuilder footerJsx = new StringBuilder();
    
    footerJsx.AppendLine("import { Heart } from 'lucide-react'");
    footerJsx.AppendLine("import { Link } from 'react-router-dom'");
    footerJsx.AppendLine("import handleSmoothScroll from '../utils/handleSmoothScroll'");
    footerJsx.AppendLine();
    footerJsx.AppendLine("const Footer = () => {");
    footerJsx.AppendLine("  return (");
    footerJsx.AppendLine("    <footer className=\"bg-white dark:bg-accent-900 border-t border-gray-200 dark:border-accent-700\">");
    footerJsx.AppendLine("      <div className=\"max-w-7xl mx-auto container-padding py-12\">");
    footerJsx.AppendLine("        <div className=\"grid grid-cols-1 md:grid-cols-3 gap-8\">");
    footerJsx.AppendLine("          <div className=\"text-center md:text-left\">");
    footerJsx.AppendLine("            <h3 className=\"text-lg font-semibold gradient-text mb-4\">");
    footerJsx.AppendLine($"              {inputs.ProjectName}");
    footerJsx.AppendLine("            </h3>");
    footerJsx.AppendLine("            <p className=\"text-gray-600 dark:text-gray-400 max-w-md\">");
    footerJsx.AppendLine("              Passionate full-stack developer creating innovative solutions with modern technologies.");
    footerJsx.AppendLine("            </p>");
    footerJsx.AppendLine("          </div>");
    footerJsx.AppendLine();
    footerJsx.AppendLine("          <div className=\"text-center\">");
    footerJsx.AppendLine("            <h4 className=\"text-lg font-semibold text-gray-900 dark:text-gray-100 mb-4\">");
    footerJsx.AppendLine("              Quick Links");
    footerJsx.AppendLine("            </h4>");
    footerJsx.AppendLine("            <div className=\"space-y-2\">");
    footerJsx.AppendLine("              <Link");
    footerJsx.AppendLine("                to=\"/home\" ");
    footerJsx.AppendLine("                className=\"block text-gray-600 dark:text-gray-400 hover:text-primary-600 dark:hover:text-primary-400 transition-colors duration-300\" ");
    footerJsx.AppendLine("                onClick={() => handleSmoothScroll()}");
    footerJsx.AppendLine("              >");
    footerJsx.AppendLine("                Home");
    footerJsx.AppendLine("              </Link>");
    footerJsx.AppendLine("            </div>");
    footerJsx.AppendLine("          </div>");
    footerJsx.AppendLine("        </div>");
    footerJsx.AppendLine();
    footerJsx.AppendLine("        <div className=\"mt-8 pt-8 border-t border-gray-200 dark:border-accent-700\">");
    footerJsx.AppendLine("          <div className=\"flex flex-col md:flex-row justify-between items-center\">");
    footerJsx.AppendLine("            <p className=\"text-gray-600 dark:text-gray-400 text-sm mb-4 md:mb-0\">");
    footerJsx.AppendLine($"              © {{new Date().getFullYear()}} {inputs.ProjectName}. All rights reserved.");
    footerJsx.AppendLine("            </p>");
    footerJsx.AppendLine("            <div className=\"flex items-center space-x-1 text-sm text-gray-600 dark:text-gray-400\">");
    footerJsx.AppendLine("              <span>Built with</span>");
    footerJsx.AppendLine("              <Heart className=\"w-4 h-4 text-red-500\" />");
    footerJsx.AppendLine("              <span>using React & Tailwind CSS</span>");
    footerJsx.AppendLine("            </div>");
    footerJsx.AppendLine("          </div>");
    footerJsx.AppendLine("        </div>");
    footerJsx.AppendLine("      </div>");
    footerJsx.AppendLine("    </footer>");
    footerJsx.AppendLine("  )");
    footerJsx.AppendLine("}");
    footerJsx.AppendLine();
    footerJsx.AppendLine("export default Footer ");
    
    File.WriteAllText(Path.Combine(path, "Footer.jsx"), footerJsx.ToString());

    Console.WriteLine("Footer.jsx created");
    Console.ResetColor();
  }

  public static void CreateHomeJsx(string path, Inputs inputs)
  {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Creating Home.jsx");
    
    StringBuilder homeJsx = new StringBuilder();

    homeJsx.AppendLine("import { motion } from 'framer-motion'");
    homeJsx.AppendLine();
    homeJsx.AppendLine("const Home = () => {");
    homeJsx.AppendLine();
    homeJsx.AppendLine("const containerVariants = {");
    homeJsx.AppendLine("  hidden: { opacity: 0 },");
    homeJsx.AppendLine("  visible: {");
    homeJsx.AppendLine("    opacity: 1,");
    homeJsx.AppendLine("    transition: {");
    homeJsx.AppendLine("      duration: 0.6,");
    homeJsx.AppendLine("      staggerChildren: 0.2,");
    homeJsx.AppendLine("      delay: 0.3,");
    homeJsx.AppendLine("    },");
    homeJsx.AppendLine("  }");
    homeJsx.AppendLine("};");
    homeJsx.AppendLine();
    homeJsx.AppendLine("  const itemVarients = {");
    homeJsx.AppendLine("    hidden: { opacity: 0, y: 20 },");
    homeJsx.AppendLine("    visible: {");
    homeJsx.AppendLine("      opacity: 1,");
    homeJsx.AppendLine("      y: 0,");
    homeJsx.AppendLine("      transition: { duration: 0.6 },");
    homeJsx.AppendLine("    },");
    homeJsx.AppendLine("  };");
    homeJsx.AppendLine();
    homeJsx.AppendLine("  return (");
    homeJsx.AppendLine("    <motion.div");
    homeJsx.AppendLine("      variants={containerVariants}");
    homeJsx.AppendLine("      initial=\"hidden\"");
    homeJsx.AppendLine("      animate=\"visible\"");
    homeJsx.AppendLine("      exit=\"hidden\"");
    homeJsx.AppendLine("    >");
    homeJsx.AppendLine("      <motion.h1");
    homeJsx.AppendLine("        variants={itemVarients}");
    homeJsx.AppendLine("        initial=\"hidden\"");
    homeJsx.AppendLine("        animate=\"visible\"");
    homeJsx.AppendLine("        className=\"text-4xl font-bold gradient-text text-center\"");
    homeJsx.AppendLine("      >");
    homeJsx.AppendLine($"        Welcome to the Home Page for {inputs.ProjectName}");
    homeJsx.AppendLine("      </motion.h1>");
    homeJsx.AppendLine("      <motion.img");
    homeJsx.AppendLine("        variants={itemVarients}");
    homeJsx.AppendLine("        initial=\"hidden\"");
    homeJsx.AppendLine("        animate=\"visible\"");
    homeJsx.AppendLine("        src=\"/logo.svg\"");
    homeJsx.AppendLine($"        alt=\"{inputs.ProjectName}\"");
    homeJsx.AppendLine("        className=\"w-1/2 mx-auto\"");
    homeJsx.AppendLine("      />");
    homeJsx.AppendLine("    </motion.div>");
    homeJsx.AppendLine("  );");
    homeJsx.AppendLine("};");
    homeJsx.AppendLine();
    homeJsx.AppendLine("export default Home;");
    
    File.WriteAllText(Path.Combine(path, "Home.jsx"), homeJsx.ToString());

    Console.WriteLine("Home.jsx created");
    Console.ResetColor();
  }

  public static void CreateErrorJsx(string path)
  {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Creating Error.jsx");
    
    StringBuilder errorJsx = new StringBuilder();

    errorJsx.AppendLine("import { motion } from 'framer-motion'");
    errorJsx.AppendLine();
    errorJsx.AppendLine("const Error = () => {");
    errorJsx.AppendLine("  const containerVariants = {");
    errorJsx.AppendLine("    hidden: { opacity: 0 },");
    errorJsx.AppendLine("    visible: {");
    errorJsx.AppendLine("      opacity: 1,");
    errorJsx.AppendLine("      transition: {");
    errorJsx.AppendLine("        duration: 0.6,");
    errorJsx.AppendLine("        staggerChildren: 0.2,");
    errorJsx.AppendLine("        delay: 0.3,");
    errorJsx.AppendLine("      },");
    errorJsx.AppendLine("    }");
    errorJsx.AppendLine("  };");
    errorJsx.AppendLine();
    errorJsx.AppendLine("  const itemVarients = {");
    errorJsx.AppendLine("    hidden: { opacity: 0, y: 20 },");
    errorJsx.AppendLine("    visible: {");
    errorJsx.AppendLine("      opacity: 1,");
    errorJsx.AppendLine("      y: 0,");
    errorJsx.AppendLine("      transition: { duration: 0.6 },");
    errorJsx.AppendLine("    },");
    errorJsx.AppendLine("  };");
    errorJsx.AppendLine();
    errorJsx.AppendLine("  return (");
    errorJsx.AppendLine("    <motion.div");
    errorJsx.AppendLine("      variants={containerVariants}");
    errorJsx.AppendLine("      initial=\"hidden\"");
    errorJsx.AppendLine("      animate=\"visible\"");
    errorJsx.AppendLine("      exit=\"hidden\"");
    errorJsx.AppendLine("    >");
    errorJsx.AppendLine("      <motion.h1");
    errorJsx.AppendLine("        variants={itemVarients}");
    errorJsx.AppendLine("        initial=\"hidden\"");
    errorJsx.AppendLine("        animate=\"visible\"");
    errorJsx.AppendLine("        className=\"text-4xl font-bold gradient-text text-center\"");
    errorJsx.AppendLine("      >");
    errorJsx.AppendLine("        Page Not Found");
    errorJsx.AppendLine("      </motion.h1>");
    errorJsx.AppendLine("    </motion.div>");
    errorJsx.AppendLine("  );");
    errorJsx.AppendLine("};");
    errorJsx.AppendLine();
    errorJsx.AppendLine("export default Error;");
    
    File.WriteAllText(Path.Combine(path, "Error.jsx"), errorJsx.ToString());

    Console.WriteLine("Error.jsx created");
    Console.ResetColor();
  }

  public static void CreateAppCss(string path)
  {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Creating app.css");
    
    StringBuilder appCss = new StringBuilder();

    appCss.AppendLine("@tailwind base;");
    appCss.AppendLine("@tailwind components;");
    appCss.AppendLine("@tailwind utilities;");
    appCss.AppendLine();
    appCss.AppendLine("#root {");
    appCss.AppendLine("  min-height: 100vh;");
    appCss.AppendLine("}");

    File.WriteAllText(Path.Combine(path, "app.css"), appCss.ToString());

    Console.WriteLine("app.css created");
    Console.ResetColor();
  }

  public static void CreateHandleSmoothScrollJs(string path)
  {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Creating handleSmoothScroll.js");
    
    StringBuilder handleSmoothScrollJs = new StringBuilder();
    
    handleSmoothScrollJs.AppendLine("export default function handleSmoothScroll() {");
    handleSmoothScrollJs.AppendLine("  window.scrollTo({");
    handleSmoothScrollJs.AppendLine("    top: 0,");
    handleSmoothScrollJs.AppendLine("    behavior: 'smooth',");
    handleSmoothScrollJs.AppendLine("  });");
    handleSmoothScrollJs.AppendLine("}");
    
    File.WriteAllText(Path.Combine(path, "handleSmoothScroll.js"), handleSmoothScrollJs.ToString());

    Console.WriteLine("handleSmoothScroll.js created");
    Console.ResetColor();
  }
}
