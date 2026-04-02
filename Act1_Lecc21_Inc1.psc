Algoritmo Act1_Lecc21_Inc1
	Definir num Como Entero
	Escribir "Escriba un numero del 1-7"
	Leer num
	
	Si num=1 Entonces
		Escribir "1. Hoy es Lunes"
	SiNo 
		Si num=2 Entonces
			Escribir"2. Hoy es Martes"
		SiNo Si num= 3 Entonces 
				Escribir"3. Hoy Miercoles"
				Sino Si num= 4 Entonces
					Escribir" 4. Hoy es Jueves"
					Sino Si num= 5 Entonces
						Escribir "5. Hoy es Viernes"
					SiNo Si num= 6 Entonces
							Escribir "6. Hoy es Sabado"
							Sino Si num= 7 Entonces
								Escribir "Hoy es Domingo"
							SiNo
								Escribir "Opcion Invalida"
							FinSi
						FinSi
					FinSi
				Fin Si
			FinSi
		FinSi
	FinSi
FinAlgoritmo
