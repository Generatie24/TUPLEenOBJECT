using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

namespace ClassLibraryTest
{
    public class Services
    {
        public List<string> FirstLetter(List<string> namen)
        {
            List<string> list = new List<string>();
            var groepen = namen.GroupBy(naam => naam[0]);
            foreach (var groep in groepen)
            {
                list.Add("---------------------");
                foreach (var naam in groep)
                    list.Add(naam);
            }
            return list;
        }

    }
}
