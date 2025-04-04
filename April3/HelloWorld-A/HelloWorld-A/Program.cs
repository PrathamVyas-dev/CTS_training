public class Crocodile
{
    public string Name { get; set; }  // String
    public double Length { get; set; }  // Double
    public double Weight { get; set; }  // Double
    public int Age { get; set; }  // Integer
    public bool IsExtinct { get; set; }  // Boolean

    public Crocodile(string name, double length, double weight, int age, bool isExtinct)
    {
        Name = name;
        Length = length;
        Weight = weight;
        Age = age;
        IsExtinct = isExtinct;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Crocodile Name: {Name}");
        Console.WriteLine($"Length: {Length} meters");
        Console.WriteLine($"Weight: {Weight} kg");
        Console.WriteLine($"Age: {Age} years");
        Console.WriteLine($"Extinct: {(IsExtinct ? "Yes" : "No")}");
    }
}

public class Zoo
{
    public List<Crocodile> CollectCrocodileDetails(List<Crocodile> crocodiles)
    {
        Console.Write("Enter the number of crocodiles: ");
        int numberOfCrocodiles = GetValidIntInput();

        for (int i = 0; i < numberOfCrocodiles; i++)
        {
            Console.WriteLine($"\nEnter details for crocodile {i + 1}:");
            Crocodile croc = CreateCrocodile();
            crocodiles.Add(croc);
        }

        return crocodiles;
    }

    public void DisplayAllCrocodiles(List<Crocodile> crocodiles)
    {
        Console.WriteLine("\nCrocodile Details:");
        foreach (var croc in crocodiles)
        {
            croc.DisplayInfo();
            Console.WriteLine();
        }
    }

    private Crocodile CreateCrocodile()
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Length (in meters): ");
        double length = GetValidDoubleInput();

        Console.Write("Weight (in kg): ");
        double weight = GetValidDoubleInput();

        Console.Write("Age (in years): ");
        int age = GetValidIntInput();

        bool isExtinct = GetIsExtinct();

        return new Crocodile(name, length, weight, age, isExtinct);
    }

    private int GetValidIntInput(string prompt = "")
    {
        while (true)
        {
            if (!string.IsNullOrEmpty(prompt))
            {
                Console.Write(prompt);
            }
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }

    private double GetValidDoubleInput()
    {
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out double result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid double.");
            }
        }
    }

    private bool GetIsExtinct()
    {
        while (true)
        {
            Console.Write("Is Extinct (1 for Yes, 0 for No): ");
            string input = Console.ReadLine();
            if (input == "1")
            {
                return true;
            }
            else if (input == "0")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 1 for Yes or 0 for No.");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Zoo zoo = new Zoo();
        List<Crocodile> crocodiles = new List<Crocodile>();

        crocodiles = zoo.CollectCrocodileDetails(crocodiles);
        zoo.DisplayAllCrocodiles(crocodiles);
    }
}