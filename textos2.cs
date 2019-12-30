using pt;

	public class textoss{
		public static void Main(string[] args){
			int numero;
			string txt1;
			string txt2;
			pt.pts.apagar();
			pt.pts.localiza(1,1);
			for(numero=0;numero<16;numero++){
				pt.pts.localiza(1,numero+1);
				txt1=pt.pts.espaco(18-numero);
				txt2=pt.pts.encher("*",(numero+1)*2);
				txt1=txt1+txt2;
				pt.pts.escrever(txt1);
			}
			
		}
	}

