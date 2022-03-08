// See https://aka.ms/new-console-template for more information

using System.Text;

Console.WriteLine("Please type a sentance to mirror:");

string? inputStr = Console.ReadLine();

if (string.IsNullOrEmpty(inputStr))
    return;

string[] arr = inputStr.Split(" ");

StringBuilder outputStr = new StringBuilder();
for(int i = arr.Length -1; i>=0; i--)
{
    if(i != 0)
        outputStr.Append(ReverseString(arr[i]) + " ");
    else
        outputStr.Append(ReverseString(arr[i]));
}

Console.WriteLine(outputStr);


static string ReverseString(string str)
{
    string result = "";
    if (string.IsNullOrEmpty(str))
        return string.Empty;

    for (int i = str.Length - 1; i >= 0; i--)
        {
            result += str[i];
        }
    return result;
}

Console.ReadLine();