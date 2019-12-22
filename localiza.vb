imports pt
module modelo1
	sub main()
			dim numero as integer
			pt.pts.apagar()
			for numero=0 to 16
				pt.pts.localiza(numero,numero)
				pt.pts.escrever("! ola mundo !")
			next
	end sub
end module
