using pt;

	public class textoss{
		public static void Main(string[] args){
			int n;
			pt.pts.apagar();
			for(n=0;n<16;n++){
				pt.pts.localiza(0,n);
				pt.pts.escrever(pt.pts.texton((int) pt.pts.loto(1,50)));
			}
		}
	}

