using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Human
    {
        private bool maleOrFemale;
        private String eyeColor;
        private String hairColor;
        private int heightCategory;

        public Human(bool maleOrFemale, String eyeColor, String hairColor, int heightCategory)
        {
            this.maleOrFemale = maleOrFemale;
            this.eyeColor = eyeColor;
            this.hairColor = hairColor;
            this.heightCategory = heightCategory;
        }

        public String GetDescription()
        {
            String description = "You got a " + GetGenderDescription();
            description = description + ", with " + eyeColor + " eyes";
            description = description + ", " + hairColor + " hair";
            description = description + ", who is " + GetHeightDescription();

            return description;
        }

        public String GetGenderDescription()
        {
            if (maleOrFemale)
            {
                return "man";
            }
            else
            {
                return "woman";
            }
        }

        public String GetHeightDescription()
        {
            switch (heightCategory)
            {
                case 0:
                    return "Very short";
                case 1:
                    return "Short";
                case 2:
                    return "Medium height";
                case 3:
                    return "Tall";
                case 4:
                    return "Very tall";
                default:
                    return "Unknown height";
            }
        }
    }
}
