Algoritmo Act2_Lecc7_Inc1
	Definir num como Entero 
	Escribir "Para ser atendido presione un botón del 1-4: 1. Ventas ,2. Soporte Técnico, 3. Contabilidad,4. Hablar con el gerente"
	Leer num
	Si num=1 Entonces
		Escribir "1. Ventas"
		SiNo 
			Si num=2 Entonces
			Escribir"2. Soporte Técnico"
			SiNo Si num= 3 Entonces 
				Escribir"3. Contabilidad"
				Si num= 4 Entonces
					Escribir" 4. Hablar con el gerente"
					SiNo
						Escribir "Opcion inválida"
				Fin Si
			FinSi
		FinSi
	FinSi
FinAlgoritmo
