Console.WriteLine("Exercises for better progrmaming logic.");

// 1- Find the biggest number in the array.
var myArry = new int[] { 1, 2, 45, 557, 700, 2850, 10, 3, 5, 9, 25, 28, 35, 10, 523 };
var n = myArry.Length;
var biggestNumber = 0;

for (int i = 0; i < n; i++)
    if (myArry[i] > biggestNumber)
        biggestNumber = myArry[i];


Console.WriteLine($"The biggest is number is:{biggestNumber}");


//1b - the same problem but with another connotation, getting random numbers.
var randon = new Random();

var numbers = new int[100];
var bignumber = 0;
var z = numbers.Length;

// Here a fill the array
for (int i = 0; i < z; i++)
{
    numbers[i] = randon.Next(100);
    Console.WriteLine($"Numbers :{numbers[i]}");
}

// Here i compare the and looking for the biggest number
for (int i=0; i < z; i++)
    if (numbers[i] > bignumber)
    bignumber = numbers[i];

Console.WriteLine($"the biggest number is :{bignumber}");


var isTrue = IsPalendromeWord("RECONOCER");
Console.WriteLine(isTrue);

//2- Palindrome words 
static bool IsPalendrome(string word)
{
    //Palindrome words
    var original = word.ToUpper();
    var reversed = new string(original.Reverse().ToArray());
    var palindrome = original.Equals(reversed);

    return palindrome;
}

//2b- Other way
static bool IsPalendromeWord(string word)
{
    var original = word.Length;

    for (var i = 0; i < original / 2; i++)
        if (word[i] != word[original - i - 1])
            return false;
    return true;
}





