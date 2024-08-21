internal class Program
{
    private static void Main(string[] args)
    {
        //TRABALHANDO COM LISTA ( LIST )
        List<string> frutas = new List<string>();

        /* Adicionar itens na Lista*/
        frutas.Add("Morango");
        frutas.Add("Manga");
        frutas.Add("Goiaba");
        frutas.Add("Uva");

        /* Imprimir os Itens da Lista */
        /* Impressao da Lista em uma única linha */
        Console.WriteLine("Minha Lista de Frutas:");
        frutas.ForEach(Console.WriteLine);

        //foreach (string fruta in frutas)
        //{
        //    Console.WriteLine(fruta);
        //}

        Console.WriteLine(); // Pula linha em branco

        /* Imprimir elemento n posição específica */
        Console.WriteLine("Fruta na indice 2: " + frutas[2]);

        /* Inserir um elemento no indice específico */
        frutas.Insert(1, "Maracuja");

        /* Imprimindo a Lista novamente*/
        Console.WriteLine(); //Pula linha em branco

        Console.WriteLine("Minha Lista de Frutas:");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        /* Alterar um elemento no índice específico */
        frutas[4] = "Pêra";

        Console.WriteLine(); //Pula linha em branco
        Console.WriteLine("Minha Lista de Frutas:");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        /* Remover elementos da lista no indice especifico*/
        frutas.RemoveAt(3);

        /* Remover elementos pelo valor do conteúdo*/
        frutas.Remove("Morango");

        /* Imprimindo da Lista novamente*/
        Console.WriteLine();
        Console.WriteLine("Minha Lista de Frutas:");
        frutas.ForEach(Console.WriteLine);

        /* Apagar todos os elementos da lista*/
        frutas.Clear();

        Console.WriteLine();
        Console.WriteLine("===================================================");
        Console.WriteLine();

        // TRABALHANDO COM DICIONARIO (DICTIONARY)
        /* Criando um Dicionario de Dado*/
        Dictionary<int, string> carros = new Dictionary<int, string>();
        /*Adicionar Dados a um Dicionário */
        carros.Add(5, "Corsa");
        carros.Add(10, "Fusca");
        carros.Add(2, "Ford Ka");

        /* Imprimir um Dicionario de Dados */
        foreach (var carro in carros)
        {
            Console.WriteLine($"{carro.Key} - {carro.Value}");
        }

        // TRabalhando com fila
        // criar uma fila (queue)

        Queue<string> FilaBanco = new Queue<string>();
        FilaBanco.Enqueue("André");
        FilaBanco.Enqueue("josé");
        FilaBanco.Enqueue("mazzi");
        FilaBanco.Enqueue("bruno");

        foreach (var pessoa in FilaBanco)
        {
            Console.WriteLine(pessoa);
        }
        FilaBanco.Dequeue();

        Console.WriteLine();
        Console.WriteLine("===============");
        Console.WriteLine();
        foreach (var pessoa in FilaBanco)
        {

            Console.WriteLine(pessoa);
        }

        // verificar se existe um elemento na fila

        bool achou = FilaBanco.Contains("manoel");
        if (achou)
        {
            Console.WriteLine("A pessoa está na fila");
        }
        else
        {
            Console.WriteLine("A pessoa NÃO está na Fila");
        }

        Console.WriteLine();
        Console.WriteLine("===============");
        Console.WriteLine();

        // TRABALHANDO COM  PILHA (STACK)
        Stack<string> Livros = new Stack<string>();
        //adicionar elementos em uma pilha
        Livros.Push("Chapeu");
        Livros.Push("Mazzi o incio");
        Livros.Push("Mazzi o fim");

        foreach (var Livro in Livros)
        {
            Console.WriteLine(Livro);
        }

        Console.WriteLine();
        Console.WriteLine("===============");
        Console.WriteLine();
    }
}