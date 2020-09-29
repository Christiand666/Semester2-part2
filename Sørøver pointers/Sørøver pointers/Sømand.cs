using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sørøverkani
{
    class Sømandscirkel
    {
        //circulær dobbelthægtet liste


        private Sømand Start;
        private Sømand End;
        public int Count;

        public void Insert(Sømand sømandToInsert)
        {
            Count++;
            if (Start == null)
            //if empty
            {
                //pointers set
                Start = sømandToInsert;
                End = sømandToInsert;

                //next/prev set
                Start.Next = sømandToInsert;
                Start.Prev = sømandToInsert;

                End.Next = sømandToInsert;
                End.Prev = sømandToInsert;
            }
            else
            {
                Start.Prev = sømandToInsert;
                sømandToInsert.Next = Start;
                End.Next = sømandToInsert;
                sømandToInsert.Prev = End;
                Start = sømandToInsert;
                //håndter insert når collection er over 0

            }
        }
        public Sømand RemoveAtIndex(int indexToRemove)
        {

            if (indexToRemove > Count - 1)
                throw new IndexOutOfRangeException();

            Sømand current = Start;

            for (int i = 0; i < indexToRemove; i++)
            {
                current = current.Next;
            }
            //hernedefter er current den som skal slettes 

            //hvis der kun er en tilbage i collection, så fjern den og set start og end null 
            if (Start == End)
            {
                Start = null;
                End = null;
            }
            else
            {

                current.Next.Prev = current.Prev;
                current.Prev.Next = current.Next;

                if (current == Start)
                {
                    Start = End.Next;
                }

                if (current == End)
                {
                    End = Start.Prev;
                }
            }

            Count--;
            return current;
        }

        public bool Empty()
        {
            if (Start == null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void Print()
        {
            var current = Start;
            do
            {
                Console.Write(current.GetGangeOverlevet() + "   ");

                current = current.Next;
                Console.WriteLine("sømand");
            } while (current != Start);

        }



    }
}
