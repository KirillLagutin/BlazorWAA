# BlazorWAA
Online Store, WebAssenbly, CRUD, SQLite, Toats


ДЗ:
1. Добавьте корзину в интернет магазин.  
2. Реализуйте добавление товаров в корзину из каталога. На данный момент на весь магазин будет одна глобальная корзина. 
3. Добавьте новую страницу, на которой можно будет посмотреть список товаров в корзине.  
4. * Добавьте кнопку “Купить” и при нажатии на нее выведите сообщение “Добавляем в корзину товар {название товара}”. Перед этим добавьте NuGet-пакет Blazored.Toast: https://github.com/Blazored/Toast


Практика:
1. Создать проект Blazor WebAssembly  
2. При необходимости перенести логику с Blazor Server на Blazor WebAssembly  
3. Доделайте страницу с информацией о товаре  
4. При нажатии на название товара из любой страницы реализуйте переход к странице с информацией о товаре  
5. Выделите плитку товара (которую показываете в каталоге и в корзине) в отдельный Razor-компонент и переиспользуйте его в каталоге и корзине  
6. * Для страницы каталога разделите код и UI по разным файлам  
7. * Добавьте обновление корзины в реальном времени (любым способом)  


ДЗ:
1. Доделайте корзину – чтобы можно было добавлять и удалять товары, а также очищать корзину  
2. Добавьте возможность добавлять новые товары в каталог  
3. * Добавьте категории для товаров, реализуйте выбор категории  


ДЗ:  
Реализуйте полноценный CRUD функционал:
1. Эндпоинт для добавления новых товаров в БД (C);
2. Эндпоинт для чтения конкретного товара (R);
3. Эндпоинт для обновления товара (U);
   Из параметров запроса productId [FromQuery], из тела запроса Product [FromBody].
4. Эндпоинт для удаления товара (D).
