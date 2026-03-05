using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

struct RecipeCard
{
    public string Name;
    public int Servings;
    public Ingredient[] Ingredients;
    public RecipeCard(string name, int servings, Ingredient[] ingredients)
    {
        Name = name;
        Servings = servings;
        Ingredients = new Ingredient[ingredients.Length];
        for (int i = 0; i < ingredients.Length; i++)
        {
            Ingredients[i] = ingredients[i];
        }
    }
    public void PrintRecipe()
    {
        Console.WriteLine("=== 원본 레시피 ===");
        Console.WriteLine($"[{Name}] ({Servings}인분)");
        Console.WriteLine("재료:");
        for(int i = 0; i < Ingredients.Length; i++)
        {
            Console.WriteLine($"- {Ingredients[i].Name}: {Ingredients[i].Amount}{Ingredients[i].Unit}");
        }
        Console.WriteLine();

    }
    public void ScaleRecipe(int newServings)
    {
        double Change = (double)newServings / (double)Servings;
        Console.WriteLine($"=== {newServings}인분으로 변환 ===");
        Console.WriteLine($"[{Name}] ({newServings}인분)");
        Console.WriteLine("재료:");
        for (int i = 0; i < Ingredients.Length; i++)
        {
            Console.WriteLine($"- {Ingredients[i].Name}: {Ingredients[i].Amount*Change}{Ingredients[i].Unit}");
        }
        Console.WriteLine();

    }
}
