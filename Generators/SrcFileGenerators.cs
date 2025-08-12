using System;
using System.IO;
using System.Text;

namespace vitemaker.Generators;

public class SrcFileGenerators
{
  public static void CreateMainJsx(string path)
  {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Creating main.jsx...");
    
    StringBuilder mainJsx = new StringBuilder();
    mainJsx.AppendLine("import { StrictMode } from 'react';");
    mainJsx.AppendLine("import { createRoot } from 'react-dom/client';");
    mainJsx.AppendLine("import { BrowserRouter as Router } from 'react-router-dom';");
    mainJsx.AppendLine("import App from './App.jsx';");
    mainJsx.AppendLine("import './styles/app.css';");
    mainJsx.AppendLine();
    mainJsx.AppendLine("createRoot(document.getElementById('root')).render(");
    mainJsx.AppendLine("  <StrictMode>");
    mainJsx.AppendLine("    <Router>");
    mainJsx.AppendLine("      <App />");
    mainJsx.AppendLine("    </Router>");
    mainJsx.AppendLine("  </StrictMode>");
    mainJsx.AppendLine(");");

    File.WriteAllText(Path.Combine(path, "main.jsx"), mainJsx.ToString());

    Console.WriteLine("main.jsx created!");
    Console.ResetColor();
  }

  public static void CreateAppJsx(string path)
  {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Creating App.jsx...");
    
    StringBuilder appJsx = new StringBuilder();

    appJsx.AppendLine("import { Routes, Route, useLocation } from 'react-router-dom';");
    appJsx.AppendLine("import { AnimatePresence } from 'framer-motion';");
    appJsx.AppendLine("import Navbar from './components/Navbar.jsx';");
    appJsx.AppendLine("import Footer from './components/Footer.jsx';");
    appJsx.AppendLine("import Home from './pages/Home.jsx';");
    appJsx.AppendLine("import Error from './pages/Error.jsx';");
    appJsx.AppendLine("import './styles/app.css';");
    appJsx.AppendLine();
    appJsx.AppendLine("const App = () => {");
    appJsx.AppendLine("  const location = useLocation();");
    appJsx.AppendLine();
    appJsx.AppendLine("  return (");
    appJsx.AppendLine("    <div className='app'>");
    appJsx.AppendLine("      <Navbar />");
    appJsx.AppendLine("      <main className='app pt-20'>");
    appJsx.AppendLine("        <AnimatePresence mode='wait'>");
    appJsx.AppendLine("          <Routes location={location} key={location.pathname}>");
    appJsx.AppendLine("            <Route path='/' element={<Home />} />");
    appJsx.AppendLine("            <Route path='*' element={<Error />} />");
    appJsx.AppendLine("          </Routes>");
    appJsx.AppendLine("      </AnimatePresence>");
    appJsx.AppendLine("      </main>");
    appJsx.AppendLine("      <Footer />");
    appJsx.AppendLine("    </div>");
    appJsx.AppendLine("  );");
    appJsx.AppendLine("}");
    appJsx.AppendLine();
    appJsx.AppendLine("export default App;");

    File.WriteAllText(Path.Combine(path, "App.jsx"), appJsx.ToString());

    Console.WriteLine("App.jsx created!");
    Console.ResetColor();
  }

  public static void CreateIndexCss(string path)
  {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Creating index.css...");
    
    StringBuilder indexCss = new StringBuilder();

    indexCss.AppendLine("@tailwind base;");
    indexCss.AppendLine("@tailwind components;");
    indexCss.AppendLine("@tailwind utilities;");
    indexCss.AppendLine();
    indexCss.AppendLine("@layer base {");
    indexCss.AppendLine("  html {");
    indexCss.AppendLine("    font-family: 'Inter', sans-serif;");
    indexCss.AppendLine("  }");
    indexCss.AppendLine("  body {");
    indexCss.AppendLine("    @apply bg-white text-black;");
    indexCss.AppendLine("  }");
    indexCss.AppendLine("  * {");
    indexCss.AppendLine("    @apply scroll-smooth;");
    indexCss.AppendLine("  }");
    indexCss.AppendLine("}");
    indexCss.AppendLine();
    indexCss.AppendLine("@layer components {");
    indexCss.AppendLine("  .gradient-text {");
    indexCss.AppendLine("    @apply bg-gradient-to-r from-blue-500 to-purple-500 text-transparent bg-clip-text;");
    indexCss.AppendLine("  }");
    indexCss.AppendLine("  .gradient-border {");
    indexCss.AppendLine("    @apply border-gradient-to-r from-blue-500 to-purple-500;");
    indexCss.AppendLine("  }");
    indexCss.AppendLine("  .gradient-bg {");
    indexCss.AppendLine("    @apply bg-gradient-to-r from-blue-500 to-purple-500;");
    indexCss.AppendLine("  }");
    indexCss.AppendLine("  .card-hover {");
    indexCss.AppendLine("    @apply hover:scale-105 transition-all duration-300;");
    indexCss.AppendLine("  }");
    indexCss.AppendLine("  .card-shadow {");
    indexCss.AppendLine("    @apply shadow-lg shadow-gray-500/20;");
    indexCss.AppendLine("  }");
    indexCss.AppendLine("  .btn-primary {");
    indexCss.AppendLine("    @apply bg-blue-500 text-white px-4 py-2 rounded-md hover:bg-blue-600;");
    indexCss.AppendLine("  }");
    indexCss.AppendLine("  .btn-secondary {");
    indexCss.AppendLine("    @apply bg-gray-500 text-white px-4 py-2 rounded-md hover:bg-gray-600;");
    indexCss.AppendLine("  }");
    indexCss.AppendLine("  .section-padding {");
    indexCss.AppendLine("    @apply py-16 md:py-24;");
    indexCss.AppendLine("  }");
    indexCss.AppendLine("  .container-padding {");
    indexCss.AppendLine("    @apply px-4 md:px-8 lg:px-16;");
    indexCss.AppendLine("  }");
    indexCss.AppendLine("}");
    indexCss.AppendLine();
    
    File.WriteAllText(Path.Combine(path, "index.css"), indexCss.ToString());

    Console.WriteLine("index.css created!");
    Console.ResetColor();
  }

  public static void CreateAppCss(string path)
  {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Creating app.css");
    
    StringBuilder appCss = new StringBuilder();

    appCss.AppendLine("#root {");
    appCss.AppendLine("  max-width: 1280px;");
    appCss.AppendLine("  margin: 0 auto;");
    appCss.AppendLine("  padding: 2rem;");
    appCss.AppendLine("  text-align: center;");
    appCss.AppendLine("}");

    File.WriteAllText(Path.Combine(path, "app.css"), appCss.ToString());

    Console.WriteLine("app.css created");
    Console.ResetColor();
  }
}
