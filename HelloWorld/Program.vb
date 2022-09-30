Imports System

Module Program
	Sub Main()
		Dim num1, num2 As String
		Dim result As Double

		Console.Write("Digite um número: ")
		num1 = Console.ReadLine()

		Console.Write("Digite outro número: ")
		num2 = Console.ReadLine()

		Try
			result = CDbl(num1) / CDbl(num2)
			Console.WriteLine("O quociente de {0} por {1} é {2:0.00}",
												num1, num2, result)
		Catch ex As Exception
			Console.WriteLine("Não é possível dividir por letras!")
		Finally
			Console.WriteLine("O código no bloco Finally sempre é executado.")
		End Try

		Console.ReadLine()
	End Sub
End Module