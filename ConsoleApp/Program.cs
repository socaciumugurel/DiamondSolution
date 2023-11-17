using DiamondProject;

var diamondBuilder = new DiamondBuilder();
var diamondPrinter = new DiamondPrinter();

var diamond = diamondBuilder
    .SetMidPointChar('z')
    .BuildDiamond()
    .GetDiamond();

diamondPrinter.Print(diamond);

Console.ReadKey();