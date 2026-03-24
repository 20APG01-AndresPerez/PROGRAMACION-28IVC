Algoritmo Act1_Lecc7_Inc1
	Escribir " ==PROMEDIO DE CALIFICACIONES== "
	//VARIABLES
	Definir materia Como Caracter
	Definir n1,n2,n3,n4,n5 Como Entero
	Definir promedio como Real
	
	//Solicitar datos al usuario
	Escribir "Escriba la materia: "
	Leer materia
	Escribir "Dame 5 notas"
	Leer n1
	Leer n2
	Leer n3
	Leer n4
	Leer n5
	
	//Proceso 
	promedio= (n1+n2+n3+n4+n5)/5;
	
	//Evalu
	Si promedio >=70 Entonces
		Escribir "Estudiante Aprobado con :",promedio
	SiNo
		Escribir "Estudiante Reprobado con" , promedio
	Fin Si
	
FinAlgoritmo
