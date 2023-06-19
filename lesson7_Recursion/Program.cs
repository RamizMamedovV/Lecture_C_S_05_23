// string NumberRecursion(int a, int b)
// {
//     if (a > b) return NumberRecursion(a - 1, b) + ($"{a} ");
//     else return string.Empty;
// }

// int Factorial(int i)
// {
//     if (i == 1) return 1;
//     else return i * Factorial(i - 1);
// }

// int PowerRec(int a, int n)
// {
//     return n == 0 ? 1 : PowerRec(a, (n - 1)) * a;
// }

// Console.WriteLine(PowerRec(3, 4));

// int n = 1;
// int m = 1;
// int c = 1;
// void FindWords(string alf, char[] word, int length = 0)
// {
//     if (length == word.Length)
//     {
//         Console.WriteLine($"{n++} {new String(word)}"); return;
//     }

//     for (int i = 0; i < alf.Length; i++)
//     {
//         //Console.WriteLine($"{m++}m= {length}");
//         word[length] = alf[i];
//         FindWords(alf, word, length + 1);
//     }
//     //Console.WriteLine($"{c++}c= {length}");
// }

// FindWords("asd", new char[2]);

string emp = String.Empty;
string[] tree = {emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"};
//                 0,   1,   2,    3,   4,   5,   6,   7,   8,   9,  10   11

void InOrderTraversal(int pos =1)
{
    if(pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        if(left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        Console.Write($"{tree[pos]} ");
        if(right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
    }
}

InOrderTraversal();
