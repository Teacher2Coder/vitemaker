using System;
using System.Diagnostics;
using vitemaker.Questions;

namespace vitemaker.Commands;

public class Installs
{
  public static void InstallDefaultPackages(string path)
  {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Installing default packages...");
    Console.ResetColor();

    Process process = new Process();

    process.StartInfo.FileName = "/bin/bash";
    process.StartInfo.Arguments = $"-c \"cd {path} && npm install\"";
    process.Start();
    process.WaitForExit();

    Console.WriteLine("Default packages installed!");
    Console.ResetColor();
  }
  
  public static void InstallUserPackages(string path, Inputs inputs)
  {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Installing user packages...");
    Console.ResetColor();

    Process process = new Process();

    process.StartInfo.FileName = "/bin/bash";
    process.StartInfo.Arguments = $"-c \"cd {path} && npm install {string.Join(" ", inputs.PackagesToAdd)}\"";
    process.Start();
    process.WaitForExit();

    Console.WriteLine("User packages installed!");
    Console.ResetColor();
  }
}
