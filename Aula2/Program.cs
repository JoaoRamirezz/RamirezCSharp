using System;


int[] arr = new int[] {192,255,89,45,32,99};
string [] binarios = new string[arr.Length/2];
int count = 0;
string final = "";

void dectobin (int[] arr)
{
    foreach (var x in arr)
    {
        int decimalNumber = x;
        int remainder;
        string binary = "";

        while (decimalNumber > 0)
        {
            remainder = decimalNumber % 2;
            decimalNumber /= 2;
            binary = remainder.ToString() + binary;
        }
        
        Console.WriteLine("Binary: " + binary);
        binarios[count] = binary;
        count ++;
    }

    foreach (var b in binarios)
    {
        string bin = b.Substring(0, 4);
        Console.WriteLine("4 primeiros: " + bin);
        final = final + bin;
    }
    Console.WriteLine(final);

}
dectobin(arr);



byte[] result = new byte[arr.Length / 2];
for (int i = 0, j = 0; i < result.Length; i++, j += 2)
{
    result[i] = (byte)((arr[j] & 240) + (arr[j+1] >> 4));
}

foreach (var x in result)
{
    Console.WriteLine(x);
}







