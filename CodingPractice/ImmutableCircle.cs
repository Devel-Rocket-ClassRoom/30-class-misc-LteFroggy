
using System;

class ImmutableCircle {
    public int Radius { get; }

    public ImmutableCircle() : this(10) { }
    public ImmutableCircle(int radius) {
        Radius = radius;
    }

    public ImmutableCircle WithRadius(int radius) {
        return new ImmutableCircle(radius);
    }
}