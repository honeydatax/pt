using System;


namespace pt{
	public class pts{
		
		public static double Pi = 3.1415927;
		public static void escrever(String s){
				Console.WriteLine(s);
		}
		public static string entrada(){
			return Console.ReadLine();
		}
		public static double entradan(){
			return double.Parse(Console.ReadLine());
		}
		public static string texton(double numero){
			return numero.ToString();
		}
		public static void apagar(){
			string s="";
			int i =0;
			for(i=0;i<80;i++){
				s=s+" ";
			}
			for(i=0;i<25;i++){
				Console.WriteLine(s);
			}

			
		}

		
	}
	
}







