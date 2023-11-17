namespace DiamondProject;

public class DiamondBuilder
{
    private const char START_CHAR = 'A';
    private const char SEPARATOR = ' ';

    private int _size;
    private char _midPointChar;
    private List<List<char>> _diamond = new();

    public DiamondBuilder SetMidPointChar(char midPointChar)
    {
        _midPointChar = midPointChar;
        _size = char.ToUpper(_midPointChar) - START_CHAR;
        return this;
    }

    public List<List<char>> GetDiamond()
    {
        return _diamond;
    }

    public DiamondBuilder BuildDiamond()
    {
        for (int position = 0; position <= _size; position++)
        {
            _diamond.Add(BuildLine(position));
        }

        for (int position = _size - 1; position >= 0; position--)
        {
            _diamond.Add(BuildLine(position));
        }

        return this;
    }

    private List<char> BuildLine(int lineSize)
    {
        var line = new List<char>();

        for (int diamondSize = _size; diamondSize > lineSize; diamondSize--)
        {
            line.Add(SEPARATOR);
        }

        line.Add((char)(START_CHAR + lineSize));

        if (lineSize > 0)
        {
            for (int i = 0; i < 2 * lineSize - 1; i++)
            {
                line.Add(SEPARATOR);
            }

            line.Add((char)(START_CHAR + lineSize));
        }

        return line;
    }
}
