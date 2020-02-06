public class Cliente : Pessoa{
    private string CPF;

    public string GetCPF()
    {
        return CPF;
    }

    public void SetCPF(string cpf)
    {
        this.CPF = cpf;
    }
}