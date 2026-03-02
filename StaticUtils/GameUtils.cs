using System;
using System.Transactions;

static class GameUtils
{
    public static int Clamp(int value, int min, int max) {
        return Math.Clamp(value, min, max);
    }
    public static double GetPercentage(int current, int max) {
        return (double)current / max * 100;
    }
    public static bool IsInRange(int value, int min, int max) {
        return value >= min && value <= max;
    }
}