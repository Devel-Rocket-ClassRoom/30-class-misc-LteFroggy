using System;

class MutableCircle {

    public int Radius { get; set; }

    public MutableCircle() {
        Radius = 10;
    }

    public void GetRadius() => Console.WriteLine($"반지름 : {Radius}");
}