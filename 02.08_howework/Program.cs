//1.Дано сьогоднішню дату. І дату нового року. 
//Крім того дано масив часових проміжків постійних дій. (8 годин, 30 днів, 2 дні, ...)
//Розрахувати для кожного елементу масиву: скільки разів дія буде зроблена з сьогоднішнього дня до нового року. 
//Наприклад якщо дія раз в місяць то до нового року дія буде розблена 6 разів (
//1)сьогодні +
//2)через 30 днів, +
//3)через 60 днів, +
//4)через 90 днів, +
//5)через 120 днів, +
//6)через 150 днів(майже новий рік, а +
//7 разу не буде бо це вже буде 2024 рік) +

var newYear = new DateTime(2023, 12, 31);
var today = new DateTime(2023, 8, 2);
TimeSpan[] timeSpace = new TimeSpan[] { new TimeSpan(8, 0, 0), new TimeSpan(30, 0, 0, 0), new TimeSpan(2, 0, 0, 0) };
var somePeriod = (newYear - today);

double counter1 = 0;
for (int i = 0; i < timeSpace.Length; i++)
{
    counter1 = (somePeriod / timeSpace[i]);
    Console.WriteLine(counter1);
};


var plus30 = new TimeSpan(30, 0, 0, 0);
var somePeriod30days = (newYear - today) - plus30;

double counter2 = 0;
for (int i = 0; i < timeSpace.Length; i++)
{
    counter2 = (somePeriod30days / timeSpace[i]);
    Console.WriteLine(counter2);
};


var plus60 = new TimeSpan(60, 0, 0, 0);
var somePeriod60days = (newYear - today) - plus60;

double counter3 = 0;
for (int i = 0; i < timeSpace.Length; i++)
{
    counter3 = (somePeriod60days / timeSpace[i]);
    Console.WriteLine(counter3);
};


var plus90 = new TimeSpan(90, 0, 0, 0);
var somePeriod90days = (newYear - today) - plus90;

double counter4 = 0;
for (int i = 0; i < timeSpace.Length; i++)
{
    counter4 = (somePeriod90days / timeSpace[i]);
    Console.WriteLine(counter4);
};


var plus120 = new TimeSpan(120, 0, 0, 0);
var somePeriod120days = (newYear - today) - plus120;

double counter5 = 0;
for (int i = 0; i < timeSpace.Length; i++)
{
    counter5 = (somePeriod120days / timeSpace[i]);
    Console.WriteLine(counter5);
};


var plus150 = new TimeSpan(150, 0, 0, 0);
var somePeriod150days = (newYear - today) - plus150;

double counter6 = 0;
for (int i = 0; i < timeSpace.Length; i++)
{
    counter6 = (somePeriod150days / timeSpace[i]);
    Console.WriteLine(counter6);
};



var somePeriodNewYear = (newYear - newYear);

double counter7 = 0;
for (int i = 0; i < timeSpace.Length; i++)
{
    counter7 = (somePeriodNewYear / timeSpace[i]);
    Console.WriteLine(counter7);
};