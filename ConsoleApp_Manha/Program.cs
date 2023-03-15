using ConsoleApp_Manha;

Console.WriteLine("Hello, World!");

Produto p1 = new Produto(1, "Mouse sem fio", 59.90M);
Console.WriteLine( p1.getDescricao() + " " + p1.getValor() );
 Endereco e1 = new Endereco("Mario Miziara","91", "91123-20", "12901290", "Matão", "São Paulo");

 Cliente c1 = new Cliente("Roberson",1, 339898998, e1);
Cliente c2 = new Cliente("Ramiro", 2, 323423498, e1);
Cliente c3 = new Cliente("Teddy", 3, 332566698, e1);
Cliente c4 = new Cliente("Danilo", 4, 332348998, e1);

Console.WriteLine(c1.getEndereco().EnderecoCompleto());

Carro car = new Carro();

car.Marca = "BMW";
car.numeroPortas = 4;
car.numeroRodas = 4;
car.cor = "Vermelho";

Aviao aviao = new Aviao();
aviao.portaInterna = 50;
aviao.numeroPortas = 1;
aviao.numeroRodas = 3;
aviao.cor = "Branco";
aviao.quantidadeAcentos = 500;
aviao.pagaImposto = false;

Bike bicicleta = new Bike();
Console.WriteLine(aviao.ExibirDados());
Console.WriteLine(car.ExibirDados());

List<Veiculos> listaVeiculos = new List<Veiculos>();
listaVeiculos.Add(aviao);
listaVeiculos.Add(car);
listaVeiculos.Add(bicicleta);

List<Cliente> listaCliente = new List<Cliente>();
listaCliente.Add(c1);
listaCliente.Add(c2);
listaCliente.Add(c3);
listaCliente.Add(c4);

foreach (var item in listaCliente)
{
    Console.WriteLine(item.getNome());
}