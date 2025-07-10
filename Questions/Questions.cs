using System;

namespace vitemaker.Questions;

public class Questions
{
  public static string AskProjectName()
  {
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("What is the name of the project?");
    Console.ResetColor();
    string answer = Console.ReadLine() ?? string.Empty;

    if (string.IsNullOrEmpty(answer))
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Project name cannot be empty.");
      Console.ResetColor();
      return AskProjectName();
    }
    return answer;
  }

  public static string AskForProjectAuthor()
  {
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Who is the author of the project?");
    Console.ResetColor();
    string answer = Console.ReadLine() ?? string.Empty;

    if (string.IsNullOrEmpty(answer))
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Answer cannot be empty.");
      Console.ResetColor();
      return AskForProjectAuthor();
    }
    return answer;
  }

  public static string AskForProjectDescription()
  {
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("What is the description of the project?");
    Console.ResetColor();
    string answer = Console.ReadLine() ?? string.Empty;

    if (string.IsNullOrEmpty(answer))
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Answer cannot be empty.");
      Console.ResetColor();
      return AskForProjectDescription();
    }

    return answer;
  }

  public static string AskForProjectKeywords()
  {
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("What are the keywords of the project?");
    Console.WriteLine("Separate keywords with commas");
    Console.ResetColor();
    string answer = Console.ReadLine() ?? string.Empty;

    if (string.IsNullOrEmpty(answer))
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Answer cannot be empty.");
      Console.ResetColor();
      return AskForProjectKeywords();
    }

    return answer;
  }

  public static string AskForAdditionalPackages()
  {
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Do you want to add any additional packages? (y/n)");
    Console.ResetColor();
    string answer = Console.ReadLine() ?? string.Empty;

    if (string.IsNullOrEmpty(answer))
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Answer cannot be empty.");
      Console.ResetColor();
      return AskForAdditionalPackages();
    }
    return answer;
  }

  public static string AskWhatPackageToAdd()
  {
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("What package do you want to add?");
    Console.ResetColor();
    string answer = Console.ReadLine() ?? string.Empty;

    if (string.IsNullOrEmpty(answer))
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Answer cannot be empty.");
      Console.ResetColor();
      return AskWhatPackageToAdd();
    }

    return answer;
  }
}
