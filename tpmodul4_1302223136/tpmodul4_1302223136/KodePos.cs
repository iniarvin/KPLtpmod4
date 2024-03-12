using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302223136
{
    internal class KodePos
    {
        public String kelurahan;
        public int kodepos;
        public KodePos(string kelurahan, int kodepos)
        {
            this.kelurahan = kelurahan;
            this.kodepos = kodepos;
        }
        public List<KodePos> listKelurahan = new List<KodePos>(); 

        public void setKodePost()
        {
            this.listKelurahan.Add(new KodePos("Batununggal", 40266));
            this.listKelurahan.Add(new KodePos("Kujangsari", 40287));
            this.listKelurahan.Add(new KodePos("Mengger", 40267));
            this.listKelurahan.Add(new KodePos("Waters", 40256));
            this.listKelurahan.Add(new KodePos("Cijaura", 40287));
            this.listKelurahan.Add(new KodePos("Jatisari", 40286));
            this.listKelurahan.Add(new KodePos("Margasari", 40286));
            this.listKelurahan.Add(new KodePos("Sekejati", 40286));
            this.listKelurahan.Add(new KodePos("Kebonwaru", 40272));
            this.listKelurahan.Add(new KodePos("Maleer", 40274));
            this.listKelurahan.Add(new KodePos("Samoja", 40273));
        }
        
        public void getKodePos()
        {
            Console.WriteLine("Kelurahan            Kode Pos");
            foreach(KodePos L in this.listKelurahan){
                Console.WriteLine(L.kelurahan + "     " + L.kodepos);
            }
        }
    }
}
