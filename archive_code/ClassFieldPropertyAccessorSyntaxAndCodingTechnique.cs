
using System.Diagnostics.CodeAnalysis;

namespace SomeNamespace
{
    /// <summary>
    /// Without using <b>Expression Body Member</b>
    /// </summary>
    class Student0
    {
        private string? _name;  // the name field
        public string Name    // the Name property
        {
            get
            {
                return _name != null ? _name : "NA";
            }
            set
            {
                _name = value;
            }
        }
    }


    /// <summary>
    /// Simple way using <b>Expression Body Member</b>
    /// </summary>
    class Student1
    {
        private string? _name;  // the name field
        public string Name    // the Name property
        {
            get => _name ?? "NA";
            set => _name = value;
        }
    }


    /// <summary>
    /// Field Backed Properties <br />
    /// Starting in C# 13, you can add validation or other logic in the accessor for a property 
    /// using the field keyword preview feature. The field keyword accesses the compiler synthesized backing 
    /// field for a property. It enables you to write a property accessor without explicitly declaring a separate backing field.
    /// </summary>
    public class Person0
    {
        public string? FirstName
        {
            get;
            set => field = value.Trim();
        }

        // Omitted for brevity.
    }


    /// <summary>
    /// Required properties <br />
    /// The preceding example allows a caller to create a Person using the default constructor, 
    /// without setting the FirstName property. The property type is set to a nullable string. 
    /// Beginning in C# 11, you can require callers to set a property
    /// </summary>
    public class Person
    {
        public Person() { }

        [SetsRequiredMembers]
        public Person(string firstName) => FirstName = firstName;

        public required string FirstName { get; init; }

        // Omitted for brevity.
    }
}
