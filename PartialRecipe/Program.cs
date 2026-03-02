using System;

Recipe r1 = new Recipe("비빔밥", 2, 5);
r1.AddIngredient("밥");
r1.AddIngredient("고추장");
r1.AddIngredient("계란");
r1.AddIngredient("시금치");
r1.AddIngredient("당근");
r1.PrintRecipe();
Console.WriteLine();

Console.WriteLine($"계란 포함 : {r1.HasIngredient("계란")}");
Console.WriteLine($"소고기 포함 : {r1.HasIngredient("소고기")}");
Console.WriteLine();

Recipe r2 = new Recipe("샌드위치", 1, 5);
r2.AddIngredient("빵");
r2.AddIngredient("햄");
r2.AddIngredient("치즈");
r2.PrintRecipe();