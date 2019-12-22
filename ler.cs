using pt;

	public class ler{
		public static void Main(string[] args){
			string texto;
			pt.pts.apagar();
			texto=pt.pts.ler("meu.txt");
			pt.pts.localiza(1,1);
			pt.pts.escrever(texto);
		}
	}

