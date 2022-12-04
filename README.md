# Итоговая работа

## Содержание

* **`FinalWork.cs`** - файл с кодом консольного приложения итоговой работы. Задание: на входе массив строк, на выходе новый массив на основе исходного, в котором длина элементов меньше либо равна 3-м символам.

    _Пробелы учитываю как полноценные символы, однако отсутствие символов вообще (пустую строку) не считаю элементом и не включаю в выборку._

    _Не смотря на рекомендацию касательно использования коллекций, счет верным для выборки из изначального массива не заниматься изобретением велосипеда, а использовать методы LINQ, т.к. в таком случае код: а) более простой и лаконичный б) работает быстрее, чем перебор элементов вручную в циклах. А учитывая, что изначальный массив строк, что результирующий, я представил именно в виде классических массивов строк, то считаю, что итоговая работа выполнена в соответствии с поставленным заданием._

* **`скриншот выполнения.png`** - скриншот успешного запуска и работы кода.

* **`алгоритм.pdf`** - алгоритм итоговой работы. При составлении использован [ГОСТ 19.701-90 (ИСО 5807-85)](http://www.gostrf.com/normadata/1/4294848/4294848992.pdf) в соответствии с межгосударственным стандартом.

    _При составлении алгоритмов не принято отображать внутреннюю логику работы готовых методов среды разработки, потому такие действия, как формирование массивов или вывод результата пользователю, ограничены по одному логическому блоку. А так же, учитывая, что в идеале код не должен допускать ошибок, то и конструкции отлавливающие ошибки в алгоритме отражать так же не принято. В остальном мной составлен довольно детальный алгоритм._