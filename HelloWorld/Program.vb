Imports System

Module Program
	Sub Main()
		Dim num1, num2 As String
		Dim result As Double

		Console.Write("Digite um n�mero: ")
		num1 = Console.ReadLine()

		Console.Write("Digite outro n�mero: ")
		num2 = Console.ReadLine()

		Try
			result = CDbl(num1) / CDbl(num2)
			Console.WriteLine("O quociente de {0} por {1} � {2:0.00}",
												num1, num2, result)
		Catch ex As Exception
			Console.WriteLine("N�o � poss�vel dividir por letras!")
		Finally
			Console.WriteLine("O c�digo no bloco Finally sempre � executado.")
		End Try

		Console.ReadLine()
	End Sub
End Module