using System;
using System.ComponentModel;
using System.Globalization;
// ...

namespace CustomRepositoryItem.Data {
    /**  
     * This is the class, for which a custom repository item is implemented in this example.
     *
     * The type converter is required to serialize parameter values to CodeDOM 
     * When an instance of the Person class is used as a custom parameter,  
     * it is converted to a string using this type converter and saved to 
     * the ValueInfo property. Accordingly, on deserialization this type converter 
     * is used to restore an original value from the stored string.
     *  
     * The ToString() method is used to display the Parameters property of an object 
     * data source in the property grid. For example, it can look like this:
     *     Parameters : customer = John Jackson
     * Here 'customer' is the name of a parameter and 'John Jackson' represents its value 
     * and is converted from it using the ToString() method.
     *  
     * The Equals(...) method is called from CustomRepositoryItem.Data.FilterByCustomer(...)
     * and is not necessary to be implemented in a general case.
     */
    [TypeConverter(typeof(Converter))]
    public class Person {
        class Converter : TypeConverter {
            #region Overrides of TypeConverter

            public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) {
                if(sourceType == typeof(string))
                    return true;
                return base.CanConvertFrom(context, sourceType);
            }

            public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) {
                if(destinationType == typeof(string))
                    return true;
                return base.CanConvertTo(context, destinationType);
            }

            public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) {
                string str = value as string;
                if(str != null) {
                    string[] parts = str.Split('|');
                    if(parts.Length == 2)
                        return new Person { FirstName = parts[0], LastName = parts[1] };
                }
                return base.ConvertFrom(context, culture, value);
            }

            public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value,
                Type destinationType) {
                if(destinationType == typeof(string)) {
                    Person person = (Person)value;
                    return value == null ? null : string.Format("{0}|{1}", person.FirstName, person.LastName);
                }
                return base.ConvertTo(context, culture, value, destinationType);
            }
            #endregion
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        #region Overrides of Object

        public override bool Equals(object obj) {
            if(ReferenceEquals(this, obj))
                return true;
            if(obj == null || obj.GetType() != GetType())
                return false;
            Person other = (Person)obj;
            return string.Equals(FirstName, other.FirstName) && string.Equals(LastName, other.LastName);
        }
        public override string ToString() { return string.Format("{0} {1}", FirstName, LastName); }

        public override int GetHashCode() {
            return (FirstName == null ? 0 : FirstName.GetHashCode()) ^ (LastName == null ? 0 : LastName.GetHashCode());
        }
        #endregion
    }
}
