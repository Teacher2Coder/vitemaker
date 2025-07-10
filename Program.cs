using vitemaker.Questions;
using vitemaker.Generators;

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
  inputs.PackageToAdd.Add(Questions.AskWhatPackageToAdd());
  inputs.AdditionalPackages = Questions.AskForAdditionalPackages();
}

var pathToProject = $"{inputs.ProjectName}";
var pathToPublic = $"{pathToProject}/public";
var pathToSrc = $"{pathToProject}/src";

FolderGenerators.CreateFolders(pathToProject);

// Create files in project folder
RootFileGenerators.CreateViteConfig(pathToProject);
RootFileGenerators.CreateIndexHtml(pathToProject, inputs);
// Need eslint.config.js and .gitignore, 

// Create files in public folder
RootFileGenerators.CreateLogo(pathToPublic);

// Create files in src folder
// Need main.jsx, App.jsx

//Create files in src subfolders
// Need navbar and footer in components
// Need home and error in pages
// Need app.css in styles
// Need handleSmoothScroll.js in utils