using pt;

	public class ola{
		public static void Main(string[] args){
			int numero;
			pt.pts.apagar();
			for(numero=0;numero<17;numero++){
				pt.pts.localiza(numero,numero);
				pt.pts.escrever("! ola mundo !");
			}
			
		}
	}

