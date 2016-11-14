using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            // Now it is impossible to mix up hair- and eye-color, or specifiy non-existing values
            Human h1 = new Human(Human.Gender.man, Human.EyeColor.brown, Human.HairColor.black, Human.HeightCategory.shortish);
            Human h2 = new Human(Human.Gender.woman, Human.EyeColor.blue, Human.HairColor.white, Human.HeightCategory.veryTall);
            Human h3 = new Human(Human.Gender.man, Human.EyeColor.green, Human.HairColor.lightBlond, Human.HeightCategory.medium);

            Console.WriteLine(h1.GetDescription());
            Console.WriteLine(h2.GetDescription());
            Console.WriteLine(h3.GetDescription());


            // The LAST line of code should be ABOVE this line
        }
    }
}
