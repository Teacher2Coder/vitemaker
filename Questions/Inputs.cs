using System;

namespace vitemaker.Questions;

public sealed class Inputs
{
  private string? projectName;
  private string? projectAuthor;
  private string? projectDescription;
  private string? projectKeywords;
  private string? additionalPackages;
  private ICollection<string> packagesToAdd;

  public Inputs()
  {
    packagesToAdd = new List<string>();
  }

  public string ProjectName
  {
    get { return projectName ?? string.Empty; }
    set { projectName = value; }
  }

  public string ProjectAuthor
  {
    get { return projectAuthor ?? string.Empty; }
    set { projectAuthor = value; }
  }

  public string ProjectDescription
  {
    get { return projectDescription ?? string.Empty; }
    set { projectDescription = value; }
  }

  public string ProjectKeywords
  {
    get { return projectKeywords ?? string.Empty; }
    set { projectKeywords = value; }
  }

  public string AdditionalPackages
  {
    get { return additionalPackages ?? string.Empty; }
    set { additionalPackages = value; }
  }

  public ICollection<string> PackagesToAdd
  {
    get { return packagesToAdd; }
    set { packagesToAdd = value; }
  }
}
