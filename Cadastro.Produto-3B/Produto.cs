public class Produto
{
    public double precoAq;
    public double lucro;
    public string codigo;
    public string descricao;

    public Produto()
    {

    }
    public double ValorLucro(double precoAq, double lucro)
    {
        this.precoAq = precoAq;
        this.lucro = lucro;

        double calculo = precoAq * (lucro / 100);
        calculo = calculo + precoAq;

        return calculo;
    }
}
    
        
    

