// See https://aka.ms/new-console-template for more information
using ConsoleApp_Manha;

Console.WriteLine("Hello, World!");

Produto p1 = new Produto(1, "Mouse sem fio", 59.90M);
Console.WriteLine( p1.getDescricao() + " " + p1.getValor() );

Cliente npc1 = new Cliente("Matheus", 1, 99999999);


Console.WriteLine("ID:"+npc1.getId() + " Nome:"+npc1.getNome() + " Telefone:"+npc1.getTelefone());

if (npc1.getId() == 1)
{
    npc1.setNome("Jarlinson");
    npc1.setTelefone(888888888);
}

Console.WriteLine("ID:" + npc1.getId() + " Nome:" + npc1.getNome() + " Telefone:" + npc1.getTelefone());