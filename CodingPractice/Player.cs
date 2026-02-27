using System.Net.Security;

class Player {
    public string Name  { get; }
    public int Level { get; }

    public Player() : this("용사", 1) { }
    public Player(string name, int level) {
        Name = name;
        Level = level;
    }

    public Player LevelUp() {
        return new Player(Name, Level + 1);
    }
}