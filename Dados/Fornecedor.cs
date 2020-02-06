public class Fornecedor : Pessoa{
    private string CNPJ;

    public string GetCNPJ()
    {
        return this.CNPJ;
    }

    public void SetCNPJ(string cnpj)
    {
        this.CNPJ = cnpj;
    }
}