// Доп. задача:
// Напишите функцию, которая принимает слово и возвращает true, если в этом слове есть две одинаковые, стоящие рядом буквы.
// "ссора" -> true
// "клюющий" -> true
// "кодер" -> false
// "цыпленок"-> false
Console.WriteLine("Введите слово");
string word = Console.ReadLine();
int i = 0;
bool tf = false;
while ( tf = true || i < word.Length)
{
    tf = word[i] == word[i + 1];
    i++;
}
if (tf=true) Console.WriteLine ($"{word} --> True");
else Console.WriteLine ($"{word} --> False"); 

// Никаких ошибок не подчёркивает, но не работает.