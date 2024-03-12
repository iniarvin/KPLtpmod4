using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302223136
{
    internal class DoorMachine
    {
        public enum State {TERKUNCI, TERBUKA};

        State defaults = State.TERKUNCI;
        public void testing()
        {
            if (defaults == State.TERKUNCI)
            {
                Console.WriteLine("Pintu terkunci");
            } else if (defaults == State.TERBUKA)
            {
                Console.WriteLine("Pintu tidak terkunci");
            }

            Console.WriteLine("Pilih aksi: ");
            Console.WriteLine("buka");
            Console.WriteLine("kunci");
            String aksi = " ";
            if(aksi == "buka")
            {
                if(defaults == State.TERKUNCI)
                {
                    defaults = State.TERBUKA;
                } 
                else
                {
                    Console.WriteLine("Pintu tidak terkunci");
                }
            }
            else if (aksi == "kunci")
            {
                if(defaults == State.TERKUNCI)
                {
                    Console.WriteLine("Pintu terkunci");
                } 
                else
                {
                    defaults = State.TERBUKA;
                }
            }
            else
            {
                Console.WriteLine("input tidak valid");
            }

        }


    }
    
}
