//Llenar un arreglo con n números y separar los números pares e impares mostrando ambos grupos
int ingreso;
Console.WriteLine("cuantas números desea ingresar?: ");
ingreso = int.Parse(Console.ReadLine());
int[] numero = new int[ingreso];

for (int i = 0; i < numero.Length; i++)
{
    Console.WriteLine("ingrese numero: ");
    numero[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("números pares:");
for (int i = 0; i < numero.Length; i++)
{
    if (numero[i] % 2 == 0)
    {
        Console.WriteLine(numero[i]);
    }
}

Console.WriteLine("números impares:");
for (int i = 0; i < numero.Length; i++)
{
    if (numero[i] % 2 != 0)
    {
        Console.WriteLine(numero[i]);
    }
}
