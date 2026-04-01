Algoritmo Act3_Lecc20_Inc1
	Definir num como Real
	Escribir "Escribir un numero de la semana"
	Leer num
	
	Si num <1 o num> 7 Entonces
		Escribir "No es válido, no es un dia de la semana"
	SiNo 
		Si num= 1 o num= 2 o num= 3 o num= 4 o num = 5
			Escribir "Es entresemana"
		SiNo
			Escribir"Es fin de semana"
		FinSi	
	FinSi
FinAlgoritmo
