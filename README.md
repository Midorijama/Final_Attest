# Final Attest

*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

# Описание работы программы

### Получение данных
- запросить ввод количества элементов массива (переменна **n**)  
- создать одномерный массив строк (**array**) с размерностью **n**  
- запросить ввод каждого элемента массива поочередно, с помощью цикла **for**

*Использую уже имеющуюся у меня с курса функцию заполнения массива*

### Определение размера массива с ответами
- создать счетчик (переменная **s**)
- с помощью цикла **foreach** посчитать все элементы исходного массива, которые соответствуют условиям задания:
  - если длинна элемента больше или равняется 3, увелимчиваем счетчик **s** на 1
  - в обратном случае не делаем ничего
- полученное значение переменной **s** и будет размерностью массива с ответами

### Получение массива с ответами
- создать массив (**final_array**) с размерностью **s**
- с помощью цикла **for** с двумя переменными в условии записать все элементы изначального массива, соответствующие условиям задачи, в массив ответов
  - первая переменная в цикле используется для перебора всех элементов массива, а вторая для записи в массив с ответами.  
  К каждому элементу применяется проверка на соответствие условию, если условие выполняется - элемент изначального массива записывается в массив с ответами, а вторая переменная увеличивается на 1
 
### Вывод массива с ответами
 - с помощью цикла **foreach** вывести все элементы массива с ответами поочередно на экран

*Использую уже имеющуюся у меня с курса функцию вывода массива*
