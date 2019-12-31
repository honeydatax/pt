using pt;

	public class textoss{
		public static void Main(string[] args){
			string txt1="ola tudo bem por ai....";
			string txt2="bem";
			pt.pts.apagar();
			pt.pts.localiza(1,1);
			pt.pts.escrever(txt1);
			pt.pts.localiza(1,2);
			pt.pts.escrever(pt.pts.texton((int) pt.pts.em(txt1,txt2)));
			
		}
	}

