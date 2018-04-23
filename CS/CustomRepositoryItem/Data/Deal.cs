using System;
// ...

namespace CustomRepositoryItem.Data {
    public class Deal {
        public DateTime Time { get; set; }
        public Person Seller { get; set; }
        public Person Customer { get; set; }
    }
}
