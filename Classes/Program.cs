using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            PC myPC = new PC();
            // Add parts
            myPC.Motherboard = "Asus - ROG STRIX Z370-E GAMING ATX LGA1151 Motherboard ";
            myPC.CPU = "Intel i7-8700K ";
            myPC.CPU_Cooler = "NZXT Kraken X62 ";
            myPC.RAM = "Patriot - Viper 4 16GB (2 x 8GB) DDR4-3400 Memory ";
            myPC.PSU = "EVGA - SuperNOVA G3 650W 80+ Gold Certified Fully-Modular ATX Power Supply ";
            myPC.Vgraphics = "Asus - GeForce GTX 1080 Ti 11GB STRIX GAMING ";
            myPC.PStorage= "Samsung - 970 Evo 500GB M.2 - 2280 Solid State Drive ";
            myPC.SStorage= "Western Digital - Red Pro 4TB \"3.5\" 7200RPM Internal Hard Drive ";
            myPC.Case = "NZXT H700i";
            myPC.WAN = "Asus - PCE-AC88 PCI-Express x1 802.11a/b/g/n/ac Wi-Fi Adapter ";
            myPC.SoundCard = "Creative Labs - Sound Blaster Audigy Rx 24-bit 192 KHz Sound Card ";
            // Display
            Console.WriteLine(
                "{0} " +
                "{1} " +
                "{2} " +
                "{3} " +
                "{4} " +
                "{5} " +
                "{6} " +
                "{7} " +
                "{8} " +
                "{9} " +
                "{10} ", 
                myPC.Motherboard, myPC.CPU, myPC.CPU_Cooler, 
                myPC.RAM, myPC.PSU, myPC.Vgraphics, myPC.PStorage,
                myPC.SStorage, myPC.Case, myPC.WAN, myPC.SoundCard);
            // Reference Method
            Console.WriteLine("{0}", myPC.IsUnlocked());
            Console.ReadLine();
        }
        private static Boolean IsUnlocked(PC myPC)

        {
            // Set Boolean
            Boolean UnLockable = false;
            // Return to Top
            return UnLockable;
        }
    }
  

    class PC
    {
        // Initialise components
        public string Motherboard { get; set; }
        public string CPU { get; set; }
        public string CPU_Cooler { get; set; }
        public string RAM { get; set; }
        public string PSU { get; set; }
        public string Vgraphics { get; set; }
        public string SStorage { get; set;}
        public string PStorage { get; set; }
        public string Case { get; set; }
        public string SoundCard { get; set; }
        public string WAN { get; set; }

        public Boolean IsUnlocked()
        {
            // Reference
            Boolean UnLockable;
            // Check if CPU matches
            if (CPU == "Intel i7-8700K ")
                // Set True
                 UnLockable = true;
            else
                // Set False
                 UnLockable = false;
            // Return to Top
            return UnLockable;
        }
    }
}
