//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Store
//{
//    public class Example : Collection<string>
//    {
//        Dictionary<string, Prime> primes = new Dictionary<string, Prime>
//      //  (StringComparer.InvariantCultureIgnoreCase)
//        {
//        {"JC", new Prime()  },
//        {"MT", new Prime()   },
//        {"TB", new Prime() }
//        };
//        Prime pm;
//        new SortedList
//        bool found = primes.TryGetValue("DC", out pm);
//       primes["JC"] = new Prime("Jim", 1976);

//        class UperComparer : IEqualityComparer<string>
//        {
//            public bool Equals(string x, string y)
//            {
//                return x.ToUpper == y.ToUpper();
//            }

//            public int GetHashCode(string obj)
//            {
//                return obj.ToUpper().GetHashCode();
//            }
//        }
//        protected override void InsertItem(int index, string item)  // Collection<string>
//{
//            if (string.IsNullOrWhiteSpace(item)) 
//                throw new ArgumentException("Should not be empty");
//            base.InsertItem(index, item);  
//        }
//    public string Name, Title = "A";
//    public override string ToString()
//        {
//            return string.Format("Name: {0}, Title: {1} ", Name, Title);
//        }
//    }
// public class Prime
// {
//    public Prime()
//    {

//    }
// }

//}
