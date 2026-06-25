namespace ProjetoCarro;

class Program
{
    static void Main(string[] args)
    {
       //Adicionar Novo Carro
       //Ver carros adicionados
       //Excluir Carro
       //Atualizar carro
      
       
       
       

      
       
    }

   static void somar(int n1, int n2)
    {
        Console.WriteLine(n1 + n2);
    }

    static void mensagem(string nome, string mensagem)
    {
        Console.WriteLine("Bem vindo(a), " + nome);
        Console.WriteLine("Mensagem do dia: " + mensagem);
    }

    static void enviarNotificacao(string mensagem, int tipo)
    {
        if(tipo == 1)
        {
            Console.WriteLine("Notificação por sms: " + mensagem);
        }
        else if (tipo == 2)
        {
            Console.WriteLine("Notificacao pelo email" + mensagem);
        }
        else if (tipo == 3)
        {
            Console.WriteLine("Notificacao por correio: " + mensagem);
        }
    }
}