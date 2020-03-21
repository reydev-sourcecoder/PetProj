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
                new MobilePrefix{ Prefix = "0813", NetworkName = "Smart" },
                new MobilePrefix{ Prefix = "0817", NetworkName = "Globe (VOIP)" },
                new MobilePrefix{ Prefix = "0905", NetworkName = "Globe or Touch Mobile" },
                new MobilePrefix{ Prefix = "0906", NetworkName = "Globe or Touch Mobile" },
                new MobilePrefix{ Prefix = "0907", NetworkName = "Smart or Talk N Text" },
                new MobilePrefix{ Prefix = "0908", NetworkName = "Smart" },
                new MobilePrefix{ Prefix = "0909", NetworkName = "Smart or Talk N Text" },
                new MobilePrefix{ Prefix = "0910", NetworkName = "Smart or Talk N Text" },
                new MobilePrefix{ Prefix = "0911", NetworkName = "Smart (unreleased)" },
                new MobilePrefix{ Prefix = "0912", NetworkName = "Smart or Talk N Text" },
                new MobilePrefix{ Prefix = "0913", NetworkName = "Smart" },
                new MobilePrefix{ Prefix = "0914", NetworkName = "Smart" },
                new MobilePrefix{ Prefix = "0915", NetworkName = "Globe" },
                new MobilePrefix{ Prefix = "0916", NetworkName = "Globe or Touch Mobile" },
                new MobilePrefix{ Prefix = "0917", NetworkName = "Globe" },
                new MobilePrefix{ Prefix = "09173", NetworkName = "Globe postpaid" },
                new MobilePrefix{ Prefix = "09175", NetworkName = "Globe postpaid" },
                new MobilePrefix{ Prefix = "09176", NetworkName = "Globe postpaid" },
                new MobilePrefix{ Prefix = "09178", NetworkName = "Globe postpaid" },
                new MobilePrefix{ Prefix = "0918", NetworkName = "Smart" },
                new MobilePrefix{ Prefix = "0919", NetworkName = "Smart or Talk N Text" },
                new MobilePrefix{ Prefix = "0920", NetworkName = "Smart, Talk N Text, Addict Mobile" },
                new MobilePrefix{ Prefix = "0921", NetworkName = "Smart or Talk N Text" },
                new MobilePrefix{ Prefix = "0922", NetworkName = "Sun Cellular" },
                new MobilePrefix{ Prefix = "0923", NetworkName = "Sun Cellular" },
                new MobilePrefix{ Prefix = "0924", NetworkName = "Sun Cellular" },
                new MobilePrefix{ Prefix = "0925", NetworkName = "Sun Cellular" },
                new MobilePrefix{ Prefix = "09253", NetworkName = "Globe postpaid" },
                new MobilePrefix{ Prefix = "09255", NetworkName = "Sun postpaid" },
                new MobilePrefix{ Prefix = "09256", NetworkName = "Globe postpaid" },
                new MobilePrefix{ Prefix = "09257", NetworkName = "Globe postpaid" },
                new MobilePrefix{ Prefix = "09258", NetworkName = "Sun postpaid" },
                new MobilePrefix{ Prefix = "0926", NetworkName = "Globe or Touch Mobile" },
                new MobilePrefix{ Prefix = "0927", NetworkName = "Globe or Touch Mobile" },
                new MobilePrefix{ Prefix = "0928", NetworkName = "Smart" },
                new MobilePrefix{ Prefix = "0929", NetworkName = "Smart or Talk N Text" },
                new MobilePrefix{ Prefix = "0930", NetworkName = "Smart, Talk N Text, Red Mobile" },
                new MobilePrefix{ Prefix = "0932", NetworkName = "Sun Cellular" },
                new MobilePrefix{ Prefix = "0933", NetworkName = "Sun Cellular" },
                new MobilePrefix{ Prefix = "0934", NetworkName = "Sun Cellular" },
                new MobilePrefix{ Prefix = "0935", NetworkName = "Touch Mobile" },
                new MobilePrefix{ Prefix = "0936", NetworkName = "Globe or Touch Mobile" },
                new MobilePrefix{ Prefix = "0937", NetworkName = "ABS-CBN (Globe) – not part of unli call and text promos" },
                new MobilePrefix{ Prefix = "0938", NetworkName = "Smart, Talk N Text, Red Mobile" },
                new MobilePrefix{ Prefix = "0939", NetworkName = "Smart, Talk N Text, Red Mobile" },
                new MobilePrefix{ Prefix = "0942", NetworkName = "Sun Cellular" },
                new MobilePrefix{ Prefix = "0943", NetworkName = "Sun Cellular" },
                new MobilePrefix{ Prefix = "0945", NetworkName = "Globe" },
                new MobilePrefix{ Prefix = "0946", NetworkName = "Talk N Text" },
                new MobilePrefix{ Prefix = "0947", NetworkName = "Smart" },
                new MobilePrefix{ Prefix = "0948", NetworkName = "Talk N Text" },
                new MobilePrefix{ Prefix = "0949", NetworkName = "Smart" },
                new MobilePrefix{ Prefix = "0950", NetworkName = "Talk N Text" },
                new MobilePrefix{ Prefix = "0955", NetworkName = "Globe or Touch Mobile" },
                new MobilePrefix{ Prefix = "0956", NetworkName = "Globe" },
                new MobilePrefix{ Prefix = "0965", NetworkName = "Globe or Touch Mobile" },
                new MobilePrefix{ Prefix = "0966", NetworkName = "Globe" },
                new MobilePrefix{ Prefix = "0967", NetworkName = "Globe" },
                new MobilePrefix{ Prefix = "0970", NetworkName = "Smart" },
                new MobilePrefix{ Prefix = "0973", NetworkName = "Extelcom" },
                new MobilePrefix{ Prefix = "0974", NetworkName = "Extelcom" },
                new MobilePrefix{ Prefix = "0975", NetworkName = "Touch Mobile" },
                new MobilePrefix{ Prefix = "0976", NetworkName = "Globe or Touch Mobile" },
                new MobilePrefix{ Prefix = "0977", NetworkName = "Globe" },
                new MobilePrefix{ Prefix = "0978", NetworkName = "Next Mobile" },
                new MobilePrefix{ Prefix = "0979", NetworkName = "Next Mobile" },
                new MobilePrefix{ Prefix = "0981", NetworkName = "Smart" },
                new MobilePrefix{ Prefix = "0989", NetworkName = "Smart or Talk N Text" },
                new MobilePrefix{ Prefix = "0994", NetworkName = "Globe" },
                new MobilePrefix{ Prefix = "0995", NetworkName = "Globe" },
                new MobilePrefix{ Prefix = "0996", NetworkName = "Cherry Prepaid (Globe) – not part of unli call and text promos" },
                new MobilePrefix{ Prefix = "0997", NetworkName = "Globe or Touch Mobile" },
                new MobilePrefix{ Prefix = "0998", NetworkName = "Smart" },
                new MobilePrefix{ Prefix = "0999", NetworkName = "Smart (old Umobile prefix)" }
            };
        }
    }
}
