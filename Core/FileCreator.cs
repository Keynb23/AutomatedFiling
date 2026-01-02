namespace AutoFiles.Core
{
    public static class FileCreator
    {
        public static void Create(string rootPath, List<StructureNode> nodes)
        {
            foreach (var node in nodes)
            {
                string folderPath = rootPath;

                if (!string.IsNullOrWhiteSpace(node.FolderPath))
                {
                    folderPath = Path.Combine(rootPath, node.FolderPath);
                    Directory.CreateDirectory(folderPath);
                }

                foreach (var file in node.Files)
                {
                    string filePath = Path.Combine(folderPath, file);

                    if (!File.Exists(filePath))
                    {
                        File.WriteAllText(filePath, $"// {node.FolderPath}/{file}".Trim('/'));
                    }
                }
            }
        }
    }
}
