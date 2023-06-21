/*
 * Session Task 1:
 *
 * Jack and his three friends have decided to go for a trip by sharing the expenses of the fuel equally. 
 * Implement a C# method CalculateCostPerPerson(double mileage,double amountPerLitre, int distanceOneWay) 
 * which returns the amount (in Rs) each of them need to put in for the complete (both to and fro) journey.
 *
 * @input double mileage, double amountPerLitre, int distanceOneWay
 *
 * @output cost per person in double.
*/
double CalculateCostPerPerson(double mileage, double amountPerLitre, int distanceOneWay)
{
    double costPerPerson,TotalDistance, TotalCost, TotalLitre ;

    TotalDistance = distanceOneWay * 2;         // Calcuating total distance
    TotalLitre = TotalDistance / mileage;       // Calucating Total Litre 
    TotalCost = TotalLitre * amountPerLitre;    // Calculating Total Cost
    costPerPerson = TotalCost / 4;              // Caculate Per person cost 
    
    return costPerPerson;
}


double Cost = CalculateCostPerPerson(12, 65, 96);
Console.WriteLine("Total Cost Per Person is  {0}", Cost);

