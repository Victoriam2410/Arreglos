//Solicitar n números enteros, guardarlos en un arreglo y calcular la suma total
int ingreso;
int suma = 0;
Console.WriteLine("cuantas números desea ingresar?: ");
ingreso = int.Parse(Console.ReadLine());
int[] numero = new int[ingreso];
for (int i = 0; i < numero.Length; i++)
{
    Console.WriteLine("ingrese numero: ");
    numero[i] = int.Parse(Console.ReadLine());
    suma += numero[i];
}
Console.WriteLine($"la suma es: {suma}");
