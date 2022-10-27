using System;

for(int i = 0; i < 250; i++)
{
    World.players[i] = new Cooperador();
}
for(int i = 250; i < 500; i++)
{
    World.players[i] = new Egoista();
}


public class World
{
    public Player[] players= new Player [500];
    public int total{get;set;}
    public int round{get;set;}
    public int falidos{get;set;}
    public void Operation(Player player1, Player player2)
    {
        if (player1.Moedas > 0 && player2.Moedas > 0)
            if (player1.Decide() && player2.Decide())
            {
                player1.Moedas++;
                player2.Moedas++;
            }
            else if (player1.Decide() && player2.Decide() == false)
            {
                player1.Moedas += 3;
                player2.Moedas -= 1;
            }
            else if (player1.Decide() == false && player2.Decide())
            {
                player1.Moedas -= 1;
                player2.Moedas += 3;
            }
            else if (player1.Decide()==false && player2.Decide() == false)
            {
                player1.Moedas += 3;
                player2.Moedas -= 1;
            }
        else if (player1.Moedas <= 0 || player2.Moedas <= 0)
            falidos++;
        else if (player1.Moedas <= 0 && player2.Moedas <= 0)
            falidos+=2;
    }
}


public abstract class Player
{
    public int Moedas { get; set; } = 2;
    public abstract bool Decide();
    public abstract void Recebe(int moedas);
}


public class Cooperador : Player
{

    public override bool Decide() => true;


    public override void Recebe(int moedas)
    {
        
    }
}


public class Egoista : Player
{

    public override bool Decide() => false;

    public override void Recebe(int moedas)
    {
        
    }
}


public class Remorse : Player
{
    public bool remorse = false;
    public override bool Decide() => !remorse;

    public override void Recebe(int moedas)
    {
        if (moedas == 0)
        {
             remorse = true;
        }
    }
}


public class CopyCat : Player
{
    public bool copy = true;
    public override bool Decide() => copy;

    public override void Recebe(int moedas)
    {
        if (moedas == 0)
        {
             copy = false;
        }
        else if (moedas > 0)
        {
             copy = true;
        }
    }
}