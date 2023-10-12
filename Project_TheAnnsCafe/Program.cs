using System; /// Provides fundamental types and core functionality of C# language.
using System.Collections.Generic; /// Provides generic collections and related interfaces.
using System.Linq; /// Provides classes and interfaces for querying collections.
using System.Text; /// Provides encoding and decoding operations for strings.
using System.Threading.Tasks; /// Provides classes and interfaces that support multithreaded programming.
using System.IO; /// Provides file and directory I/O operations, including classes for reading and writing to files.

/// <summary>
/// This is the main namespace for the Project_TheAnnsCafe application.
/// </summary>
namespace Project_TheAnnsCafe
{
/// <summary>
/// Public class to represent an Ice Americano item.
/// </summary>
public class IceAmericano
{
    /// <summary>
    /// The quantity of Ice Americano cups.
    /// </summary>
    public double IceAmericanoQuantity;

    /// <summary>
    /// Constructor to initialize an IceAmericano object.
    /// </summary>
    public IceAmericano()
    {
        IceAmericanoQuantity = 0;
    }

    /// <summary>
    /// Method to set the quantity of Ice Americano cups based on user input.
    /// </summary>
    public void SetIceAmericanoQuantity()
    {
        // Display a prompt to the user.
        Console.Write("How many cups of Ice Americano would you like? ");

        // Accept the user input and convert it to a double.
        IceAmericanoQuantity = Convert.ToDouble(Console.ReadLine());
    }

    /// <summary>
    /// Display the quantity of Ice Americano cups added.
    /// </summary>
    public void DisplayIceAmericanoQuantity()
    {
        Console.WriteLine("\n" + IceAmericanoQuantity + " cup(s) successfully added!\n");
        Console.WriteLine("Press Enter to add more items.");
    }
}

    /// <summary>
/// Public class to represent a Hot Americano item.
/// </summary>
public class HotAmericano
{
    /// <summary>
    /// The quantity of Hot Americano cups.
    /// </summary>
    public double HotAmericanoQuantity;

    /// <summary>
    /// Constructor to initialize a HotAmericano object.
    /// </summary>
    public HotAmericano()
    {
        HotAmericanoQuantity = 0;
    }

    /// <summary>
    /// Method to set the quantity of Hot Americano cups based on user input.
    /// </summary>
    public void SetHotAmericanoQuantity()
    {
        // Display a prompt to the user.
        Console.Write("How many cups of Hot Americano would you like? ");

        // Accept the user input and convert it to a double.
        HotAmericanoQuantity = Convert.ToDouble(Console.ReadLine());
    }

    /// <summary>
    /// Display the quantity of Hot Americano cups added.
    /// </summary>
    public void DisplayHotAmericanoQuantity()
    {
        Console.WriteLine("\n" + HotAmericanoQuantity + " cup(s) successfully added!\n");
        Console.WriteLine("Press Enter to add more items.");
    }
}

   /// <summary>
/// Public class to represent an Ice Cappuccino item.
/// </summary>
public class IceCappuccino
{
    /// <summary>
    /// The quantity of Ice Cappuccino cups.
    /// </summary>
    public double IceCappuccinoQuantity;

    /// <summary>
    /// Constructor to initialize an IceCappuccino object.
    /// </summary>
    public IceCappuccino()
    {
        IceCappuccinoQuantity = 0;
    }

    /// <summary>
    /// Method to set the quantity of Ice Cappuccino cups based on user input.
    /// </summary>
    public void SetIceCappuccinoQuantity()
    {
        // Display a prompt to the user.
        Console.Write("How many cups of Ice Cappuccino would you like? ");

        // Accept the user input and convert it to a double.
        IceCappuccinoQuantity = Convert.ToDouble(Console.ReadLine());
    }

    /// <summary>
    /// Display the quantity of Ice Cappuccino cups added.
    /// </summary>
    public void DisplayIceCappuccinoQuantity()
    {
        Console.WriteLine("\n" + IceCappuccinoQuantity + " cup(s) successfully added!\n");
        Console.WriteLine("Press Enter to add more items.");
    }
}

    /// <summary>
/// Public class to represent a Hot Cappuccino item.
/// </summary>
public class HotCappuccino
{
    /// <summary>
    /// The quantity of Hot Cappuccino cups.
    /// </summary>
    public double HotCappuccinoQuantity;

    /// <summary>
    /// Constructor to initialize a HotCappuccino object.
    /// </summary>
    public HotCappuccino()
    {
        HotCappuccinoQuantity = 0;
    }

    /// <summary>
    /// Method to set the quantity of Hot Cappuccino cups based on user input.
    /// </summary>
    public void SetHotCappuccinoQuantity()
    {
        // Display a prompt to the user.
        Console.Write("How many cups of Hot Cappuccino would you like? ");

        // Accept the user input and convert it to a double.
        HotCappuccinoQuantity = Convert.ToDouble(Console.ReadLine());
    }

    /// <summary>
    /// Display the quantity of Hot Cappuccino cups added.
    /// </summary>
    public void DisplayHotCappuccinoQuantity()
    {
        Console.WriteLine("\n" + HotCappuccinoQuantity + " cup(s) successfully added!\n");
        Console.WriteLine("Press Enter to add more items.");
    }
}

    /// <summary>
/// Public class to represent an Ice Caramel Macchiato item.
/// </summary>
public class IceCaramelMacchiato
{
    /// <summary>
    /// The quantity of Ice Caramel Macchiato cups.
    /// </summary>
    public double IceCaramelMacchiatoQuantity;

    /// <summary>
    /// Constructor to initialize an IceCaramelMacchiato object.
    /// </summary>
    public IceCaramelMacchiato()
    {
        IceCaramelMacchiatoQuantity = 0;
    }

    /// <summary>
    /// Method to set the quantity of Ice Caramel Macchiato cups based on user input.
    /// </summary>
    public void SetIceCaramelMacchiatoQuantity()
    {
        // Display a prompt to the user.
        Console.Write("How many cups of Ice Caramel Macchiato would you like? ");

        // Accept the user input and convert it to a double.
        IceCaramelMacchiatoQuantity = Convert.ToDouble(Console.ReadLine());
    }

    /// <summary>
    /// Display the quantity of Ice Caramel Macchiato cups added.
    /// </summary>
    public void DisplayIceCaramelMacchiatoQuantity()
    {
        Console.WriteLine("\n" + IceCaramelMacchiatoQuantity + " cup(s) successfully added!\n");
        Console.WriteLine("Press Enter to add more items.");
    }
}

   /// <summary>
/// Public class to represent a Hot Caramel Macchiato item.
/// </summary>
public class HotCaramelMacchiato
{
    /// <summary>
    /// The quantity of Hot Caramel Macchiato cups.
    /// </summary>
    public double HotCaramelMacchiatoQuantity;

    /// <summary>
    /// Constructor to initialize a HotCaramelMacchiato object.
    /// </summary>
    public HotCaramelMacchiato()
    {
        HotCaramelMacchiatoQuantity = 0;
    }

    /// <summary>
    /// Method to set the quantity of Hot Caramel Macchiato cups based on user input.
    /// </summary>
    public void SetHotCaramelMacchiatoQuantity()
    {
        // Display a prompt to the user.
        Console.Write("How many cups of Hot Caramel Macchiato would you like? ");

        // Accept the user input and convert it to a double.
        HotCaramelMacchiatoQuantity = Convert.ToDouble(Console.ReadLine());
    }

    /// <summary>
    /// Display the quantity of Hot Caramel Macchiato cups added.
    /// </summary>
    public void DisplayHotCaramelMacchiatoQuantity()
    {
        Console.WriteLine("\n" + HotCaramelMacchiatoQuantity + " cup(s) successfully added!\n");
        Console.WriteLine("Press Enter to add more items.");
    }
}

   /// <summary>
/// Public class to represent an Ice Coffee Latte item.
/// </summary>
public class IceCoffeeLatte
{
    /// <summary>
    /// The quantity of Ice Coffee Latte cups.
    /// </summary>
    public double IceCoffeeLatteQuantity;

    /// <summary>
    /// Constructor to initialize an IceCoffeeLatte object.
    /// </summary>
    public IceCoffeeLatte()
    {
        IceCoffeeLatteQuantity = 0;
    }

    /// <summary>
    /// Method to set the quantity of Ice Coffee Latte cups based on user input.
    /// </summary>
    public void SetIceCoffeeLatteQuantity()
    {
        // Display a prompt to the user.
        Console.Write("How many cups of Ice Coffee Latte would you like? ");

        // Accept the user input and convert it to a double.
        IceCoffeeLatteQuantity = Convert.ToDouble(Console.ReadLine());
    }

    /// <summary>
    /// Display the quantity of Ice Coffee Latte cups added.
    /// </summary>
    public void DisplayIceCoffeeLatteQuantity()
    {
        Console.WriteLine("\n" + IceCoffeeLatteQuantity + " cup(s) successfully added!\n");
        Console.WriteLine("Press Enter to add more items.");
    }
}

/// <summary>
/// Public class to represent a Hot Coffee Latte item.
/// </summary>
public class HotCoffeeLatte
{
    /// <summary>
    /// The quantity of Hot Coffee Latte cups.
    /// </summary>
    public double HotCoffeeLatteQuantity;

    /// <summary>
    /// Constructor to initialize a HotCoffeeLatte object.
    /// </summary>
    public HotCoffeeLatte()
    {
        HotCoffeeLatteQuantity = 0;
    }

    /// <summary>
    /// Method to set the quantity of Hot Coffee Latte cups based on user input.
    /// </summary>
    public void SetHotCoffeeLatteQuantity()
    {
        // Display a prompt to the user.
        Console.Write("How many cups of Hot Coffee Latte would you like? ");

        // Accept the user input and convert it to a double.
        HotCoffeeLatteQuantity = Convert.ToDouble(Console.ReadLine());
    }

    /// <summary>
    /// Display the quantity of Hot Coffee Latte cups added.
    /// </summary>
    public void DisplayHotCoffeeLatteQuantity()
    {
        Console.WriteLine("\n" + HotCoffeeLatteQuantity + " cup(s) successfully added!\n");
        Console.WriteLine("Press Enter to add more items.");
    }
}

    /// <summary>
/// Public class to represent an Ice Mochachino item.
/// </summary>
public class IceMochachino
{
    /// <summary>
    /// The quantity of Ice Mochachino cups.
    /// </summary>
    public double IceMochachinoQuantity;

    /// <summary>
    /// Constructor to initialize an IceMochachino object.
    /// </summary>
    public IceMochachino()
    {
        IceMochachinoQuantity = 0;
    }

    /// <summary>
    /// Method to set the quantity of Ice Mochachino cups based on user input.
    /// </summary>
    public void SetIceMochachinoQuantity()
    {
        // Display a prompt to the user.
        Console.Write("How many cups of Ice Mochachino would you like? ");

        // Accept the user input and convert it to a double.
        IceMochachinoQuantity = Convert.ToDouble(Console.ReadLine());
    }

    /// <summary>
    /// Display the quantity of Ice Mochachino cups added.
    /// </summary>
    public void DisplayIceMochachinoQuantity()
    {
        Console.WriteLine("\n" + IceMochachinoQuantity + " cup(s) successfully added!\n");
        Console.WriteLine("Press Enter to add more items.");
    }
}

    /// <summary>
/// Public class to represent a Hot Mochachino item.
/// </summary>
public class HotMochachino
{
    /// <summary>
    /// The quantity of Hot Mochachino cups.
    /// </summary>
    public double HotMochachinoQuantity;

    /// <summary>
    /// Constructor to initialize a HotMochachino object.
    /// </summary>
    public HotMochachino()
    {
        HotMochachinoQuantity = 0;
    }

    /// <summary>
    /// Method to set the quantity of Hot Mochachino cups based on user input.
    /// </summary>
    public void SetHotMochachinoQuantity()
    {
        // Display a prompt to the user.
        Console.Write("How many cups of Hot Mochachino would you like? ");

        // Accept the user input and convert it to a double.
        HotMochachinoQuantity = Convert.ToDouble(Console.ReadLine());
    }

    /// <summary>
    /// Display the quantity of Hot Mochachino cups added.
    /// </summary>
    public void DisplayHotMochachinoQuantity()
    {
        Console.WriteLine("\n" + HotMochachinoQuantity + " cup(s) successfully added!\n");
        Console.WriteLine("Press Enter to add more items.");
    }
}

/// <summary>
/// Public class to represent Chocolate Cookies.
/// </summary>
public class ChocolateCookies
{
    /// <summary>
    /// The quantity of Chocolate Cookies pieces.
    /// </summary>
    public double ChocolateCookiesQuantity;

    /// <summary>
    /// Constructor to initialize a ChocolateCookies object.
    /// </summary>
    public ChocolateCookies()
    {
        ChocolateCookiesQuantity = 0;
    }

    /// <summary>
    /// Method to set the quantity of Chocolate Cookies pieces based on user input.
    /// </summary>
    public void SetChocolateCookiesQuantity()
    {
        // Display a prompt to the user.
        Console.Write("How many pieces of Chocolate Cookies would you like? ");

        // Accept the user input and convert it to a double.
        ChocolateCookiesQuantity = Convert.ToDouble(Console.ReadLine());
    }

    /// <summary>
    /// Display the quantity of Chocolate Cookies pieces added.
    /// </summary>
    public void DisplayChocolateCookiesQuantity()
    {
        Console.WriteLine("\n" + ChocolateCookiesQuantity + " piece(s) successfully added!\n");
        Console.WriteLine("Press Enter to add more items.");
    }
}

  /// <summary>
/// Public class to represent Vanilla Cookies.
/// </summary>
public class VanillaCookies
{
    /// <summary>
    /// The quantity of Vanilla Cookies pieces.
    /// </summary>
    public double VanillaCookiesQuantity;

    /// <summary>
    /// Constructor to initialize a VanillaCookies object.
    /// </summary>
    public VanillaCookies()
    {
        VanillaCookiesQuantity = 0;
    }

    /// <summary>
    /// Method to set the quantity of Vanilla Cookies pieces based on user input.
    /// </summary>
    public void SetVanillaCookiesQuantity()
    {
        // Display a prompt to the user.
        Console.Write("How many pieces of Vanilla Cookies would you like? ");

        // Accept the user input and convert it to a double.
        VanillaCookiesQuantity = Convert.ToDouble(Console.ReadLine());
    }

    /// <summary>
    /// Display the quantity of Vanilla Cookies pieces added.
    /// </summary>
    public void DisplayVanillaCookiesQuantity()
    {
        Console.WriteLine("\n" + VanillaCookiesQuantity + " piece(s) successfully added!\n");
        Console.WriteLine("Press Enter to add more items.");
    }
}

    /// <summary>
/// Public class to represent Coffee Cookies.
/// </summary>
public class CoffeeCookies
{
    /// <summary>
    /// The quantity of Coffee Cookies pieces.
    /// </summary>
    public double CoffeeCookiesQuantity;

    /// <summary>
    /// Constructor to initialize a CoffeeCookies object.
    /// </summary>
    public CoffeeCookies()
    {
        CoffeeCookiesQuantity = 0;
    }

    /// <summary>
    /// Method to set the quantity of Coffee Cookies pieces based on user input.
    /// </summary>
    public void SetCoffeeCookiesQuantity()
    {
        // Display a prompt to the user.
        Console.Write("How many pieces of Coffee Cookies would you like? ");

        // Accept the user input and convert it to a double.
        CoffeeCookiesQuantity = Convert.ToDouble(Console.ReadLine());
    }

    /// <summary>
    /// Display the quantity of Coffee Cookies pieces added.
    /// </summary>
    public void DisplayCoffeeCookiesQuantity()
    {
        Console.WriteLine("\n" + CoffeeCookiesQuantity + " piece(s) successfully added!\n");
        Console.WriteLine("Press Enter to add more items.");
    }
}

/// <summary>
/// Public class to represent French Fries.
/// </summary>
public class FrenchFries
{
    /// <summary>
    /// The quantity of French Fries portions.
    /// </summary>
    public double FrenchFriesQuantity;

    /// <summary>
    /// Constructor to initialize a FrenchFries object.
    /// </summary>
    public FrenchFries()
    {
        FrenchFriesQuantity = 0;
    }

    /// <summary>
    /// Method to set the quantity of French Fries portions based on user input.
    /// </summary>
    public void SetFrenchFriesQuantity()
    {
        // Display a prompt to the user.
        Console.Write("How many portions of French Fries would you like? ");

        // Accept the user input and convert it to a double.
        FrenchFriesQuantity = Convert.ToDouble(Console.ReadLine());
    }

    /// <summary>
    /// Display the quantity of French Fries portions added.
    /// </summary>
    public void DisplayFrenchFriesQuantity()
    {
        Console.WriteLine("\n" + FrenchFriesQuantity + " portion(s) successfully added!\n");
        Console.WriteLine("Press Enter to add more items.");
    }
}

   /// <summary>
/// Public class to represent Croquette.
/// </summary>
public class Croquette
{
    /// <summary>
    /// The quantity of Croquette portions.
    /// </summary>
    public double CroquetteQuantity;

    /// <summary>
    /// Constructor to initialize a Croquette object.
    /// </summary>
    public Croquette()
    {
        CroquetteQuantity = 0;
    }

    /// <summary>
    /// Method to set the quantity of Croquette portions based on user input.
    /// </summary>
    public void SetCroquetteQuantity()
    {
        // Display a prompt to the user.
        Console.Write("How many portions of Croquette would you like? ");

        // Accept the user input and convert it to a double.
        CroquetteQuantity = Convert.ToDouble(Console.ReadLine());
    }

    /// <summary>
    /// Display the quantity of Croquette portions added.
    /// </summary>
    public void DisplayCroquetteQuantity()
    {
        Console.WriteLine("\n" + CroquetteQuantity + " portion(s) successfully added!\n");
        Console.WriteLine("Press Enter to add more items.");
    }
}
    /// <summary>
/// This is the main class of the program.
/// </summary>
    class Program
    {
        /// <summary>
/// The main entry point of the program.
/// </summary>
/// <param name="args">Command-line arguments.</param>
        static void Main(string[] args)
        {
             /// <summary>
    /// Represents an Ice Americano item.
    /// </summary>
    iceamericano ia = new iceamericano();

    /// <summary>
    /// Represents a Hot Americano item.
    /// </summary>
    hotamericano ha = new hotamericano();

    /// <summary>
    /// Represents an Ice Cappuccino item.
    /// </summary>
    icecappucino ic = new icecappucino();

    /// <summary>
    /// Represents a Hot Cappuccino item.
    /// </summary>
    hotcappucino hc = new hotcappucino();

    /// <summary>
    /// Represents an Ice Caramel Macchiato item.
    /// </summary>
    icecaramelmacchiatto icm = new icecaramelmacchiatto();

    /// <summary>
    /// Represents a Hot Caramel Macchiato item.
    /// </summary>
    hotcaramelmacchiatto hcm = new hotcaramelmacchiatto();

    /// <summary>
    /// Represents an Ice Coffee Latte item.
    /// </summary>
    icecoffeelatte icl = new icecoffeelatte();

    /// <summary>
    /// Represents a Hot Coffee Latte item.
    /// </summary>
    hotcoffeelatte hcl = new hotcoffeelatte();

    /// <summary>
    /// Represents an Ice Mochachino item.
    /// </summary>
    icemochachino im = new icemochachino();

    /// <summary>
    /// Represents a Hot Mochachino item.
    /// </summary>
    hotmochachino hm = new hotmochachino();

    /// <summary>
    /// Represents a Chocolate Cookies item.
    /// </summary>
    chocolatecookies cc = new chocolatecookies();

    /// <summary>
    /// Represents a Vanilla Cookies item.
    /// </summary>
    vanillacookies vc = new vanillacookies();

    /// <summary>
    /// Represents a Coffee Cookies item.
    /// </summary>
    coffeecookies fc = new coffeecookies();

    /// <summary>
    /// Represents a French Fries item.
    /// </summary>
    frenchfries ff = new frenchfries();

    /// <summary>
    /// Represents a Croquette item.
    /// </summary>
    croquette cr = new croquette();

            /// <summary>
/// This section displays a welcome message and collects cashier and customer information.
/// </summary>
Console.WriteLine("==============================================");
Console.WriteLine("\t    WELCOME TO THE ANN'S CAFÉ ");
Console.WriteLine("     Find your taste of Coffee in Our Café");
Console.WriteLine("==============================================");

/// <summary>
/// Prompt the user to input the cashier's ID
/// </summary>
Console.Write("Input Cashier ID : ");

/// <summary>
/// Accept and store the cashier_id
/// </summary>
double cashier_id = Convert.ToDouble(Console.ReadLine());

/// <summary>
/// Prompt the user to input the cashier's name
/// </summary>
Console.Write("Input Cashier Name = ");

/// <summary>
/// Accept and store the cashier_name
/// </summary>
string cashier_name = Console.ReadLine();

/// <summary>
/// Prompt the user to input the customer's name
/// </summary>
Console.Write("Input Customer Name = ");

/// <summary>
/// Accept and store the customer_name
/// </summary>
string customer_name = Console.ReadLine();


            /// <summary>
/// Declare the variable 'choose' to store the user's choice.
/// </summary>
int choose = 0;

/// <summary>
/// Perform a do-while loop to display the menu and collect user choices.
/// </summary>
do
{
    // Display the main menu.
    Console.WriteLine("==========================================");
    Console.WriteLine("---------- THE ANN'S  CAFÉ MENU ----------");
    Console.WriteLine("------------------------------------------");
    Console.WriteLine("-------------- COFFEE  SIDE --------------");
    Console.WriteLine("------------------------------------------");
    Console.WriteLine("|            COFFEE          |   PRICE   |");
    Console.WriteLine("------------------------------------------");
    Console.WriteLine("1. Ice Americano             = Rp 18000");
    Console.WriteLine("2. Hot Americano             = Rp 16000");
    Console.WriteLine("3. Ice Cappucino             = Rp 22000");
    Console.WriteLine("4. Hot Cappucino             = Rp 20000");
    Console.WriteLine("5. Ice Caramel Macchiatto    = Rp 22000");
    Console.WriteLine("6. Hot Caramel Macchiatto    = Rp 20000");
    Console.WriteLine("7. Ice Coffee Latte          = Rp 23000");
    Console.WriteLine("8. Hot Coffee Latte          = Rp 21000");
    Console.WriteLine("9. Ice Mocachino             = Rp 21000");
    Console.WriteLine("10. Hot Mocachino            = Rp 19000");
    Console.WriteLine("------------------------------------------");
    Console.WriteLine("--------------- SNACK SIDE ---------------");
    Console.WriteLine("------------------------------------------");
    Console.WriteLine("|            SNACK          |   PRICE   |");
    Console.WriteLine("------------------------------------------");
    Console.WriteLine("11. Chocolate Cookies        = Rp 5000");
    Console.WriteLine("12. Vanilla Cookies          = Rp 5000");
    Console.WriteLine("13. Coffee Cookies           = Rp 5000");
    Console.WriteLine("14. French Fries             = Rp 10000");
    Console.WriteLine("15. Croquette                = Rp 12000");
    Console.WriteLine("-----------------------------------------");
    Console.WriteLine("16. Finish add item(s), go to cart");
    Console.WriteLine("-----------------------------------------");
    
    /// <summary>
    /// Prompt the user to input the menu code for their selection.
    /// </summary>
    Console.Write("Input menu's code that you want to buy = ");


                // Accept the user's choice.
    choose = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" ");

    // Use a switch-case to handle the user's choice.
    switch (choose)
    {
        // Handle case 1
        case 1:
            ia.iceamericano_cup();
            ia.display_iceamericano();
            break;

        // Handle case 2
        case 2:
            ha.hotamericano_cup();
            ha.display_hotamericano();
            break;

        // Handle case 3
        case 3:
            ic.icecappucino_cup();
            ic.display_icecappucino();
            break;

        // Handle case 4
        case 4:
            hc.hotcappucino_cup();
            hc.display_hotcappucino();
            break;

        // Handle case 5
        case 5:
            icm.icecaramelmacchiatto_cup();
            icm.display_icecaramelmacchiatto();
            break;

        // Handle case 6
        case 6:
            hcm.hotcaramelmacchiatto_cup();
            hcm.display_hotcaramelmacchiatto();
            break;

        // Handle case 7
        case 7:
            icl.icecoffeelatte_cup();
            icl.display_icecoffeelatte();
            break;

        // Handle case 8
        case 8:
            hcl.hotcoffeelatte_cup();
            hcl.display_hotcoffeelatte();
            break;

        // Handle case 9
        case 9:
            im.icemochachino_cup();
            im.display_icemochachino();
            break;

        // Handle case 10
        case 10:
            hm.hotmochachino_cup();
            hm.display_hotmochachino();
            break;

        // Handle case 11
        case 11:
            cc.chocolatecookies_pcs();
            cc.displaychocolatecookies();
            break;

        // Handle case 12
        case 12:
            vc.vanillacookies_pcs();
            vc.displayvanillacookies();
            break;

        // Handle case 13
        case 13:
            fc.coffeecookies_pcs();
            fc.displaycoffeecookies();
            break;

        // Handle case 14
        case 14:
            ff.frenchfries_portion();
            ff.displayfrenchfries();
            break;

        // Handle case 15
        case 15:
            cr.croquette_portion();
            cr.displaycroquette();
            break;

        // Handle case 16
        case 16:
            // Display the customer's cart and compute the total.
            Console.WriteLine("=============================================");
            Console.WriteLine("---------------- CUSTOMER CART --------------");
            Console.WriteLine("=============================================");
            // Display items and prices...
            // Compute the total...
            Console.WriteLine(" ");
            Console.WriteLine("Click enter to finish ordering coffee and snack");
            break;

        // Handle the default case
        default:
            Console.WriteLine("SOMETHING WENT WRONG! YOU CHOOSE THE WRONG CHOICE! ENTER TO GO BACK TO MENU");
            Console.ReadKey();
            break;
    }
    Console.ReadKey();
}
while (choose != 16);

           /// <summary>
/// Display the customer receipt.
/// </summary>
Console.WriteLine(" ");
Console.WriteLine("================================================");
Console.WriteLine("---------------- CUSTOMER RECEIPT --------------");
Console.WriteLine("================================================");
Console.WriteLine(ia.ice_americano + " cup Ice Americano            = Rp " + ia.ice_americano * 18000);
Console.WriteLine(ha.hot_americano + " cup Hot Americano            = Rp " + ha.hot_americano * 16000);
Console.WriteLine(ic.ice_cappucino + " cup Ice Cappucino            = Rp " + ic.ice_cappucino * 22000);
Console.WriteLine(hc.hot_cappucino + " cup Hot Cappucino            = Rp " + hc.hot_cappucino * 20000);
Console.WriteLine(icm.ice_caramelmacchiatto + " cup Ice Caramel Macchiatto   = Rp " + icm.ice_caramelmacchiatto * 22000);
Console.WriteLine(hcm.hot_caramelmacchiatto + " cup Hot Caramel Macchiatto   = Rp " + hcm.hot_caramelmacchiatto * 20000);
Console.WriteLine(icl.ice_coffeelatte + " cup Ice Coffee Latte         = Rp " + icl.ice_coffeelatte * 23000);
Console.WriteLine(hcl.hot_coffeelatte + " cup Hot Coffee Latte         = Rp " + hcl.hot_coffeelatte * 21000);
Console.WriteLine(im.ice_mochachino + " cup Ice Mochachino           = Rp " + im.ice_mochachino * 21000);
Console.WriteLine(hm.hot_mochachino + " cup Hot Mochachino           = Rp " + hm.hot_mochachino * 19000);
Console.WriteLine(cc.chocolate_cookies + " piece Chocolate Cookies      = Rp " + cc.chocolate_cookies * 5000);
Console.WriteLine(vc.vanilla_cookies + " piece Vanilla Cookies        = Rp " + vc.vanilla_cookies * 5000);
Console.WriteLine(fc.coffee_cookies + " piece Coffee Cookies         = Rp " + fc.coffee_cookies * 5000);
Console.WriteLine(ff.french_fries + " portion French Fries         = Rp " + ff.french_fries * 10000);
Console.WriteLine(cr.the_croquette + " portion Croquette            = Rp " + cr.the_croquette * 12000);
Console.WriteLine("-------------------------------------------");

/// <summary>
/// Display the total and compute the total.
/// </summary>
Console.WriteLine("TOTAL                          = Rp " + ((ia.ice_americano * 18000) + (ha.hot_americano * 16000) +
    (ic.ice_cappucino * 22000) + (hc.hot_cappucino * 20000) + (icm.ice_caramelmacchiatto * 22000) + (hcm.hot_caramelmacchiatto * 20000) +
    (icl.ice_coffeelatte * 23000) + (hcl.hot_coffeelatte * 21000) + (im.ice_mochachino * 21000) + (hm.hot_mochachino * 19000) +
    (cc.chocolate_cookies * 5000) + (vc.vanilla_cookies * 5000) + (fc.coffee_cookies * 5000) + (ff.french_fries * 10000) + (cr.the_croquette * 12000)));

/// <summary>
/// Display the cash input prompt.
/// </summary>
Console.Write("CASH                           = Rp ");

/// <summary>
/// Accept cash payment from the customer.
/// </summary>
double cash = Convert.ToDouble(Console.ReadLine());

/// <summary>
/// Display the change and compute the change.
/// </summary>
Console.WriteLine("CHANGE                         = Rp " + (cash - ((ia.ice_americano * 18000) + (ha.hot_americano * 16000) +
    (ic.ice_cappucino * 22000) + (hc.hot_cappucino * 20000) + (icm.ice_caramelmacchiatto * 22000) + (hcm.hot_caramelmacchiatto * 20000) +
    (icl.ice_coffeelatte * 23000) + (hcl.hot_coffeelatte * 21000) + (im.ice_mochachino * 21000) + (hm.hot_mochachino * 19000) +
    (cc.chocolate_cookies * 5000) + (vc.vanilla_cookies * 5000) + (fc.coffee_cookies * 5000) + (ff.french_fries * 10000) + (cr.the_croquette * 12000))));

          /// <summary>
/// Declare the variable for the receipt text.
/// </summary>
string TheAnnsCafeReceipt;

/// <summary>
/// Declare the variable for data.
/// </summary>
string data;

/// <summary>
/// Create an exception handling using try-catch.
/// </summary>
try
{
    Console.WriteLine(" ");
    Console.WriteLine("DOUBLE ENTER TO PRINT THE RECEIPT");
    Console.WriteLine(" ");
    
    /// <summary>
    /// Accept the input for TheAnnsCafeReceipt.
    /// </summary>
    TheAnnsCafeReceipt = Convert.ToString(Console.ReadKey());

    // Call StreamWriter to choose the directory for printing the receipt and specify the receipt name.
    StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        + "/TheAnnsCafeReceipt.txt");

    // Display the opening for the Customer Receipt using StreamWriter.
    sw.WriteLine("==================================================================");
    sw.WriteLine("\t \t \t  THE ANN'S CAFÉ ");
    sw.WriteLine("\t \t Find your taste of Coffee in Our Café");
    sw.WriteLine("  Instagram : @theannscafe      ||     Delivery Order : 0812345678910");
    sw.WriteLine("----------------------------- RECEIPT ----------------------------");

    // Display the current date and time using DateTime.Now using StreamWriter.
    sw.WriteLine("Date & Time : " + DateTime.Now);

    // Display and call Cashier ID and Cashier Name using StreamWriter.
    sw.WriteLine("Cashier ID : " + cashier_id + "\t         ||  Cashier Name : " + cashier_name);

    // Display and call Customer Name using StreamWriter.
    sw.WriteLine("Customer Name : " + customer_name);
    sw.WriteLine("------------------------------------------------------------------");

    // Display Customer Receipt List and compute the Total for each drink or snack using StreamWriter.
    sw.WriteLine(ia.ice_americano + " cup Ice Americano             = Rp " + ia.ice_americano * 18000);
    sw.WriteLine(ha.hot_americano + " cup Hot Americano             = Rp " + ha.hot_americano * 16000);
    sw.WriteLine(ic.ice_cappucino + " cup Ice Cappucino             = Rp " + ic.ice_cappucino * 22000);
    sw.WriteLine(hc.hot_cappucino + " cup Hot Cappucino             = Rp " + hc.hot_cappucino * 20000);
    sw.WriteLine(icm.ice_caramelmacchiatto + " cup Ice Caramel Macchiatto    = Rp " + icm.ice_caramelmacchiatto * 22000);
    sw.WriteLine(hcm.hot_caramelmacchiatto + " cup Hot Caramel Macchiatto    = Rp " + hcm.hot_caramelmacchiatto * 20000);
    sw.WriteLine(icl.ice_coffeelatte + " cup Ice Coffee Latte          = Rp " + icl.ice_coffeelatte * 23000);
    sw.WriteLine(hcl.hot_coffeelatte + " cup Hot Coffee Latte          = Rp " + hcl.hot_coffeelatte * 21000);
    sw.WriteLine(im.ice_mochachino + " cup Ice Mochachino            = Rp " + im.ice_mochachino * 21000);
    sw.WriteLine(hm.hot_mochachino + " cup Hot Mochachino            = Rp " + hm.hot_mochachino * 19000);
    sw.WriteLine(cc.chocolate_cookies + " piece Chocolate Cookies       = Rp " + cc.chocolate_cookies * 5000);
    sw.WriteLine(vc.vanilla_cookies + " piece Vanilla Cookies         = Rp " + vc.vanilla_cookies * 5000);
    sw.WriteLine(fc.coffee_cookies + " piece Coffee Cookies          = Rp " + fc.coffee_cookies * 5000);
    sw.WriteLine(ff.french_fries + " portion French Fries          = Rp " + ff.french_fries * 10000);
    sw.WriteLine(cr.the_croquette + " portion Croquette             = Rp " + cr.the_croquette * 12000);
    sw.WriteLine("------------------------------------------------------------------");

    // Display and compute the TOTAL using StreamWriter.
    sw.WriteLine("TOTAL                           = Rp " + ((ia.ice_americano * 18000) + (ha.hot_americano * 16000) +
                (ic.ice_cappucino * 22000) + (hc.hot_cappucino * 20000) + (icm.ice_caramelmacchiatto * 22000) + (hcm.hot_caramelmacchiatto * 20000) +
                (icl.ice_coffeelatte * 23000) + (hcl.hot_coffeelatte * 21000) + (im.ice_mochachino * 21000) + (hm.hot_mochachino * 19000) +
                (cc.chocolate_cookies * 5000) + (vc.vanilla_cookies * 5000) + (fc.coffee_cookies * 5000) + (ff.french_fries * 10000) + (cr.the_croquette * 12000)));

    // Display and call CASH using StreamWriter.
    sw.WriteLine("CASH                            = Rp " + cash);

    // Display and compute CHANGE using StreamWriter.
    sw.WriteLine("CHANGE                          = Rp " + (cash - ((ia.ice_americano * 18000) + (ha.hot_americano * 16000) +
                (ic.ice_cappucino * 22000) + (hc.hot_cappucino * 20000) + (icm.ice_caramelmacchiatto * 22000) + (hcm.hot_caramelmacchiatto * 20000) +
                (icl.ice_coffeelatte * 23000) + (hcl.hot_coffeelatte * 21000) + (im.ice_mochachino * 21000) + (hm.hot_mochachino * 19000) +
                (cc.chocolate_cookies * 5000) + (vc.vanilla_cookies * 5000) + (fc.coffee_cookies * 5000) + (ff.french_fries * 10000) + (cr.the_croquette * 12000))));

    // Close the StreamWriter.
    sw.Close();
}
catch (Exception e)
{
    // Handle exceptions.
    Console.WriteLine("An error occurred: " + e.Message);
}


                //display closing for Customer Receipt using StreamWriter
                sw.WriteLine("==================================================================");
                sw.WriteLine("      Thank You For Your Visit in Our Café! Enjoy Your Coffee!");
                sw.WriteLine("Wear Your Mask! Stay at Home! Stay Safe! Stay Healthy! Stay Happy!");
                sw.WriteLine("\t \t \t Have A Nice Day ^^ ");
                sw.WriteLine("==================================================================");
                sw.WriteLine(" ");

                 /// <summary>
    /// Accept input data from the user.
    /// </summary>
    data = Convert.ToString(Console.ReadKey());

    // Display data using StreamWriter.
    sw.WriteLine(data);
    sw.Close();
}
// Catch exceptions.
catch (Exception e)
{
    /// <summary>
    /// Handle and display the exception message.
    /// </summary>
    Console.WriteLine("Exception : " + e.Message);
}

/// <summary>
/// This block is executed regardless of whether an exception occurred or not.
/// </summary>
finally
{
    Console.WriteLine("Executing is finally blocked");
    Console.WriteLine(" ");
    Console.WriteLine("The Receipt is Already Printed");
}
        }
    }
}
