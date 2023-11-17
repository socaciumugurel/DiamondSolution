using DiamondProject;

namespace Tests
{
    public class DiamondBuilderUnitTests
    {
        [Theory, MemberData(nameof(Data))]
        public void DiamondBuilder_ReturnCorrectResult(
            char midpointChar, 
            List<List<char>> expectedResult)
        {
            //Arrange
            var diamondBuilder = new DiamondBuilder();

            //Act
            var diamond = diamondBuilder
                .SetMidPointChar(midpointChar)
                .BuildDiamond()
                .GetDiamond();

            //Assert
            var areSequencesEqual = CompareListOfLists(expectedResult, diamond);
            Assert.True(areSequencesEqual);
        }

        private static bool CompareListOfLists(List<List<char>> expectedResult, List<List<char>> diamond)
        {
            for (int i = 0; i < diamond.Count; i++)
            {
                if (!diamond[i].SequenceEqual(expectedResult[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public static IEnumerable<object[]> Data()
        {
            yield return new object[] { 'a', new List<List<char>> { new() { 'A' } } };

            yield return new object[] { 'b', new List<List<char>>
            {
                new() { ' ','A' },
                new() { 'B',' ', 'B' },
                new() { ' ','A' },
                }
            };

            yield return new object[] { 'd', new List<List<char>>
                {
                    new() { ' ', ' ', ' ', 'A' },
                    new() { ' ', ' ', 'B', ' ', 'B' },
                    new() { ' ', 'C', ' ', ' ', ' ', 'C' },
                    new() { 'D', ' ', ' ', ' ', ' ', ' ', 'D' },
                    new() { ' ', 'C', ' ', ' ', ' ',  'C' },
                    new() { ' ', ' ', 'B', ' ', 'B' },
                    new() { ' ', ' ', ' ', 'A' },
                }
            };
        }
    }
}