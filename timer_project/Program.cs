using System.Threading;
/*for (int i = 0; i < 10; i++)
{
    Thread.Sleep(i * 1000);
    Console.WriteLine($"{i}");
    Console.Beep();
}*/


var dateNew = new DateTime();//DateTime.Today.Year,
                             //DateTime.Today.Month,
                             //DateTime.Today.Day,
                             //hours, minute, second
var timeNew = new TimeSpan();


var birth = new DateTime(1991, 8, 21);
var today = new DateTime(2023, 8, 2);
var sumDays = today - birth;
Console.WriteLine(sumDays);

TimeSpan[] routine = new TimeSpan[] {new TimeSpan(8, 0, 0), new TimeSpan(9, 0, 0), new TimeSpan(1, 0, 0)};
for(int i = 0; i < routine.Length; i++)
{
    Console.WriteLine(routine[i]);
};
