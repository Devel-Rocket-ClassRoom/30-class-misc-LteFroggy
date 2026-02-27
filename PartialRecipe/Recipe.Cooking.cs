using System;

partial class Recipe {
    public void AddIngredient(string ingredient) {
        if (_ingredientCount >= _ingredients.Length - 1) {
            Console.WriteLine($"재료가 꽉 찼습니다!");
        } else {
            _ingredients[_ingredientCount++] = ingredient;
        }
    }

    public void PrintRecipe() {
        Console.WriteLine($"=== 비빔밥 ({_servings}인분) ===");
        Console.WriteLine($"재료 : ");
        for (int i = 0; i < _ingredientCount; i++) {
            if (_ingredients[i] == null) break;
            Console.WriteLine($"  {i}. {_ingredients[i]}");
        }
    }
    
    public bool HasIngredient(string ingredient) {
        for (int i = 0; i < _ingredientCount; i++) {
            if (_ingredients[i] == ingredient) {
                return true;
            }
        }
        return false;
    }
}