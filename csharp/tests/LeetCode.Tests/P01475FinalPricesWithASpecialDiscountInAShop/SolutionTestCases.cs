using Xunit;

namespace LeetCode.Tests.P01475FinalPricesWithASpecialDiscountInAShop;

public static class SolutionTestCases
{
    public static TheoryData<int[], int[]> FinalPricesCases =>
        new()
        {
            { [8, 4, 6, 2, 3], [4, 2, 4, 2, 3] },
            { [1, 2, 3, 4, 5], [1, 2, 3, 4, 5] },
            { [10, 1, 1, 6], [9, 0, 1, 6] },
            { [5], [5] },
            { [2, 2, 2], [0, 0, 2] },
        };
}
