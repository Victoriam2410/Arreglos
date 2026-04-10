//Solicitar n números, guardarlos en un arreglo y calcular el promedio
int ingreso;
int suma = 0;
Console.WriteLine("cuantas números desea ingresar?: ");
ingreso = int.Parse(Console.ReadLine());
int[] numero = new int[ingreso];
for (int i = 0; i < numero.Length; i++)
{
    Console.WriteLine("ingrese edad: ");
    numero[i] = int.Parse(Console.ReadLine());
    suma += numero[i];
}
Console.WriteLine($"el promedio de los numeros es: {suma / ingreso}");

