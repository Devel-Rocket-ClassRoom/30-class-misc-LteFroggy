class Vector2D {
    public readonly double x;
    public readonly double y;

    public Vector2D(double x, double y) {
        this.x = x; this.y = y;
    }

    public Vector2D Add(double x, double y) => new Vector2D(this.x + x, this.y + y);
    public Vector2D Multiply(double scalar) => new Vector2D(x * scalar, y * scalar);
    public override string ToString() => $"({x}, {y})";
}