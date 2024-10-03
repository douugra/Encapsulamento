using System;

public class Pessoa
{
    // Atributos privados
    private string nome;
    private int idade;
    private string telefone;
    private string endereco;
    private string email;

    // Propriedade para Nome
    public string Nome
    {
        get { return nome; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O nome não pode ser vazio."); // usei o throw new ArgumentException que serve 
                                                                           //para lançar uma exceção. Quando você lança uma exceção, está basicamente interrompendo o fluxo normal do programa
                                                                           //e informando que ocorreu um erro que precisa ser tratado.
                                                                           //Essa exceção é comumente utilizada para indicar que um argumento fornecido a um método não é válido.
                                                                           //O texto que você passa para o construtor (por exemplo, "O nome não pode ser vazio.") é uma mensagem que pode ajudar a entender qual foi o erro.


            }
            nome = value;
        }
    }

    // Propriedade para Idade
    public int Idade
    {
        get { return idade; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("A idade não pode ser negativa.");
            }
            idade = value;
        }
    }

    // Propriedade para Telefone
    public string Telefone
    {
        get { return telefone; }
        set { telefone = value; }
    }

    // Propriedade para Endereço
    public string Endereco
    {
        get { return endereco; }
        set { endereco = value; }
    }

    // Propriedade para E-mail
    public string Email
    {
        get { return email; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))      
                // usei o string.IsNullOrWhiteSpace , Este é um método estático da classe string que verifica se uma string é null, vazia ("")
                // ou contém apenas espaços em branco. Ele retorna true se qualquer uma dessas condições for verdadeira, e false caso contrário.
            {
                throw new ArgumentException("O e-mail não pode ser vazio.");
            }
            email = value;
        }
    }
}