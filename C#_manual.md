## 1. **Introduction to C#.**
C# - cross-platform language of development.<br>
C# it's: 
* mobile apps (fw `zemarina`);
* game dev (engine `Unity`), where C# this is a script language;
* desktop apps for a Win/MacOS;
* web-development;
* IoT. Rassberry PI 2+ 'n' WinIoT.

C# a created by Anders Halesberg (Microsoft). C# - an alternative to JAVA. C# get more a things from C++, JAVA. 

> Language of development it's only a instrument.
> Language's syntax study in a few days?? 00:05:30 - программист vs тыжпрограммист vs хакер.

Успешный запуск "Hello, World!" - это означает правильные: установка, настройка, выполнение IDE.

Особенности установки пакета SDK, ASP.NET 00:10:52. Для MacOS пакет x64, arm64 на процессорах, например, M1 (Apple) работает неверно.

## 2. **Configuration VS Code.**

### *Extensions.*
Install extensions to VS Code, find:

1. `C#` by Mscft (C# for VS Code powered by Omnisharp);
2. `C# Extentions` by jchannon. Extension "no longer under development". ??? Пригодиться для сложных проектов и углубленного изучения C#. Пока лучше не ставить - во вкладке "Проблемы" начинает ругаться на код программы.

#### Additional extensions VS Code.

1. find "`C#`";
2. find "`C# highlight`" for highlightning syntax of a code. 

### Recomendations by Sergey.

File -> Preferences -> Setting:
1. Commonly Used -> File:Auto Save = "onFocusChange". Это значит, автосохранение кода при переходе в терминал, дугое окно, вкладку. Для тех, кто забывает про "Ctrl+S". 

>!!! Но если в рамках проекта много обновляющихся файлов - это может вызвать тормоза. Причем лютые тормоза. Нужно быть внимательным. 

2. find `terminal font`. Terminal -> Integrated: Font Size = 20 (Sergey). I'm = 16 FullHD. 


## 3. **Begin any project on C# to VS Code.**
Create a directory for the project. Initiate the local repository `git`, add a remote repository to the `github`:

    $ git init
    $ git branch -M main
    $ git remote add origin <url_github_repo>

After add of a changes to project:

    $ git add <directory_or_file> && git commit -m "Message" 
    or
    $ git commit -a, add message for the commit
    $ git push origin main

Prepare a directory to the project on C# and add the `.gitignore`:

    $ dotnet new console
    $ dotnet new gitignore
    $ dotnet run - компиляция и запуск программы

Если в терминале вывелось сообщение "Hello, World!", значит всё в порядке, можно начинать писать код. 

Команда `dotnet new gitignore` создаст файл `.gitignore`, который нужен, чтобы в удал-й репо-й не отправлялись ненужные файлы при компиляции - *__признак дурного тона__*. Важен файл `Program.cs`.


File `*.cs` - he need us.

### Gitignore. [github.](https://github.com/r-oleg-official/VisualStudio.git)

Можно не копироать файл руками, а можно после команды `dotnet new console` команду:

    $ dotnet new gitirnore

File be created by automatically.

Generator `.gitignore`, [see.](https://www.toptal.com/developers/gitignore)

# Syntax C#
## Краткий словарь команд инициации каталога для написания будущего кода.

    $ dotnet new console
    $ dotnet new gitignore
    $ dotnet run

## F.A.Q. C#.
[Справочник по C#](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/).<br>
`//` - comment, `=` - присвоение.

### 1. Variable's types 
Переменная (анг. `variable`) - контейнер/ID.

> Переменные именуются лат. буквами, цифрами. Начинается с нижнего регистра, стиль `CamelCase`. Не начинаются с цифры, "_", не принят стиль `Snake_Case` (Сергей), `Snake_Case` для именования констант (Денис).

* `=` - присвоить, или положить значение/содержимое справа после знака `=` переменную `username`.

Задание переменной:

    int a = 0;
    string username = Ivan Ivanov;

Где, `int` - указать тип, `a` - задать переменную, `= 0` - инициализировать переменную. Теперь можно использовать.

Краткий вариант присвоения переменным значений, через `","`:

        int xa = 1, ya = 1, xb = 1, yb = 30;

or

    int xa = 40, ya = 1, 
        xb = 1,  yb = 30,
        xc = 80, yc = 30;

Пример, именования переменной:

* верно: numberA, number2; - так как они локальные
* неверно: 2number, _numberA, number_A.

`string` var_name = ... - строковые, ссылочный тип, 0 (пустая строка) $\div$ много, 4byte $\div$ 2Gb

`int` var_name = ... - целочисленные, 32 bit, -2,14x10<sup>9</sup> $\div$ 2.14x10<sup>9</sup> 

`double` var_name = ... - вещественные, 64 bit, $\pm$ 5,0x10<sup>-324</sup> $\div$ $\pm$ 1,7x10<sup>308</sup>

`char` - представляющий символ Юникода UTF-16, [см](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/char)

`bool` var_name = ... - `true`/`false`, 1 byte (думаю бит??). В переменную сохраняется результат сравнения, или исп.-ся как флаг.

`bool?` var_name = null - 


При делении двух `integer` переменных, чтобы сохранить остаток, нужно чтобы хотя бы одна была `double`. 

#### **String.**

Если нужна новая переменная, но `пустая`, то:

    string var_name = ""
    // or
    string var_name = String.Empty;

Для лучшего понимания кода, использовать значение `String.Empty`.

Как сохраняются данные в переменной `string`?

    string s = "qwerty"
    // indexes  012345
    s - ID строки
    s[0] = q
    s[3] = r

Чтобы обратиться к определенному символу в переменной, нужно использовать методы как с массивом.

### 2. Console.
#### 2.1. WriteLine/Write.

В след. примере, в случае прибавления к `string`-переменной `"Text"` `int`-переменную `var_name`, в итоге получается `string`-переменная:

    Console.WriteLine("Text" + var_name)  |  Console.Write("Text" + var_name)

**Console.WriteLine("Text");**<br>
* **Console** - обращение к системному терминалу, взаимодействие с ним для ввода-вывода данных.<br>
* **WriteLine** - вывод в строку то, что в (), с завершающим символом `\n`.<br>
* **"Text"** - текст сообщения `Text` заключается в `""`.<br>
* **;** - завершение строки кода в C#.<br>

    Console.WriteLine("Text" + var_name) ?? ""; 

`?? ""` - проверка на NULL.

#### 2.1.1. Конкатена́ция (сцепле́ние)

`Конкатена́ция` (лат. concatenatio «присоединение цепями; сцепле́ние») — операция склеивания объектов линейной структуры, обычно строк.

Example:

    Console.WriteLine("Text1" + var_name1 + "Text2" + var_name2);

В таком случае, если используется несколько переменных в выводе, то лучше использовать `интерполяцию` а не `конкатена́цию`.

`Интерполя́ция`, `интерполи́рование` (от лат. inter–polis — «разглаженный, подновлённый, обновлённый; преобразованный») — в вычислительной математике нахождение неизвестных промежуточных значений некоторой функции, по имеющемуся дискретному набору её известных значений, определенным способом.

Пример варианта, который лучше смотрится, не нужны `+`-ки для склеивания текста и переменных: `var_name1` и `var_name2`:

    Console.WriteLine($"Text1 {var_name1} , Text2 {var_name2}");

Для формирования `string`-переменной при `интерполяции` исп в начале `$`, а далее переменные вставлятся в текст с помощью `{ }`.

#### 2.2. ReadLine/Read.

**Read()** - считывание данных, введенных `user`'ом без перехода на новую строку.<br>

> Если в конце строки появляется артефакт в виде "**`%`**" - ничего страшного код правильный, проблема с `VSC`.

    Console.ReadLine("Text" + var_name) | Console.Read("Text" + var_name)
    Console.Clear() - очистка экрана консоли.
    Console.SetCursorPosition(x, y)

где, `int x`- отступ от левого края, `int y` - отступ от верхнего края.

### 3. Конвертация переменных.

Когда `user` вводит число в консоль получается `string`-переменная, для перевода в число нужна конвертация:

    int a = Convert.ToInt32(ReadLine());

Конвертация `int a` в ` double b` без функции `Convert.`:

    int a = 2;
    double b = (double) a;

Или наоборот:

    double a = 2;
    int b = (int) a;

>! Перевод в `double` может понадобиться, если делить 2-а `int`-числа, тогда нужно одно из них перевести. C# автоматически не конвертирует.


### 4. Логические операторы, [см](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/boolean-logical-operators):<br>

* `+`, `-`, `/`, `*`, `%`, `()` - классические операторы арифмет-х операций;
* `x ! y` - НЕ, (true, если x не равен y, или наоборот, иначе false);
* `x & y` - И (true, если x=true y=true, else false);
* `x ^ y` - ИЛИ, исключение (true: x=false, y=true, или x=true, y=false), (false: x=false, y=false), тот же результат как `!=bool`;
* `x | y` - ИЛИ, исключение (true: x=false, y=true, или x=true, y=false), (false: x=false, y=false), если левый операнд `x = true`, то правый `y` не вычисляется;
* `x && y` - И, (оператор к.з.), (true, если x=true y=true, else false), если `x=false`, то `y` не вычисляется;
* `||` - ИЛИ, (оператор к.з.), (true, если x=true y=true, else false), если `x=false`, то `y` не вычисляется;
* `bool?` - оператор допускает знач-е `NULL`, [см](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/boolean-logical-operators). 

### 5. Операторы сравнения.

`==`, `<`, `>`, `<=`, `>=`, например:

* `x == y` - оператор равенства/сравнения, если `x` или `y` не число [Double.NaN](https://docs.microsoft.com/ru-ru/dotnet/api/system.double.nan) или [Single.NaN](https://docs.microsoft.com/ru-ru/dotnet/api/system.single.nan), то результат `false`;

Эти операторы поддерживаются всеми [целочисленными](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/integral-numeric-types) типами: `int`, `uint`, `byte`, `long`,...; и типами [с плавающей запятой](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types): `float`, `double`, `decimal`. `decimal` - точнее обрабатывает финансовые числа, а `float` и  `double` могут создать непредвиденные ошибки.

### 6. Generator random of numbers.

Генератор псевдослучайных целых чисел (`min` $\div$ `max-1`):

    new Random().Next(min, max);

Задать переменную типа `int` со случайным числом (`0` $\div$ `9`):

    int a = new Random().Next(0, 10);

Генератор псевдослучайных вещественных чисел (`min` $\div$ `max`):

    double randomDouble = new Random().NextDouble() * (max - min) + min;


### 7. Условия, ветвления.

Condition `if...else`:

    if (true) 
        {Actions 1;}
    else
        {Actions 2;}

Или такой рабочий вариант:

    if (a > max) max = a

Ещё пример:

        if (true)
    {
        Actions;
    }
    else if (true)
    { 
        Actions;
    }
    else if (true)
    { 
        Actions;
    }
    else
    {
        Actions;
    }
....
И так бесконечно.

Пример, с `boolean` переменной `var`:

    if (!var) //значит, что неравно var.
    {
        Actions;
    }
    else 
    { 
        Actions;
    }


В `if (username == "Oleg")` - условие выполнится только при полном совпадении значения `username`. Для решения проблемы можно исп.:

 `if (username.ToLower() == "oleg")` - в таком случае `ToLower()` переведёт все значения в нижний регистр.

### 8. Circles.

> Внимание! В условиях цикла быть осторожным со знаками равенства `=`, т.к. есть только один случай `true` для выхода из цикла. Особенно касается нецелочисленными числами.

Circle `while ... do`:

    int count = 0;
    while (count < 100)
        {Actions;
         count = count + 1;
         count++; }

Circle `for`:

    for (int i = 0; i < 3; i++)
    {
        Console.Write(i);
    }
    // Output:
    // 012

где, разделы (`инициализатор`; `условия`; `итератор`). 

* `Инициализатор` (`i = 0`) - задаёт и инициализирует локальную переменную в цикле, вне цикла она недоступна;
* `условия` (i < 3) - задаётся условие/условия;
* `итератор` (i++) - определяте что произойдёт после каждого выполнения тела цикла.

Для прерывания цикла при срабатывании условия:

    break;

Варианты счетчиков: 

    count = count + 1
    count += 1; (-=, *=, /=)
    count++;

Суффиксная форма и постсуффиксная форма `count`:

    count++ - сначала выводится значение count, а потом прибавляется 1-ца
    ++count - сначала прибавится 1-ца, а потом выведится значение count.

Example:

`int a = 2;`

`int b = 3;`

`int c = a++ + b;` // `a=2`, `b=3`, `c=5`, дальше будет `a=3`, т.е. сначала выполняется выражение (берется значение `a`), потом `a+1`.

`int c = ++a + b;` // `a=3`, `b=3`, `c=6`, дальше будет `a=3`, т.е. сначала к `a+1`, а потом выполняется выражение (берется значение `a`).

Подобное выражение `a++`, или `++a`, нужно чтобы писать быстрее.

#### **Цикл в цикле.**
Сортировка массива перемещением мин элемента из оставшегося массива:

    void SelectionSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++) // -1 - т.к. j=i+1.
        {
            int minPosition = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minPosition]) minPosition = j;
            }
            int temporary = array[i];
            array[i] = array[minPosition];
            array[minPosition] = temporary;
        }
    }


### **9. Спецсимволы.**

#### 9.1. $ — интерполяция строк. [см](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/tokens/interpolated)

Example:

    string name = "Mark";
    var date = DateTime.Now;

    // Composite formatting:
    Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now.", name, date.DayOfWeek, date);
    // String interpolation:
    Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");
    // Both calls produce the same output that is similar to:
    // Hello, Mark! Today is Wednesday, it's 19:40 now.



#### 9.2. @ - буквальный идентификатор. [см](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/tokens/verbatim) 

Example 1:

    string[] @for = { "John", "James", "Joan", "Jamie" };
    for (int ctr = 0; ctr < @for.Length; ctr++)
    {
        Console.WriteLine($"Here is your gift, {@for[ctr]}!");
    }
    // The example displays the following output:
    //     Here is your gift, John!
    //     Here is your gift, James!
    //     Here is your gift, Joan!
    //     Here is your gift, Jamie!

Example 2:

    string s1 = "He said, \"This is the last \u0063hance\x0021\"";
    string s2 = @"He said, ""This is the last \u0063hance\x0021""";

    Console.WriteLine(s1);
    Console.WriteLine(s2);
    // The example displays the following output:
    //     He said, "This is the last chance!"
    //     He said, "This is the last \u0063hance\x0021"

### **10. Methods.**

Функция, или Метод:

* ID - индетификатор/имя, как переменные(латиница аА, 0 $\div$ 9, _, ). Цифра не может быть на 1-ом месте. Snake_Case не принят в C#, но возможен.
* могут быть входные аргументы. 
* может/не может возвращать значения (без возврата в некоторых ЯП наз., процедурами).

Общее описание функции:

ВозвращаемыйТипДанных ИмяМетода([ТипДанных1 ИмяАргумента1, ...]) <br>

    { 
        Тело Метода 
        return ЗначениеСоответствующееВозвращаемомуТипуДанных;
    }

Example:

$$ f(x) = x^2 + 1$$ 

    double f(double x)
    {
        double result = x * x + 1;
        return result;
    }

Поиск макс. числа при помощи метода:

    int Max(int arg1, int arg2, int arg3)
    {
        int result = arg1;
        if (arg2 > result) result = arg2;
        if (arg3 > result) result = arg3;
        return result;
    }

    // Version-1.
    //int max1 = Max(a1, b1, c1);
    //int max2 = Max(a2, b2, c2);
    //int max3 = Max(a3, b3, c3);
    //int max = Max(max1, max2, max3);

    // Version-2. Относится к функциональномум программированию.
    int max = Max(
        Max(a1, b1, c1),
        Max(a2, b2, c2),
        Max(a3, b3, c3));

Виды методов:

1. Void (ничего не возвращает, только выполняет действия):
* ничего не принимают, ничего не возвращают;
* что-то принимают, ничего не возвращают.
2.
* ничего не принимают, что-то возвращают (например, генератор случ-х данных);
* что-то принимают, что-то возвращают.

> !!! Признаком хорошего тона является объявление до 5-ти аргументов метода.
> В стандартной библиотеке C# имеется метод с 16-тью аргументами, но это специфичный метод. Т.е. использовать только в исключительных случаях. А лучше перепроектировать свой метод.

#### **Void.**
Первый. Ничего не принимает, ничего не возвращает:<br>

    void SayHello()
    {
        Console.WriteLine("Hello");
    }

Второй. Что-то принимает, ничего не возвращает.

    void Method21(string msg, int count)
    {
        int i =0;
        while (i < count)
            {
                Console.WriteLine(msg);    
                i++;
            }
    }
    Method21("Text", 4);
    // or
    Method21(msg: "Text2", count: 4);
    Method21(count: 4, msg: "Text3"); // передает значение конкретному аргументу

#### **Возвращаемый тип методов.**
Третий (ничего не принимает, что-то возвращает):

    int Method3()
    {
        return DateTime.Now.Year;
    }
    int year = Method3();
    Console.WriteLine(year);

Четвертый, самый важный (что-то принимает, что-то возвращает):

    string Method4(int count, string text)
    {
        int i = 0;
        string result = String.Empty; // - так лучше задавать пустую переменную
        while (i < count)
        {
            result = result + text;
            i++;
        }
        return result;
    }
    string res = Method4(10, "x");
    Console.WriteLine(res);


#### **Abs().**
Применяется к .NET 7 Preview 5+ и другие версии.

* Abs(Decimal) - возвращает абсолютное значение числа Decimal.
* Abs(Double) - возвращает абсолютное значение числа двойной точности с плавающей запятой.
* Abs(Int16) - возвращает абсолютное значение 16-битового целого числа со знаком.
* Abs(Int32) - возвращает абсолютное значение 32-битового целого числа со знаком.
* Abs(Int64) - возвращает абсолютное значение 64-битового целого числа со знаком.
* Abs(IntPtr) - возвращает абсолютное значение собственного целого числа со знаком.
* Abs(SByte) - возвращает абсолютное значение 8-битового целого числа со знаком.
* Abs(Single) - возвращает абсолютное значение числа одинарной точности с плавающей запятой.

#### **Math.Round.**
Округление чисел.

    Math.Round(Double, Int32)

где `Double` - число `double`-типа, `Int32` - степень округления, кол-во знаков дробной части после запятой.

### **Arrays.**
#### **One-dimensioanl array.**

##### Объявление массива.
Type`[]` name_array = {value1, value2, ...};

    int array[] = {0, 0, 0, 0, 0}; // не работает
    int array[] = new int[5]; //будет заполнен нулями
    int array[] = new int[]{0, 0, 0, 0, 0};
    int array[] = new int[5]{1, 0, 2, 0, 3};

##### **Отсутствующий элемент в массиве.**
При поиске элемента в массиве может быть так, что он отсутствует. Обычно переменной присваивают значение `0`, но если эл-т не найден, переменная так и будет иметь значение `0`. Программисты договорились в таком случае изначально присваивать значение `-1`:

    int position = -1; // or -2

    int IndexOf(int[] collection, int find)
    {
        int count = collection.Length;
        int index = 0;
        int position = -1;
        while (index < count)
        {
            if (collection[index] == find)
            {
                position = index;
            }
            index++;
        }
        return position;
    }

### **Two-dimensional array.**

Задать двумерный массив можно:

    string[,] table = new string[2,3];

где, `string` - тип данных; `[,]` - указывает на 2-е размерности (строки и столбцы); `table` - наименование массива; `[2,3]` - сколько надо строк и столбцов соотвественно.

Результат задания массива:

    table[0,0]  table[0,1]  table[0,2]
    table[1,0]  table[1,1]  table[1,2] 


Например, прямоугольная таблица чисел, или `матрица` в математике с 5-ью строками и 8-мь столбцов:

    int[,] matrix = new int[3, 4];
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }


### **Sources.**
1. [METANIT.COM](https://metanit.com/). 
2. [C# documentation](https://docs.microsoft.com/en-us/dotnet/csharp/).
3. [overcoder](https://overcoder.net/t/c#).

### **IDE.**

Денис рекомендует для C# - `Rider`. `VS` даже полноценный глючит, подвисает. 

`Rider` с `Unity` в связке лучше работает.
