//Llenar un arreglo con n números, solicitar una posición y reemplazar su valor
int ingreso;
Console.WriteLine("cuantas números desea ingresar?: ");
ingreso = int.Parse(Console.ReadLine());
int[] numero = new int[ingreso];

for (int i = 0; i < numero.Length; i++)
{
    Console.WriteLine("ingrese numero: ");
    numero[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("ingrese la posicion que desea modificar: ");
int posicion = int.Parse(Console.ReadLine());

Console.WriteLine("ingrese el nuevo valor: ");
int nuevoValor = int.Parse(Console.ReadLine());

numero[posicion] = nuevoValor;

Console.WriteLine("arreglo actualizado:");
for (int i = 0; i < numero.Length; i++)
{
    Console.WriteLine($"posicion {i}: {numero[i]}");
}
