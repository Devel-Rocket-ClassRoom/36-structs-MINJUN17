using System;

Ingredient[] pasta = new Ingredient[4];
pasta[0] = new Ingredient("스파게티면", 200, "g");
pasta[1] = new Ingredient("토마토소스", 150, "ml");
pasta[2] = new Ingredient("양파", 2, "개");
pasta[3] = new Ingredient("마늘", 5, "쪽");

RecipeCard pastaRecipe = new RecipeCard("토마토 파스타", 2, pasta);
pastaRecipe.PrintRecipe();
pastaRecipe.ScaleRecipe(4);
