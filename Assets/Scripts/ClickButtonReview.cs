using UnityEngine;
using UnityEngine.UI;

//===== This is a review of the ClickButton script =====
public class ClickButtonReview : MonoBehaviour
{
    public Button myButton;
    public Text outputFuel;

    void Start()
    {
        //==== Set the text to some message when the game starts and the button isn't clicked
        outputFuel.text = "Click the Consume Fuel button to see something...";
    }

    public void TaskOnClick()
    {
        ConsumeFuel();

        //===== Create a new variable to store the return of the CheckFuelLevel function. Check the function below for more info.
        string fuelCheckResult = CheckFuelLevel();

        //===== You can either directly update the text like so
        //outputFuel.text = fuelCheckResult;
        
        //===== Or you can call the SeeText function you made
        seeText(fuelCheckResult);

        //===== Just choose one or the other. If you keep both then you're doing the same thing twice
    }

    // ==== Inconsistent function naming style here. seeText should be SeeText
    public void seeText(string text)
    {
        outputFuel.text = text;
    }

    public class Fuel
    {
        public int fuelLevel;

        public Fuel(int amount)
        {
            fuelLevel = amount;
        }
    }

    public Fuel carFuel = new Fuel(100);

    public void ConsumeFuel()
    {
        //carFuel.fuelLevel = carFuel.fuelLevel - 10;

        //===== This is a shorthand for the above
        carFuel.fuelLevel -= 10;
    }

    //===== This function will now be returning a string value. So change the return type from void to string =====
    public string CheckFuelLevel()
    {
        //=====  Create a local variable to store the outcome from the switch statement =====
        string fuelReport;

        switch (carFuel.fuelLevel)
        {
            case 70:
                // ===== Replace the print with assigning the string to the fuelReport variable =====
                //print("fuel level is nearing two-thirds");
                fuelReport = "fuel level is nearing two-thirds";
                break;

            case 50:
                // ===== Same for each of the cases
                fuelReport = "fuel level is at half amount";
                break;

            case 10:
                fuelReport = "Warning! Fuel level is critically low";
                break;

            default:
                fuelReport = "there's nothing to report";
                break;
        }

        // ==== After the switch statement ends, the fuelReport variable will be assigned one of the above string values.
        return fuelReport;
    }
}
