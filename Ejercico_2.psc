Algoritmo Ejercico_2
	Definir num1, num2, opc, result Como Real
	Definir mjs Como Caracter
	Escribir Sin Saltar "Dijite dos valores numericos"
	Leer num1
	Escribir Sin Saltar num2
	Leer num2
	Leer opc
	Leer mjs

	Escribir "***********************"
	Escribir "MENÚ PRINCIPAL"
	Escribir "1-Suma"
	Escribir "2-Resta"
	Escribir "3-Multiplicación"
	Escribir "4-Divición"
	Escribir "5-Salir"
	Escribir Sin Saltar "Dijite el numero segun su operación"
	Leer opc
	
	Segun opc Hacer
		1:
			mjs="El Resultado de la suma es"
			result=num1+num2
		2:
			mjs="El Resultado de la resta es"
			result=num1-num2
		3:
			mjs="El Resultado de la multiplicacion es"
			result=num1*num2
		4:
			mjs="El Resultado de la divició es"
			result=num1/num2
		5:
			mjs="Saliendo del sistema"
		De Otro Modo:
			mjs="Seleccione una opcion Valida!!!"
	FinSegun
	
	Escribir mjs
	Escribir result
FinAlgoritmo
