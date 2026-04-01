Algoritmo Act3_Lecc7_Inc2
	Definir a1, a2, a3, angulo Como Entero
	Escribir "Escriba el primer ángulo"
	Leer a1
	Escribir "Escriba el segundo ángulo"
	Leer a2
	Escribir "Escriba el tercer ángulo"
	Leer a3
	Si a1+a2+a3 <>180 Entonces
		Escribir "La suma de sus ángulos no dan 180, No es un triangulo"
	SiNo
		Si a1= 60 y a2= 60 y a3= 60 Entonces
			Escribir "Es un triangulo Equilátero"
		SiNo
			Si a1= a2 o a1= a3 o a2= a3 Entonces
				Escribir "Es un triángulo Isosceles"
			SiNo
				Escribir"Es un triangulo Escaleno"
			FinSi
		FinSi
	FinSi
FinAlgoritmo
