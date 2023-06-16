Console.WriteLine("--- Entrada Válida ---\n");

int NumeroDigitado = -1;

while (NumeroDigitado <0 || NumeroDigitado >9)

{
    Console.WriteLine ("Escreva um numero de 1 a 9 (ou digite 0 para cancelar): ");
    string  input = Console.ReadLine()!;
    NumeroDigitado =
    Convert.ToInt32(input);
}

if (NumeroDigitado == 0)
{
 Console.WriteLine ("\n Operação cancelada.");
}
else

{
    Console.WriteLine ($"\n Numero selecionado = {NumeroDigitado}");
}

Console.WriteLine ("Volte sempre!");