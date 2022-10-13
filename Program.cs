using System;

// //tipos de variáveis
// char c = 'a';
// string str = "Olá mundo";

// byte b = 200;
// short s = short.MinValue;
// int i = 300;
// long l = 3000000000;

// float f = 2.5f;
// double d = 2.5;
// double d1 = double.Epsilon;
// double d2 = double.NaN;
// decimal m = 5.0m;

// sbyte sb = -100;
// ushort us = 20938;
// uint ui = 300;
// ulong ul = 30000;


// object obj = s;
// string str2 = (string)obj;

// int result = (int)(ui + l);

// int num = (int)(ui+ul);

// dynamic dy = 8;
// dy = "Ola, mundo!";


// //identifica o tipo de variavel
// var x = 7;




// //vetores
// int[] arr = new int[10];
// object[] objs = new object[100];
// var arr2 = new double[3];

// arr[0] = 4;
// var arr3 = arr[0..1];






// Console.WriteLine(num);
// Console.WriteLine(8);
// Console.WriteLine(1.0/0.0);


// //usos de tecnica null
// int? y = null;


// string s3 = null;
// string s4 = s3?.Replace('a','b') ?? "Erro"; // troca as letras a pela letra b na variável, caso não funcione, escreva o texto "Erro"

// Console.WriteLine(y ?? 7); // caso y seja nulo, retorne o valor 7
// Console.WriteLine(s4);











// //FUNÇÕES
// Console.WriteLine("------- AQUI COMEÇAM AS FUNÇÕES -------");
// int a = 3;


// // Função IF
// if (a<10)
// {
//     Console.WriteLine(a);
// }
// else if (a < 15)
// {
//     Console.WriteLine("Muito forte!");
// }
// else 
// {
//     Console.WriteLine("...");
// }


// // Função Switch Case
// switch(i)
// {
//     case 3:
//         Console.WriteLine(3);
//         goto case 5;
//     case 4:
//         Console.WriteLine(4);
//         break;
//     case 5:
//         Console.WriteLine("Bom dia!");
//         break;
//     default:
//         Console.WriteLine("Não sei");
//         break;
// }


// //Função While

// while(i < 10){
//     Console.WriteLine("Bom dia!!!");
// }


// //Função FOR
// for (int j = 0; j < 10; j++)
// {
//     Console.WriteLine("Oi!");
// }


// //FOR com arr
// int[] arrfor = new int[100];

// for (int k = 0; k < arrfor.Length; k++)
// {
//     arrfor[k] = 1;
// }

// //Função FOREACH
// foreach (int n in arrfor)
// {
//     Console.WriteLine(n);
// }

// MERGESORT


int[] arrmerge = new int[] {8,4,2,5,4,1,7,9,6};

void mergesort(int[] arrmerge)
{
    int e = arrmerge.Length;
    int[] arraux = new int[e];
    mergesortrec(arrmerge, arraux, 0, e);

}

mergesort(arrmerge);

foreach (var x in arrmerge)
{
    Console.Write($"{x}, ");
}

void mergesortrec(
    int[] arrmerge, 
    int[] arraux, 
    int s, int e)
{
    if (e - s < 2)
    {
        return;
    }

    int p = (s+e)/2;
    mergesortrec(arrmerge, arraux, s, p);
    mergesortrec(arrmerge, arraux, p, e);
    merge(arrmerge, arraux,  s, p, e);
}


void merge(
    int [] arrmerg, 
    int[] arraux,
    int s, int p, int e)
{
    int i = s, j = p, k = s;
    while (i < p && j < e)
    {
        if (arrmerge[i] < arrmerge[j])
        {
            arraux[k] = arrmerg[i];
            i++;
            k++;
        }
        else 
        {
            arraux[k] = arrmerg[j];
            j++;
            k++;
        }
    }

    while (i < p)
    {
        arraux[k] = arrmerg[i];
        i++;
        k++;
    }

    while (j < e)
    {
        arraux[k] = arrmerg[j];
        j++;
        k++;
    }

    for(int t = s; t < e; t++)
    {
        arrmerg[t] = arraux[t];
    }
}