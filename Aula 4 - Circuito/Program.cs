// See https://aka.ms/new-console-template for more information
public abstract class Porta
{
    public int Entrada {get; set;}
    public int Saida {get; set;}
    public int Valor {get; set;}

    public abstract void Verificacao (int Enter);
}


public class And : Porta
{
    public And()
    {
        this.Valor = 0;
        this.Saida = 0;
    }

    public override void Verificacao(int Enter)
    {
        
    }
}

public class Or : Porta
{
    public override void Verificacao(int Enter)
    {
        throw new NotImplementedException();
    }
}
public class Not : Porta

{
    public override void Verificacao(int Enter)
    {
        throw new NotImplementedException();
    }
}

public abstract class Entrada 
{
    public int enter;
    public abstract void Connect (Porta porta);
}
