using ConsoleApp1.Model;
using Newtonsoft.Json;

/* Lendo Arquivo
////Lendo um aruivo txt comum
//var readMe = File.ReadAllLines("C:\\Users\\Admin\\source\\repos\\WebApiRest\\ConsoleApp1\\Arquivos\\ReadMe.txt");

//foreach (var line in readMe)
//{
//    Console.WriteLine(line);
//}
*/


List<Venda> listaVenda = new List<Venda>();

Venda v1 = new Venda(1, "Material de Escritório", 25.00M);
Venda v2 = new Venda(2, "Licença de Software", 110.00M);

listaVenda.Add(v1);
listaVenda.Add(v2);


//Serializar
string jsonSerializer = JsonConvert.SerializeObject(v1,Formatting.Indented);
Console.WriteLine(jsonSerializer);

//Criando um arquivo .json na pasta arquivos
File.WriteAllText("C:\\Users\\Admin\\source\\repos\\WebApiRest\\ConsoleApp1\\Arquivos\\vendas.json", jsonSerializer);
