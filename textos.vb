imports pt
module modelo1
	sub main()
			dim numero as integer
			dim txt1 as string
			dim txt2 as string
			pt.pts.apagar()
			pt.pts.localiza(1,1)
			for numero=0 to 16
				pt.pts.localiza(0,numero+1)
				txt2=pt.pts.encher("*",(numero+1)*2)
				txt1=pt.pts.centrar(txt2,79)
				pt.pts.escrever(txt1)
			next
	end sub
end module
