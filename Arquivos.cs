namespace Arquivos;
public class TrabalhandoComArquivos
{
  public void AulaCriandoArquivo()
  {
    var escrever = new StreamWriter("Cadastro.txt", true); // StreamWriter gravar um arquivo, entre () pode ser informado o path de onde deseja gravar o arquivo, se colocar apenas o nome do arquivo grava automaticamente na raiz do projeto | true para informar que o append é verdadeiro, caso o arquivo já esteja criado, ele vai abrir o arquivo e acrescentar a informação desejada

    Console.Write("Informe um nome: ");
    var nome = Console.ReadLine();

    escrever.WriteLine("ID...: " + Random.Shared.Next(1, 100)); // Escrevendo as informaçõe no arquivo
    escrever.WriteLine("Nome.: " + nome);
    escrever.WriteLine("========================");

    escrever.Close(); // Fechando o arquivo 
  }
  public void AulaLendoArquivo()
  {
    // Para ler todo o arquivo de uma única vez
    var conteudo = File.ReadAllText("Cadastro.txt");
    Console.WriteLine(conteudo);

    // Para ler o arquivo linha por linha
    var ler = new StreamReader("Cadastro.txt");
    while (!ler.EndOfStream)
    {
      var linha = ler.ReadLine();
      Console.WriteLine(linha);
    }
    ler.Close();
  }
    public void AulaExcluindoArquivo()
  {
    if (File.Exists("Cadastro.txt"))
    {
      File.Delete("Cadastro.txt");
    }
  }
}