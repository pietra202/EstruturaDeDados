internal class Program
{
    private static void Main(string[] args)
    {
        // trabalhando com lista (list)
        List<string> frutas = new List<string>();

        /* adicionar itens na lista*/
        frutas.Add("Morango");
        frutas.Add("Manga");
        frutas.Add("Maçã");
        frutas.Add("Melancia");
        frutas.Add("Uva");

        /* imprimir os itens da listav */
        Console.WriteLine("Minha lista de frutas:");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        /* imprimir elemento no indice especifico*/
        Console.WriteLine("fruta indice 2:" + frutas[2]);

        /* inserir um elementon no indice especifico*/
        frutas.Insert(1, "Maracuja");

        /*imprimindo a lista novamente */
        Console.WriteLine(); //pula linha em branco

        Console.WriteLine("Minha lista de fruta:");
        foreach (string fruta in frutas) ;
        {
            Console.WriteLine(frutas);
        }
        /*alternar um elemento no indice especifico*/
        frutas[4] = "pera";
        /*imprimindo a lista novamente */
        Console.WriteLine();
        Console.WriteLine("Minha lista de fruta:");
        foreach (string fruta in frutas) ;
        {
            Console.WriteLine(frutas);
        }
        /*remover elementos da lista indice especifico */
        frutas.Remove("Morango");
        /*imprimindo a lista novamente*/
        Console.WriteLine();
        Console.WriteLine("Minha lista de fruta:");
        frutas.ForEach(Console.WriteLine);

        /* apagar todos os elementos da lista*/
        frutas.Clear();

        //trabalhando com dicionario (dicionary)

        /* Criando um dicionario de dados */
        Dictionary<int, string> carros = new Dictionary<int, string>();
        /* adicionar dados a um dicionario */
        carros.Add(5, "Uno");
        carros.Add(10, "Del rey");
        carros.Add(2, "Ford Ka");

        Console.WriteLine(); //pula linha em whitee
        Console.WriteLine("===========================================================");
        Console.WriteLine(); //pula linha em whitee

        Console.WriteLine("Meu dicionario de carros:");

        //trabalhando com fila//
        /*criar uma fila (queue)*/
        Queue<string> filaBanco = new Queue<string>();

        /*adicionar elemento em uma fila*/
        filaBanco.Enqueue("Andre");
        filaBanco.Enqueue("João");
        filaBanco.Enqueue("Maria");
        filaBanco.Enqueue("Bia");

        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }
        /* verificar se existe um elemento na fila*/

        bool achou = filaBanco.Contains("Manoel");

        if (achou)
        {
            Console.WriteLine("A pessoa esta na fila");
        }
        else
        {
            Console.WriteLine("A pessoa não esta na fila");
        }

        Console.WriteLine(); //pula linha em whitee
        Console.WriteLine("===========================================================");
        Console.WriteLine(); //pula linha em whitee
        // trabalhando com pilha (stack)
        /* criando uma pilha */
        Stack<string> livros = new Stack<string>();

        /* adicionar elementos em uma pilha */
        livros.Push("Chapeuzinho Vermelho");
        livros.Push("Branca de neve e os sete anões");
        livros.Push("Princesa e o sapo");

        foreach (var livro in livros)
        {
            Console.WriteLine(pessoa);
        }
        Console.WriteLine(); //pula linha em whitee
        Console.WriteLine("===========================================================");
        Console.WriteLine(); //pula linha em whitee

        /* remove o primeiro elemento da pilha*/
        livros.Pop();
        foreach (var livro in livros)
        {
            Console.WriteLine(livro);
        }
        Console.WriteLine(); //pula linha em whitee
        Console.WriteLine("===========================================================");
        Console.WriteLine(); //pula linha em whitee
    }
}