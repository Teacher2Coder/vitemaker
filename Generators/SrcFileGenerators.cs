using System;
using System.IO;
using System.Text;

namespace vitemaker.Generators;

public class SrcFileGenerators
{
  public static void CreateMainJsx(string path)
  {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Creating main.jsx");
    
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

    Console.WriteLine("main.jsx created");
    Console.ResetColor();
  }

  public static void CreateAppJsx(string path)
  {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Creating App.jsx");
    
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

    Console.WriteLine("App.jsx created");
    Console.ResetColor();
  }
}
