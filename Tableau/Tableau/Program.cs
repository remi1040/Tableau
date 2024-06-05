// See https://aka.ms/new-console-template for more information


char[] charArray1 = { 'a', 'b', 'c', 'd' };

char[] charArray2 = { 'e', 'f', 'g', 'h' };

char[] charArray3 = new char[8];

for (int i = 0; i < charArray1.Length; i++)
{
    charArray3[i] = charArray1[i];
}

for (int i = 0; i < charArray2.Length; i++)
{
    charArray3[i+3] = charArray2[i];
}

Console.WriteLine(charArray3);
