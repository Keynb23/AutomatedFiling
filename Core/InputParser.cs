namespace AutoFiles.Core
{
    public static class InputParser
    {
        public static List<StructureNode> Parse(List<string> lines)
        {
            var result = new List<StructureNode>();

            foreach (var rawLine in lines)
            {
                string line = rawLine.Trim();

                if (line.StartsWith("/"))
                    line = line.Substring(1);

                string[] parts = line.Split('/', 2);

                string folderPath;
                string filePart;

                if (parts.Length == 1)
                {
                    folderPath = "";
                    filePart = parts[0];
                }
                else
                {
                    folderPath = parts[0];
                    filePart = parts[1];
                }

                var files = filePart
                    .Split(',')
                    .Select(f => f.Trim())
                    .Where(f => f.Length > 0)
                    .ToList();

                var existing = result.FirstOrDefault(n => n.FolderPath == folderPath);

                if (existing != null)
                {
                    existing.Files.AddRange(files);
                }
                else
                {
                    result.Add(new StructureNode
                    {
                        FolderPath = folderPath,
                        Files = files
                    });
                }
            }

            return result;
        }
    }
}
