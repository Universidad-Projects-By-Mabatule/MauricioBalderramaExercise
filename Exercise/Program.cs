// See https://aka.ms/new-console-template for more information

using System.Linq;
String reverseMethod(string cad)
{
	String result ="";
	for (int i = cad.Length-1;  i>=0; i--)
	{
		result += cad[i];

    }
	return result;
}
List<string> Invert(List<string> palabras)
{

	for (int i = 0; i < palabras.Count(); i++)
	{
		palabras[i] = palabras[i].Length>=5 ? reverseMethod(palabras[i]) : palabras[i];
	}
	return palabras;
}
void printList(List<string> lis)
{
	foreach (string str in lis)
	{
		Console.Write(str+ " ");
	}
	Console.WriteLine();
}
int multNums(int num)
{
	int result=1, aux=1;
	while (num > 0)
	{
		result *= num % 10;
		num /= 10;
	}
	return result;
}
int numberPersistente(int num)
{
	int newnum=20,count=0;
	while (newnum >= 10)
	{
		newnum = multNums(num);
		num = newnum;
		count++;
    }
	return count;
}

/*
Console.WriteLine("Ingrese una oracion");
string oracion = Console.ReadLine();
List<string> list = oracion.Split(" ").ToList();
var newlist=Invert(list);
printList(newlist);
*/
Console.WriteLine("Ingrese su numero");
var num = Int32.Parse(Console.ReadLine());
Console.WriteLine("Su numero persistente es: ");
Console.WriteLine(numberPersistente(num));