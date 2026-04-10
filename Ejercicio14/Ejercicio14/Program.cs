//Solicitar n números, guardarlos en un arreglo y ordenarlos de menor a mayor usando ciclos simples
int ingreso;
Console.WriteLine("cuantas números desea ingresar?: ");
ingreso = int.Parse(Console.ReadLine());
int[] numero = new int[ingreso];

for (int i = 0; i < numero.Length; i++)
{
    Console.WriteLine("ingrese numero: ");
    numero[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < numero.Length; i++)
{
    for (int j = i + 1; j < numero.Length; j++)
    {
        if (numero[i] > numero[j])
        {
            int auxiliar = numero[i];
            numero[i] = numero[j];
            numero[j] = auxiliar;
        }
    }
}

Console.WriteLine("arreglo ordenado:");
for (int i = 0; i < numero.Length; i++)
{
    Console.WriteLine(numero[i]);
}
