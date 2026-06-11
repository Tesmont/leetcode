using LeetCode.P00155MinStack.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00155MinStack.SolutionTestCases;

namespace LeetCode.Tests.P00155MinStack.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.MinStackCases), MemberType = typeof(RootSolutionTestCases))]
    public void Operations_ReturnExpectedResults(string[] operations, int?[] arguments, object?[] expected)
    {
        MinStack stack = new();

        for (int i = 0; i < operations.Length; i++)
        {
            object? actual = operations[i] switch
            {
                "Push" => Push(stack, arguments[i]),
                "Pop" => Pop(stack),
                "Top" => stack.Top(),
                "GetMin" => stack.GetMin(),
                _ => throw new System.InvalidOperationException(),
            };

            Assert.Equal(expected[i], actual);
        }
    }

    private static object? Push(MinStack stack, int? argument)
    {
        if (argument is null)
        {
            throw new System.InvalidOperationException();
        }

        stack.Push(argument.Value);

        return null;
    }

    private static object? Pop(MinStack stack)
    {
        stack.Pop();

        return null;
    }
}
