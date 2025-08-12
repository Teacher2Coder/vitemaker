using vitemaker.Questions;
using vitemaker.Generators;
using vitemaker.Commands;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("-------------------------------");
Console.WriteLine("|        Vite Generator!       |");
Console.WriteLine("-------------------------------");
Console.ResetColor();

Inputs inputs = new Inputs();

inputs.ProjectName = Questions.AskProjectName();
inputs.ProjectAuthor = Questions.AskForProjectAuthor();
inputs.ProjectDescription = Questions.AskForProjectDescription();
inputs.ProjectKeywords = Questions.AskForProjectKeywords();
inputs.AdditionalPackages = Questions.AskForAdditionalPackages();

while (inputs.AdditionalPackages == "y")
{
  inputs.PackagesToAdd.Add(Questions.AskWhatPackagesToAdd());
  inputs.AdditionalPackages = Questions.AskForAdditionalPackages();
}

var pathToProject = $"{inputs.ProjectName}";
var pathToPublic = $"{pathToProject}/public";
var pathToSrc = $"{pathToProject}/src";
var pathToComponents = $"{pathToSrc}/components";
var pathToPages = $"{pathToSrc}/pages";
var pathToStyles = $"{pathToSrc}/styles";
var pathToUtils = $"{pathToSrc}/utils";

FolderGenerators.CreateFolders(pathToProject);

// Create files in root folder
RootFileGenerators.CreatePackageJson(pathToProject, inputs);
RootFileGenerators.CreateViteConfig(pathToProject);
RootFileGenerators.CreateTailwindConfig(pathToProject);
RootFileGenerators.CreatePostcssConfig(pathToProject);
RootFileGenerators.CreateIndexHtml(pathToProject, inputs);
RootFileGenerators.CreateEslintConfigJs(pathToProject);
RootFileGenerators.CreateGitignore(pathToProject);

// Create files in public folder
PublicFileGenerators.CreateLogo(pathToPublic);
PublicFileGenerators.CreateRedirects(pathToPublic);
PublicFileGenerators.CreateRobotsTxt(pathToPublic);
PublicFileGenerators.CreateSiteMapXml(pathToPublic);

// Create files in src folder
SrcFileGenerators.CreateMainJsx(pathToSrc);
SrcFileGenerators.CreateAppJsx(pathToSrc);
SrcFileGenerators.CreateIndexCss(pathToSrc);

//Create files in src subfolders
SrcSubFileGenerators.CreateNavbarJsx(pathToComponents, inputs);
SrcSubFileGenerators.CreateFooterJsx(pathToComponents, inputs);
SrcSubFileGenerators.CreateHomeJsx(pathToPages, inputs);
SrcSubFileGenerators.CreateErrorJsx(pathToPages);
SrcSubFileGenerators.CreateAppCss(pathToStyles);
SrcSubFileGenerators.CreateNavbarCss(pathToStyles);
SrcSubFileGenerators.CreateHandleSmoothScrollJs(pathToUtils);
SrcSubFileGenerators.CreateUsePageSeoJs(pathToUtils);

// Run console commands
Installs.InstallDefaultPackages(pathToProject);
if (inputs.PackagesToAdd.Count > 0)
  Installs.InstallUserPackages(pathToProject, inputs);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Project created successfully!");
Console.ResetColor();