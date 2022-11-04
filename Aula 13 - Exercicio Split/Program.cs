// string[] ListaVacinasAstra = new string[]
//     {"NECA", "NICA", "NEZA", "NEKA", "NIKA"};
// var coll = "LAB_PR_COV.csv"
//     .Open()
//     .Skip(1) //pula o 1 
//     .ToListContains(ListaVacinasAstra, Vacinas.astra); //transf em lista






// MeuDelegate func = delegate(string s)
// {
//     Console.WriteLine("Função anonima diz: " + s);
// };
// ChameNvezes(func,1);


// ChameNvezes(Console.WriteLine, 10);
// ChameNvezes(MeuPrint, 1);


// MeuDelegate func2 = s => Console.WriteLine("Lambda diz: " + s);
// ChameNvezes(func2,1);



// void MeuPrint(string s)
// {
//     Console.WriteLine("Mensagem: " + s);
// }



// void ChameNvezes(MeuDelegate f, int n)
// {
//     for (int i = 0; i < n; i++)
//     {
//         f("Ola mundo");
//     }
// }

int[] valores = new int[] {1,2,3,4,5};

Transformador<int> funcao = s => s*s;

foreach (var x in Transforme(valores, funcao))
{
    Console.WriteLine(x);
}

int[] Transforme(int[] entrada, Transformador<int> t)
{
    for(int i = 0; i < entrada.Length; i++)
    {
        entrada[i] = t(entrada[i]);
    }
    return entrada;
}



public delegate void MeuDelegate(string x);
public delegate T Transformador<T>(T n);

// public static class MyExtensionMethods
// {
//     // public static void Mostrar(List<string> lista)
//     // {
//     //     foreach (var line in lista)
//     //         Console.WriteLine(line);
//     // }
//     public static IEnumerable<T> Skip<T>(this IEnumerable<T> coll, int N) //this pq é um emtodo iterador - yield é de metodo de extensao
//     {
//         var it = coll.GetEnumerator();
//         for (int i = 0; i < N && it.MoveNext(); i++);

//         while (it.MoveNext())
//             yield return it.Current;
//     }

//     public static IEnumerable<T> Take<T>(this IEnumerable<T> coll, int N)
//     {
//         var it = coll.GetEnumerator();
//         for (int i = 0; i < N && it.MoveNext(); i++);
//             yield return it.Current;
//     }

//     public static List<T> TolIst<T>(this IEnumerable<T> coll)
//     {
//         List<T> list = new List<T>();
//         var it = coll.GetEnumerator();
//         while(it.MoveNext())
//             list.Add(it.Current);
//         return list;
//     }
//     public static List<string> ToListContains(this IEnumerable<string> coll, string[]  PalavraProc, List<string> tpVacina) 
//     {
//         var it = coll.GetEnumerator();
//         while(it.MoveNext())
//         {
//             for (int i = 0; i < PalavraProc.Length; i ++)
//             {
//                 var line = it.Current;
//                 bool contains = line.Contains(PalavraProc[i]);
//                 if (contains)
//                 {
//                     tpVacina.Add(it.Current);
//                 }
//             }
//         } 

//         foreach (var linha in tpVacina)
//                 Console.WriteLine(linha); 

//         return tpVacina;
//     }

//     public static int Count<T>(this IEnumerable<T> coll)
//     {
//         int count = 0;
//         var it = coll.GetEnumerator();
//         while (it.MoveNext()) 
//             count++;

//         return count;
//     }

//     public static T LastORDefault<T>(this IEnumerable<T> coll)
//     {
//         int count = 0;
//         var it = coll.GetEnumerator();
//         while (it.MoveNext()) 
//             count++;
    
//         return count == 0 ? default(T) : it.Current; 

//         // if (count == 0) //equivale a linha de cima
//         //     yield return default(T);

//         // else yield return it.Current;  
//     }

//     public static IEnumerable<T> Append<T>(this IEnumerable<T> coll, T item)
//     {
//         var it = coll.GetEnumerator(); //pega o iterador
//         while (it.MoveNext()) //enqt houver prox 
//             yield return it.Current; //retornar o atual

//         yield return item; //adiciona o elemento apenas na coleção atual, ou swja nao muda na lista original
//     }
    
//     public static IEnumerable<T> Prepend<T>(this IEnumerable<T> coll, T item)
//     {
//         yield return item; //retorna o elemento antes da lista original

//         var it = coll.GetEnumerator();
//         while (it.MoveNext())  //ou foreach (var x in coll) 
//             yield return it.Current; 
//     }

//     public static T FirstOrDefault<T>(this IEnumerable<T> coll)
//     {
//         var it = coll.GetEnumerator();
//         return it.MoveNext() ? it.Current : default(T); //o it pegou o prim it, caso haja um seguinte ele retorna o atual(o first)
//     }

//     public static T[] ToArray<T>(this IEnumerable<T> coll)
//     {
//         T[] array = new T[coll.Count()]; //a coll recebida chama a função count para definir o tam do arr

//         var it = coll.GetEnumerator(); 
//         for(int i = 0; it.MoveNext(); i++) //loop enqt houver prox iterador 
//             array[i] = it.Current; //array novo é construido com o iterador atual

//         return array;
//     }

//     public static IEnumerable<string> Open(this string file)
//     {
//         var stream = new StreamReader(file);

//         while(!stream.EndOfStream)
//         {
//             var line = stream.ReadLine();
//             yield return line;
//         }

//         stream.Close();
//     }

//     public static IEnumerable<string[]> Split(this IEnumerable<string> coll)
//     {
//         foreach (var el in coll)
//             yield return el.Split(";");
//     }
// }