/*
 * Session Task 3:
 * Implement a C# method, FindArmstrong(int number) to check whether a given n digit number is an Armstrong number.
 * If the number is an Armstrong number, the method should return true else false. Hint: An “Armstrong number” is 
 * an n-digit number that is equal to the sum of the nth powers of its individual digits. 
 * Example: 371 is an Armstrong number as 3^3 +7^3+ 1^3 = 371. Note: 0 is not a valid “Armstrong number”
 * 
 */ 


// CountDigit Function calculate how many digit present in given Number
int CountDigit(int num)
{
    int count = 0;          // initialize Count to Zero becuase in start no digit is present 

    while (num > 0)
    {
        num = num / 10;     //  Remove Last digit from the number
        count++;            // increment count for removed digit
    }

    return count;
}


// FindArmstrong Function Check number is Armstrong or not
bool FindArmstrong(int num)
{

    int r, sum = 0, temp, count; // Declare varibles to process Armstrong Calculation

    temp = num; // Store number to tem for compare sum in last

    count = CountDigit(num);  // Get Number of Digit in Number

    while (num > 0)   // Check if Number is Grater Than Zero
    {
        r = num % 10;  // Get Last Digit of Number 
        sum = sum + Convert.ToInt32(Math.Pow(r, count));  // Calculate Sum of Last Digit by adding with power of n of Last digit
        num = num / 10;  // Get New Number after removing Last Digit
    }

    if (temp == sum)         // Check if Sum of all digit with there poer of n is equla to number
        return true;        // true Number is Armstrong
    else
        return false;       // false Number is not Armstrong


}


bool Result1 = FindArmstrong(371);
Console.WriteLine("371 is a Armstrong Number {0}", Result1);

bool Result2 = FindArmstrong(1634);
Console.WriteLine("1634 is a Armstrong Number {0}", Result2);

bool Result3 = FindArmstrong(1292);
Console.WriteLine("371 is a Armstrong Number {0}", Result3);


