imports pt
module modelo1
	sub main()
		dim meutexto as string
		pt.pts.escrever("escreva o seu nome.?")
		meutexto=pt.pts.entrada()
		pt.pts.escrever("o texto que digitou foi.!")
		pt.pts.escrever(meutexto)
	end sub
end module
