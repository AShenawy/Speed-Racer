using UnityEngine;
using System.Collections;

public class SpeedRacer : MonoBehaviour
{
    /*
     (A.03.1)
     Setting Up Variables
    Inside the class �SpeedRacer�, create the following variables (note the letter capitalisation)
    1. carModel, which holds the string value GTR R35
    2. engineType, which holds the string value V6, Twin Turbo
    3. carWeight, which holds the integer value 1609
    4. yearMade, which holds the integer value 2009
    5. maxAcceleration, which holds the float/decimal value 0.98
    6. isCarTypeSedan, which holds the boolean value false
    7. hasFrontEngine, which holds the boolean value true
     */

    /*
     Setting Up Variables (A.03.2)
     1. In the SpeedRacer class, declare the following variable (note the letter capitalisation)
        a. carMaker, which is of the string data type, and holds no value (un-initialized).
     2. Make all the variables in the class publicly accessible.
     */

    public string carMaker;

    public string carModel = "GTR R35";
    public string engineType = "V6, Twin Turbo";
    public int carWeight = 1609;
    public int yearMade = 2009;
    public float maxAcceleration = 0.98f;
    public bool isCarTypeSedan = false;
    public bool hasFrontEngine = true;

    /*
     Adding Our Custom Data Type (A.03.2)
    1. In the code, create a public subclass within the SpeedRacer class. 
    Name the class Fuel (note the capitalization of the first letter in class names). This will hold information about the car�s fuel levels. 
    Inside the Fuel subclass, do the following:
        a. Declare an integer variable and name it fuelLevel. Keep it uninitialized.
        b. Create a class constructor, which has 1 parameter of the integer data type. 
        This parameter will be used to initialize the fuelLevel variable when the Fuel class is instantiated/created, 
        so name it something appropriate, such as amount.
        c. Inside the constructor, assign the constructor parameter�s value to the fuelLevel variable to initialize it.
     */
    public class Fuel
    {
        int fuelLevel;

        public Fuel(int amount)
        {
            fuelLevel = amount;
        }

        //Class constructor
        public Fuel()
        {
            int amount = 1;
            fuelLevel = amount;
        }

    }

    /*
     Adding Our Custom Data Type (A.03.2)
     2. Back in the SpeedRacer class, and after the Fuel subclass block/scope ends, create a new public variable of the type Fuel. 
     Name it carFuel, and initialize it with a new instance of the Fuel class, while passing the constructor a value of 100.
     */
    public Fuel carFuel = new Fuel(100);

    void Start()
    {
        /*
         1-(A.03.1).
        In the Start function, print to the Unity console a sentence stating the values stored in the carModel and engineType variables.
        */

        /*
         Setting Up Variables (A.03.2)
         6. In the Start function, where the first print function that displays a message including the carModel and engineType variables is; 
        modify the message, so that it includes the carMaker variable as well, 
        where it appears somewhere in the message after carModel and before engineType value.
         */
        print("The car model is " + carModel + " created by " + carMaker + ". " + " And the engine type is " + engineType + ".");

        //2-(A.03.1).
        CheckWeight();

        /*
         4-(A.03.1).
        In the Start function, after the CheckWeight function call, check if the yearMade value is less than or equal to 2009.
        If the value is less than 2009, then:
            a. Print a console message stating what year the car was introduced in, using the yearMade variable.
            b. Call the CalculateAge function, passing it the yearMade as an argument. 
               Create an integer variable to store the return result of it. You can call it carAge as an example.
            c. Print a console message describing the age of the car, using the new carAge variable.
        If not, then:
            d. Print a console message that the car was introduced in the 2010�s.
            e. Print another message stating the car�s maximum acceleration, using the maxAcceleration variable.
         */
        if (yearMade <= 2009)
        {
            print("The car was introduced in " + yearMade + ".");
            int carAge = CalculateAge(yearMade);
            print("The age of the car is " + carAge + ".");

        }
        else {
            print("The car was introduced in the 2010�s.");
            print("The car�s maximum acceleration is " + maxAcceleration + ".");
        }

        /*
         6-(A.03.1).
         In the Start function, call the print function and provide it with the return result of the CheckCharacteristics function.
         */
        string message = CheckCharacteristics();
        print(message);

    }

    /*
    2-(A.03.1).
    Create a function named CheckWeight, which takes no arguments and returns nothing.
    The function should check if the carWeight value is less than 1500.
    If it is, then print to the console a message stating that the carModel weighs less than 1500 kg.
    Otherwise, print to the console a message stating that the carModel weighs over 1500 kg.
    Call the CheckWeight function inside the Start function, after the first print in the previous step.
    */
    void CheckWeight() {
        if (carWeight < 1500)
        {
            print("The car weighs less than 1500 kg.");
        }
        else {
            print("The car weighs over 1500 kg.");
        }
    }

    /*
     3-(A.03.1).
    Create another function named CalculateAge, which takes one integer argument and returns an integer.
    Inside the function, return the result of subtracting the yearMade variable from the number 2021.
     */
    int CalculateAge(int yearMade) {
        int result = 2021 - yearMade;
        return result;
    }

    /*
     5-(A.03.1).
    Create a function named CheckCharacteristics, which takes no arguments and returns a string value.
    In the function body, check if the car type is a sedan or not, using the isCarTypeSedan variable. 
    If yes, return a string indicating that the car type is a sedan.
    If not, then check if it has a front engine, using the hasFrontEngine variable. 
    If that is true, then return a string indicating that the car isn�t a sedan, but has a front engine.
    If both checks failed, then return a string saying that the car is neither a sedan nor does it have a front engine.
     */
    string CheckCharacteristics() {
        
        string result;

        if (isCarTypeSedan == true) {
            result = "The car type is a sedan.";
            return result;
        }
        else
        {
            if (hasFrontEngine == true)
            {
                result = "The car isn�t a sedan, but has a front engine.";
                return result;
            }
            else
            {
                result = "The car is neither a sedan nor does it have a front engine.";
                return result;
            }
        }
    }
    /*
    void Update()
    {
       
    }
    */
}
