string input = Console.ReadLine();
int count = 0;
string number = "";
int convertedNumber = 0;
for (int i=0; i<input.Length; i++)
{
    if (input[i] == ',')
    {
        convertedNumber = Convert.ToInt32(number);
        if (convertedNumber > 0)
        {
            count += 1;
        }
        number = "";
        continue;
    }
    number += input[i];
}
Console.WriteLine(count);