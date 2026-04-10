//Solicitar n números, guardarlos en un arreglo y buscar un valor indicado por el usuario
int ingreso;
Console.WriteLine("cuantas números desea ingresar?: ");
ingreso = int.Parse(Console.ReadLine());
int[] numero = new int[ingreso];

for (int i = 0; i < numero.Length; i++)
{
    Console.WriteLine("ingrese numero: ");
    numero[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("ingrese el valor que desea buscar: ");
int buscar = int.Parse(Console.ReadLine());
int coincidencias = 0;

for (int i = 0; i < numero.Length; i++)
{
    if (numero[i] == buscar)
    {
        Console.WriteLine($"valor encontrado en la posicion: {i}");
        coincidencias++;
    }
}

if (coincidencias == 0)
{
    Console.WriteLine("el valor no se encuentra en el arreglo");
}
