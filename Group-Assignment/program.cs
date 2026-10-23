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

/*Step 6 - Using a while statement to check if the user entered a valid input type, 
used a double to capture the decimal number, .TryParse translate the input to the spcified input type (double)
 and stores it in the variable.*/
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

