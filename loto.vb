imports pt
module modelo1
	sub main()
			dim n as integer
			pt.pts.apagar()
			for n=0 to 16 
				pt.pts.localiza(0,n)
				pt.pts.escrever(pt.pts.texton(pt.pts.loto(1,50)))
			next

	end sub
end module
