using ConsoleApp1.Model;
using Newtonsoft.Json;
using System.Globalization;

/* Lendo Arquivo
////Lendo um aruivo txt comum
//var readMe = File.ReadAllLines("C:\\Users\\Admin\\source\\repos\\WebApiRest\\ConsoleApp1\\Arquivos\\ReadMe.txt");

//foreach (var line in readMe)
//{
//    Console.WriteLine(line);
//}
*/

/* Serializando 
List<Venda> listaVenda = new List<Venda>();

DateTime data = DateTime.Now;


Venda v1 = new Venda(1, "Material de Escritório", 25.00M,data);
Venda v2 = new Venda(2, "Licença de Software", 110.00M, data);

listaVenda.Add(v1);
listaVenda.Add(v2);


//Serializar
string jsonSerializer = JsonConvert.SerializeObject(listaVenda, Formatting.Indented);
Console.WriteLine(jsonSerializer);

//Criando um arquivo .json na pasta arquivos
string path = "C:\\Users\\Admin\\Desktop\\WebApiBootCampCSharp\\WebApiRest\\ConsoleApp1\\Arquivos\\vendas.json";

// Garante que o diretório existe
Directory.CreateDirectory(Path.GetDirectoryName(path));

// Cria o arquivo JSON
File.WriteAllText(path, jsonSerializer);
*/

/*Consumindo_Json_local
string conteudoArquivo = File.ReadAllText("C:\\Users\\Admin\\source\\repos\\WebApiRest\\ConsoleApp1\\Arquivos\\vendas.json");


List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);   

foreach(Venda venda in listaVenda)
{
    Console.WriteLine($"ID: {venda.Id}\n" +
        $"Produto: {venda.Produto}\n" +
        $"Preço: {venda.Preco.ToString("C2", new CultureInfo("pt-BR"))}\n" +
        $"Data:{venda.DataVenda.ToString("dd/MM/yyyy")}\n");
}
*/


Console.WriteLine("Informe seu CEP:");
string cep =
    Console.ReadLine();

using var httpClient = new HttpClient();
var url = $"https://brasilapi.com.br/api/cep/v1/{cep}";

var response = await httpClient.GetAsync(url);
response.EnsureSuccessStatusCode();

var json = await response.Content.ReadAsStringAsync();
var resultado = JsonConvert.DeserializeObject<Cep>(json);


// Exibindo os dados
Console.WriteLine($"\nCEP: {resultado.cep}");
Console.WriteLine($"Estado: {resultado.state}");
Console.WriteLine($"Cidade: {resultado.city}");
Console.WriteLine($"Bairro: {resultado.neighborhood}");
Console.WriteLine($"Rua: {resultado.street}");
Console.WriteLine($"Fonte: {resultado.service}");