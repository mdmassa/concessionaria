using System;

class Carro {
    private string marca;
    private string modelo;
    private string cor;
    private int ano;
    private double preco;

    public Carro(string marca, string modelo, string cor, int ano, double preco) {
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
        this.ano = ano;
        this.preco = preco;
    }

    public void verInformacao() {
        string precoFormatado = preco.ToString("C2", new System.Globalization.CultureInfo("pt-BR"));
        Console.WriteLine($"\n\nInformações do veículo\n\nMarca: {marca}\nModelo: {modelo}\nCor: {cor}\nAno: {ano}\nPreço: {precoFormatado}");
    }
}