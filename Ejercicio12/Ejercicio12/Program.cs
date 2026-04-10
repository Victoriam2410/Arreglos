//Solicitar n números y mostrar únicamente los valores positivos
int ingreso;
Console.WriteLine("cuantas números desea ingresar?: ");
ingreso = int.Parse(Console.ReadLine());
int[] numero = new int[ingreso];

for (int i = 0; i < numero.Length; i++)
{
    Console.WriteLine("ingrese numero: ");
    numero[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("valores positivos:");
for (int i = 0; i < numero.Length; i++)
{
    if (numero[i] > 0)
    {
        Console.WriteLine(numero[i]);
    }
}
