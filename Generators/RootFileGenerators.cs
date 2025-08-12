using System;
using System.IO;
using System.Text;
using vitemaker.Questions;

namespace vitemaker.Generators;

public class RootFileGenerators
{
  public static void CreatePackageJson(string path, Inputs inputs)
  {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Creating package.json...");
    
    StringBuilder packageJson = new StringBuilder();
    
    packageJson.AppendLine("{");
    packageJson.AppendLine($"  \"name\": \"{inputs.ProjectName.ToLower()}\",");
    packageJson.AppendLine("  \"version\": \"1.0.0\",");
    packageJson.AppendLine($"  \"description\": \"{inputs.ProjectDescription}\",");
    packageJson.AppendLine("  \"keywords\": [");
    string[] keywords = inputs.ProjectKeywords.Split(',');
    for (int i = 0; i < keywords.Length; i++)
    {
      string keyword = keywords[i].Trim();
      if (i == keywords.Length - 1)
      {
        packageJson.AppendLine($"    \"{keyword}\"");
      }
      else
      {
        packageJson.AppendLine($"    \"{keyword}\",");
      }
    }
    packageJson.AppendLine("  ],");
    packageJson.AppendLine("  \"license\": \"MIT\",");
    packageJson.AppendLine($"  \"author\": \"{inputs.ProjectAuthor}\",");
    packageJson.AppendLine("  \"type\": \"commonjs\",");
    packageJson.AppendLine("  \"main\": \"main.jsx\",");
    packageJson.AppendLine("  \"scripts\": {");
    packageJson.AppendLine("    \"dev\": \"vite\",");
    packageJson.AppendLine("    \"build\": \"vite build\",");
    packageJson.AppendLine("    \"lint\": \"eslint .\",");
    packageJson.AppendLine("    \"preview\": \"vite preview\"");
    packageJson.AppendLine("  },");
    packageJson.AppendLine("  \"dependencies\": {");
    packageJson.AppendLine("    \"axios\": \"^1.10.0\",");
    packageJson.AppendLine("    \"framer-motion\": \"^12.18.1\",");
    packageJson.AppendLine("    \"lucide-react\": \"^0.515.0\",");
    packageJson.AppendLine("    \"react\": \"^19.1.0\",");
    packageJson.AppendLine("    \"react-dom\": \"^19.1.0\",");
    packageJson.AppendLine("    \"react-router-dom\": \"^7.6.2\"");
    packageJson.AppendLine("  },");
    packageJson.AppendLine("  \"devDependencies\": {");
    packageJson.AppendLine("    \"@eslint/js\": \"^9.25.0\",");
    packageJson.AppendLine("    \"@types/react\": \"^19.1.2\",");
    packageJson.AppendLine("    \"@types/react-dom\": \"^19.1.2\",");
    packageJson.AppendLine("    \"@vitejs/plugin-react\": \"^4.4.1\",");
    packageJson.AppendLine("    \"autoprefixer\": \"^10.4.21\",");
    packageJson.AppendLine("    \"eslint\": \"^9.25.0\",");
    packageJson.AppendLine("    \"eslint-plugin-react-hooks\": \"^5.2.0\",");
    packageJson.AppendLine("    \"eslint-plugin-react-refresh\": \"^0.4.19\",");
    packageJson.AppendLine("    \"globals\": \"^16.0.0\",");
    packageJson.AppendLine("    \"postcss\": \"^8.5.6\",");
    packageJson.AppendLine("    \"tailwindcss\": \"^3.4.17\",");
    packageJson.AppendLine("    \"vite\": \"^6.3.5\"");
    packageJson.AppendLine("  }");
    packageJson.AppendLine("}");

    File.WriteAllText(Path.Combine(path, "package.json"), packageJson.ToString());

    Console.WriteLine("package.json created!");
    Console.ResetColor();
  }

  public static void CreateViteConfig(string path)
  {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Creating vite.config.js...");
    
    StringBuilder viteConfig = new StringBuilder();

    viteConfig.AppendLine("import { defineConfig } from 'vite'");
    viteConfig.AppendLine("import react from '@vitejs/plugin-react'");
    viteConfig.AppendLine();
    viteConfig.AppendLine("// https://vitejs.dev/config/");
    viteConfig.AppendLine("export default defineConfig({");
    viteConfig.AppendLine("  plugins: [react()],");
    viteConfig.AppendLine("  server: {");
    viteConfig.AppendLine("    port: 3001,");
    viteConfig.AppendLine("  },");
    viteConfig.AppendLine("});");


    File.WriteAllText(Path.Combine(path, "vite.config.js"), viteConfig.ToString());

    Console.WriteLine("vite.config.js created!");
    Console.ResetColor();
  }

  public static void CreateTailwindConfig(string path)
  {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Creating tailwind.config.js...");
    
    StringBuilder tailwindConfig = new StringBuilder();
    
    tailwindConfig.AppendLine("/** @type {import('tailwindcss').Config} */");
    tailwindConfig.AppendLine("export default {");
    tailwindConfig.AppendLine("  content: [");
    tailwindConfig.AppendLine("    \"./index.html\",");
    tailwindConfig.AppendLine("    \"./src/**/*.{js,ts,jsx,tsx}\",");
    tailwindConfig.AppendLine("  ],");
    tailwindConfig.AppendLine("  theme: {");
    tailwindConfig.AppendLine("    extend: {");
    tailwindConfig.AppendLine("      fontFamily: {");
    tailwindConfig.AppendLine("        'sans': ['Inter', 'system-ui', 'sans-serif'],");
    tailwindConfig.AppendLine("      },");
    tailwindConfig.AppendLine("      colors: {");
    tailwindConfig.AppendLine("        primary: {");
    tailwindConfig.AppendLine("          50: '#f0f4ff',");
    tailwindConfig.AppendLine("          100: '#e0ebff',");
    tailwindConfig.AppendLine("          200: '#c7d8ff',");
    tailwindConfig.AppendLine("          300: '#a3bdff',");
    tailwindConfig.AppendLine("          400: '#7a94ff',");
    tailwindConfig.AppendLine("          500: '#4169e1',");
    tailwindConfig.AppendLine("          600: '#3d5fcc',");
    tailwindConfig.AppendLine("          700: '#3651b8',");
    tailwindConfig.AppendLine("          800: '#2f44a3',");
    tailwindConfig.AppendLine("          900: '#283a8f',");
    tailwindConfig.AppendLine("        },");
    tailwindConfig.AppendLine("        accent: {");
    tailwindConfig.AppendLine("          50: '#f8f9fa',");
    tailwindConfig.AppendLine("          100: '#f1f3f4',");
    tailwindConfig.AppendLine("          200: '#e8eaed',");
    tailwindConfig.AppendLine("          300: '#dadce0',");
    tailwindConfig.AppendLine("          400: '#c0c0c0',");
    tailwindConfig.AppendLine("          500: '#9aa0a6',");
    tailwindConfig.AppendLine("          600: '#80868b',");
    tailwindConfig.AppendLine("          700: '#5f6368',");
    tailwindConfig.AppendLine("          800: '#3c4043',");
    tailwindConfig.AppendLine("          900: '#202124',");
    tailwindConfig.AppendLine("        }");
    tailwindConfig.AppendLine("      },");
    tailwindConfig.AppendLine("      animation: {");
    tailwindConfig.AppendLine("        'fade-in': 'fadeIn 0.5s ease-in-out',");
    tailwindConfig.AppendLine("        'fade-in-up': 'fadeInUp 0.6s ease-out',");
    tailwindConfig.AppendLine("        'float': 'float 6s ease-in-out infinite',");
    tailwindConfig.AppendLine("        'gradient': 'gradient 15s ease infinite',");
    tailwindConfig.AppendLine("      },");
    tailwindConfig.AppendLine("      keyframes: {");
    tailwindConfig.AppendLine("        fadeIn: {");
    tailwindConfig.AppendLine("          '0%': { opacity: '0' },");
    tailwindConfig.AppendLine("          '100%': { opacity: '1' },");
    tailwindConfig.AppendLine("        },");
    tailwindConfig.AppendLine("        fadeInUp: {");
    tailwindConfig.AppendLine("          '0%': { opacity: '0', transform: 'translateY(20px)' },");
    tailwindConfig.AppendLine("          '100%': { opacity: '1', transform: 'translateY(0)' },");
    tailwindConfig.AppendLine("        },");
    tailwindConfig.AppendLine("        float: {");
    tailwindConfig.AppendLine("          '0%, 100%': { transform: 'translateY(0px)' },");
    tailwindConfig.AppendLine("          '50%': { transform: 'translateY(-20px)' },");
    tailwindConfig.AppendLine("        },");
    tailwindConfig.AppendLine("        gradient: {");
    tailwindConfig.AppendLine("          '0%, 100%': {");
    tailwindConfig.AppendLine("            'background-size': '200% 200%',");
    tailwindConfig.AppendLine("            'background-position': 'left center'");
    tailwindConfig.AppendLine("          },");
    tailwindConfig.AppendLine("          '50%': {");
    tailwindConfig.AppendLine("            'background-size': '200% 200%',");
    tailwindConfig.AppendLine("            'background-position': 'right center'");
    tailwindConfig.AppendLine("          },");
    tailwindConfig.AppendLine("        },");
    tailwindConfig.AppendLine("      },");
    tailwindConfig.AppendLine("    },");
    tailwindConfig.AppendLine("  },");
    tailwindConfig.AppendLine("} ");
    
    File.WriteAllText(Path.Combine(path, "tailwind.config.js"), tailwindConfig.ToString());
  
    Console.WriteLine("tailwind.config.js created!");
    Console.ResetColor();
  }

  public static void CreatePostcssConfig(string path)
  {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Creating postcss.config.js...");
    
    StringBuilder postcssConfig = new StringBuilder();
    
    postcssConfig.AppendLine("module.exports = {");
    postcssConfig.AppendLine("  plugins: {");
    postcssConfig.AppendLine("    tailwindcss: {},");
    postcssConfig.AppendLine("    autoprefixer: {},");
    postcssConfig.AppendLine("  },");
    postcssConfig.AppendLine("};");

    File.WriteAllText(Path.Combine(path, "postcss.config.js"), postcssConfig.ToString());

    Console.WriteLine("postcss.config.js created!");
    Console.ResetColor();
  }

  public static void CreateIndexHtml(string path, Inputs inputs)
  {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Creating index.html...");
    
    StringBuilder indexHtml = new StringBuilder();

    indexHtml.AppendLine("<!DOCTYPE html>");
    indexHtml.AppendLine("<html lang=\"en\">");
    indexHtml.AppendLine("  <head>");
    indexHtml.AppendLine("    <meta charset=\"UTF-8\">");
    indexHtml.AppendLine("    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">");
    indexHtml.AppendLine($"    <meta name=\"description\" content=\"{inputs.ProjectDescription}\">");
    indexHtml.AppendLine($"    <meta name=\"author\" content=\"{inputs.ProjectAuthor}\">");
    indexHtml.AppendLine($"    <meta name=\"keywords\" content=\"{inputs.ProjectKeywords}\">");
    indexHtml.AppendLine();
    indexHtml.AppendLine("    <!-- Open Graph / Facebook -->");
    indexHtml.AppendLine("    <meta property=\"og:type\" content=\"website\">");
    indexHtml.AppendLine("    <meta property=\"og:url\" content=\"\">");
    indexHtml.AppendLine($"    <meta property=\"og:title\" content=\"{inputs.ProjectName}\">");
    indexHtml.AppendLine($"    <meta property=\"og:description\" content=\"{inputs.ProjectDescription}\">");
    indexHtml.AppendLine("    <meta property=\"og:image\" content=\"\">");
    indexHtml.AppendLine("    <meta property=\"og:image:alt\" content=\"\">");
    indexHtml.AppendLine("    <meta property=\"og:image:width\" content=\"1200\">");
    indexHtml.AppendLine("    <meta property=\"og:image:height\" content=\"630\">");
    indexHtml.AppendLine("    <meta property=\"og:image:type\" content=\"image/png\">");
    indexHtml.AppendLine("    <meta property=\"og:locale\" content=\"en_US\">");
    indexHtml.AppendLine($"    <meta property=\"og:site_name\" content=\"{inputs.ProjectName}\">");
    indexHtml.AppendLine();
    indexHtml.AppendLine("    <!-- Twitter -->");
    indexHtml.AppendLine("    <meta property=\"twitter:card\" content=\"summary_large_image\">");
    indexHtml.AppendLine("    <meta property=\"twitter:url\" content=\"\">");
    indexHtml.AppendLine($"    <meta property=\"twitter:title\" content=\"{inputs.ProjectName}\">");
    indexHtml.AppendLine($"    <meta property=\"twitter:description\" content=\"{inputs.ProjectDescription}\">");
    indexHtml.AppendLine("    <meta property=\"twitter:image\" content=\"\">");
    indexHtml.AppendLine("    <meta property=\"twitter:image:alt\" content=\"\">");
    indexHtml.AppendLine("    <meta property=\"twitter:image:width\" content=\"1200\">");
    indexHtml.AppendLine("    <meta property=\"twitter:image:height\" content=\"630\">");
    indexHtml.AppendLine("    <meta property=\"twitter:image:type\" content=\"image/png\">");
    indexHtml.AppendLine("    <meta property=\"twitter:locale\" content=\"en_US\">");
    indexHtml.AppendLine($"    <meta property=\"twitter:site\" content=\"{inputs.ProjectName}\">");
    indexHtml.AppendLine();
    indexHtml.AppendLine("    <!-- Robots -->");
    indexHtml.AppendLine("    <meta name=\"robots\" content=\"index, follow\">");
    indexHtml.AppendLine("    <meta name=\"googlebot\" content=\"index, follow\">");
    indexHtml.AppendLine("    <meta name=\"bingbot\" content=\"index, follow\">");
    indexHtml.AppendLine("    <meta name=\"yandexbot\" content=\"index, follow\">");
    indexHtml.AppendLine("    <meta name=\"sogoubot\" content=\"index, follow\">");  
    indexHtml.AppendLine("    <meta name=\"360bot\" content=\"index, follow\">");
    indexHtml.AppendLine("    <meta name=\"shenma\" content=\"index, follow, max-snippet:-1, max-image-preview:large, max-video-preview:-1\">");
    indexHtml.AppendLine("    <meta name=\"baidubot\" content=\"index, follow, max-snippet:-1, max-image-preview:large, max-video-preview:-1\">");
    indexHtml.AppendLine("    <meta name=\"duckduckbot\" content=\"index, follow\">");
    indexHtml.AppendLine();
    indexHtml.AppendLine("    <!-- Favicon -->");
    indexHtml.AppendLine("    <link rel=\"icon\" type=\"image\" href=\"/logo.svg\">");
    indexHtml.AppendLine("    <link rel=\"apple-touch-icon\" href=\"/logo.svg\">");
    indexHtml.AppendLine("    <link rel=\"icon\" type=\"image/x-icon\" href=\"/logo.svg\">");
    indexHtml.AppendLine();
    indexHtml.AppendLine("    <!-- Schema.org -->");
    indexHtml.AppendLine("    <script type=\"application/ld+json\">");
    indexHtml.AppendLine("      {");
    indexHtml.AppendLine("        \"@context\": \"https://schema.org\",");
    indexHtml.AppendLine("        \"@type\": \"WebSite\",");
    indexHtml.AppendLine($"        \"name\": \"{inputs.ProjectName}\",");
    indexHtml.AppendLine($"        \"url\": \"https://{inputs.ProjectName}.com\"");
    indexHtml.AppendLine("      }");
    indexHtml.AppendLine("    </script>");
    indexHtml.AppendLine();
    indexHtml.AppendLine($"    <title>{inputs.ProjectName}</title>");
    indexHtml.AppendLine("  </head>");
    indexHtml.AppendLine("  <body>");
    indexHtml.AppendLine("    <div id=\"root\"></div>");
    indexHtml.AppendLine("    <script type=\"module\" src=\"/src/main.jsx\"></script>");
    indexHtml.AppendLine("  </body>");
    indexHtml.AppendLine("</html>");

    File.WriteAllText(Path.Combine(path, "index.html"), indexHtml.ToString());

    Console.WriteLine("index.html created!");
    Console.ResetColor();
  }

  public static void CreateEslintConfigJs(string path)
  {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Creating eslint.config.js...");
    
    StringBuilder eslintConfigJs = new StringBuilder();

    eslintConfigJs.AppendLine("module.exports = {");
    eslintConfigJs.AppendLine("  extends: [");
    eslintConfigJs.AppendLine("    'eslint:recommended',");
    eslintConfigJs.AppendLine("    'plugin:react/recommended',");
    eslintConfigJs.AppendLine("    'plugin:react/jsx-runtime',");
    eslintConfigJs.AppendLine("    'plugin:react-hooks/recommended',");
    eslintConfigJs.AppendLine("  ],");
    eslintConfigJs.AppendLine("  parserOptions: {");
    eslintConfigJs.AppendLine("    ecmaVersion: 'latest',");
    eslintConfigJs.AppendLine("    sourceType: 'module',");
    eslintConfigJs.AppendLine("  },");
    eslintConfigJs.AppendLine("  settings: {");
    eslintConfigJs.AppendLine("    react: { version: '18.2' }");
    eslintConfigJs.AppendLine("  },");
    eslintConfigJs.AppendLine("  plugins: [");
    eslintConfigJs.AppendLine("    'react',");
    eslintConfigJs.AppendLine("    'react-hooks',");
    eslintConfigJs.AppendLine("    'react-hooks',");
    eslintConfigJs.AppendLine("  ],");
    eslintConfigJs.AppendLine("  rules: {");
    eslintConfigJs.AppendLine("    'react-refresh/only-export-components': 'warn',");
    eslintConfigJs.AppendLine("    'react/prop-types': 'off',");
    eslintConfigJs.AppendLine("  },");
    eslintConfigJs.AppendLine("};");

    File.WriteAllText(Path.Combine(path, "eslint.config.js"), eslintConfigJs.ToString());

    Console.WriteLine("eslint.config.js created!");
    Console.ResetColor();
  }

  public static void CreateGitignore(string path)
  {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Creating .gitignore...");
    
    StringBuilder gitignore = new StringBuilder();

    gitignore.AppendLine("# Logs");
    gitignore.AppendLine("logs");
    gitignore.AppendLine("*.log");
    gitignore.AppendLine("npm-debug.log*");
    gitignore.AppendLine("yarn-debug.log*");
    gitignore.AppendLine("yarn-error.log*");
    gitignore.AppendLine("pnpm-debug.log*");
    gitignore.AppendLine("lerna-debug.log*");
    gitignore.AppendLine();
    gitignore.AppendLine("# Dependencies");
    gitignore.AppendLine("node_modules");
    gitignore.AppendLine("package-lock.json");
    gitignore.AppendLine("dist");
    gitignore.AppendLine("dist-ssr");
    gitignore.AppendLine("*.local");
    gitignore.AppendLine(".env");
    gitignore.AppendLine();
    gitignore.AppendLine("# IDEs");
    gitignore.AppendLine(".vscode");
    gitignore.AppendLine(".vscode/extensions.json");
    gitignore.AppendLine(".idea");
    gitignore.AppendLine(".cursorrules");
    gitignore.AppendLine(".cursor");
    gitignore.AppendLine("*.suo");
    gitignore.AppendLine("*.ntvs*");
    gitignore.AppendLine("*.njsprod");
    gitignore.AppendLine("*.sln");
    gitignore.AppendLine("*.sw?");

    File.WriteAllText(Path.Combine(path, ".gitignore"), gitignore.ToString());

    Console.WriteLine(".gitignore created!");
    Console.ResetColor();
  }
}
