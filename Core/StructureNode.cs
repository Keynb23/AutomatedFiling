namespace AutoFiles.Core
{
    public class StructureNode
    {
        public string FolderPath { get; set; } = "";
        public List<string> Files { get; set; } = new();
    }
}
