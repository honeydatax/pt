imports pt
module modelo1
	sub main()
			dim texto as string
			pt.pts.apagar()
			texto=pt.pts.ler("meu.txt")
			pt.pts.localiza(1,1)
			pt.pts.escrever(texto)
	end sub
end module
