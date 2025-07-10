using System;
using System.IO;

namespace vitemaker.Generators;

public class FolderGenerators
{
  public static void CreateFolders(string path)
  {
    CreatePublicFolder(path);
    CreateSrcFolder(path);
  }

  public static void CreatePublicFolder(string path)
  {
    Directory.CreateDirectory(Path.Combine(path, "public"));
  }

  public static void CreateSrcFolder(string path)
  {
    Directory.CreateDirectory(Path.Combine(path, "src"));
    Directory.CreateDirectory(Path.Combine(path, "src", "assets"));
    Directory.CreateDirectory(Path.Combine(path, "src", "components"));
    Directory.CreateDirectory(Path.Combine(path, "src", "data"));
    Directory.CreateDirectory(Path.Combine(path, "src", "pages"));
    Directory.CreateDirectory(Path.Combine(path, "src", "styles"));
    Directory.CreateDirectory(Path.Combine(path, "src", "utils"));
  }
}
