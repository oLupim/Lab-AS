﻿﻿using System.Security.Cryptography.X509Certificates;

Empresa Empresa = new Empresa();


while (true) 
{
    // aqui mostra o menu de opções para a pessoa
    Console.WriteLine("\n******************************");
    Console.WriteLine("*      Menu de Opções        *");
    Console.WriteLine("******************************");
    Console.WriteLine("1. Adicionar um funcionário de tempo integral");
    Console.WriteLine("2. Adicionar um funcionário de meio período");
    Console.WriteLine("3. Remover um funcionário");
    Console.WriteLine("4. Exibir informações de todos os funcionários");
    Console.WriteLine("5. Adicionar projeto a um funcionário");
    Console.WriteLine("9. Sair do programa");
    Console.WriteLine("******************************");
    Console.Write("Escolha uma opção: ");

    // Lê a opção escolhida
    int opcao = Convert.ToInt32(Console.ReadLine()); 

    // Executa a operação correspondente à opção escolhida  
    switch (opcao)
    {
        case 1: 
            // Adiciona um funcionário de tempo integral
            Console.WriteLine("\n*======Digite um nome de um funcionário de tempo integral======*");
            string nomeTI = Console.ReadLine();
            Console.WriteLine("*      Digite a matrícula do funcionário:        *");
            int matriculaTI = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*      Digite o salário mensal do funcionário:        *");
            double salarioTI = Convert.ToDouble(Console.ReadLine());

            //funcionarioTI vai receber todos os parâmetros
            FuncionarioTempoIntegral funcionarioTI = new FuncionarioTempoIntegral(nomeTI, matriculaTI, salarioTI); 
            Empresa.AdicionarFuncionario(funcionarioTI); //vai adicionar 
            Console.WriteLine("*      Funcionário de tempo integral adicionado com sucesso!        *");
            break;
        
        case 2:
            // Adiciona um funcionário de meio período
            Console.WriteLine("\n*======Digite o nome do funcionário de meio período======*");
            string nomeMP = Console.ReadLine();
            Console.WriteLine("*      Digite o número de matrícula        *");
            int matriculaMP = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*      Digite o salário por hora do funcionário        *");
            double salarioPorHoraMP = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("*      Digite o número de horas trabalhadas do funcionário (Arredonde os minutos)        *");
            int horasTrabalhadasMP = Convert.ToInt32(Console.ReadLine()); // 

            //funcionarioMP vai receber todos os parâmetros
            FuncionarioMeioPeriodo funcionarioMP = new FuncionarioMeioPeriodo(nomeMP, matriculaMP, salarioPorHoraMP,horasTrabalhadasMP);
            Empresa.AdicionarFuncionario(funcionarioMP);
            Console.WriteLine("*      Funcionário de meio periodo adicionado com sucesso!        *");
            break;
        
        case 3:
            // Remove um funcionário pela matrícula
            Console.WriteLine();
            Console.WriteLine("\n*======Digite o número da matrícula do funcionário que deseja remover======*");
            Empresa.ExibirFuncionarios();

            int matriculaRemover = Convert.ToInt32(Console.ReadLine());
            Empresa.RemoverFuncionario(matriculaRemover);
            Console.WriteLine("*      Funcionário removido com sucesso        *");
            break;
        
        case 4:
            // Exibe as informações dos funcionários
            Console.WriteLine();
            Empresa.ExibirFuncionarios();
            break;
        
        case 5:
            // Adiciona um projeto de um funcionário específico
            Console.WriteLine();
            Empresa.ExibirFuncionarios();
            Console.WriteLine("\n*======Digite o número de mátricula do funcionário que deseja adicionar no projeto======*");
            

            int matriculaProjeto = Convert.ToInt32(Console.ReadLine());

             // Aqui percorre a lista de funcionários para encontrar o funcionário com a matrícula recebida
            for (int i = 0; i < Empresa.ListaFuncionarios.Count; i++){
                if (Empresa.ListaFuncionarios[i].matricula == matriculaProjeto){
                    Console.WriteLine("*      Digite o nome do projeto:        *");
                    string projetoADD = Console.ReadLine();

                    Empresa.ListaFuncionarios[i].AdicionarProjeto(projetoADD);
                    Console.WriteLine("*      Projeto adicionado com sucesso!        *");
                    break;
                }
                else{
                    Console.WriteLine("*      Funcionário não encontrado, repita o processo        *");
                    Console.WriteLine();
                }
            }
            break;

        //aqui cai fora do programa
        case 9:
            Console.WriteLine();
            Console.WriteLine("*      Saindo do programa...3        *");
            Thread.Sleep(1000); // método usado para pausar a execução usando milissegundos 
            Console.WriteLine("*      Saindo do programa...2        *");
            Thread.Sleep(1000); // Pausa por 1 segundo
            Console.WriteLine("*      Saindo do programa...1        *");
            Thread.Sleep(1000); // Pausa por 1 segundo
            Console.WriteLine("Até logo!");
            return;

        default:
            Console.WriteLine();
            Console.WriteLine("*      Opção inválida! Tente novamente.        *");
            Console.WriteLine();
            break;
    }
}