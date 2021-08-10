using System;

namespace BELayer
{
    public class Good
    {
        using System;
using System.Collections.Generic;
using System.Text;

namespace BELayer
    {
        public class Good
        {
            enum GoodType { Nutrition, Clothes, Communication, Cleaning, Infants, Pets };
            private string Id;
            private float price;
            private string Shop;
            private float Quantity;
            private string Picture;
            private string Description;
            private GoodType Type;
            private string Name { get; set; }
            public string getID()
            {
                return Id;
            }
            public bool PictureIsNull()
            {
                return Picture == null;
            }

            public bool DescriptionIsNull()
            {
                return (Description == null) || (Description.Length == 0);
            }
        }
    }

}
}
