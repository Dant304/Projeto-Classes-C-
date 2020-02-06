using System;

namespace Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.nome = "Daniel";
            cliente.idade = 21;
            cliente.telefone = "5874-3689";
            cliente.SetCPF("478.606.618-45");
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.nome = "Ivan";
            fornecedor.idade = 32;
            fornecedor.telefone = "5832-3245";
            fornecedor.SetCNPJ("112223334445");

            Console.WriteLine("Cliente: " + cliente.nome + "\nTelefone: " + cliente.telefone + 
                            "\nCPF: " + cliente.GetCPF() + "\nFornecedor: " + fornecedor.nome + "\nTelefone:" +
                            fornecedor.telefone + "\nCNPJ: " + fornecedor.GetCNPJ() );
        }
    }
}
