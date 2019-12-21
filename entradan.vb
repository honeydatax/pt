imports pt
module modelo1
	sub main()
			dim numero as double
			pt.pts.escrever("escreva a sua idade?")
			numero=pt.pts.entradan()
			pt.pts.escrever("")
			pt.pts.escrever("a sua idade é!")
			pt.pts.escrever(pt.pts.texton(numero))
	end sub
end module
