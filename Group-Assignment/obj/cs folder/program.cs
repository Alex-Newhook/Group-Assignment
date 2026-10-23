//Step 2 Declaring the flooring types and their prices
string Bamboo = "Bamboo ($5.95/sq.ft.)";
string Pine = "Pine ($3.50/sq.ft.)";
string Cherry = "Cherry ($8.25/sq.ft.)";

/*Step 3 Declaring variables for user's floor type. The input will be done later on */
string flooringType;

//Step 4 Declaring variables for the room dimensions. The dimensions will be input later on
double flooringLength;
double flooringWidth;


//Step 5 - Used Console.WriteLine to ask the user for input and stored it in the flooringLength variable using Console.ReadLine

Console.WriteLine("What is the length of the room where you are looking to install new flooring in feet: ");
string lengthInput = Console.ReadLine(); 

/*Step 6 - Using an if statement to check if the user entered a valid input type, 
used a double to capture the decimal number, .TryParse translate the input to the spcified input type (double)
 and stores it in the variable. */
while (double.TryParse(lengthInput, out flooringLength) == false)
{
    /*set upan error so if the user enetered a non accepted 
     input type, making the condition == false, they would be given said message. And they will continue to receive it until they enter a valid number */
    Console.WriteLine("Error: Please enter a valid number");
    Console.WriteLine("What is the length of the room in feet: ");
    lengthInput = Console.ReadLine();

} 


//Step 7 - Used Console.WriteLine to ask the user for width input and stored it in the flooringWidth variable using Console.ReadLine

Console.WriteLine("What is the width of the room where you are looking to install new flooring in feet: ");
string WidthInput = Console.ReadLine();

//Step 8 - same concept used in Step 7

while (double.TryParse(WidthInput, out flooringWidth) == false)
{
    Console.WriteLine("Error: Please enter a valid number");

    Console.WriteLine("What is the width of the room where you are looking to install new flooring in feet: ");
    WidthInput = Console.ReadLine();

}
//Step 9 - Asking the user to choose which flooring they would like, assigning A, B and C the same values as Bamboo, Pine and Cherry respectively.

Console.WriteLine("What kind of flooring would you like:");
string A = Bamboo;
string B = Pine;
string C = Cherry;
/* Step 10 - The console writes the options. The assigns the user input into the flooring variable we've already created. 
 * I added a .ToUpper() element so the user's selection is valid both in upper case and lower case*/

Console.WriteLine("A - " + Bamboo);
Console.WriteLine("B - " + Pine);
Console.WriteLine("C - " + Cherry);
flooringType = Console.ReadLine().ToUpper();
/* I added a while statement to ensure that the input is valid. If the value stored into flooringType - throught he user's input - is not equal to A, B or, C 
 * the user gets an error message and is asked to input a correct value. This will run until a correct value is put in.*/

while (flooringType != "A" && flooringType != "B" && flooringType != "C") 
{
    Console.WriteLine("Error: Please enter a valid choice");

    Console.WriteLine("What kind of flooring would you like:");
    Console.WriteLine("A - Bamboo");
    Console.WriteLine("B - Pine");
    Console.WriteLine("C - Cherry");
    flooringType = Console.ReadLine().ToUpper();
}



//Step 11 & 12 - 
// if the user chose bamboo, the console will print 
// Declared all variables so the program recognizes them. 
double floorArea = flooringLength * flooringWidth;
double finalCost = 0;
string floorMaterial = "";
/*Set up the if statements so that when the user picks an option it has a set material name, price calculated by their square foot input and the default value for the price per square foot, 
I then repeated this two more times to encorporate all options */
if (flooringType == "A")
{
    double sqFtPrice = 5.95;
    finalCost = floorArea * sqFtPrice;
    floorMaterial = "Bamboo";
}

else if (flooringType == "B")
{
    double sqFtPrice = 3.50;
    finalCost = floorArea * sqFtPrice;
    floorMaterial = "Pine";
}

else if (flooringType == "C")
{
    double sqFtPrice = 8.25;
    finalCost = floorArea * sqFtPrice;
    floorMaterial = "Cherry";
}

//Step 13 - Used console.WriteLine to print out total to the user, inputted the variables declared in previous step to display the variables based on the input from the users choice of A, B OR C. 
Console.WriteLine($"You have selected {floorMaterial} with a floor area of: {floorArea:F2} square feet, your total cost is: ${finalCost:F2}"); 

