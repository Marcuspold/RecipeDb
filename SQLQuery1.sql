SELECT Recipe.Name, Ingredient.Name 
FROM Recipe JOIN RecipeIngredient
ON Recipe.Id = RecipeIngredient.RecipeId
Join Ingredient
ON Ingredient.Id = RecipeIngredient.IngredientId