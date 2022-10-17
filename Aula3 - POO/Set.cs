public abstract class Set
{
    public abstract bool IsIn(Set set);
    public abstract Set Union(Set set)
    {
        UnionSet union = new UnionSet();
        union.A = this;
        union.B = set;
        return union;
    }
}






public class EmptySet: Set
{
    public override bool IsIn(Set set)
    {
        return false;
    }

    public override bool Equals(object obj)
    {
        return obj is EmptySet;
    }

    public override Set Union(Set set)
    {
        return set;
    }

    public override Set Intersect(Set set)
    {
        return set;
    }
}





public class UnionSet : Set
{
    public Set A { get; set;}
    public Set B { get; set;}

    public override bool IsIn(Set set)
    {
        return A.Equals(set) || B.Equals(set);
    }

    public override Set Union(Set set)
    {
        throw new System.NotImplementedException();
    }

}


public class Intersect : Set
{
    public Set A { get; set;}
    public Set B { get; set;}

    public override bool IsIn(Set set)
    {
        return A.Equals(set) && B.Equals(set);
    }
}





public class PairSet : Set
{
    public Set A { get; set;}
    public Set B { get; set;}

    public override bool IsIn(Set set)
    {
        return A.Equals(set) || B.Equals(set);
    }

    public override bool Equals(object obj)
    {
        if (obj is PairSet pair)
        {
            return (pair.A.Equals(this.A) && pair.B.Equals(this.B)) 
                || (pair.A.Equals(this.B) && pair.B.Equals(this.A)) 
                || (pair.A.Equals(this.B) && (pair.A.Equals(this.A) 
                || pair.A.Equals(this.B)));


        }
        return false;
    }

}
