using Backend;

var list = new DoublyLinkedList<string>();
var option = string.Empty;

do
{
    option = Menu();

    switch (option)
    {
        case "1":
            Console.Write("Ingrese el dato que quiere adicionar: ");
            var itemToAdd = Console.ReadLine()!;
            list.InsertInOrder(itemToAdd);
            Console.WriteLine("Elemento agregado correctamente.");
            break;

        case "2":
            Console.Write("Lista hacia adelante: ");
            Console.WriteLine(list);
            break;

        case "3":
            Console.Write("Lista hacia atrás: ");
            Console.WriteLine(list.ToStringReverse());
            break;

        case "4":
            list.SortDescending();
            Console.Write("Lista ordenada descendentemente: ");
            Console.WriteLine(list);
            break;

        case "5":
            var modes = list.GetModes();

            Console.WriteLine("Moda(s): ");

            if (modes.Count == 0)
            {
                Console.WriteLine("La lista está vacía.");
            }
            else
            {
                Console.WriteLine(string.Join(", ", modes));
            }
            break;

        case "6":
            Console.WriteLine("Gráfico de ocurrencias: ");
            list.DisplayOccurrences();
            break;

        case "7":
            Console.Write("Ingrese el dato que desea buscar: ");
            var itemToSearch = Console.ReadLine()!;

            Console.WriteLine(list.Contains(itemToSearch)
                ? $"El elemento '{itemToSearch}' existe en la lista."
                : $"El elemento '{itemToSearch}' no existe en la lista.");
            break;

        case "8":
            Console.Write("Ingrese el dato que desea eliminar: ");
            var itemToRemove = Console.ReadLine()!;

            if (!list.Contains(itemToRemove))
            {
                Console.WriteLine($"El elemento '{itemToRemove}' no existe en la lista.");
                break;
            }

            list.Remove(itemToRemove);
            Console.WriteLine($"Se eliminó una ocurrencia de '{itemToRemove}'.");
            break;

        case "9":
            Console.Write("Ingrese el valor que desea eliminar: ");
            var itemToRemoveAll = Console.ReadLine()!;

            if (!list.Contains(itemToRemoveAll))
            {
                Console.WriteLine($"El elemento '{itemToRemoveAll}' no existe en la lista.");
                break;
            }

            list.RemoveAll(itemToRemoveAll);
            Console.WriteLine($"Se eliminaron todas las ocurrencias de '{itemToRemoveAll}'.");
            break;

        case "0":
            Console.WriteLine("Saliendo del programa... ");
            break;

        default:
            Console.WriteLine("Opción no válida.");
            break;
    }

    if (option != "0")
    {
        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

} while (option != "0");


string Menu()
{
    Console.Clear();

    Console.WriteLine("===========================================");
    Console.WriteLine("          LISTA DOBLEMENTE LIGADA          ");
    Console.WriteLine("===========================================");
    Console.WriteLine("1. Adicionar.");
    Console.WriteLine("2. Mostrar hacia adelante.");
    Console.WriteLine("3. Mostrar hacia atrás.");
    Console.WriteLine("4. Ordenar descendentemente.");
    Console.WriteLine("5. Mostrar las(s) mosda(s).");
    Console.WriteLine("6. Mostrar gráfico.");
    Console.WriteLine("7. Existe.");
    Console.WriteLine("8. Eliminar una ocurrencia.");
    Console.WriteLine("9. Eliminar todas las ocurrencias.");
    Console.WriteLine("0. Salir.");
    Console.WriteLine("===========================================");
    Console.Write("Seleccione una opción: ");

    return Console.ReadLine()!;
}
