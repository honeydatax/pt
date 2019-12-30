using pt;

	public class textoss{
		public static void Main(string[] args){
			int numero;
			string txt1;
			string txt2;
			pt.pts.apagar();
			pt.pts.localiza(1,1);
			for(numero=0;numero<16;numero++){
				pt.pts.localiza(0,numero+1);
				txt2=pt.pts.encher("*",(numero+1)*2);
				txt1=pt.pts.centrar(txt2,79);
				pt.pts.escrever(txt1);
			}
			
		}
	}

