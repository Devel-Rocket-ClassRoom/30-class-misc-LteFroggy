using System;

partial class Character {
    public void TakeDamage(int damage) {
        _health = Math.Clamp(_health - damage, 0, 100);
        Console.WriteLine($"용사이(가) {damage}의 피해를 입음. 남은 체력 : {_health}");
    }
    public void Heal(int amounth) {
        _health = Math.Clamp(_health + amounth, 0, 100);
        Console.WriteLine($"용사이(가) {amounth}만큼 회복함. 현재 체력 : {_health}");
    }
}