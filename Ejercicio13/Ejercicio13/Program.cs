//Crear un arreglo de tamaño n, llenarlo y copiar sus valores a otro arreglo
int ingreso;
Console.WriteLine("cuantas números desea ingresar?: ");
ingreso = int.Parse(Console.ReadLine());

int[] numero = new int[ingreso];
int[] copia = new int[ingreso];

for (int i = 0; i < numero.Length; i++)
{
    Console.WriteLine("ingrese numero: ");
    numero[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < numero.Length; i++)
{
    copia[i] = numero[i];
}

Console.WriteLine("valores en el arreglo copia:");
for (int i = 0; i < copia.Length; i++)
{
    Console.WriteLine(copia[i]);
}
