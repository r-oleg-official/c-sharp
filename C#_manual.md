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
2. `C# Extentions` by jchannon. Extension "no longer under development". ??? Пригодиться для сложных проектов и углубленного изучения C#.

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

### 2. Console.
#### 2.1. WriteLine/Write.

В след. примере, в случае прибавления к `string`-переменной `"Text"` `int`-переменную `var_name`, в итоге получается `string`-переменная:

    Console.WriteLine("Text" + var_name)  |  Console.Write("Text" + var_name)

**Console.WriteLine("Text");**<br>
* **Console** - обращение к системному терминалу, взаимодействие с ним для ввода-вывода данных.<br>
* **WriteLine** - вывод в строку то, что в (), с завершающим символом `\n`.<br>
* **"Text"** - текст сообщения `Text` заключается в `""`.<br>
* **;** - завершение строки кода в C#.<br>

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

Подобное выражение `a++`, или `++a`, нужно чтобы не писать 

### 9. Спецсимволы.

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
        return result
    }

Поиск мах числа через функцию - Лекция №2 по С# 00:15:30. 

#### **Void.**

void SayHello()
{
    Console.WriteLine("Hello");
}

Void - ничего не возвращает, только выполняет действия.

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


### **Sources.**
1. [METANIT.COM](https://metanit.com/). 
2. [C# documentation](https://docs.microsoft.com/en-us/dotnet/csharp/).
3. [overcoder](https://overcoder.net/t/c#).

### **IDE.**

Денис рекомендует для C# - `Rider`. `VS` даже полноценный глючит, подвисает. 

`Rider` с `Unity` в связке лучше работает.
