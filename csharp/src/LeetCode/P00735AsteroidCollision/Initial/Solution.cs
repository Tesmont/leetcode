namespace LeetCode.P00735AsteroidCollision.Initial;

/// <summary>
/// LeetCode 735. Asteroid Collision.
/// https://leetcode.com/problems/asteroid-collision/
/// </summary>
public sealed class Solution
{
    public int[] AsteroidCollision(int[] asteroids)
    {
        Span<int> stack = stackalloc int[asteroids.Length];
        int count = 0;

        foreach (int asteroid in asteroids)
        {
            bool isDestroyed = false;
            while (count > 0
                && stack[count - 1] > 0 && asteroid < 0)
            {
                int asteroidAbs = Math.Abs(asteroid);
                int topAsteroidAbs = stack[count - 1];

                if (asteroidAbs == topAsteroidAbs)
                {
                    isDestroyed = true;
                    count--;
                    break;
                }

                if (topAsteroidAbs > asteroidAbs)
                {
                    isDestroyed = true;
                    break;
                }

                count--;
            }

            if (!isDestroyed)
            {
                stack[count++] = asteroid;
            }
        }

        return stack[..count].ToArray();
    }
}
