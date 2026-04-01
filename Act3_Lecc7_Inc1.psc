Algoritmo Act3_Lecc7_Inc1
	Definir dia, mes Como Entero
    Escribir "Ingrese el número del día:"
    Leer dia
    Escribir "Ingrese el número del mes:"
    Leer mes
    Si mes < 1 o mes > 12 Entonces
        Escribir "Mes no válido."
    Sino
        Si (mes = 2 y dia > 28) o ((mes = 4 o mes = 6 o mes = 9 o mes = 11) y dia > 30) o (dia > 31) o (dia < 1) Entonces
            Escribir "El día ingresado no existe en ese mes."
        Sino
            Si mes >= 5 y mes <= 10 Entonces
                Escribir "Es Invierno"
            Sino
                Escribir "Es Verano"
            FinSi
        FinSi
    FinSi
FinAlgoritmo

