## Здравствуте! 
Начало работы. Программа написана на языке C#.
---
***1 Этап.*** Условия выполнения задания 
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись ОСНОВНОЙ содержательной части, если вы выделяете ее в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения(файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом(не должно быть так, что все залито одним коммитом, как минимум этапы 2,3 и 4 должны быть расположены в разных коммитах)

***2 Этап.*** Задача и пример. 

 *Задача:* 
 * Написать программу, которавя из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решениии не рекомендуетсяпользоваться коллекциями, лучше обойтись исключительно массивами.

 *Пример:* 

* 1). ["hello", "2", "world", ":-)"] -> ["2", ":-)"]

* 2). ["Russia", "Denmark," "Kazan"] -> []

***3 Этап.*** Выполнение Контрольной работы*

 *В этой программе, каждое действие выполняются в отдельном методе.*

1. Программа начинается с приветствия пользователя и очистки поля терминала
2. Пользователю предлагается ввод количества значений для проверки их на количество символов(по умолчанию 5шт.)
3. После чего в работу вступает первый метод "OneMassivStr", который формирует одномерный массив, заданной длины.
4. Затем в работу вступает метод "TheAnswString", который принимает данные и выводит в терминал получившийся массив с введенными значениями
5. После чего массив с данными переходит в метод сортировки "SortingMetod", в нашем случае должны выводится значения, в которых количество символов меньше или равно 3.
* *в данном методе предусмотрен новый массив в который запишутся данные после их сортировки.*
6. После того как массив отсортирован он снова переходит в метод "TheAnswString", который выводит с прошедшими проверку значениями

***Из особенностей хотел бы отметить, что если ни одно значение не пройдет проверку, то на выходе мы получим массив без данных. Так же записыват значения возможно из любых символов***

# Примечание: 
Прошу изложить отзывы и рекомендации по данному решению. За ранее благодарю за внимание!)
