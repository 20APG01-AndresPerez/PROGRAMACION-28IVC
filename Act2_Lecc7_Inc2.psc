Algoritmo Act2_Lecc7_Inc2
//Inciso 2 ? Un algoritmo para leer una calificación numérica y determinar si es deficiente, regular,
//bien, muy bien o excelente.
	Definir materia Como Caracter
	Definir nota como Real
	
	Escribir "Escriba la materia"
	Leer materia 
	Escribir "Escriba la nota"
	Leer nota 
	
	Si nota >50 y nota<=60 Entonces
		Escribir "Nota Deficiente"
		SiNo Si nota >61 y nota <=70 Entonces
			Escribir "Nota regular"
			SiNo Si nota >71 y nota<=80 Entonces
				Escribir"Nota buena"
				Sino Si nota >81 y nota <=90 Entonces 
					Escribir"Nota muy buena"
					SiNo Si nota >91 y nota <=100
						Escribir" Nota Excelente"
						SiNo
							Escribir"Nota muy baja"
					FinSi
				FinSi
			Fin Si
		Fin Si
	FinSi
FinAlgoritmo
