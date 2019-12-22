using System;
using System.IO;

namespace pt{
	public class pts{
		public static int cor_papel = 0;
		public static int cor_tinta = 7;
		public static int preto = 0;
		public static int vermelho = 1;
		public static int verde = 2;
		public static int laranja = 3;
		public static int azul = 4;
		public static int rosa = 5;
		public static int cyan = 6;
		public static int cinza = 7;
		public static int branco = 7;
		
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
			for(i=0;i<60;i++){
				Console.WriteLine(s);
			}

			
		}
		public static void localiza(int x,int y){
			string s;
			string sx;
			string sy;
			sx=x.ToString() + ";" ;
			sy=y.ToString() + "f" ;
			s="\x1b[" + sx + sy ;
			Console.Write(s);
		}
		public static void papel(int valor){
			string s;
			string sx;
			string sy;
			cor_papel=valor;
			sx=(cor_tinta+30).ToString() + ";" ;
			sy=(cor_papel+40).ToString() + "m" ;
			s="\x1b[" + sx + sy ;
			Console.Write(s);

		}
		public static void tinta(int valor){
			string s;
			string sx;
			string sy;
			cor_tinta=valor;
			sx=(cor_tinta+30).ToString() + ";" ;
			sy=(cor_papel+40).ToString() + "m" ;
			s="\x1b[" + sx + sy ;
			Console.Write(s);

		}
		public static string ler(string files){
			String line2="";
			String[] lines=File.ReadAllLines(files);
			foreach(string line1 in lines){
				line2=line2+"\n"+line1;
			}
			return line2.ToString();
		}

	}
	
}







