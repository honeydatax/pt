using pt;

	public class entrada{
		public static void Main(string[] args){
			string meutexto;
			pt.pts.escrever("escreva seu nome?");
			meutexto=pt.pts.entrada();
			pt.pts.escrever("o texto que digitou foi!");
			pt.pts.escrever(meutexto);
		}
	}

