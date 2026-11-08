using Backend;

//var list = new DoublyLinkedList<string>();
//var option = string.Empty;

//do
//{
//    option = Menu();
//    switch (option)
//    {
//        case "1":
//            Console.Write("Enter value: ");
//            list.InsertAtBeginning(Console.ReadLine()!);
//            break;
//        case "2":
//            Console.Write("Enter value: ");
//            list.InsertAtEnd(Console.ReadLine()!);
//            break;
//        case "3":
//            Console.Write("Enter value: ");
//            var itemToSearch = Console.ReadLine()!;
//            Console.WriteLine(list.Contains(itemToSearch) 
//                ? $"The item: '{itemToSearch}' exists!" 
//                : $"The item: '{itemToSearch}' doesn't exists!");
//            break;
//        case "4":
//            Console.Write("Enter value: ");
//            var itemToRemove = Console.ReadLine()!;
//            if (!list.Contains(itemToRemove))
//            {
//                Console.WriteLine($"Item: ´{itemToRemove}´ not exists in the list.");
//                break;
//            }
//            list.Remove(itemToRemove);
//            Console.WriteLine($"Item: ´{itemToRemove}´ removed.");
//            break;
//        case "8":
//            Console.WriteLine(list);
//            break;
//        case "9":
//            Console.WriteLine(list.ToStringReverse());
//            break;
//        default: 
//            Console.WriteLine("Invalid option.");
//            break;
//    }
//} while (option != "0");

//string Menu()
//{
//    Console.WriteLine("1. Insert at beginning.");
//    Console.WriteLine("2. Insert at end.");
//    Console.WriteLine("3. Contains.");
//    Console.WriteLine("4. Remove."); 
//    Console.WriteLine("5. Reverse."); // Homework!
//    Console.WriteLine("6. Insert."); // Homework! ask for item to insert and ask for previous item
//    Console.WriteLine("7. Order."); // Homework! order alphabetically
//    Console.WriteLine("8. Show list.");
//    Console.WriteLine("9. Show reverse list.");
//    Console.WriteLine("0. Exit.");
//    Console.Write("Enter your option? ");
//    return Console.ReadLine()!;
//}

var numbers  = new DoublyLinkedList<int>();

numbers.InsertInOrder(30);
numbers.InsertInOrder(10);
numbers.InsertInOrder(20);
numbers.InsertInOrder(20);
numbers.InsertInOrder(20);

Console.WriteLine("Lista Ascendente:");
Console.WriteLine(numbers);

Console.WriteLine("\nLista hacia atras:");
Console.WriteLine(numbers.ToStringReverse());

Console.WriteLine("\nModas:");
Console.WriteLine(string.Join(", ", numbers.GetModes()));

Console.WriteLine("\nOccurences:");
numbers.DisplayOccurrences();

Console.WriteLine("\n¿Existe el numero 20?");
Console.WriteLine(numbers.Contains(20));

Console.WriteLine("\n¿Existe el numero 50?");
Console.WriteLine(numbers.Contains(50));