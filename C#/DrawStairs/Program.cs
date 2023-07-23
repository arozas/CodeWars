
Console.WriteLine(Kata.DrawStairs(1));
Console.WriteLine(Kata.DrawStairs(2));
Console.WriteLine(Kata.DrawStairs(3));

public class Kata
{
    public static string DrawStairs(int n)
    {
        string stairs = "";
        for (int i = 0; i < n; i++)
        {
            stairs += new string(' ', i) + "I\n";
        }
        return stairs.TrimEnd();
    }
}