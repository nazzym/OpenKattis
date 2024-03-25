using System;

class VideoLengthCalculator
{
    public static double CalculateOriginalLength(int n, int p, int k, int[] timestamps)
    {
        double currentSpeedMultiplier = 1.0; // At the start, the video plays at 100% speed.
        double totalOriginalLength = 0.0; // Total length of the original video.

        for (int i = 0; i < n; i++)
        {
            int segmentDuration;
            if (i == 0)
            {
                // For the first segment, it starts from 0
                segmentDuration = timestamps[i];
            }
            else
            {
                // For subsequent segments, subtract the previous timestamp to get the duration
                segmentDuration = timestamps[i] - timestamps[i - 1];
            }

            // Calculate the original segment duration at the current speed and add it to the total length
            totalOriginalLength += segmentDuration / currentSpeedMultiplier;

            // Update the current speed multiplier to account for the new speed after each event Y
            currentSpeedMultiplier *= (1 + p / 100.0);
        }

        // After processing all segments, add the remaining duration from the last timestamp to the end
        // at the current speed multiplier
        if (timestamps.Length > 0)
        {
            totalOriginalLength += (k - timestamps[n - 1]) / currentSpeedMultiplier;
        }
        else
        {
            // If there are no timestamps, the whole video plays at original speed
            totalOriginalLength = k;
        }

        return totalOriginalLength;
    }

    static void Main(string[] args)
    {
        // Sample usage
        int n = 2;
        int p = 20;
        int k = 15;
        int[] timestamps = { 3, 10 };

        double originalLength = CalculateOriginalLength(n, p, k, timestamps);
        Console.WriteLine($"The original length of the video is approximately {originalLength:F2} seconds.");
    }
}
