string[,] cadAluno = new string[5, 7];
int linha = 0;
int coluna = 0;
int menu = 0;
string voltar = "S";
string nome = "";
double total = 0;
int trabalho = 0;
string resultado = " ";
double presenca = 0;

while (voltar == "S" || voltar == "s")
{
    Console.WriteLine("Para Cadastras os Alunos digite '1' \n\n\nPara ver as notas e se o ALUNO foi APROVADO ou REPROVADO digite '2' \n\n\nPara fechar o programa digite '3'");
    menu = int.Parse(Console.ReadLine());
    Console.Clear();

    switch (menu)
    {
        case 1:
            {
                for (linha = 0; linha < 5; linha++)
                {
                    Console.WriteLine("Informe o Nome do Aluno: ");
                    cadAluno[linha, coluna++] = Console.ReadLine();
                    Console.WriteLine("Informe o Número de aulas dadas: ");
                    cadAluno[linha, coluna++] = Console.ReadLine();
                    Console.WriteLine("Informe o Número de faltas: ");
                    cadAluno[linha, coluna++] = Console.ReadLine();
                    Console.WriteLine("Informe a Nota da Prova 1: ");
                    cadAluno[linha, coluna++] = Console.ReadLine();
                    Console.WriteLine("Informe a Nota da Prova 2: ");
                    cadAluno[linha, coluna++] = Console.ReadLine();
                    Console.WriteLine("Informe a Nota da Prova 3: ");
                    cadAluno[linha, coluna++] = Console.ReadLine();
                    Console.WriteLine("Informe a Nota do Trabalho 1: ");
                    cadAluno[linha, coluna++] = Console.ReadLine();

                    coluna = 0;
                    Console.Clear();                    
                }
                Console.WriteLine("Deseja voltar ao Menu Iniciar? Digite 'S' || 'N' ");
                voltar = Console.ReadLine();
                Console.Clear();
                break;
            }     
            case 2:
            {
                for (linha = 0; linha < 5; linha++)
                {
                    total = (int.Parse(cadAluno[linha, 3]) + int.Parse(cadAluno[linha, 4]) + int.Parse(cadAluno[linha, 5]) / 3) + trabalho;
                    presenca = (int.Parse(cadAluno[linha, 2]) / int.Parse(cadAluno[linha, 1])) * 100;

                    if (total >= 6 && presenca > 25)
                    {
                        resultado = "Aprovado";
                    }
                    if (total < 6 && presenca >= 25)
                    {
                        resultado = "Reprovado por Menção";
                    }
                    if (total > 6 && presenca < 25)
                    {
                        resultado = "Reprovado por Faltas";
                    }
                    if (total < 6 && presenca < 25)
                    {
                        resultado = "Reprovado por Menção e Faltas";
                    }

                    Console.WriteLine(cadAluno[linha, 0] + ", sua nota foi de: " + total + " E sua presença foi de: " + presenca + ", O ALUNO FOI ");

                }
                Console.WriteLine("Deseja voltar ao Menu Iniciar? Digite 'S' || 'N' ");
                voltar = Console.ReadLine();
                Console.Clear();
                break;
            }
        case 3:
            {
                voltar = "N";
                break;
            }                          
    }
}