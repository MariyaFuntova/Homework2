int dayNumber = new Random().Next(1, 8);
string[] days ={ "понедельник", "вторник", "среда", "четверг", "пятница","суббота", "воскресенье" };
string txtResult = "";
if ( dayNumber > 5)
{
    txtResult = $" - выходной день";
}
else txtResult = $" - рабочий день";
Console.WriteLine($"{dayNumber} день недели - это {days[dayNumber-1]}{txtResult}");