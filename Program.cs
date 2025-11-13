// Work with files and directories in a .NET app



// using Humanizer;
// int result = Fibonacci(5);
// Console.WriteLine(result);

// static int Fibonacci(int n)
// {
//     int n1 = 0;
//     int n2 = 1;
//     int sum;

//     for (int i = 2; i <= n; i++)
//     {
//         sum = n1 + n2;
//         n1 = n2;
//         n2 = sum;
//     }

//     return n == 0 ? n1 : n2;
// }
//----------------------------------------------------------------------------------------------------
// var salesFiles = FindFiles("stores");

// foreach (var file in salesFiles)
// {
//     Console.WriteLine(file);
// }

// IEnumerable<string> FindFiles(string folderName)
// {
//     List<string> salesFiles = new List<string>();

//     var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

//     foreach (var file in foundFiles)
//     {
//         // The file name will contain the full path, so only check the end of it
//         if (file.EndsWith("sales.json"))
//         {
//             salesFiles.Add(file);
//         }
//     }

//     return salesFiles;
// }
//-------------------------------------------------------------------------------------------------
// var currentDirectory = Directory.GetCurrentDirectory();
// var storesDirectory = Path.Combine(currentDirectory, "stores");

// var salesFiles = FindFiles(storesDirectory);

// foreach (var file in salesFiles)
// {
//     Console.WriteLine(file);
// }

// IEnumerable<string> FindFiles(string folderName)
// {
//     List<string> salesFiles = new List<string>();

//     var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

//     foreach (var file in foundFiles)
//     {
//         var extension = Path.GetExtension(file);
//         if (extension == ".json")
//         {
//             salesFiles.Add(file);
//         }
//     }

//     return salesFiles;
// }
//--------------------------------------------------------------------------------------------------
// Create directories

// Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "stores","201","newDir"));

// Make sure directories exist

// bool doesDirectoryExist = Directory.Exists(filePath);

// Create files

// File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "greeting.txt"), "Hello World!");
//---------------------------------------------------------------------------------------------------
// Create the SalesTotals directory

// var currentDirectory = Directory.GetCurrentDirectory();
// var storesDirectory = Path.Combine(currentDirectory, "stores");

// var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir");
// Directory.CreateDirectory(salesTotalDir);     
// var salesFiles = FindFiles(storesDirectory);

// File.WriteAllText(Path.Combine(salesTotalDir, "totals.txt"), String.Empty);

// IEnumerable<string> FindFiles(string folderName)
// {
//     List<string> salesFiles = new List<string>();

//     var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

//     foreach (var file in foundFiles)
//     {
//         var extension = Path.GetExtension(file);
//         if (extension == ".json")
//         {
//             salesFiles.Add(file);
//         }
//     }

//     return salesFiles;
// }
//--------------------------------------------------------------------------------------------------
// Read and write to files


// using Newtonsoft.Json; 

// var currentDirectory = Directory.GetCurrentDirectory();
// var storesDirectory = Path.Combine(currentDirectory, "stores");

// var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir");
// Directory.CreateDirectory(salesTotalDir);   

// var salesFiles = FindFiles(storesDirectory);

// var salesTotal = CalculateSalesTotal(salesFiles);

// File.AppendAllText(Path.Combine(salesTotalDir, "totals.txt"), $"{salesTotal}{Environment.NewLine}");

// IEnumerable<string> FindFiles(string folderName)
// {
//     List<string> salesFiles = new List<string>();

//     var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

//     foreach (var file in foundFiles)
//     {
//         var extension = Path.GetExtension(file);
//         if (extension == ".json")
//         {
//             salesFiles.Add(file);
//         }
//     }

//     return salesFiles;
// }

// double CalculateSalesTotal(IEnumerable<string> salesFiles)
// {
//     double salesTotal = 0;
    
//     // Loop over each file path in salesFiles
//     foreach (var file in salesFiles)
//     {      
//         // Read the contents of the file
//         string salesJson = File.ReadAllText(file);
    
//         // Parse the contents as JSON
//         SalesData? data = JsonConvert.DeserializeObject<SalesData?>(salesJson);
    
//         // Add the amount found in the Total field to the salesTotal variable
//         salesTotal += data?.Total ?? 0;
//     }
    
//     return salesTotal;
// }

// record SalesData (double Total);
//-----------------------------------------------------------------------------------------------
// Create a web API with ASP.NET Core controllers

