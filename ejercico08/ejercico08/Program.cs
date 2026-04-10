//Llenar un arreglo con n números y contar cuántos son impares
int ingreso;
Console.WriteLine("cuantas números desea ingresar?: ");
ingreso = int.Parse(Console.ReadLine());
int[] numero = new int[ingreso];
int impares = 0;

for (int i = 0; i < numero.Length; i++)
{
    Console.WriteLine("ingrese numero: ");
    numero[i] = int.Parse(Console.ReadLine());

    if (numero[i] % 2 != 0)
    {
        impares++;
    }
}

Console.WriteLine($"cantidad de impares: {impares}");

