namespace udemy_DadosAluno
{
    internal class Program
    {
        /* Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres
         * do ano (primeiro trimestre vale 30 e o segundo valem 35 cada). Ao final, mostrar qual a nota do aluno
         * no ano. Dizer também se o aluno está aprovado ou reprovado e, em caso negativo, quantos pontos faltam
         * para o aluno obter o mínimo para ser aprovado (60 pontos). Criar uma calsse aluno para resolver o problema.
         */
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Digite o nome do aluno:");
            aluno.nome = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"Certo, agora digite as três notas do {aluno.nome}:");
            aluno.nota1 = double.Parse(Console.ReadLine());
            aluno.nota2 = double.Parse(Console.ReadLine());
            aluno.nota3 = double.Parse(Console.ReadLine());

            if (aluno.aprovacao() == false)
            {
                Console.WriteLine($"O aluno {aluno.nome} está reprovado.\n" +
                    $"A nota final foi de: {aluno.notaFinal():n2}\n" +
                    $"A quantidade de pontos faltantes foi de: {aluno.pontosFaltantes():n2}");
            }
            else
            {
                Console.WriteLine($"O aluno {aluno.nome} foi aprovado. \n" +
                    $"A nota final foi de: {aluno.notaFinal():n2}");
            }
        }
    }
}