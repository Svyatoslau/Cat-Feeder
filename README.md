Cat Feeder
=====================================

Основные требования к системе системе управления кормушками для котов
--------------------------------

Автоматические кормушки позволяют кормить питомцев сухим кормом согласно заданному расписанию. Особенным образом автоматические кормушки раскрывают себя в сочетании с возможностью удалённого управления и мониторинга состояния. В совокупности это позволяет котоводам оставлять питомцев без присмотра на некоторое время будучи полностью уверенным что кот не останется без еды.


Необходимая функциональность:
--------------------------------
	User:
	  - Мониторить состояние кормушки
	  - Просмотреть логов
	  - Создать расписание
	  - Назначить расписание на кормушки(у)
	  - Сохранить и редактировать расписание
	  - Ставить метки на кормушки (add/edit/remove)
	  - Экспортировать логи и экспорт/импорт расписания кормёжки 
	Admin:
	  - Зарегистрировать нового пользователя(add/edit/remove)
	  - Добавление новой кормушки(add/edit/remove)
	  - Мониторинг состояния всех кормушек
	  - Просмотр админ логов
	  - Экспортировать логов и экспорт/импорт расписания кормёжки 


Анализ требований
-----------------
![Use case diagram TP (5 semestr)](https://user-images.githubusercontent.com/70974206/146601654-b0f7818e-4fd4-403f-9456-ec25c94b597c.jpeg)

Проектирование
--------------
![Зарегистрировать пользователя](https://user-images.githubusercontent.com/70974206/146601752-6b0d3da7-c55f-4a95-a70f-52435565911d.jpg)
![Просмотр состояние кормушки](https://user-images.githubusercontent.com/70974206/146601768-4040bf94-963a-407d-b8f3-26cd01612f57.jpg)
![Создание расписания](https://user-images.githubusercontent.com/70974206/146601797-bf111964-a2b6-4e83-bd0d-67bd4baefd19.jpg)




Зависимости между проектами
---------------------------
![Архитектура](https://user-images.githubusercontent.com/70974206/146601902-506cec6e-addf-485e-88df-b3ecbbaaf63b.png)

База данных
---------------------------
![БД](https://user-images.githubusercontent.com/70974206/146602090-1b62f490-dc00-4972-b776-53dc77206b35.png)


