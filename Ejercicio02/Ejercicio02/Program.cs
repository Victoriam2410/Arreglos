//Solicitar n números, guardarlos en un arreglo y mostrarlos en orden inverso
int ingreso;
Console.WriteLine("cuantas números desea ingresar?: ");
ingreso = int.Parse(Console.ReadLine());
int[] numero = new int[ingreso];
for (int i = 0; i < numero.Length; i++)
{
    Console.WriteLine("ingrese numero: ");
    numero[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Los numeros ingresados son:");
for (int i = numero.Length - 1; i >= 0; i--)
{
    Console.WriteLine(numero[i]);
}