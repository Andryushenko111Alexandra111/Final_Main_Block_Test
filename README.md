# Итоговая контрольная лработа по основному блоку

## Задача:

 Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

*Примеры:*<br>
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

### Описание алгоритма решения:

* Для выполнения задачи был создан строчный массив, и две переменные сount и j. 
* Затем создана функция  *GetCount*, которая перебирала массив и считала, сколько элементов содержат <= 3 символов.
* Далее, создаём функцию *GetArrayResult* для получения нового массива, который содержит число элементов равное count из первой функции с элементами, которые содержат <= 3 символов.
* Следующим действие мы создаём функцию *PrintArray* для вывода результата.
* И выводим два массива для сравнения: один который мы содали первым и второй, который проверила программа.

* Графическое представление метода в папке flowchart в формате JPG.
Реализация алгоритма по пути Code_programs/Program.cs
