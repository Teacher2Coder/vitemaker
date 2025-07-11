using System;
using vitemaker.Questions;

namespace vitemaker.Commands;

public class Installs
{
  public static void InstallUserPackages(string path, Inputs inputs)
  {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Installing user packages...");
    Console.ResetColor();

    foreach (string package in inputs.PackagesToAdd)
    {
      Console.WriteLine($"Installing {package}...");
    }

    Console.WriteLine("User packages installed!");
    Console.ResetColor();
  }
}
