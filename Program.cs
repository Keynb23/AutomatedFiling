using AutoFiles.Core;

Console.WriteLine("=== AutoFiles – Project Scaffolder ===");
Console.WriteLine();

Console.Write("Do you already have a root folder? (Y/N): ");
string? answer = Console.ReadLine()?.Trim().ToUpper();

string rootPath;

if (answer == "Y")
{
    rootPath = RootResolver.GetExistingRoot();
}
else
{
    rootPath = RootResolver.CreateNewRoot();
}

Console.WriteLine();
Console.WriteLine("Enter your file structure (one line at a time).");
Console.WriteLine("Examples:");
Console.WriteLine("/game/game_state.py, tick_engine.py");
Console.WriteLine("/ai/model.py");
Console.WriteLine("/main.py");
Console.WriteLine("Press ENTER on an empty line to finish.");
Console.WriteLine();

List<string> inputLines = new();

while (true)
{
    string? line = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(line))
        break;

    inputLines.Add(line);
}

var nodes = InputParser.Parse(inputLines);
FileCreator.Create(rootPath, nodes);

Console.WriteLine();
Console.WriteLine("✅ File structure created successfully.");
Console.WriteLine("Press any key to exit.");
Console.ReadKey();
