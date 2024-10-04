
// Mostrar al usuario el menu de lo que puede hacer
using KingFungi;

string input = string.Empty;
ControladorGastos controladorGastos = new ControladorGastos();

while (input != string.Empty && input != "fin")
{
    input = Console.ReadLine();

    Console.WriteLine("Menu:");
    Console.WriteLine("(1) Agregar Socio");
    if (input == "1")
    {
        Console.Clear();
        controladorGastos.AgregarGasto();
    }
}