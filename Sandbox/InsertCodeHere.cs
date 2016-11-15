using System;
using System.Collections.Generic;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Human h1 = new Human(Human.Køn.man, Human.øjenFarve.gul,Human.hårfarve.gul ,Human.Højde.MediumHeight );
            Human h2 = new Human(Human.Køn.woman, Human.øjenFarve.grøn, Human.hårfarve.rød, Human.Højde.Tall);
            Human h3 = new Human(Human.Køn.man, Human.øjenFarve.rød, Human.hårfarve.hvid, Human.Højde.UnknownHeight );
            Human h4 = new Human(Human.Køn.man, Human.øjenFarve.rød, Human.hårfarve.hvid, Human.Højde.UnknownHeight);

            if (h3 == h4)
            {
                Console.WriteLine("Person h3 og h4 er ens");
            }
            else
            {
                Console.WriteLine("De er ikke ens");
            }
            
            //Human h1 = new Human(true, "Brown", "Black", 1);
            //Human h2 = new Human(false, "White", "Blue", 4);
            //Human h3 = new Human(true, "Blond", "Green", 8);
            List<Human> mineFolk = new List<Human>();
            mineFolk.Add(h1);
            mineFolk.Add(h2);
            mineFolk.Add(h3);

            
            Console.WriteLine("En Liste med personer fra enum");
            foreach (Human p in mineFolk)
            {
                Console.WriteLine(p.GetDescription());
            }


            Console.WriteLine("");
            Console.WriteLine("3 console udskrivninger");
            Console.WriteLine(h1.GetDescription());
            Console.WriteLine(h2.GetDescription());
            Console.WriteLine(h3.GetDescription());


            // The LAST line of code should be ABOVE this line
        }
    }
}
