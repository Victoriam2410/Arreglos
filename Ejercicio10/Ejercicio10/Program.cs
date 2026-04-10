//Llenar un arreglo con n números y contar cuántas veces se repite un valor indicado
int ingreso;
Console.WriteLine("cuantas números desea ingresar?: ");
ingreso = int.Parse(Console.ReadLine());
int[] numero = new int[ingreso];

for (int i = 0; i < numero.Length; i++)
{
    Console.WriteLine("ingrese numero: ");
    numero[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("ingrese el valor para contar repeticiones: ");
int buscar = int.Parse(Console.ReadLine());
int repetido = 0;

for (int i = 0; i < numero.Length; i++)
{
    if (numero[i] == buscar)
    {
        repetido++;
    }
}

Console.WriteLine($"el numero se repite: {repetido} veces");
