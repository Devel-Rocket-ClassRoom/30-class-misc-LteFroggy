using System;

class Point {
    public readonly int x;
    public readonly int y;

    public Point() : this(0, 0) { }

    public Point(int x, int y) {
        this.x = x;
        this.y = y;
    }

    public Point MoveBy(int dx, int dy) => new Point(x + dx, y + dy);


    public override string ToString() => $"({x}, {y})";
}