
public class CLIConfig
{

    public static void addon(string? api1 = "null", string? api2 = "null", string? api3 = "null", string? api4 = "null", string? api5 = "null")
    {
        //SGCLI.api(api1,api2,api3);//sg addon
    }
    //-------------------------------------------------------------------------------------------------------------------------------------------------------------------
    // these functions only exists so you can use the code in different modules. For example, if you wanted to make your own module, you could override it here.
    //-------------------------------------------------------------------------------------------------------------------------------------------------------------------  
    //options

    //cli options settings 
    public static void optionsretun()
    {
        Console.Clear();
    }
    public static void Advancedoptions()
    {
        //CLIMenu.Advancedoptions();
        //CLITest.Advancedoptions();
    }
    //Consol
    public static void Consol()
    {
        CLIMenu.Consol();
    }
    //Cli Consol settings
    public static void Consolext()
    {
         CLIMenu.consolebool = false;
    }


    //MMAColoursel ui color settings
    public static void MMAColoursel()
    {
        //CLIMenu.MMAColoursel();
        //CLITest.MMAColoursel();
    }
}
