using LeetCode.P00232ImplementQueueUsingStacks.Initial;
using Xunit;
using RootSolutionTestCases = LeetCode.Tests.P00232ImplementQueueUsingStacks.SolutionTestCases;

namespace LeetCode.Tests.P00232ImplementQueueUsingStacks.Initial;

public sealed class SolutionTests
{
    [Theory]
    [MemberData(nameof(RootSolutionTestCases.ImplementQueueUsingStacksCases), MemberType = typeof(RootSolutionTestCases))]
    public void Operations_ReturnExpectedResults(string[] operations, int?[] arguments, object?[] expected)
    {
        MyQueue queue = new();

        for (int i = 0; i < operations.Length; i++)
        {
            object? actual = operations[i] switch
            {
                "Push" => Push(queue, arguments[i]),
                "Pop" => queue.Pop(),
                "Peek" => queue.Peek(),
                "Empty" => queue.Empty(),
                _ => throw new System.InvalidOperationException(),
            };

            Assert.Equal(expected[i], actual);
        }
    }

    private static object? Push(MyQueue queue, int? argument)
    {
        if (argument is null)
        {
            throw new System.InvalidOperationException();
        }

        queue.Push(argument.Value);

        return null;
    }
}
