//Llenar un arreglo con n números y contar cuántos son pares
int ingreso;
Console.WriteLine("cuantas números desea ingresar?: ");
ingreso = int.Parse(Console.ReadLine());
int[] numero = new int[ingreso];
int pares = 0;

for (int i = 0; i < numero.Length; i++)
{
    Console.WriteLine("ingrese numero: ");
    numero[i] = int.Parse(Console.ReadLine());

    if (numero[i] % 2 == 0)
    {
        pares++;
    }
}

Console.WriteLine($"cantidad de pares: {pares}");
