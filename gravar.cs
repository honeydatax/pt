using pt;

	public class gravars{
		public static void Main(string[] args){
			string texto;
			texto="ola mundo \ntudo bem\n.!";
			pt.pts.apagar();
			pt.pts.gravar("meu.txt",texto);
			pt.pts.localiza(1,1);
			pt.pts.escrever("texto gravado em meu.txt\n");
		}
	}

