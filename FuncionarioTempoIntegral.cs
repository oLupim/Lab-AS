public class FuncionarioTempoIntegral : Funcionario, IBonus
{
    private double salarioMensal;
    public double bonus;

    public FuncionarioTempoIntegral(string nome, int matricula, double salarioMensal) : base(nome, matricula)
    {
        // this.nome = nome;
        // this.matricula = matricula;
        this.salarioMensal = salarioMensal;
    }

    public override double CalcularSalario()
    {
        return salarioMensal;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {nome} \nMatrícula: {matricula} \nSalário Mensal: {salarioMensal}");
    }

    public double CalcularBonus()
    {
        double bonus = salarioMensal * 0.10;
        return Math.Round(salarioMensal + bonus, 2);
    }
}