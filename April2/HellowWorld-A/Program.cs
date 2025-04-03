
#region program1
//Random random = new Random();
//string[] names = {
//            "Aarav", "Vivaan", "Aditya", "Vihaan", "Arjun",
//            "Sai", "Reyansh", "Ayaan", "Krishna", "Ishaan"
//        };

//// Randomly select 5 unique names for the students
//string[] studentNames = new string[5];
//for (int i = 0; i < 5; i++)
//{
//    int index;
//    do
//    {
//        index = random.Next(names.Length);
//    } while (Array.Exists(studentNames, name => name == names[index]));
//    studentNames[i] = names[index];
//}

//// Generate random marks for each student
//int student1Math = random.Next(50, 101), student1Science = random.Next(50, 101), student1History = random.Next(50, 101), student1English = random.Next(50, 101);
//int student2Math = random.Next(50, 101), student2Science = random.Next(50, 101), student2History = random.Next(50, 101), student2English = random.Next(50, 101);
//int student3Math = random.Next(50, 101), student3Science = random.Next(50, 101), student3History = random.Next(50, 101), student3English = random.Next(50, 101);
//int student4Math = random.Next(50, 101), student4Science = random.Next(50, 101), student4History = random.Next(50, 101), student4English = random.Next(50, 101);
//int student5Math = random.Next(50, 101), student5Science = random.Next(50, 101), student5History = random.Next(50, 101), student5English = random.Next(50, 101);

//// Calculate totals and averages
//int student1Total = student1Math + student1Science + student1History + student1English;
//double student1Average = student1Total / 4.0;

//int student2Total = student2Math + student2Science + student2History + student2English;
//double student2Average = student2Total / 4.0;

//int student3Total = student3Math + student3Science + student3History + student3English;
//double student3Average = student3Total / 4.0;

//int student4Total = student4Math + student4Science + student4History + student4English;
//double student4Average = student4Total / 4.0;

//int student5Total = student5Math + student5Science + student5History + student5English;
//double student5Average = student5Total / 4.0;

//// Display totals and averages
//Console.WriteLine($"{studentNames[0]} - Total: {student1Total}, Average: {student1Average:F2}");
//Console.WriteLine($"{studentNames[1]} - Total: {student2Total}, Average: {student2Average:F2}");
//Console.WriteLine($"{studentNames[2]} - Total: {student3Total}, Average: {student3Average:F2}");
//Console.WriteLine($"{studentNames[3]} - Total: {student4Total}, Average: {student4Average:F2}");
//Console.WriteLine($"{studentNames[4]} - Total: {student5Total}, Average: {student5Average:F2}");

//// Find the student with the highest total
//int highestTotal = student1Total;
//if (student2Total > highestTotal) highestTotal = student2Total;
//if (student3Total > highestTotal) highestTotal = student3Total;
//if (student4Total > highestTotal) highestTotal = student4Total;
//if (student5Total > highestTotal) highestTotal = student5Total;

//// Find the student with the highest average
//double highestAverage = student1Average;
//if (student2Average > highestAverage) highestAverage = student2Average;
//if (student3Average > highestAverage) highestAverage = student3Average;
//if (student4Average > highestAverage) highestAverage = student4Average;
//if (student5Average > highestAverage) highestAverage = student5Average;

//Console.WriteLine($"Highest Total: {highestTotal}");
//Console.WriteLine($"Highest Average: {highestAverage:F2}");

//// Calculate class total and average
//int classTotal = student1Total + student2Total + student3Total + student4Total + student5Total;
//double classAverage = (student1Average + student2Average + student3Average + student4Average + student5Average) / 5.0;

//Console.WriteLine($"Class Total: {classTotal}");
//Console.WriteLine($"Class Average: {classAverage:F2}");
#endregion

#region Program2
//static double Add(double a, double b)
//{
//    return a + b;
//}
//static double Subtract(double a, double b)
//{
//    return a - b;
//}
//static double Multiply(double a, double b)
//{
//    return a * b;
//}
//static double Divide(double a, double b)
//{
//    return a / b;
//}
//while (true)
//{
//    Console.WriteLine("Select an operation:");
//    Console.WriteLine("1. Add");
//    Console.WriteLine("2. Subtract");
//    Console.WriteLine("3. Multiply");
//    Console.WriteLine("4. Divide");
//    Console.WriteLine("5. Exit");
//    Console.Write("Enter your choice (1-5): ");
//    int choice = int.Parse(Console.ReadLine());

//    if (choice == 5)
//    {
//        Console.WriteLine("Exiting the program.");
//        break;
//    }

//    Console.Write("Enter the first number: ");
//    double num1 = double.Parse(Console.ReadLine());
//    Console.Write("Enter the second number: ");
//    double num2 = double.Parse(Console.ReadLine());

//    switch (choice)
//    {
//        case 1:
//            Console.WriteLine($"Result: {Add(num1, num2)}");
//            break;
//        case 2:
//            Console.WriteLine($"Result: {Subtract(num1, num2)}");
//            break;
//        case 3:
//            Console.WriteLine($"Result: {Multiply(num1, num2)}");
//            break;
//        case 4:
//            Console.WriteLine($"Result: {Divide(num1, num2)}");
//            break;
//        default:
//            Console.WriteLine("Invalid choice. Please select a valid option.");
//            break;
//    }

//    Console.WriteLine();
//}
#endregion

#region Program3

const string CUSTOMER = "customer";
const string OWNER = "owner";

string[] productNames = new string[10];
int[] productPrices = new int[10];
int[] productStock = new int[10];
int productCount = 0;

string[] cartItems = new string[10];
int[] cartQuantities = new int[10];
int cartCount = 0;

productNames[0] = "Apple";
productPrices[0] = 50;
productStock[0] = 100;
productCount++;

productNames[1] = "Banana";
productPrices[1] = 20;
productStock[1] = 150;
productCount++;

productNames[2] = "Orange";
productPrices[2] = 30;
productStock[2] = 120;
productCount++;



while (true)
{
    Console.WriteLine("Select your role:");
    Console.WriteLine("1. Customer");
    Console.WriteLine("2. Owner");
    Console.WriteLine("3. Exit");
    Console.Write("Enter your choice (1-3): ");
    int roleChoice = int.Parse(Console.ReadLine());
    Console.WriteLine();

    if (roleChoice == 3)
    {
        Console.WriteLine("Exiting the program.");
        break;
    }

    if (roleChoice == 1)
    {
        CustomerMenu();
    }
    else if (roleChoice == 2)
    {
        OwnerMenu();
    }
    else
    {
        Console.WriteLine("Invalid choice. Please select a valid option.");
    }

    Console.WriteLine();
}

    void CustomerMenu()
{
    while (true)
    {
        Console.WriteLine("Customer Menu:");
        Console.WriteLine("1. List of items");
        Console.WriteLine("2. Add items to cart");
        Console.WriteLine("3. View cart");
        Console.WriteLine("4. Checkout");
        Console.WriteLine("5. Back to main menu");
        Console.Write("Enter your choice (1-5): ");
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if (choice == 5)

        {
            break;
        }

        switch (choice)
        {
            case 1:
                ListItems();
                break;
            case 2:
                ListItems();
                AddToCart();
                break;
            case 3:
                ViewCart();
                break;
            case 4:
                Checkout();
                break;
            default:
                Console.WriteLine("Invalid choice. Please select a valid option.");
                break;
        }

        Console.WriteLine();
    }
}

void OwnerMenu()
{
    while (true)
    {
        Console.WriteLine("Owner Menu:");
        Console.WriteLine("1. View product catalog");
        Console.WriteLine("2. Add new product");
        Console.WriteLine("3. Update stock");
        Console.WriteLine("4. Update price");
        Console.WriteLine("5. Back to main menu");
        Console.Write("Enter your choice (1-5): ");
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if (choice == 5)
        {
            break;
        }

        switch (choice)
        {
            case 1:
                ListItems();
                break;
            case 2:
                AddNewProduct();
                break;
            case 3:
                ListItems();
                UpdateStock();
                break;
            case 4:
                UpdatePrice();
                break;
            default:
                Console.WriteLine("Invalid choice. Please select a valid option.");
                break;
        }

        Console.WriteLine();
    }
}

void ListItems()
{
    Console.WriteLine("Product Catalog:");
    for (int i = 0; i < productCount; i++)
    {
        Console.WriteLine($"{i + 1}. {productNames[i]} - Price: {productPrices[i]}, Stock: {productStock[i]}");
    }
}

void AddToCart()
{
    Console.Write("Enter the product number to add to cart: ");
    int productNumber = int.Parse(Console.ReadLine()) - 1;
    if (productNumber >= 0 && productNumber < productCount)
    {
        Console.Write("Enter the quantity: ");
        int quantity = int.Parse(Console.ReadLine());
        if (quantity <= productStock[productNumber])
        {
            cartItems[cartCount] = productNames[productNumber];
            cartQuantities[cartCount] = quantity;
            cartCount++;
            Console.WriteLine($"Added {quantity} of {productNames[productNumber]} to cart.");
        }
        else
        {
            Console.WriteLine("Insufficient stock.");
        }
    }
    else
    {
        Console.WriteLine("Invalid product number.");
    }
}

void ViewCart()
{
    Console.WriteLine("Cart Items:");
    for (int i = 0; i < cartCount; i++)
    {
        Console.WriteLine($"{i + 1}. {cartItems[i]} - Quantity: {cartQuantities[i]}");
    }
}

void Checkout()
{
    int totalPrice = 0;
    for (int i = 0; i < cartCount; i++)
    {
        int productIndex = Array.IndexOf(productNames, cartItems[i]);
        totalPrice += cartQuantities[i] * productPrices[productIndex];
        productStock[productIndex] -= cartQuantities[i];
    }
    Console.WriteLine($"Total price: {totalPrice}");
    cartCount = 0; // Clear the cart after checkout
}

void AddNewProduct()
{
    if (productCount < 10)
    {
        Console.Write("Enter product name: ");
        productNames[productCount] = Console.ReadLine();
        Console.Write("Enter product price: ");
        productPrices[productCount] = int.Parse(Console.ReadLine());
        Console.Write("Enter product stock: ");
        productStock[productCount] = int.Parse(Console.ReadLine());
        productCount++;
        Console.WriteLine("Product added successfully.");
    }
    else
    {
        Console.WriteLine("Product catalog is full.");
    }
}

void UpdateStock()
{
    Console.Write("Enter the product number to update stock: ");
    int productNumber = int.Parse(Console.ReadLine()) - 1;
    if (productNumber >= 0 && productNumber < productCount)
    {
        Console.Write("Enter the new stock quantity: ");
        productStock[productNumber] += int.Parse(Console.ReadLine());
        Console.WriteLine("Stock updated successfully.");
    }
    else
    {
        Console.WriteLine("Invalid product number.");
    }
}

void UpdatePrice()
{
    Console.Write("Enter the product number to update price: ");
    int productNumber = int.Parse(Console.ReadLine()) - 1;
    if (productNumber >= 0 && productNumber < productCount)
    {
        Console.Write("Enter the new price: ");
        productPrices[productNumber] = int.Parse(Console.ReadLine());
        Console.WriteLine("Price updated successfully.");
    }
    else
    {
        Console.WriteLine("Invalid product number.");
    }
}

#endregion