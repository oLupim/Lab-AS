public class FuncionarioTempoIntegral : Funcionario, IBonus
{
    //atributos
    private double salarioMensal;
    public double bonus;

    public FuncionarioTempoIntegral(string nome, int matricula, double salarioMensal) : base(nome, matricula) //metodo construtor
    {
        this.salarioMensal = salarioMensal;
    }

    public override double CalcularSalario()  //metodo01
    {
        return salarioMensal;
    }

    public override void ExibirInformacoes() //metodo02
    {
        Console.WriteLine($"Nome: {nome} \nMatrícula: {matricula} \nSalário Mensal: {salarioMensal}");
    }

    public double CalcularBonus() //metodo03
    {
        double bonus = salarioMensal * 0.10;
        return Math.Round(salarioMensal + bonus, 2);
    }
}