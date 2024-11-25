namespace concessionaria;

class Program {
    static void Main(string[] args) {

        Console.Write("Marca: ");
        string marca = Console.ReadLine();

        Console.Write("Modelo: ");
        string modelo = Console.ReadLine();

        Console.Write("Cor: ");
        string cor = Console.ReadLine();
        Console.Write("Ano: ");
        int ano = int.Parse(Console.ReadLine());

        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine());

        Carro carro = new Carro(marca, modelo, cor, ano, preco);

        carro.verInformacao();

    }
}
