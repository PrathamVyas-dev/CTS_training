using System.Collections.Generic;
// See https://aka.ms/new-console-template for more information

string fileName = "ListOfNames.txt";
List<string> names = new List<string>();
// Load existing names from the file if it exists
if (File.Exists(fileName))
{
    names.AddRange(File.ReadAllLines(fileName));
}

while (true)
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Add a name");
    Console.WriteLine("2. Show list of names");
    Console.WriteLine("3. Exit");
    Console.Write("Enter your choice: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.Write("Enter a name to add: ");
            string name = Console.ReadLine();
            names.Add(name);
            File.AppendAllText(fileName, name + Environment.NewLine);
            break;
        case "2":
            Console.WriteLine("List of names:");
            foreach (var n in names)
            {
                Console.WriteLine(n);
            }
            break;
        case "3":
            return;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}
int CalculateNames(List<string> ListOfNames)
{
    int count = 0;
    for (int i=0; i < 100; i++)
    {
        try
        {
            if (ListOfNames.ElementAt(i) != null)
            {
                count++;
            }
        }
        catch (System.Exception)
        { 
            break;
        }
    }
    return count;
}

int CalculateNumbers(List<int> ListOfNames)
{
    int count = 0;
    for (int i = 0; i < 100; i++)
    {
        try
        {
            if (ListOfNames.ElementAt(i) != null)
            {
                count++;
            }
        }
        catch (System.Exception)
        {
            break;
        }
    }
    return count;
}