
/// <summary>
/// Class with <b>Static Constructor</b> and <b>Static Field</b>
/// <br /><br />
/// - A special constructor for a class/type. <br />
/// - Automatically called by the runtime. <br />
/// - Runs before the type is used for the first time. <br />
/// - Also runs before the first instance is created. <br />
/// - Cannot be called manually. <br />
/// - Has no parameters. <br />
/// - Has no access modifier. <br />
/// - Runs only once for a type. <br />
/// - Commonly used to initialize static members. <br />
/// - Static fields do not require a static constructor. <br />
/// - Simple values → initialize directly in the field declaration. <br />
/// - Initialization requiring logic/process → use a static constructor. <br />
/// <br /><br />
/// Instance constructor → initializes each object. <br />
/// Static constructor   → initializes the type/class. <br />
/// </summary>
public class Person
{
    public string personName;
    public string personAge;

    // Static field
    public static string defaultName;
    public static string defaultAge;

    // Static constructor
    static Person()
    {
        // Static field initialization
        defaultName = "unknown";
        defaultAge = "unknown";
    }

    public Person()
    {
        // Field initialization and constructor logic goes here.
        personName = defaultName;
        personAge = defaultAge;
    }

    public Person(string name)
    {
        // Field initialization and constructor logic goes here.
        personName = name;
        personAge = defaultAge;
    }

    public Person(string name, int age)
    {
        // Field initialization and constructor logic goes here.
        personName = name;
        personAge = age.ToString();
    }
}
