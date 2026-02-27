partial class Recipe { 
    private readonly string _name;
    private readonly int _servings;
    private string[] _ingredients;
    private int _ingredientCount;
    
    public Recipe(string name, int servings, int maxIngredientCount) {
        _name = name;
        _servings = servings;
        _ingredientCount = 0;
        _ingredients = new string[maxIngredientCount];
    }
}