// See https://aka.ms/new-console-template for more information

Edjalma edjalma = new Edjalma();
Edjalma edjalmaagressivo = new Edjalma();
Sword sword = new Sword();
edjalmaagressivo.Weapon = sword;
edjalmaagressivo.Attack(edjalma);

Console.WriteLine(edjalma.Life);
public abstract class Entity
{
    public string Name {get; protected set;}
    public int Life { get;  set;}
    public int Damage {get; protected set;}
    public Weapon Weapon { get;  set;}
    public int Shield { get; set;}
    public int Mana {get; set;}
    public Magic Magic { get;  set;}

    public abstract void Attack (Entity target);
    public abstract void ReciveDamage(int damage);
    public abstract void Poderzinho(Entity target);
}





public abstract class Weapon
{
    public string Name {get; protected set;}
    public int Damage { get; protected set;}
}


public abstract class Magic
{
    public string Name {get; protected set;}
    public int Damage { get; protected set;}
    public int Custo { get; protected set;}
}




public class Edjalma : Entity
{
    public Edjalma()
    {
        this.Name = "Edjalma";
        this.Life = 200;
        this.Damage = 10;
        this.Shield = 50;
        this.Mana = 100;
    }

    public override void Attack (Entity target)
    {
        int damage = this.Damage / 2
            + this.Weapon.Damage * 2;
        target.Life -= damage;
    }

    public override void ReciveDamage(int damage)
    {
        if (this.Shield > 0)
        {
            if (this.Shield > damage)
            {
                this.Shield = 0;
                return;
            }
            else
            {
                damage -= this.Shield;
                this.Shield = 0;
            }
        }
        this.Life -= damage;
    }

    public override void Poderzinho(Entity target)
    {
        int dano = this.Magic.Damage;
    }
}




public class Fabão : Entity
{
    public Fabão()
    {
        this.Name = "Fabão";
        this.Life = 250;
        this.Damage = 5;
        this.Mana = 100;
    }


    public override void Attack (Entity target)
    {
        int damage = this.Damage / 2
            + this.Weapon.Damage * 2;
        
        target.ReciveDamage(damage);
    }


    public override void ReciveDamage(int damage)
    {
        if (this.Life < 10)
        {
            this.Life += 3;
        }

        this.Life -= damage;

    }

    public override void Poderzinho(Entity target)
    {
        throw new NotImplementedException();
    }
}




public class Sword : Weapon
{
    public Sword()
    {
        this.Name = "Espada";
        this.Damage = 20;
    }
}

public class LongSword : Weapon
{
    public LongSword()
    {
        this.Name = "Espada Longa";
        this.Damage = 30;
    }
}

public class BolaDeFogo : Magic
{
    public BolaDeFogo()
    {
        this.Name = "Bola de Fogo";
        this.Damage = 40;
        this.Custo = 20;
    }
}

