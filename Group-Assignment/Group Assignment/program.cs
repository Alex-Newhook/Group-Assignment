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
Console.WriteLine("What is the length of the room where you are looking to install new flooring: ");
 flooringLength = double.Parse(Console.ReadLine()); 

/*Step 6 - Using an if statement to check if the user entered a valid input type, 
used a double to capture the decimal number, .TryParse translate the input to the spcified input type (double)
 and stores it in the variable. */
if (double.TryParse(Console.ReadLine(), out flooringLength))
{
    //left the if statement blank as the code will complete naturally from step 5.
    ;
}
else
{
    /*set up the else statement with an error so if the user enetered a non accepted 
     input type they would be given said message. */
        Console.WriteLine("Error: Please enter a valid number");
    
}

//Step 7 - Used Console.WriteLine to ask the user for width input and stored it in the flooringWidth variable using Console.ReadLine
Console.WriteLine("What is the width of the room where you are looking to install new flooring: ");
 flooringWidth = Console.ReadLine(); 

