using System;

QueryBuilder qb1 = new QueryBuilder();

Console.WriteLine($"=== 기본 쿼리 ===");
Console.WriteLine($"{qb1.Select("*").From("Users").Build()}");
Console.WriteLine();

qb1 = new QueryBuilder();
Console.WriteLine($"=== 조건 쿼리 ===");
Console.WriteLine($"{qb1.Select("Name, Age").From("USERS").Where("Age > 18").Build()}");
Console.WriteLine();

qb1 = new QueryBuilder();
Console.WriteLine($"=== 정렬 쿼리 ===");
Console.WriteLine($"{qb1.Select("*").From("Products").Where("Price > 1000").Orderby("Price").Build()}");
Console.WriteLine();