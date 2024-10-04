
// Mostrar al usuario el menu de lo que puede hacer
using KingFungi;

string input = string.Empty;
ControladorGastos controladorGastos = new ControladorGastos();

while (input != "fin")
{

    Console.WriteLine("Menu:");
    Console.WriteLine("(1) Agregar Gasto");
    Console.WriteLine("(2) Listar Gastos");
    Console.WriteLine("(3) Eliminar Gasto");
    Console.WriteLine("Ingrese una opcion:");

    input = Console.ReadLine();

    if (input == "1")
    {
        Console.Clear();
        controladorGastos.AgregarGasto();
    } else if (input == "2")
    {
        Console.Clear();
        controladorGastos.MostrarGastos();
    } else if (input == "3")
    {
        Console.Clear();
        controladorGastos.EliminarGasto();
    }
    else if (input == "fin")
    {
        Console.WriteLine("Adios!");
    }
    else
    {
        Console.WriteLine("Opcion no valida");
    }
}