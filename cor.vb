imports pt
module modelo1
	sub main()
			dim numero as integer
			pt.pts.apagar()
			pt.pts.papel(pt.pts.branco)
			pt.pts.tinta(pt.pts.preto)
			for numero=0 to 16
				pt.pts.localiza(numero,numero)
				pt.pts.escrever("! ola mundo !")
			next
	end sub
end module
