using System;
using System.Collections.Generic;
using DevExpress.DataAccess.ObjectBinding;
// ...

namespace CustomRepositoryItem.Data {
    /**
     * This is a type to which an object data source is bound.
     * 
     * The 'public' access modifier is required to serialize the object data source to *.repx.
     * Setting the [HighlightedClass] attribute highlightes a class in the Object Data Source wizard.
     */
    [HighlightedClass]
    public static class History {
        static List<Deal> Data;

        static History() {
            Person mrJohnDoe = new Person { FirstName = "John", LastName = "Doe" };
            Person mrJohnJackson = new Person { FirstName = "John", LastName = "Jackson" };
            Person mrJackJohnson = new Person { FirstName = "Jack", LastName = "Johnson" };

            Data = new List<Deal>();
            Data.AddRange(new[] {
                new Deal { Seller = mrJohnDoe, Customer = mrJohnJackson, Time = DateTime.Now.AddDays(-1) },
                new Deal { Seller = mrJohnDoe, Customer = mrJackJohnson, Time = DateTime.Now.AddDays(-2) }
            });
        }

        public static IEnumerable<Deal> GetAll() { return Data; }

        public static IEnumerable<Deal> FilterByCustomer(Person customer) {
            foreach(Deal deal in Data) {
                if(deal.Customer.Equals(customer))
                    yield return deal;
            }
        }
    }
}
