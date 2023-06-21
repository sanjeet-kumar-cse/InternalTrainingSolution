/*
 * Session Task 4: 
 * Implement a C# method CalculateFlightCharge(int noOfAdults, int noOfChildren) to find and return the 
 * total flight ticket cost for a given number of adults and children. Consider the below values for the 
 * calculation. Rate per Adult: $150.0 Rate per Child: 1/3rd of the rate per adult Service Tax: 7% of 
 * the ticket amount (including all passengers) Consider 10% discount on the final ticket cost (after
 * inclusion of the service tax).
 * 
 */

int CalculateFlightCharge(int noOfAdults, int noOfChildren)
{
    int AdultTicketRate = 150;      // initialize  Adult Ticket Cost

    int ChildTicketRate = AdultTicketRate/3;  // Calcuate Child Ticket Cost

    // Delcare Varible to Calulate Cost without Tax, With Tax and After Discount
    int TotalTicketCostWithoutTax, TotalTicketCostWithTax, TotalTikcetCostAfterDiscount;

    // Calulate Total Ticket Cost Without Tax
    TotalTicketCostWithoutTax = noOfAdults * AdultTicketRate + noOfChildren * ChildTicketRate;

    // Calulate Total Ticket Cost With Tax
    TotalTicketCostWithTax = TotalTicketCostWithoutTax + TotalTicketCostWithoutTax * 7 / 100;

    // Calulate Total Ticket Cost After Discount
    TotalTikcetCostAfterDiscount = TotalTicketCostWithTax - TotalTicketCostWithTax * 10 / 100;

    return (TotalTikcetCostAfterDiscount);
        
        ;
}


int Result = CalculateFlightCharge(5, 2);
Console.WriteLine("Total Cost for 5 Adult and 2 Child is  {0}", Result);

