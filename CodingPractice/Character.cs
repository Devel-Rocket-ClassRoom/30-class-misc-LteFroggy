using System;

partial class Character {
    public Character(string name) {
        _name = name;
        _health = 100;
        _level = 1;
        Console.WriteLine($"{_name} - 레벨 : {_level}, 체력 : {_health}");
    }
    private string _name;
    private int _health;
    private int _level;
}