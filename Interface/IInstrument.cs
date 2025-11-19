using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface
{

    public interface IInstrument
    {
        void Play();
        string What();
        void Adjust();
    }


    public class Wind : IInstrument
    {
        public virtual void Play()
        {
            Console.WriteLine("Wind instrument is playing...");
        }

        public virtual string What()
        {
            return "Wind Instrument";
        }

        public virtual void Adjust()
        {
            Console.WriteLine("Adjusting Wind instrument...");
        }
    }

    public class Percussion : IInstrument
    {
        public virtual void Play()
        {
            Console.WriteLine("Percussion instrument is playing...");
        }

        public virtual string What()
        {
            return "Percussion Instrument";
        }

        public virtual void Adjust()
        {
            Console.WriteLine("Adjusting Percussion instrument...");
        }
    }

    public class Stringed : IInstrument
    {
        public virtual void Play()
        {
            Console.WriteLine("Stringed instrument is playing...");
        }

        public virtual string What()
        {
            return "Stringed Instrument";
        }

        public virtual void Adjust()
        {
            Console.WriteLine("Adjusting Stringed instrument...");
        }
    }

    public class Woodwind : Wind
    {
        public override void Play()
        {
            Console.WriteLine("Woodwind instrument is playing...");
        }

        public override string What()
        {
            return "Woodwind Instrument";
        }
    }

    public class Brass : Percussion
    {
        public override void Play()
        {
            Console.WriteLine("Brass instrument is playing...");
        }

        public override string What()
        {
            return "Brass Instrument";
        }
    }

    class IInstrument1
    {
        public static void M1()
        {
            // Wind
            IInstrument wind = new Wind();
            wind.Play();
            Console.WriteLine(wind.What());
            wind.Adjust();
            Console.WriteLine("--------------------------");

            // Percussion
            IInstrument percussion = new Percussion();
            percussion.Play();
            Console.WriteLine(percussion.What());
            percussion.Adjust();
            Console.WriteLine("--------------------------");

            // Stringed
            IInstrument stringed = new Stringed();
            stringed.Play();
            Console.WriteLine(stringed.What());
            stringed.Adjust();
            Console.WriteLine("--------------------------");

            // Woodwind
            IInstrument woodwind = new Woodwind();
            woodwind.Play();
            Console.WriteLine(woodwind.What());
            woodwind.Adjust();
            Console.WriteLine("--------------------------");

            // Brass
            IInstrument brass = new Brass();
            brass.Play();
            Console.WriteLine(brass.What());
            brass.Adjust();
            Console.WriteLine("--------------------------");
        }
    }

}
