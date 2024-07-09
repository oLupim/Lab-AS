public class FuncionarioMeioPeriodo : Funcionario
{
    private double salarioHora;
    private double horasTrabalhadas;
    // public double salarioMensal;

    public FuncionarioMeioPeriodo(string nome, int matricula, double salarioHora, double horasTrabalhadas) : base(nome, matricula)
    {
        this.salarioHora = salarioHora;
        this.horasTrabalhadas = horasTrabalhadas;
    }

    public override double CalcularSalario()
    {
        return salarioHora*horasTrabalhadas;
    }

    public override void ExibirInformacoes()
    {
        double SalarioMensal = CalcularSalario();
        Console.WriteLine($"Nome: {nome} \nMatrícula: {matricula} \nSalário Mensal: {SalarioMensal} \nHoras Trabalhadas: {horasTrabalhadas} \nSalário Total: {CalcularSalario()}");
    }

    public double CalcularBonus()
    {
        return CalcularSalario() * 0.5;
    }
}