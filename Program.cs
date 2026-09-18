int dayNumber = 6;

switch (dayNumber){
    case 5 or 6 or 7: Console.WriteLine("Выходной");break;
    default: Console.WriteLine("Будний");break;
}


int score = 78;

switch (score) {
    case >= 0 and < 40:
        Console.WriteLine("Неудовлетворительно");break;
    case >= 40 and < 59:
        Console.WriteLine("Удовлетворительно");break;
    case >= 60 and < 79:
        Console.WriteLine("Хорошо");break;
    case >= 80 and <= 100:
        Console.WriteLine("Отлично");break;
    default:
        Console.WriteLine("Некорректный балл");break;
}

Console.WriteLine();
Console.WriteLine("Введите температуру");
int temp = int.Parse(Console.ReadLine()!);

string result = temp switch
{
    <= 0 => "Мороз",
    <= 14 => "Прохладно",
    <= 24 => "Комфортно",
    <= 34 => "Жарко",
    _ => "Очень жарко"
};
Console.WriteLine(result);

Console.WriteLine();
string role = "user";

string result_role = role switch{
    "admin" => "Полный доступ",
    "teacher" => "Доступ преподавателя",
    not "admin" or not "teacher" => "Ограниченный доступ",
};
Console.WriteLine(result_role);

int age = 70;
bool hasTicket = true;

switch (age)
{
    case >= 18 when hasTicket:
        Console.WriteLine("Вход разрешён"); break;
    case >= 18:
        Console.WriteLine("Нет билета"); break;
    default:
        Console.WriteLine("Возраст не подходит"); break;
}


//Время года
Console.WriteLine();
Console.WriteLine("Введите номер месяца: ");
int number = int.Parse(Console.ReadLine()!);

string vremyas = number switch{
    12 or 1 or 2 => "Зима",
    3 or 4 or 5 => "Весна",
    6 or 7 or 8 => "Лето",
    9 or 10 or 11 => "Осень",
    _ => "Неверный месяц"
};

Console.WriteLine(vremyas);

//Категория возраста
Console.WriteLine();
Console.WriteLine("Введите возраст: ");
int ageage = int.Parse(Console.ReadLine()!);

string result_age = ageage switch{
    < 0 => "Ошибка",
    < 7 => "Ребёнок",
    < 18 => "Подросток",
    < 65 => "Взрослый",
    >= 65 => "Пенсионер",    
};
Console.WriteLine(result_age);


//Стоимость напитка(Вариант 4)
Console.WriteLine();
Console.WriteLine("Введите размер напитка(S - маленький, M - средний, L - большой): ");
char size = char.Parse(Console.ReadLine()!);
Console.WriteLine("Вы студент? (1 - да, 0 - нет)");
bool stud = (1==int.Parse(Console.ReadLine()!));


switch (size)
{
    case 'S' when stud == true:
        Console.WriteLine($"{150 * 0.9}руб"); break;
    case 'S':
        Console.WriteLine("150руб"); break;
    case 'M' when stud == true:
        Console.WriteLine($"{200 * 0.9}руб"); break;
    case 'M':
        Console.WriteLine("200руб"); break;
    case 'L' when stud == true:
        Console.WriteLine($"{250 * 0.9}руб"); break;
    case 'L':
        Console.WriteLine("250руб"); break;
    default:
        Console.WriteLine("Неизвестный размер"); break;
}


//Тип транспорта(Вариант 8)
Console.WriteLine();
Console.WriteLine("Введите тип транспорта(автобус,метро,такси): ");
string type = Console.ReadLine();

switch (type){
    case "автобус":
        Console.WriteLine("Наземный транспорт");break;
    case "метро":
        Console.WriteLine("Подземный транспорт");break;
    case "такси":
        Console.WriteLine("Индивидуальный транспорт");break;
    default:
        Console.WriteLine("Неизвестный транспорт");break;    
}