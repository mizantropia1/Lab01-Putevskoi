// Константы для перевода — фиксированные значения
const double FahrenheitOffset = 32.0;
const double KelvinOffset = 273.15;

// Температура в градусах Цельсия
double celsius = 37.2;

// Перевод в Фаренгейты: F = C * 9 / 5 + 32
double fahrenheit = celsius * 9 / 5 + FahrenheitOffset;

// Перевод в Кельвины: K = C + 273.15
double kelvin = celsius + KelvinOffset;

Console.WriteLine("Конвертер температур");
Console.WriteLine($"Цельсий:   {celsius} °C");
Console.WriteLine($"Фаренгейт: {fahrenheit} °F");
Console.WriteLine($"Кельвин:   {kelvin} K");