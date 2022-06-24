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

Особенности установки пакета SDK, ASP.NET 00:10:52. Для MacOS пакет x64, arm64 на процессорах, например, M1 работает неверно.


## 2. **Configuration VS Code.**

### *Extensions.*
Install extensions to VS Code:

1. `C#` by Mscft (C# for VS Code powered by Omnisharp);
2. `C# Extentions` by jchannon. Extension "no longer under development". ??? Пригодиться для сложных проектов и углубленного изучения C#.

#### Additional extensions VS Code.

1. find "`C#`";
2. find "`C# highlight`" for highlightning syntax of a code. 

### Recomendations by Sergey.

File -> Preferences -> Setting:
1. Commonly Used -> File:Auto Save = "onFocusChange". Это значит, автосохранение кода при переходе в терминал, дугое окно, вкладку. Для тех, кто забывает про "Ctrl+S". 

>!!! Но если в рамках проекта много обновляющихся файлов - это может вызвать тормоза. Нужно быть внимательным. Причем лютые тормоза.

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

Initiate `.netcore console`, add `.gitignore`:

    $ dotnet new console
    $ dotnet new gitirnore

File `*.cs` - he need us.

Команда запуска кода:

    $ dotnet run 

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


## Краткий словарь.

    $ dotnet new console
    $ dotnet new gitignore
    $ dotnet run
