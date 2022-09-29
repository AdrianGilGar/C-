using System;
class Triangulo
{
	static void Main()
	{
		int ancho;
		do{
			Console.WriteLine("Cual sera el ancho del triangulo (impar)");
			ancho= Convert.ToInt32(Console.ReadLine());
			if (ancho % 2 == 0){
				Console.WriteLine("Tiene que ser impar");
			}
			if (ancho <= 3){
				Console.WriteLine("Venga, uno mas grande");
			}
		}while ((ancho % 2 == 0) || (ancho <= 3));
		Console.WriteLine("Tr");
	}
}
		
