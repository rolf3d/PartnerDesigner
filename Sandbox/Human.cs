using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Human
    {
        public enum Køn { man, woman}
        public enum øjenFarve { rød, grøn, gul, brun, blå}
        
        public enum hårfarve { hvid, sort, grøn, rød, blå, gul, grå}
        public enum Højde { VeryShort, Short, MediumHeight, Tall, VaryTall, UnknownHeight }

        private Køn maleOrFemale;
        private øjenFarve eyeColor;
        private hårfarve hairColor;
        private Højde heightCategory;
        //private bool maleOrFemale;
        //private String eyeColor;
        //private String hairColor;
        //private int heightCategory;

        public Human(Køn maleOrFemale, øjenFarve eyeColor, hårfarve hairColor, Højde heightCategory)
        {
            this.maleOrFemale = maleOrFemale;
            this.eyeColor = eyeColor;
            this.hairColor = hairColor;
            this.heightCategory = heightCategory;
        }

        public String GetDescription()
        {
            String description = "You got a " + maleOrFemale;
            description = description + ", with " + eyeColor + " eyes";
            description = description + ", " + hairColor + " hair";
            description = description + ", who is " + heightCategory;

            return description;
        }

        //public String GetGenderDescription()
        //{
        //    if (Køn)
        //    {
        //        return "man";
        //    }
        //    else
        //    {
        //        return "woman";
        //    }
        //}

        //public String GetHeightDescription()
        //{
        //    switch (heightCategory)
        //    {
        //        case 0:
        //            return "Very short";
        //        case 1:
        //            return "Short";
        //        case 2:
        //            return "Medium height";
        //        case 3:
        //            return "Tall";
        //        case 4:
        //            return "Very tall";
        //        default:
        //            return "Unknown height";
        //    }
        //}
    }
}
