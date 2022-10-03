using System;
class Triangulo
{
	static void Main()
	{
		int ancho, esp;
		do{
			Console.WriteLine("Cual sera el ancho del triangulo (impar)");
			ancho= Convert.ToInt32(Console.ReadLine());
			if (ancho % 2 == 0){
				Console.WriteLine("Tiene que ser impar");
			}
			if ((ancho <= 3) && (ancho % 2 != 0)){
				Console.WriteLine("Venga, uno mas grande");
			}
		}while ((ancho % 2 == 0) || (ancho <= 3));
		for (int i = ancho; i >= 1; i-=2){
			for (esp = (ancho - i) / 2; esp > 0; esp--){
				Console.Write(" ");
			}
			for (int ast = i; ast > 0; ast--){
				Console.Write("*");
			}
			Console.WriteLine();
		}
		
		Console.WriteLine("De regalo una piramide no invertida");
		for (int i = 1; i <= ancho; i+=2){
			for (esp = (ancho - i) / 2; esp > 0; esp--){
				Console.Write(" ");
			}
			for (int ast = i; ast > 0; ast--){
				Console.Write("*");
			}
			Console.WriteLine();
		}	
	}
}
		
