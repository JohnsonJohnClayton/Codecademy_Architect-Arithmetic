using System;

namespace Architect_Arithmetic
{
    class Program
    {
        //This console-based program calculatesthe area of famous, oddly shaped places.
        
        //Methods for basic polygons
        static double Rectangle(double length, double width) => length * width;
        
        //Method for Circles
        static double Circle(double radius) => (Math.PI * Math.Pow(radius, 2));
        
        //Method for Triangles
        static double Triangle(double bottom, double height) => ((.5) * bottom * height);

            //For Global Sum of Area
            //static double TotalArea(double areaA, double areaB, double areaC) => areaA + areaB + areaC;
        //For Global Multiplication of Area to Cost
        static double TotalCost(double area, double cost=180) => Math.Round(area*cost);

        static void Main(string[] args)
        {
            //For Steps 1-9, see calcTotalCost() at the bottom of the code
            //Step 10 Extra Challenges
            //Make the entire project one method - calcTotalCost
            //Calculate the floor area of the Taj Mahal & The Great Mosque of Mecca
            //Will refactor into new methods, CalcTeoArea(), CalcTajArea(), CalcMecArea()
            //Create console menu where user can pick which monument to view/calculate cost
            //calcTotalCost();

            //Defining the GUI / UX
            string menuHeader =  //Header for clearing the console
                "--------------------------------------------------\n" +
                "                 Architect Arithemtic             \n" +
                "--------------------------------------------------";
            string menuWelcome =
                 "\nWelcome to Architect Arithemtic," +
                 "     \na demonstration by John Johnson...";
            string menuPrompt0 =
                "What Monument would you like calculated?   " +
                "\n\n-A.Teotihuacan of Mexico City\n-B.The Taj Mahal\n-C.The Great Mosque of Mecca\n";
            string menuError =
                "      Option not found, please try again and type \"A\" \"B\" or \"C\" ";
            bool isValidOption = false;
            //Allows console to pause at user's pace
            void  MenuPause()
            {
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }

            //Begin printing out GUI / UX
            Console.WriteLine(menuHeader);
            Console.WriteLine(menuWelcome);
            MenuPause();
            Console.Clear();
            Console.WriteLine(menuHeader);
            Console.WriteLine(menuPrompt0);
            string selection = Console.ReadLine();
            selection = selection.ToUpper();
            string[] menuChoices = { "A", "B", "C" }; //Array of valid menu chocies
            
            //Checks if user input was valid, checking against menuChoices variable
            for (int i = 0; i < menuChoices.Length; i++)
            {
                if (String.Equals(menuChoices[i], selection))
                    isValidOption = true;
            }

            //If user input is valid, the program will output as expected, but if not, will loop through
            //an error until option is
            while (!isValidOption)
            {
                Console.WriteLine(menuError);
                selection=Console.ReadLine();

                //Checks if user input was valid, checking against menuChoices variable
                for (int i = 0; i < menuChoices.Length; i++)
                {
                    if (String.Equals(menuChoices[i], selection))
                        isValidOption = true;
                }
            }
            //Clean up console
            Console.Clear();
            Console.Write(menuHeader);

            switch (selection)
            {
                case "A":   //Teotihuacan
                    Console.WriteLine("\nYou have selected the ancient city:\n\n- Teotihuacan -");
                    MenuPause();
                    var A = CalcTeoArea();
                    Console.WriteLine($"\nThe total area of Teotihuacan is: \n{A}.\n");
                    Console.WriteLine($"In order to floor that area, it would cost a total of: \n{TotalCost(A)} in Mexican Pesos.\n");
                    MenuPause();
                    Console.Clear();
                    Console.WriteLine(menuHeader);
                    Console.WriteLine("\nThis has been Architect Arithmetic...");
                    break;
                case "B":   //Taj Majal
                    Console.WriteLine("\nYou have selected the awe-inspiring monument:\n\n- The Taj Majal -");
                    MenuPause();
                    var B = CalcTajArea();
                    Console.WriteLine($"\nThe total area of The Taj Majal is: \n{B}.\n");
                    Console.WriteLine($"In order to floor that area, it would cost a total of: \n{TotalCost(B)} in Mexican Pesos (weird, huh?).\n");
                    MenuPause();
                    Console.Clear();
                    Console.WriteLine(menuHeader);
                    Console.WriteLine("\nThis has been Architect Arithmetic...");
                    break;
                case "C":   //Mecca
                    Console.WriteLine("\nYou have selected holy pilgrimage site:\n\n- The Great Mosque of Mecca -");
                    MenuPause();
                    var C = CalcMecArea();
                    Console.WriteLine($"\nThe total area of The Great Mosque of Mecca is: \n{C}.\n");
                    Console.WriteLine($"In order to floor that area, it would cost a total of: \n{TotalCost(C)} in Mexican Pesos (I mean, weird, huh?).\n");
                    MenuPause();
                    Console.Clear();
                    Console.WriteLine(menuHeader);
                    Console.WriteLine("\nThis has been Architect Arithmetic...");
                    break;
                default:
                    Console.WriteLine("\n\n!!!!Error: Default!!!!\n\n");
                    break;
            }
            MenuPause();
            
            //End of main program
            //Add loop
        }

        static Double CalcTeoArea()
        {
            //Declaration of the specefic dimensions of this monument:             
            //image link: https://content.codecademy.com/courses/learn-c-sharp/methods/teotihuacan-complete.svg

            double rectArea = Rectangle(1500, 2500);
            double circleArea = Circle(375);
            double triArea = Triangle(375, 500);
            //Calculate & Return Area - Why save it as a variable? - Saves Memory
            return rectArea+circleArea+triArea;
        }

        static Double CalcTajArea()
        {
            //Declaration of the specefic dimensions of this monument:             
            //image link: https://content.codecademy.com/courses/learn-c-sharp/methods/tajmahal-complete.svg
           
            double rectArea = Rectangle(90.5, 90.5);
            double triArea = (Triangle(24, 24))*4;
            //Calculate & Return Area - Why save it as a variable? - Saves Memory
            return rectArea - triArea;
        }

        static Double CalcMecArea()
        {
            //Declaration of the specefic dimensions of this monument:             
            //image link: https://content.codecademy.com/courses/learn-c-sharp/methods/greatmosque-complete.svg

            double triArea = Triangle(84, 264);
            double rectArea1 = Rectangle(200, 264);
            double rectArea2 = Rectangle(180, 106);

            //Calculate & Return Area - Why save it as a variable? - Saves Memory
            return rectArea1 + rectArea2 + triArea;
        }
    }
}



//ORIGNAL STEP-BY STEP FROM CODECADEMY (PRE RE-FACTORING)

/*static void calcTotalCost()
        {
            //Step 1
            //Method for Quadrilaterals
            static double Rectangle(double length, double width)
            {
                return (length * width);
            }
            //Step 2
            //Method for Circles
            static double Circle(double radius)
            {
                return (Math.PI * Math.Pow(radius, 2));
            }
            //Step 3
            //Method for Triangles
            static double Triangle(double bottom, double height)
            {
                return ((.5) * bottom * height);
            }
            //Step 4
            //Test
            //Console.WriteLine($"Rectangle Test: {Rectangle(4, 5)}");  //Expected Output: 20
            //Console.WriteLine($"Circle Test: {Circle(4)}");       //Expected Output: ~50
            //Console.WriteLine($"Triangle Test: {Triangle(10, 9)}"); //Expected Output: 45
            //Step 5
            //Location: Teotihuacan
            //Break up into polygons/primitives
            //image link: https://content.codecademy.com/courses/learn-c-sharp/methods/teotihuacan-complete.svg
            //Base Rectangle -> 1500m x 2500m
            //Protruding Circle -> Radius of 375m
            //Protruding Triangle -> 750m x 500m
            //Step 6
            //Calculate Area
            double rectArea = Rectangle(1500, 2500);
            double circleArea = (Circle(375)) / 2;
            double triArea = (Triangle(375, 500)) * 2;
            double totalArea = rectArea + circleArea + triArea;
            //Step 7
            //Hypothetical cost of flooring material in Pesos
            double flooringCost = 180;
            double totalCost = totalArea * flooringCost;
            //Step 8
            //Result of Step 7
                //Console.WriteLine($"The total cost to floor all of Ancient Mexican City, Teotihuacan, in Mexican Pesos is: {totalCost}");
            //Step 9
            //Round the result to match proper Peso notation of 2 decimal places
            Console.WriteLine($"The total cost to floor all of Ancient Mexican City, Teotihuacan, in Mexican Pesos is: {Math.Round(totalCost, 2)}");
        }*/