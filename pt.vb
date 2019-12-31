imports system
imports System.IO

namespace pt
public module pts
		public cor_papel as integer = 0
		public cor_tinta as integer= 7
		public preto as integer= 0
		public vermelho as integer= 1
		public verde as integer= 2
		public laranja as integer= 3
		public azul as integer= 4
		public rosa as integer= 5
		public cyan as integer= 6
		public cinza as integer= 7
		public branco as integer= 7
		
		

	public pi as double = 3.1415927
	public sub escrever(s as string)
				Console.WriteLine(s)
	end sub
	public function entrada() as string
			entrada=Console.ReadLine()
	end function
	public function entradan()as double 
			entradan=double.Parse(Console.ReadLine())
	end function
	public function texton(numero as double)as string 
			texton=numero.ToString()
	end function

	public sub apagar()
			dim s as string =" "
			dim i as integer=0
			for i=0 to 60
				Console.WriteLine(s)
			next

	end sub
	
	public sub localiza(x as integer,y as integer)
			dim s as string 
			dim sx as string
			dim sy as string
			sx=x.ToString() + "f" 
			sy=y.ToString() + ";" 
			s=chr(27)+"[" + sy + sx 
			Console.Write(s)
	end sub
		

	public sub papel(valor as integer)
			dim s as string
			dim sx as string 
			dim sy as string
			cor_papel=valor
			sx=(cor_tinta+30).ToString() + ";" 
			sy=(cor_papel+40).ToString() + "m" 
			s=chr(27)+"[" + sx + sy 
			Console.Write(s)
	end sub
		
	public sub  tinta(valor as integer)
			dim s as string
			dim sx as string 
			dim sy as string
			cor_tinta=valor
			sx=(cor_tinta+30).ToString() + ";" 
			sy=(cor_papel+40).ToString() + "m" 
			s=chr(27)+"[" + sx + sy 
			Console.Write(s)

	end sub

	public function ler(files as string) as string
			dim line2 as string =""
			line2=line2.join(chr(13)+chr(10),File.ReadAllLines(files))
			ler=line2
	end function

	public sub gravar(files as string,textos as string)
			using file as StreamWriter = new StreamWriter(files)
				file.Write(textos)
			end using
	end sub

	public function encher(textos as string,vezes as integer) as string
		dim n as integer
		dim s as string =""
		for n=0 to vezes
			s=s+textos
		next
		encher=s
	end function

	public function espaco(vezes as integer) as string
		dim n as integer
		dim s as string =""
		for n=0 to vezes
			s=s+" "
		next
		espaco=s
	end function

	public function centrar(textos as string,vezes as integer)as string
	
			dim s as string=""
			dim nn as integer=(vezes-textos.Length)\2
			s=espaco(nn)
			s=s+textos
			centrar=s
	end function

	public function em(textos as string,contendo as string) as integer
	
		dim i as integer
		i=textos.IndexOf(contendo)
		em=i
	end function

	public function loto(inicial as integer,fim as integer)as integer
		dim rnd as Random = new Random()
		dim i as integer
		i=rnd.Next(inicial,fim)
		loto=i
	end function


		
end module
end namespace
















