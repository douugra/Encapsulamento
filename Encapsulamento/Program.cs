class Program
{
    static void Main()
    {
        try
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Douglas Alexandre";
            pessoa.Idade = 26;
            pessoa.Telefone = "(81)99376-2420";
            pessoa.Endereco = "Rua Doutor Eudes sobral,N 05";
            pessoa.Email = "douglas11918@gmail.com";

            Console.WriteLine($"Nome: {pessoa.Nome}");
            Console.WriteLine($"Idade: {pessoa.Idade}");
            Console.WriteLine($"Telefone: {pessoa.Telefone}");
            Console.WriteLine($"Endereço: {pessoa.Endereco}");
            Console.WriteLine($"E-mail: {pessoa.Email}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}
// No Main, usei um bloco try-catch para capturar possíveis exceções geradas durante a configuração dos atributos.
//Com isso, a classe Pessoa está encapsulada corretamente, e as validações são realizadas conforme solicitado.