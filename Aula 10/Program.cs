using System;

Jogo.Iniciar();

public abstract class Maquina
{
    public string Name {get; protected set;}
    public int Producao {get; protected set;}
    public int Quantidade {get; set;}
    public int Valor {get;  set;}
    public int Prod {get; protected set;}


    public abstract int produzir ();
}


public class Britadeira : Maquina
{
    public Britadeira()
    {
        this.Name = "Britadeira";
        this.Producao = 2;
        this.Quantidade = 0;
        this.Valor = 10;
        this.Prod = 0;
    }

    public override int produzir()
    {
        Prod = this.Producao * this.Quantidade;
        return Prod;
    }
}

public class Gerador_de_Elixir : Maquina
{
    public Gerador_de_Elixir()
    {
        this.Name = "Gerador de Elixir";
        this.Producao = 3;
        this.Quantidade = 0;
        this.Valor = 15;
        this.Prod = 0;
    }

    public override int produzir()
    {
        Prod = this.Producao * this.Quantidade;
        return Prod;
    }
}

public class Mina_de_Diamante : Maquina
{
    public Mina_de_Diamante()
    {
        this.Name = "Mina de Diamante";
        this.Producao = 5;
        this.Quantidade = 0;
        this.Valor = 30;
        this.Prod = 0;
    }

    public override int produzir()
    {
        Prod = this.Producao * this.Quantidade;
        return Prod;
    }
}

public class Trevisan_Bombado : Maquina
{
    public Trevisan_Bombado()
    {
        this.Name = "Trevisan Bombado";
        this.Producao = 100;
        this.Quantidade = 0;
        this.Valor = 10000;
        this.Prod = 0;
    }

    public override int produzir()
    {
        Prod = this.Producao * this.Quantidade;
        return Prod;
    }
}

public class Maite_chatona : Maquina
{
    public Maite_chatona()
    {
        this.Name = "Maite Chatona";
        this.Producao = 1000000;
        this.Quantidade = 0;
        this.Valor = 100000000;
        this.Prod = 0;
    }

    public override int produzir()
    {
        Prod = this.Producao * this.Quantidade;
        return Prod;
    }
}


public static class Jogo
{
    public static int Dinheiro {get; set;} = 0;

    public static Britadeira Britadeira {get; set;} = new Britadeira(); 
    public static Gerador_de_Elixir Gerador {get; set;} = new Gerador_de_Elixir(); 
    public static Mina_de_Diamante Mina {get; set;} = new Mina_de_Diamante(); 
    public static Trevisan_Bombado Trevis {get; set;} = new Trevisan_Bombado(); 
    public static Maite_chatona Maite {get; set;} = new Maite_chatona();


    public static void Iniciar()
    {    
        while (true)
        {
            Console.Clear();
            int Producao_atual = (Britadeira.produzir() + Gerador.produzir() + Mina.produzir() + 
            Trevis.produzir() + Maite.produzir()) + 1;
            Console.WriteLine($"Seu dinheiro: {Dinheiro} ------------------------------------------- Produção Atual: {Producao_atual}\n\n\n\n\n");
            Console.WriteLine($"BRITADEIRA (1) ------------- {Britadeira.Valor}$ ------------- Produção por clique: {Britadeira.Prod}$ ------------- NIVEL: {Britadeira.Quantidade}");
            Console.WriteLine($"GERADOR DE ELIXIR (2) ------------- {Gerador.Valor}$ ------------- Produção por clique: {Gerador.Prod}$ ------------- NIVEL: {Gerador.Quantidade}");
            Console.WriteLine($"MINA DE DIAMANTE(3) ------------- {Mina.Valor}$ ------------- Produção por clique: {Mina.Prod}$ ------------- NIVEL: {Mina.Quantidade}");
            Console.WriteLine($"TREVISAN BOMBADO(4) ------------- {Trevis.Valor}$ ------------- Produção por clique: {Trevis.Prod}$ ------------- NIVEL: {Trevis.Quantidade}");
            Console.WriteLine($"MAITE CHATONA PKRL(5) ------------- {Maite.Valor}$ ------------- Produção por clique: {Maite.Prod}$ ------------- NIVEL: {Maite.Quantidade}");

            var Clique = Console.ReadKey().Key;
            if (Clique == ConsoleKey.D0)
                Dinheiro += Producao_atual;

            
            else if (Clique == ConsoleKey.D1)
            {
                if (Dinheiro >= Britadeira.Valor)
                {
                    Britadeira.Quantidade += 1;
                    Dinheiro -= Britadeira.Valor;
                    Britadeira.Valor += Britadeira.Valor;
                }
                else
                    Console.WriteLine("Você não possui dinheiro o suficiente!");

            }

            else if (Clique == ConsoleKey.D2)
            {
                if (Dinheiro >= Gerador.Valor)
                {
                    Gerador.Quantidade += 1;
                    Dinheiro -= Gerador.Valor;
                    Gerador.Valor += Gerador.Valor;
                }
                else
                    Console.WriteLine("Você não possui dinheiro o suficiente!");

            }

            else if (Clique == ConsoleKey.D3)
            {
                if (Dinheiro >= Mina.Valor)
                {
                    Mina.Quantidade += 1;
                    Dinheiro -= Mina.Valor;
                    Mina.Valor += Mina.Valor;
                }
                else
                    Console.WriteLine("Você não possui dinheiro o suficiente!");

            }

            else if (Clique == ConsoleKey.D4)
            {
                if (Dinheiro >= Trevis.Valor)
                {
                    Trevis.Quantidade += 1;
                    Dinheiro -= Trevis.Valor;
                    Trevis.Valor += Trevis.Valor;
                }
                else
                    Console.WriteLine("Você não possui dinheiro o suficiente!");

            }

            else if (Clique == ConsoleKey.D5)
            {
                if (Dinheiro >= Maite.Valor)
                {
                    Maite.Quantidade += 1;
                    Dinheiro -= Maite.Valor;
                    Maite.Valor += Maite.Valor;
                }
                else
                    Console.WriteLine("Você não possui dinheiro o suficiente!");

            }
            
        }
    }
}