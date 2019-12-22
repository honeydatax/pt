imports pt
module modelo1
	sub main()
			dim numero as double
			pt.pts.apagar()
			pt.pts.escrever("!numeros. entre 0 e 10 !")
			for numero=0.00 to 11.00
				pt.pts.escrever(pt.pts.texton(numero))
			next
	end sub
end module
