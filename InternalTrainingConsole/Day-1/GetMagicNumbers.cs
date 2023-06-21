/*
 * Session Task 5: 
 * Implement a C# method, GetMagicNumbers(int number) which accepts an integer value as a parameter and
 * returns the sum of its digits till a single digit is obtained by recursively adding the sum of its digits. 
 * Example: If the number is 901: 9+0+1=10 1+0=1
 * 
 */


int  GetMagicNumbers(int num) {

    int sum = 0;  // initialize Sum 

    while (num > 0 || sum > 9)  // Check if Number is not Zero and Sum is not in Single Digit
    {
        if (num == 0)
        {
            num = sum;      // if num is Zero after caulation Sum but Sum is more then 9
            sum = 0;        // sum initialize as 0 to start calulation agian 
        }
        sum += num % 10;          // Calcuate Sum  by adding last digit of Number
        num /= 10;                  // Get New Number after removing last digit
    }

   return (sum);



}


int Result1 = GetMagicNumbers(123);
Console.WriteLine("Sum of Numbner 123 is  {0}", Result1);


int Result2 = GetMagicNumbers(129);
Console.WriteLine("Sum of Numbner 129 is  {0}", Result2);

int Result3 = GetMagicNumbers(1991);
Console.WriteLine("Sum of Numbner 1991 is  {0}", Result3);


int Result4 = GetMagicNumbers(1111);
Console.WriteLine("Sum of Numbner 1111 is  {0}", Result4);

int Result5 = GetMagicNumbers(00097);
Console.WriteLine("Sum of Numbner 00097 is  {0}", Result5);

int Result6 = GetMagicNumbers(100010);
Console.WriteLine("Sum of Numbner 100010 is  {0}", Result6);



