using Humanizer;

Console.WriteLine("por favor ingrese su nombre");
var nombre = Console.ReadLine();
Console.WriteLine("por favor ingrese su puesto");
var cargo = Console.ReadLine();
Console.WriteLine("por favor ingrese su edad");
var edad = int.Parse(Console.ReadLine());  //pasar de numero a letra//

Console.WriteLine($"Hola, mi nombre es {nombre}, mi cargo es {cargo} y tengo {edad.ToWords()} años"); //ToWords pasa de numero a letra//
