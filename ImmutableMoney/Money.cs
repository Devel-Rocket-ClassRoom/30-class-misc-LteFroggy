using System;

class Money {
    private int _gold;
    private int _silver;

    public int Gold => _gold;
    public int Silver => _silver;

    public Money(int gold, int silver) {
        _gold = gold; _silver = silver;
    }

    public Money Add(int gold, int silver) => new Money(Gold + gold, Silver + silver);
    public Money Subtract(int gold, int silver) {
        return new Money(
            Math.Clamp(Gold - gold, 0, Int32.MaxValue),
            Math.Clamp(Silver - silver, 0, Int32.MaxValue)
        );
    }
    public override string ToString() => $"{Gold}골드 {Silver}실버";
}