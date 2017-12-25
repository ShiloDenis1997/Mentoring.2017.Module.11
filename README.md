# Mentoring.2017.Module.11
# Задание к модулю Logging and Monitoring
## Общее
В данном задании мы добавим счетчики производители и логгирование к уже имеющемуся проекту. По умолчанию предлагается взять за основу приложение MvcMusicStore, обновленный на ASP.Net MVC 5 (его можно найти в архиве Task.zip).
### Задание 1. Счетчики производительности
Добавьте несколько счетчиков производительности в ваш проект.
Если вы используете MvcMusicStore, то добавьте счетчики:
- Число успешных LogIn 
- Число успешных LogOff
- 1 на ваш выбор
Для регистрации и удаления счетчиков может потребоваться отдельное приложение (которое необходимо будет запускать с повышенными привилегиями).
При выполнении задания вы можете использовать как непосредственно классы System.Diagnostics, так и сторонние библиотеки-надстройки, такие как Performance Counter Helper.
### Задание 2. Логгирование
Добавьте запись логов для выбранного проекта. Необходимо соблюсти следующие условия:
- Должно поддерживаться несколько уровней логгирования (как минимум Error, Info, Debug)
- Логгирование должно включаться/отключаться через конфигурационный файл
### Задание 3. Сбор и анализ логов
Используя API или командную строку Log Parser, создайте генератор отчетов по логам. В отчете должно фигурировать:
- Общее количество каждого типа записей
- Перечень ошибок (записей с кодом Error)
