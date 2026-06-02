using System.Text;

namespace LeetCode.P00071SimplifyPath;

/// <summary>
/// LeetCode #71 - Simplify Path.
/// Problem: https://leetcode.com/problems/simplify-path/
/// </summary>
public sealed class Solution
{
    public string SimplifyPath(string path)
    {
        Span<(int StartIndex, int Length)> segments = stackalloc (int, int)[path.Length];
        int segmentCount = 0;

        int segmentStart = 0;
        int currentIndex = 0;
        while (currentIndex < path.Length)
        {
            if (path[currentIndex] != '/')
            {
                currentIndex++;
                continue;
            }

            ProcessSegment(segments);
            currentIndex++;
            segmentStart = currentIndex;
        }

        if (segmentStart != currentIndex)
        {
            ProcessSegment(segments);
        }

        string simplifiedPath = BuildSimplifiedPath(segments);

        return simplifiedPath;

        void ProcessSegment(Span<(int StartIndex, int Length)> segments)
        {
            int segmentLength = currentIndex - segmentStart;
            if (segmentLength == 0)
            {
                return;
            }

            ReadOnlySpan<char> segment = path.AsSpan(segmentStart, segmentLength);
            if (segment.SequenceEqual("."))
            {
                return;
            }

            if (segment.SequenceEqual(".."))
            {
                if (segmentCount > 0)
                {
                    segmentCount--;
                }
                return;
            }

            segments[segmentCount] = (segmentStart, segmentLength);
            segmentCount++;
        }

        string BuildSimplifiedPath(Span<(int StartIndex, int Length)> segments)
        {
            if (segmentCount == 0)
            {
                return "/";
            }

            StringBuilder builder = new(path.Length);
            foreach ((int startIndex, int length) in segments[..segmentCount])
            {
                builder.Append('/');
                builder.Append(path.AsSpan(startIndex, length));
            }

            return builder.ToString();
        }
    }
}
