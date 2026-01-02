AutoFiles – Project Scaffolder
AutoFiles is a lightweight, C#-based command-line tool designed to rapidly scaffold project structures. It allows users to define folders and multiple files via simple text input, making it an ideal utility for starting new programming projects or organizing directories without manual "Right-click > New File" repetition.

🚀 Features
Generic Namespace: Built under AutoFiles.Core, making the logic portable and reusable across different C# projects.

Flexible Root Selection: Choose an existing folder or create a new root directory on the fly.

Batch Creation: Define multiple files across different subdirectories in a single session.

Standalone Portability: Can be compiled into a single .exe that runs without a .NET installation (Self-contained).

📂 Project Structure
The project is organized into a main entry point and a Core library containing the logic:

Plaintext

AutoFiles
│
├── Program.cs          # Entry point (CLI Interface)
└── Core/               # Business Logic
    ├── StructureNode.cs # Data model for folders/files
    ├── RootResolver.cs  # Handles directory path logic
    ├── InputParser.cs   # Converts text input into nodes
    └── FileCreator.cs   # Physical disk I/O operations
🛠 Usage
Launch the App: Run AutoFiles.exe.

Set Root: * Enter Y to provide a full path to an existing folder.

Enter N to create a new folder (you will be asked for the base path and folder name).

Define Structure: Enter your paths and files using the format: /folder/file1.ext, file2.ext.

Example: /models/User.cs, Product.cs

Example: /tests/UserTests.cs

Example: README.md (places file in root)

Execute: Press ENTER on an empty line to generate the files.

📦 How to Export & Reuse
Option 1: Standalone Executable (Recommended)
To create a single file you can use anywhere:

Right-click the project in Visual Studio 2026 and select Publish.

Target: Folder.

In Deployment Mode, select Self-contained.

In File Publish Options, check Produce single file.

Click Publish to generate your AutoFiles.exe.

Option 2: Class Library
If you want to use this logic in another C# application:

Reference the AutoFiles.Core namespace.

Use the InputParser and FileCreator classes programmatically.

📝 Example Syntax
When the program is running, you can input lines like this:

Bash

/src/app.py, utils.py
/docs/setup.md
/tests/test_app.py
This will automatically create the src, docs, and tests folders and place the respective files inside them.
