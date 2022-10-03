using System;
class Triangulo
{
	static void Main()
	{
		int ancho = 0, esp;
		do{
			try{
				Console.WriteLine("Cual sera el ancho del triangulo (impar y mayor de 3)");
				ancho= Convert.ToInt32(Console.ReadLine());
				if ((ancho % 2 == 0) || (ancho <=3)){
					throw new Exception ("Numero invalido");
				}
			}catch (Exception error){
				Console.WriteLine(error.Message);}
			
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
		
