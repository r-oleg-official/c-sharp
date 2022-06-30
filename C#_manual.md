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
**//** - строка комментариев.<br>
Пример:

**Console.WriteLine("Text");**<br>
* **Console** - обращение к системному терминалу, взаимодействие с ним для ввода-вывода данных.<br>
* **WriteLine** - вывод в строку то, что в (), с завершающим символом `\n`.<br>
* **"Text"** - текст сообщения `Text` заключается в `""`.<br>
* **;** - завершение строки кода в C#.<br>

**Read()** - считывание данных, введенных `user`'ом без перехода на новую строку.<br>
**string username =**, где <br>
* `string` - создание переменой со строковым типом данных, аналогично: `int`, `bool`;
* `username` - задать имя переменной. 
* `=` - присвоить, или положить значение/содержимое справа после знака `=` переменную `username`.

Переменная (анг. variable) - контейнер/ID.

Пример, именования переменной:

* верно: numberA, number2;
* неверно: 2number, _numberA, number_A.

> Переменные именуются лат. буквами, цифрами. Начинается с нижнего регистра, стиль `CamelCase`. Не начинаются с цифры, "_", не принят стиль `Snake_Case`.

## Краткий словарь команд.

    $ dotnet new console
    $ dotnet new gitignore
    $ dotnet run

## Краткий словарь синтаксиса C#.
[Справочник по C#](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/).<br>
`//` - comment, `=` - присвоение.

`string` var_name = ...; - строковые, ссылочный тип, 0 (пустая строка) $\div$ много, 4byte $\div$ 2Gb

`int` var_name = ...; - целочисленные, 32 bit, -2,14x10<sup>9</sup> $\div$ 2.14x10<sup>9</sup> 

`double` var_name = ...; - вещественные, 64 bit, $\pm$ 5,0x10<sup>-324</sup> $\div$ $\pm$ 1,7x10<sup>308</sup>

`char` - представляющий символ Юникода UTF-16, [см](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/char)

`bool` var_name = ...; - `true`/`false`, 1 byte (думаю бит??)

`bool?` var_name = null; -

Console.WriteLine("Text" + var_name); | Console.Write("Text" + var_name); <br>
> Если в конце строки появляется артефакт в виде "**`%`**" - ничего страшного код правильный, проблема с `VSC`.

Console.ReadLine("Text" + var_name);  | Console.Read("Text" + var_name);

`+`, `-`, `/`, `*`, `%`, `()` - классические арифмет-е операции опред-ся этими операторами.

Логические операторы, [см](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/boolean-logical-operators):<br>

* `x ! y` - НЕ, (true, если x не равен y, или наоборот, иначе false);
* `x & y` - И (true, если x=true y=true, else false);
* `x ^ y` - ИЛИ, исключение (true: x=false, y=true, или x=true, y=false), (false: x=false, y=false), тот же результат как `!=bool`;
* `x | y` - ИЛИ, исключение (true: x=false, y=true, или x=true, y=false), (false: x=false, y=false), если левый операнд `x = true`, то правый `y` не вычисляется;
* `x && y` - И, (оператор к.з.), (true, если x=true y=true, else false), если `x=false`, то `y` не вычисляется;
* `||` - ИЛИ, (оператор к.з.), (true, если x=true y=true, else false), если `x=false`, то `y` не вычисляется;
* `bool?` - оператор допускает знач-е `NULL`, [см](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/boolean-logical-operators). 

Операторы сравнения `==`, `<`, `>`, `<=`, `>=`, например:

* `x == y` - оператор равенства/сравнения, если `x` или `y` не число [Double.NaN](https://docs.microsoft.com/ru-ru/dotnet/api/system.double.nan) или [Single.NaN](https://docs.microsoft.com/ru-ru/dotnet/api/system.single.nan), то результат `false`;

Эти операторы поддерживаются всеми [целочисленными](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/integral-numeric-types) типами: `int`, `uint`, `byte`, `long`,...; и типами [с плавающей запятой](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types): `float`, `double`, `decimal`. `decimal` - точнее обрабатывает финансовые числа, а `float` и  `double` могут создать непредвиденные ошибки.

Генератор псевдослучайных целых чисел (`min` $\div$ `max-1`):

    new Random().Next(min, max);

