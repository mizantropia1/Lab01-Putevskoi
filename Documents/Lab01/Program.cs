Console.WriteLine("Hello, World!");


String myName = "Данила Путевской";
String groupName = "ИСП-251";
int courseNumber = 2;
double averageGrade = 4.8;
bool isBudget = true;

Console.WriteLine("Знакомство");
Console.WriteLine($"Студент: {myName}");
Console.WriteLine($"Группа: {groupName}");
Console.WriteLine($"Курс: {courseNumber}");
Console.WriteLine($"Средний балл: {averageGrade}");
Console.WriteLine($"Бюджетное место: {isBudget}");


// Считаем площадь и периметр комнаты — нужные для ремонта
// Использую double потому что размеры могут быть с запятой
Console.WriteLine();
Console.WriteLine("Ремонт: комната");

double roomWidth = 3.5;
double roomLength = 4.2;

double roomArea = roomWidth * roomLength;
double roomPerimeter = (roomWidth + roomLength) * 2;
Console.WriteLine($"Ширина : {roomWidth} м, длина:{roomLength} м");
Console.WriteLine($"Площадь : {roomArea} кв.м");
Console.WriteLine($"Периметр : {roomPerimeter} м");


// Рассрочка на ноутбук. interestRate это процент переплаты (0.08 = 8%)
Console.WriteLine();
Console.WriteLine("Покупка ноутбука в рассрочку");

int laptopPrice = 65000;
int monthsCount = 12;
double interestRate = 0.08;
double totalWithInterest = laptopPrice * (1 + interestRate);
double monthlyPayment = totalWithInterest / monthsCount;
Console.WriteLine($"Цена ноутбука : {laptopPrice} руб.");
Console.WriteLine($"Итого с процентами : {totalWithInterest} руб.");
Console.WriteLine($"Платеж в месяц : {monthlyPayment} руб.");


// Если делить int на int то дробная часть просто пропадает
// поэтому пишу double чтобы получить точный результат
Console.WriteLine();
Console.WriteLine("Внимание : деление int");

int totalStudents = 25;
int groupsCount = 4;

int studentsPerGroupWrong = totalStudents / groupsCount;
double studentsPerGroupCorrect = (double)totalStudents / groupsCount;

Console.WriteLine($"25 / 4 как int: {studentsPerGroupWrong}");
Console.WriteLine($"25 / 4 как double: {studentsPerGroupCorrect}");


Console.WriteLine();
Console.WriteLine("Способы собрать строку");
string firstName = "Анна";
string lastName = "Смирнова";

// Способ 1: конкатенация через оператор +
string fullNameConcat = firstName + " " + lastName;

// Способ 2: интерполяция через $""
string fullNameInterp = $"{firstName}{lastName}";

// Способ 3: метод string.Concat
string fullNameConcatMethod = string.Concat(firstName, "", lastName);
Console.WriteLine(fullNameConcat);
Console.WriteLine(fullNameInterp);
Console.WriteLine(fullNameConcatMethod);
Console.WriteLine($"Все три строки равны: {fullNameConcat==fullNameInterp && fullNameInterp==fullNameConcatMethod}");


// Константа — значение которое нельзя поменять. VatRate это ставка НДС, она фиксированная
Console.WriteLine();
Console.WriteLine("Константы");
const double VatRate = 0.20;
const string CollegeName = "ВФ ВолГУ";

double productPrice = 1000;
double priceWithVat = productPrice * (1 + VatRate);

Console.WriteLine($" Учебное заведение: {CollegeName}");
Console.WriteLine($"Цена без НДС: {productPrice}, с НДС ({VatRate: P0}): {priceWithVat}");