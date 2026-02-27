using System;

Console.WriteLine($"=== 초기 화폐 ===");
Money wallet = new Money(100, 50);
Console.WriteLine($"지갑 : {wallet}");
Console.WriteLine();


Console.WriteLine($"=== 화폐 추가 ===");
Money wallet2 = wallet.Add(50, 30);
Console.WriteLine($"추가 후 : {wallet2}");
Console.WriteLine($"원본 지갑 : {wallet}");
Console.WriteLine();

Console.WriteLine($"=== 화폐 차감 ===");
Money wallet3 = wallet.Subtract(20, 30);
Console.WriteLine($"차감 후 : {wallet3}");
Console.WriteLine($"원본 지갑 : {wallet}");
Console.WriteLine();

Console.WriteLine($"=== 메서드 체이닝 ===");
Console.WriteLine($"결과 : {wallet.Add(50, 30).Subtract(30, 50)}");
Console.WriteLine();


Console.WriteLine($"");
