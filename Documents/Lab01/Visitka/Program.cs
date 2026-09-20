// Константа: номер группы не меняется в течение семестра
const string GroupNumber = "ИСП-251";
// Переменные разных типов
string name = "Путевской Данила";      
int age = 17;                      
string course = "Информационные системы и программирование ";   
string city = "Волжский";            
int semester = 3;                   
// Три оценки для расчёта среднего балла
double grade1 = 4.5;
double grade2 = 5.0;
double grade3 = 4.8;

// Арифметический расчёт: средний балл по трём оценкам
double avgGrade = (grade1 + grade2 + grade3) / 3;

// Красивый вывод через интерполяцию
Console.WriteLine("========================================");
Console.WriteLine();
Console.WriteLine($"Студент: {name}");
Console.WriteLine($"Курс: {course}");
Console.WriteLine($"Группа: {GroupNumber}");
Console.WriteLine($"Возраст: {age} лет");
Console.WriteLine($"Город: {city}");
Console.WriteLine($"Семестр: {semester}");
Console.WriteLine($"Оценки: {grade1}, {grade2}, {grade3}");
Console.WriteLine($"Средний балл: {avgGrade:F2}");
Console.WriteLine();
Console.WriteLine("========================================");