/*
 * Session Task 2:
 * 
 *  Implement a C# method FindProduct(int num1, int num2, int num3) to calculate the product of 
 *  three positive integer values. However, if one of the integers is 7, consider only the values 
 *  to the right of 7 for calculation. If 7 is the last integer then return -1. Note: 7 can appear only once
 * 
 */

int FindProduct(int num1, int num2, int num3)
{
    if (num1 == 7) {
        
        return (num2 * num3);               // caulate product if 7 is at first postion
    
    } else if (num2 == 7) {
        
        return (num3);                     // caulate product if 7 is at middile postion

    } else if (num3 == 7) { 

        return (-1);                      // caulate product if 7 is at last postion

    } else  {  

        return (num1 * num2 * num3);     // caulate product if 7 is not in list

    }

}


int Product1 = FindProduct(1,5,3);
Console.WriteLine("Product of 1,5,3 is  {0}", Product1);


int Product2 = FindProduct(3, 7, 8);
Console.WriteLine("Product of 3, 7, 8 is  {0}", Product2);

int Product3 = FindProduct(7, 4, 3);
Console.WriteLine("Product of 7, 4, 3 is  {0}", Product3);

int Product4 = FindProduct(1, 5, 7);
Console.WriteLine("Product of 1, 5, 7 is  {0}", Product4);


