//Solicitar n números en un arreglo y determinar el valor mayor
int ingreso;
Console.WriteLine("cuantas números desea ingresar?: ");
ingreso = int.Parse(Console.ReadLine());
int[] numero = new int[ingreso];
int mayor = numero[0];
for (int i = 0; i < numero.Length; i++)
{
    Console.WriteLine("ingrese numero: ");
    numero[i] = int.Parse(Console.ReadLine());
    if (numero[i] > mayor)
    {
        mayor = numero[i];
    }
}
Console.WriteLine($"Mayor: {mayor}");