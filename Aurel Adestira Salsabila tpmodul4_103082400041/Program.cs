using System;

namespace Aurel_Adestira_Salsabila_tpmodul4_103082400041
{
    class Program
    {
        static void Main(string[] args)
        {
            KodePos kode = new KodePos();

            Console.Write("Masukkan Kelurahan: ");
            string kel = Console.ReadLine();

            Console.WriteLine("Kode Pos: " + kode.getKodePos(kel));

            Console.WriteLine("\nSimulasi Door Machine:");


            DoorMachine pintu = new DoorMachine();

            pintu.BukaPintu();
            pintu.KunciPintu();

        }
    }
}