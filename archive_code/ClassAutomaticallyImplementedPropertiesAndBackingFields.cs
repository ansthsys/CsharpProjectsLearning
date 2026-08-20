using System.Diagnostics.CodeAnalysis;


/// <summary>
/// Automatically implemented properties
/// Short syntax for properties without custom accessor logic.
/// </summary>
public class Customer
{
    // Auto-implemented properties.
    public double TotalPurchases { get; set; }
    public string Name { get; set; }
    public int CustomerId { get; set; }

    public Customer(double purchases, string name, int id)
    {
        TotalPurchases = purchases;
        Name = name;
        CustomerId = id;
    }

    public string GetContactInfo() { return "ContactInfo"; }
    public string GetTransactionHistory() { return "History"; }
}

class CustomerProgram
{
    static void Main()
    {
        // Initialize a new object.
        Customer customer = new Customer(4987.63, "Northwind", 90108);

        // Modify a property.
        customer.TotalPurchases += 499.99;
    }
}


/// <summary>
/// Initializing automatically implemented properties
/// A property can have an initial value.
/// </summary>
public class CustomerDefault
{
    public string FirstName { get; set; } = "FirstName";
}


/// <summary>
/// Field-backed properties
/// Use the compiler-generated backing field inside an accessor.
/// </summary>
public class PersonValidation
{
    public string FirstName
    {
        get;
        set
        {
            field = string.IsNullOrWhiteSpace(value is false
                ? value
                : throw new ArgumentException(
                    nameof(value),
                    "First name can't be whitespace or null"));
        }
    } = "FirstName";
}


/// <summary>
/// Properties with backing fields
/// A backing field can store a computed property value.
/// </summary>
public class PersonCached
{
    public PersonCached() { }

    [SetsRequiredMembers]
    public PersonCached(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public required string FirstName { get; init; }
    public required string LastName { get; init; }

    private string? _fullName;

    public string FullName
    {
        get
        {
            if (_fullName is null)
                _fullName = $"{FirstName} {LastName}";

            return _fullName;
        }
    }
}


/// <summary>
/// Updating cached properties
/// Clear the cached value when its source properties change.
/// </summary>
public class PersonMutable
{
    private string? _firstName;

    public string? FirstName
    {
        get => _firstName;
        set
        {
            _firstName = value;
            _fullName = null;
        }
    }

    private string? _lastName;

    public string? LastName
    {
        get => _lastName;
        set
        {
            _lastName = value;
            _fullName = null;
        }
    }

    private string? _fullName;

    public string FullName
    {
        get
        {
            if (_fullName is null)
                _fullName = $"{FirstName} {LastName}";

            return _fullName;
        }
    }
}


/// <summary>
/// Immutable lightweight classes
/// Use get, init, or private set to restrict changes.
/// </summary>
class Contact
{
    // Read-only property.
    public string Name { get; }

    // Read-write property with a private set accessor.
    public string Address { get; private set; }

    public Contact(string contactName, string contactAddress)
    {
        // Both properties are accessible in the constructor.
        Name = contactName;
        Address = contactAddress;
    }

    // Name isn't assignable here.
    // public void ChangeName(string newName) => Name = newName;

    // Address is assignable here.
    public void ChangeAddress(string newAddress) => Address = newAddress;
}


/// <summary>
/// Static factory method
/// A static method creates an object through a private constructor.
/// </summary>
public class Contact2
{
    // Read-write property with a private set accessor.
    public string Name { get; private set; }

    // Read-only property.
    public string Address { get; }

    // Private constructor.
    private Contact2(string contactName, string contactAddress)
    {
        Name = contactName;
        Address = contactAddress;
    }

    // Public factory method.
    public static Contact2 CreateContact(string name, string address)
    {
        return new Contact2(name, address);
    }
}


/// <summary>
/// Create immutable objects
/// Create objects with a constructor or a static factory method.
/// </summary>
public class ContactProgram
{
    static void Main()
    {
        // Some simple data sources.
        string[] names =
        [
            "Person One",
            "Person Two",
            "Person Three",
            "Person Four",
            "Person Five"
        ];

        string[] addresses =
        [
            "123 Main St.",
            "345 Cypress Ave.",
            "678 1st Ave",
            "12 108th St.",
            "89 E. 42nd St."
        ];

        // Create Contact objects by using a constructor.
        var query1 = from i in Enumerable.Range(0, 5)
                     select new Contact(names[i], addresses[i]);

        // List elements can't be modified by client code.
        var contactList = query1.ToList();

        foreach (var contact in contactList)
        {
            Console.WriteLine("{0}, {1}", contact.Name, contact.Address);
        }

        // Create Contact2 objects by using a static factory method.
        var query2 = from i in Enumerable.Range(0, 5)
                     select Contact2.CreateContact(names[i], addresses[i]);

        // Console output is identical to query1.
        var contactList2 = query2.ToList();

        // List elements can't be modified by client code.
        // CS0272:
        // contactList2[0].Name = "Person Six";
    }
}


/// <summary>
/// Required properties
/// A required property must be set when creating an object.
/// </summary>
public class RequiredPerson
{
    public RequiredPerson() { }

    [SetsRequiredMembers]
    public RequiredPerson(string firstName) => FirstName = firstName;

    public required string FirstName { get; init; }
}

class RequiredPersonProgram
{
    static void Main()
    {
        var person1 = new RequiredPerson("PersonName");

        var person2 = new RequiredPerson
        {
            FirstName = "PersonName"
        };

        // Required property must be set.
        // var person3 = new RequiredPerson();
    }
}
