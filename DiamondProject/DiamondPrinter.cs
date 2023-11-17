namespace DiamondProject;

public class DiamondPrinter
{
    public void Print(List<List<char>> diamond)
    {
        foreach (var line in diamond)
        {
            foreach (var character in line)
            {
                Console.Write(character);
            }

            Console.WriteLine();
        }
    }
}

