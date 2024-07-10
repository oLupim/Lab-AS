public class Empresa
{

    public List<Funcionario>ListaFuncionarios = new List<Funcionario>(); //criando uma lista de funcionarios

    public void AdicionarFuncionario(Funcionario Funcionario) //metodo01 adicionar
    {
        ListaFuncionarios.Add(Funcionario);
    }

    public void RemoverFuncionario(int NumeroMatricula) //metodo02 remover
    {
        
        for (int i = 0; i < ListaFuncionarios.Count; i++) //loop para percorrer a lista
        {

            if (ListaFuncionarios[i].matricula == NumeroMatricula) //se o int digitado estiver na lista de funcionario, remove
            {
                ListaFuncionarios.RemoveAt(i);
            }
        }
    }

    public void ExibirFuncionarios()  //metodo03 exibir
    {
        for (int i = 0; i < ListaFuncionarios.Count; i++) //loop para percorrer a lista
        {
            ListaFuncionarios[i].ExibirInformacoes(); //aqui ele acessa a posição usando o [i] e exibi percorrendo toda a lista

            if (ListaFuncionarios[i].Projetos.Count > 0) //aqui é pra conseguir mostrar os projeto e ir adicionando após a virgula
            {
                Console.WriteLine($"Projetos: {string.Join(", ", ListaFuncionarios[i].Projetos)}");
            }

            else
            {
                Console.WriteLine("Projetos: Nenhum Projeto");
            }
            Console.WriteLine();
        }
    }
}