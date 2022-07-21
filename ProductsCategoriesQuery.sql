//Выполняем LEFT JOIN так как он идеально подходит под условия задачи - вывести все пары продукт - категория, даже если у продукта нет категории
//LEFT JOIN поставит в местах где у продукта нету категории значение NULL


SELECT Products.name, Category.name
FROM Products LEFT JOIN  Category ON Products.id=Category.productId 
ORDER BY Products.name;