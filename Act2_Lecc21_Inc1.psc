Algoritmo Act2_Lecc21_Inc1
	Definir num como Entero 
	Escribir "Para ser atendido presione un botón del 1-4: "
	Leer num
	Si num=1 Entonces
		Escribir "1. Ventas"
	SiNo 
		Si num=2 Entonces
			Escribir"2. Recepcion"
		SiNo Si num= 3 Entonces 
				Escribir"3. Dirección"
				Si num= 4 Entonces
					Escribir" 4. Compras"
				SiNo
					Escribir "Opcion inválida"
				Fin Si
			FinSi
		FinSi
	FinSi
FinAlgoritmo