Console.WriteLine("How many elements there will be in array?");
var countString = Console.ReadLine();

int count = Convert.ToInt32(countString);

var resultArray = new string[count];

for(int i = 0; i < count; i++)
{
    var str = Console.ReadLine();

    resultArray[i] = str ?? "";
}

Console.WriteLine("All of elements are written");