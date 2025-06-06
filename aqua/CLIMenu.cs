using System;
using System.IO;

public class CLIMenu
{
    //CLILogo logo = new CLILogo();
    // CLIPlayer player = new CLIPlayer();
    //CLISettings settings = new CLISettings();


   

    public static void options()
    {
        Console.Clear();
        Console.ForegroundColor = CLISettings.Mcolor; ;
        Console.WriteLine("====option====");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.WriteLine("1. Menu Colour");
        Console.WriteLine("2. Advancedoptions");
        Console.WriteLine("3. Credits");
        Console.WriteLine("4. Save");
        Console.WriteLine("0. Exit");
        Console.ResetColor();
        Console.WriteLine("");
        Console.Write(">");
        var optionsmenu = Console.ReadLine();

        switch (optionsmenu)
        {
            case "1":
                //Console.WriteLine("demo 3");
                MMAColoursel();
                break;
            case "4":
                //Console.WriteLine("demo 3");
               // CLIGameBackup.WriteBackup("s");
                break;
            case "2":
                //Console.WriteLine("demo 3");
                //Advancedoptions();
                CLIConfig.Advancedoptions();
                break;
            case "3":
                //Console.WriteLine("demo 3");
                Credits();
                break;
            case "0":
                //Console.Clear();
                CLIConfig.optionsretun();
                break;
            default:
                options();
                break;
        }
    }
    public static void Credits()
    {
        Console.Clear();
        Console.ForegroundColor = CLISettings.Mcolor;
        Console.WriteLine("0 to go to main menu");
        Console.ForegroundColor = CLISettings.Dmcolor;
        int x = ClIMiscellaneous.Creditsdata.Count;
        for (int i = 0; i < x; i++)
        {
            switch (ClIMiscellaneous.Creditsdata[i])
            {
                case "CL":
                    Color();
                    break;
                case "MC":
                    Console.ForegroundColor = CLISettings.Mcolor;
                    break;
                case "DMC":
                    Console.ForegroundColor = CLISettings.Dmcolor;
                    break;
                default:
                    Console.WriteLine(ClIMiscellaneous.Creditsdata[i]);
                    break;

            }
            void Color()
            {
                i++;
                switch (ClIMiscellaneous.Creditsdata[i])
                {
                    case "Red":
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case "Magenta":
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case "Yellow":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case "Green":
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case "Blue":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case "Cyan":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    case "Gray":
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    case "DarkRed":
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    case "DarkMagenta":
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        break;
                    case "DarkYellow":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        break;
                    case "DarkGreen":
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    case "DarkBlue":
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        break;
                    case "DarkCyan":
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        break;
                    case "DarkGray":
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        break;
                    default:
                        break;
                }
            }

        }
        var optionsmenu = Console.ReadLine();
        switch (optionsmenu)
        {
            case "0":
                Console.Clear();
                break;
            default:
                Credits();
                break;
        }
    }
    

    public static void MMAColoursel()
    {
        Console.Clear();
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.Write("1. ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("red");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.Write("2. ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Magenta");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.Write("3. ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Yellow");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.Write("4. ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Green");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.Write("5. ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Blue");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.Write("6. ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Cyan");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.Write("7. ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Gray");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.WriteLine("");
        Console.Write(">");
        Console.ForegroundColor = ConsoleColor.White;
        switch (Console.ReadLine())
        {
            case "1":
                CLISettings.Mcolor = ConsoleColor.Red;
                CLISettings.Dmcolor = ConsoleColor.DarkRed;
                break;
            case "2":
                CLISettings.Mcolor = ConsoleColor.Magenta;
                CLISettings.Dmcolor = ConsoleColor.DarkMagenta;
                break;
            case "3":
                CLISettings.Mcolor = ConsoleColor.Yellow;
                CLISettings.Dmcolor = ConsoleColor.DarkYellow;
                break;
            case "4":
                CLISettings.Mcolor = ConsoleColor.Green;
                CLISettings.Dmcolor = ConsoleColor.DarkGreen;
                break;
            case "5":
                CLISettings.Mcolor = ConsoleColor.Blue;
                CLISettings.Dmcolor = ConsoleColor.DarkBlue;
                break;
            case "6":
                CLISettings.Mcolor = ConsoleColor.Cyan;
                CLISettings.Dmcolor = ConsoleColor.DarkCyan;
                break;
            case "7":
                if (CLIRuntimevar.crt == true)
                {
                    CLISettings.Mcolor = ConsoleColor.White;
                    CLISettings.Dmcolor = ConsoleColor.Gray;
                }
                else
                {
                    CLISettings.Mcolor = ConsoleColor.Gray;
                    CLISettings.Dmcolor = ConsoleColor.DarkGray;
                }
                break;
            default:
                MMAColoursel();
                break;
        }
    }
    public static bool consolebool { get; set; } = false; 
    public static void Consol()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("====Consol====");
        Console.WriteLine("You can write commands here. Enter 0 to exit.");
        CLIMenu.consolebool = true; // set the console bool to true so it can be used
        while (CLIMenu.consolebool == true)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("");
            Console.Write(">");
            string? input = Console.ReadLine();


            //CLICmd.Cmd(input);

            Console.ResetColor();
        }
       
  }
    

    //text
    public static string textboxname { get; set; } = "";
    public static string textboxvar { get; set; } = "1";
    static string textboxstylevar = "1";
    static ConsoleColor textboxnameCL { get; set; } = ConsoleColor.White;
    static ConsoleColor CLtemmp { get; set; } = ConsoleColor.White;
    public static List<string?> textdata { get; set; } = new List<string?>();
    public static void textbox()
    {
        textboxstyle();
        int line = 1;
        int x = textdata.Count;
        for (int i = 0; i < x; i++)
        {

            switch (textdata[i])
            {
                case "CL":
                    Color();
                    break;
                case "MC":
                    Console.ForegroundColor = CLISettings.Mcolor;
                    break;
                case "DMC":
                    Console.ForegroundColor = CLISettings.Dmcolor;
                    break;
                case "PLC":
                    //Console.ForegroundColor = CLIPlayer.Color;
                    break;
                case "CR":
                    Console.ResetColor();
                    break;
                case "WL":
                    line++;
                    if (CLISettings.Debug == true)
                    {
                        Console.WriteLine($" {line - 1}/{CLISettings.textmaxline - 1}");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    if (line >= CLISettings.textmaxline)
                    {
                        textboxstylenext();
                        line = 1;
                        textboxstyle();
                    }


                    break;
                case "RS":
                    textdata.Clear();
                    break;
                case "TP":
                    textboxstyle();
                    break;
                case "NX":
                    if (line != CLISettings.textmaxline)
                    {
                        //int z = line;
                        for (int z = line; z < CLISettings.textmaxline; z++)
                        {
                            if (CLISettings.Debug == true)
                            {
                                Console.WriteLine($" {line - 1}/{CLISettings.textmaxline - 1}");
                            }
                            else
                            {
                                Console.WriteLine();
                            }
                        }
                        line = 1;
                    }
                    textboxstylenext();
                    break;
                default:
                    Console.Write(textdata[i]);
                    break;

            }
            void Color()
            {
                i++;
                switch (textdata[i])
                {
                    case "Red":
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case "Magenta":
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case "Yellow":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case "Green":
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case "Blue":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case "Cyan":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    case "Gray":
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    case "DarkRed":
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    case "DarkMagenta":
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        break;
                    case "DarkYellow":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        break;
                    case "DarkGreen":
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    case "DarkBlue":
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        break;
                    case "DarkCyan":
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        break;
                    case "DarkGray":
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        break;
                    default:
                        break;
                }
            }

        }
    }

    static void textboxstyle()
    {
        switch (textboxstylevar)
        {
            case "1":
                Console.Clear();
                Console.WriteLine();
                CLtemmp = Console.ForegroundColor;
                Console.ForegroundColor = CLISettings.Mcolor;
                Console.Write($"####/");
                Console.WriteLine(textboxname, Console.ForegroundColor = textboxnameCL);
                Console.ForegroundColor = CLtemmp;
                break;
            default:
                break;
        }
    }
    static void textboxstylenext()
    {
        //Console.WriteLine();
        CLtemmp = Console.ForegroundColor;
        Console.ForegroundColor = CLISettings.Mcolor;
        Console.Write($"next");
        Console.ReadLine();
        Console.ForegroundColor = CLtemmp;
        //return "null";
    }
    //old
    public string textboxvarold { get; set; } = "1";
    public string textboxnameold { get; set; } = "";
    public ConsoleColor textboxnamecold { get; set; } = ConsoleColor.White;

    public void TextBoxstartold()
    {
        switch (textboxvarold)
        {
            case "1":
                Console.Clear();
                Console.WriteLine();
                Console.ForegroundColor = CLISettings.Mcolor;
                Console.Write($"####/");
                Console.WriteLine(textboxnameold, Console.ForegroundColor = textboxnamecold);
                Console.ForegroundColor = CLISettings.Mcolor;
                break;
            case "0":
                Console.WriteLine();
                Console.Clear();
                Console.ForegroundColor = CLISettings.Mcolor;
                Console.Write($"####/");
                Console.WriteLine(textboxnameold, Console.ForegroundColor = textboxnamecold);
                Console.ForegroundColor = CLISettings.Mcolor;
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("textvar mode:error 404 perss enter to contue.");
                Console.ForegroundColor = ConsoleColor.White;
                CLIRuntimevar.rerror();
                Console.ReadLine();
                break;
        }
    }
    public void TextBoxsendold()
    {
        switch (textboxvarold)
        {
            case "1":

                //return r;
                //InGameControls();
                break;
            case "0":
                Console.WriteLine();
                Console.ForegroundColor = CLISettings.Mcolor;
                Console.Write($"next");
                Console.ReadLine();
                //return "null";
                break;
            default:
                break;
        }
    }
    //still good
    
}