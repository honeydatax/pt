imports pt
module modelo1
	sub main()
			
			dim txt1 as string
			dim txt2 as string
			txt1="ola tudo bem por ai...."
			txt2="bem"
			pt.pts.apagar()
			pt.pts.localiza(1,1)
			pt.pts.escrever(txt1)
			pt.pts.localiza(1,2)
			pt.pts.localiza(1,2)
			pt.pts.escrever(pt.pts.texton(pt.pts.em(txt1,txt2)))
	end sub
end module
