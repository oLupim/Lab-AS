public class FuncionarioMeioPeriodo : Funcionario
{
    //atributos
    private double salarioHora;
    private double horasTrabalhadas;

    public FuncionarioMeioPeriodo(string nome, int matricula, double salarioHora, double horasTrabalhadas) : base(nome, matricula) //metodo construtor
    {
        this.salarioHora = salarioHora;
        this.horasTrabalhadas = horasTrabalhadas;
    }

    public override double CalcularSalario() //metodo01
    {
        return salarioHora*horasTrabalhadas;
    }

    public override void ExibirInformacoes() //metodo02
    {
        double SalarioMensal = CalcularSalario();
        Console.WriteLine($"Nome: {nome} \nMatrícula: {matricula} \nSalário Mensal: {SalarioMensal}");
    }

    public double CalcularBonus() //metodo03
    {
        return CalcularSalario() * 0.5;
    }
}