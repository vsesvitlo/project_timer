//Взяти кілька дат видатних людей (Тесла, Бора, Хмельницького...)
//і розрахувати скільки тижнів назад вони родилися, скільки днів, років, місяців

var birthTesla = new DateTime(1886, 7, 10);
var birthBohr = new DateTime(1885, 10, 7);
var birthKhmelnitsky = new DateTime(1595, 12, 27);

DateTime[] howLongAgo = new DateTime[] { new DateTime(1886, 7, 10), new DateTime(1885, 10, 7),
    new DateTime(1595, 12, 27) };


var today = new DateTime(2023, 8, 2);

for (int i = 0; i < howLongAgo.Length; i++)
{
    var differencesDays = (today - howLongAgo[i]).Days;
    var differencesYearsAlternative = today.Year - howLongAgo[i].Year;
    var differencesMonthesAlternative = differencesYearsAlternative * 12;
    Console.WriteLine(differencesDays);
    Console.WriteLine(differencesMonthesAlternative);
    Console.WriteLine(differencesYearsAlternative);

    //var differencesMonthes = (today.Month - howLongAgo[i].Month);
    //var differencesYears = differencesDays / 365;
    //Console.WriteLine(differencesMonthes);
    //Console.WriteLine(differencesYears);
};
