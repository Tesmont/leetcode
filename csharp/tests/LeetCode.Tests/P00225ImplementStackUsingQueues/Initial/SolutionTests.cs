using LeetCode.P00225ImplementStackUsingQueues.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00225ImplementStackUsingQueues.SolutionTestCases;

namespace LeetCode.Tests.P00225ImplementStackUsingQueues.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.MyStackCases), MemberType = typeof(RootSolutionTestCases))]
    public void Operations_ReturnExpectedResults(string[] operations, int?[] arguments, object?[] expected)
    {
        MyStack stack = new();

        for (int i = 0; i < operations.Length; i++)
        {
            object? actual = operations[i] switch
            {
                "Push" => Push(stack, arguments[i]),
                "Pop" => stack.Pop(),
                "Top" => stack.Top(),
                "Empty" => stack.Empty(),
                _ => throw new System.InvalidOperationException(),
            };

            Assert.Equal(expected[i], actual);
        }
    }

    private static object? Push(MyStack stack, int? argument)
    {
        if (argument is null)
        {
            throw new System.InvalidOperationException();
        }

        stack.Push(argument.Value);

        return null;
    }
}
