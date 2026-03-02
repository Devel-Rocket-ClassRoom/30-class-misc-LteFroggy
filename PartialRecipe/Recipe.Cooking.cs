using System;

partial class Recipe {
    public void AddIngredient(string ingredient) {
        if (_ingredientCount >= _ingredients.Length) {
            Console.WriteLine($"재료가 꽉 찼습니다!");
        } else {
            _ingredients[_ingredientCount++] = ingredient;
        }
    }

    public void PrintRecipe() {
        Console.WriteLine($"=== {_name} ({_servings}인분) ===");
        Console.WriteLine($"재료 : ");
        for (int i = 0; i < _ingredientCount; i++) {
            if (_ingredients[i] == null) break;
            Console.WriteLine($"  {i + 1}. {_ingredients[i]}");
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