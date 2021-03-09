using System;
using System.Collections.Generic;

class Checker
{    
    static void Main()
    {
        float temperatureInput,stateOfChargeInput,chargeRateInput;
        string languageInput = string.Empty;
        languageInput = GetLanguageInput();
        temperatureInput = GetTemperatureInput(languageInput);
        stateOfChargeInput = GetStateOfChargeInput(languageInput);
        chargeRateInput = GetChargeRateInput(languageInput);
        BatteryExamine batteryExamine = new BatteryExamine();
        batteryExamine.BatteryIsOk(new BatteryFactors(temperatureInput, stateOfChargeInput, chargeRateInput,languageInput));
    }

    static string GetLanguageInput()
    {
        DisplayMessage("Please select language 1.English 2.German");
        int languageChoice = Convert.ToInt32(Console.ReadLine());
        if (languageChoice == 1)
        {
            return "English";
        }
        else if (languageChoice==2)
        {
            return "German";
        }
        else
        {
            DisplayMessage("Please Enter valid value");
            Environment.Exit(0);
            return "Wrong Input";
        }
    }
    static float GetTemperatureInput(string language)
    {
            int temperatureUnit;
        if (language == "English")
        {
            DisplayMessage("Please provide temperature unit 1.Celsius 2.Fahrenheit");
            temperatureUnit = Convert.ToInt32(Console.ReadLine());
            DisplayMessage("Please provide temprature value:");
            if (temperatureUnit == 1)
            {
                return float.Parse(Console.ReadLine());
            }
            else
            {
                return ConvertTemperatureCelsiusToFahrenheit(float.Parse(Console.ReadLine()));
            }            
        }
        else
        {
            DisplayMessage("Bitte Temperatureinheit 1.Celsius 2.Fahrenheit angeben");
            temperatureUnit = Convert.ToInt32(Console.ReadLine());
            DisplayMessage("Bitte geben Sie den Temperaturwert an");
            if (temperatureUnit == 1)
            {
                return float.Parse(Console.ReadLine());
            }
            else
            {
                return ConvertTemperatureCelsiusToFahrenheit(float.Parse(Console.ReadLine()));
            }
           
        }
         
        
    }
    static float GetStateOfChargeInput(string language)
    {
        if (language == "English")
        {           
            DisplayMessage("Please provide state of charge value:");
            return float.Parse(Console.ReadLine());
        }
        else
        {
            DisplayMessage("Bitte geben Sie den Ladezustand an:");
            return float.Parse(Console.ReadLine());
        }

    }
    static float GetChargeRateInput(string language)
    {
        if (language == "English")
        {
            DisplayMessage("Please provide charge rate value:");
            return float.Parse(Console.ReadLine());
        }
        else
        {
            DisplayMessage("Bitte geben Sie den Gebührenwert an:");
            return float.Parse(Console.ReadLine());
        }

    }
    static void DisplayMessage(string inputMessage)
    {
        Console.WriteLine(inputMessage);
    }
    static float ConvertTemperatureCelsiusToFahrenheit(float fahrenheitTemp)
    {
        return (fahrenheitTemp - 32) * 5 / 9;
    }
}

