//Solicitar n números en un arreglo y determinar el valor menor
int ingreso;
Console.WriteLine("cuantas números desea ingresar?: ");
ingreso = int.Parse(Console.ReadLine());
int[] numero = new int[ingreso];
int menor = numero[0];
for (int i = 0; i < numero.Length; i++)
{
    Console.WriteLine("ingrese numero: ");
    numero[i] = int.Parse(Console.ReadLine());
    if (i == 0 || numero[i] < menor)
    {
        menor = numero[i];
    }
}
Console.WriteLine($"menor: {menor}");