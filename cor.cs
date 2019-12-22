using pt;

	public class ola{
		public static void Main(string[] args){
			int numero;
			pt.pts.apagar();
			pt.pts.papel(pt.pts.branco);
			pt.pts.tinta(pt.pts.preto);
			for(numero=0;numero<17;numero++){
				pt.pts.localiza(numero,numero);
				pt.pts.escrever("! ola mundo !");
			}
			
		}
	}

