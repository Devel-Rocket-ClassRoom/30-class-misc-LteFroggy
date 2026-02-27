using System;
static class GameHelper {
    public static int CalculateDamage(int baseDamage, int level) {
        return baseDamage + level * 5;
    }

    public static bool IsAlive(int health) => health > 0;
    public static string GetHealthStatus(int health, int maxHealth) {
        double ratio = (double)health / maxHealth;
        if (ratio > 0.7) { return "양호"; } 
        else if (ratio > 0.3) { return "주의"; }
        else if (ratio > 0) { return "위험"; }
        else { return "사망"; }
    }
}