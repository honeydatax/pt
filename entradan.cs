using pt;

	public class entrada{
		public static void Main(string[] args){
			double numero;
			pt.pts.escrever("escreva a sua idade?");
			numero=pt.pts.entradan();
			pt.pts.escrever("");
			pt.pts.escrever("a sua idade é!");
			pt.pts.escrever(pt.pts.texton(numero));
		}
	}

