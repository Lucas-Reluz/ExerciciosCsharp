var quantidadeAlunos = 0;
var pausa = true;
while (pausa == true)
{
    Console.WriteLine("Informe a idade dos 5 alunos: ");
    quantidadeAlunos++;
    var idade = Convert.ToInt32(Console.ReadLine());
    if (quantidadeAlunos == 5)
    {
        var media = (idade + idade + idade + idade + idade)/5;
        Console.WriteLine($"A media de idade dos alunos é {media}");
        pausa = false;
    }
}
//Exercício basico para calcular a media da idade de 5 alunos, tentei fazer da menor forma possível.