imports pt
module modelo1
	sub main()
			dim texto as string
			texto="ola mundo"
			texto=texto+chr(13)+chr(10)+"tudo bem"+chr(13)+chr(10)+".!"
			pt.pts.apagar()
			pt.pts.gravar("meu.txt",texto)
			pt.pts.localiza(1,1)
			pt.pts.escrever("texto gravado em meu.txt")	
	end sub
end module
