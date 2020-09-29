using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sørøverkani
{
    class Program
    {
        static void Main(string[] args)
        {
            Sømandscirkel cirkel = new Sømandscirkel();
            for (int i = 0; i < 15; i++)
            {
                Sømand s = new Sømand();
                cirkel.Insert(s);
            }





            //s.overlevede();

            //s2.overlevede();
            //s2.overlevede();

            //s3.overlevede();
            //s3.overlevede();
            //s3.overlevede();


            Random randi = new Random();
            Random storb = new Random();
            int talmellem1 = 0;

            while (cirkel.Empty() == false)
            {
                int random1 = randi.Next(talmellem1, cirkel.Count);
                Sømand Sømandthattoremove = cirkel.RemoveAtIndex(random1);

                int random2 = storb.Next(0, 2);
                if (random2 == 1)
                {
                    //han råbte king kong
                    Console.WriteLine("king kong");

                    int antalGangeHanHarOverlevet = Sømandthattoremove.GetGangeOverlevet();
                    if (antalGangeHanHarOverlevet == 2)
                    {
                        Console.WriteLine("han blev spist");
                    }
                    else if (antalGangeHanHarOverlevet < 2)
                    {
                        Sømandthattoremove.overlevede();
                        cirkel.Insert(Sømandthattoremove);
                        Console.WriteLine("han blev ikke spist");
                    }
                }
                else
                {
                    Console.WriteLine("han råbte ikke og blev spist");
                }


                //kan han råbe king kong
                //  hvis ja check om han har gjort det 2 gange
                //      hvis han har gjort det 2 gange, så spis ham
                //      hvis nej overlever han og tæller op (overlever == komme tilbage i cirklen) 


                Console.WriteLine();
                cirkel.Print();

                Console.ReadLine();
            }




            //lav sæmandsklasse : gjort;
            // på klassen: lav en tæller for overlevelse : gjort;
            //random instantieret : gjort;



            //en collection (en cirkulær liste) af sømænd
            // Insert(Sømand)
            //RemoveAtIndex() -> sømand

            //sæmand skal kune holde en instans af sig selv next og previous


            //opgavebeskrivlse:
            //for hver runde:
            //tilfældig sømand bliver valgt ud
            //hvis han kan råbe king kong bliver han ikke spist og går tilbage i cirklen

        }
    }
}