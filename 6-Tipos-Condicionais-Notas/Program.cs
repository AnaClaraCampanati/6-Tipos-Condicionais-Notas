//Escreva um algoritmo que receba quatro notas de um aluno, calcule e mostre a média aritmética das notas e a mensagem de aprovado ou reprovado, considerando para aprovação média 70.


Console.WriteLine("Digite a primeira nota:");
int nota1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a segunda nota:");
int nota2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a terceira nota:");
int nota3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quarta nota:");
int nota4 = Convert.ToInt32(Console.ReadLine());

int media = (nota1 + nota2 + nota3 + nota4) / 4;

Console.WriteLine("Média: " + media);

if (media >= 7)
{
    Console.WriteLine("Situação: Aprovado");
}

if (media <= 6)
{
    Console.WriteLine("Situação: Reprovado");
}