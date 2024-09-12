namespace GradingSwitchCase;

internal abstract class Program
{
    private static string GetGrade(int score)
    {
        const int best = 100;
        return score switch
        {
            >= best - 10 => "A",
            >= best - 20 => "B",
            >= best - 30 => "C",
            >= best - 40 => "D",
            >= best - 50 => "E",
            _ => "F"
        };
    }
    
    
    private static void Main()
    {
        Console.Write("Enter scores: ");
        var input = Console.ReadLine(); // 0 4 1 100 22 28 57 80
        var items = new[] { "0" };

        if (!string.IsNullOrEmpty(input)) // If not (null or empty)
        {
            items = input.Split();
        }
        var scores = new int[items.Length]; // Not neccessary, but used in example to show that arrays/lists cant containt multiple types.

        for (var i = 0; i < items.Length; i++)
        {
            if (int.TryParse(items[i], out var score))
            {
                scores[i] = score;
                Console.WriteLine($"Student: {i}, Scores: {scores[i]}, Grade: {GetGrade(scores[i])} ");
                // Alternative use score directly without using the scores[]
                // Console.WriteLine($"Student: {i}, Scores: {score}, Grade: {GetGrade(score)} ");
            }
            else
            {
                Console.WriteLine($"Invalid input: {items[i]}");
            }
        }
    }
}