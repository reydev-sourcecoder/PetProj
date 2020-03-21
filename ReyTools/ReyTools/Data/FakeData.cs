using System.Collections.Generic;

namespace ReyTools.Data
{
    public static class FakeData
    {
        private static IEnumerable<MobilePrefix> MobilePrefixesField;
        public static IEnumerable<MobilePrefix> MobilePrefixes => MobilePrefixesField; 

        static FakeData()
        {
            InitializeData();
        }

        private static void InitializeData()
        {
            MobilePrefixesField = new List<MobilePrefix>
            {
                new MobilePrefix{ Prefix = "0917", NetworkName = "Globe/TM" },
                new MobilePrefix{ Prefix = "0930", NetworkName = "Smart, Talk N Text" },
                new MobilePrefix{ Prefix = "0932", NetworkName = "Sun Cellular" },
                new MobilePrefix{ Prefix = "0945", NetworkName = "Globe" },
                new MobilePrefix{ Prefix = "0950", NetworkName = "Talk N Text" },
            };
        }
    }
}
