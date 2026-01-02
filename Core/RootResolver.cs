namespace AutoFiles.Core
{
    public static class RootResolver
    {
        public static string GetExistingRoot()
        {
            while (true)
            {
                Console.Write("Enter full path to existing root folder: ");
                string? path = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(path) && Directory.Exists(path))
                    return path;

                Console.WriteLine("❌ Folder does not exist. Try again.");
            }
        }

        public static string CreateNewRoot()
        {
            Console.Write("Enter the directory where the root folder should be created: ");
            string? basePath = Console.ReadLine();

            Console.Write("Enter name for the root folder: ");
            string? folderName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(basePath) || string.IsNullOrWhiteSpace(folderName))
                throw new Exception("Invalid path or folder name.");

            string fullPath = Path.Combine(basePath, folderName);
            Directory.CreateDirectory(fullPath);

            return fullPath;
        }
    }
}
