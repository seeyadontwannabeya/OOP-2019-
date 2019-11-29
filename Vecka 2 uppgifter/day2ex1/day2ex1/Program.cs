using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2ex1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //// create a new ship with 10 units of storage space
            //var ship = new TransportShip("Planet Express", 10);
            //// keep loading it until we don't have enough space left
            //while (true)
            //{
            //    // create some new cargo that takes up 3 units of space 
            //    var cargo = new Cargo("Bottles of Slurm", 3);
            //    if (!ship.AddCargo(cargo))
            //        break;
            //}

            //Console.WriteLine($"{ship.Name}, space available: {ship.Available}");
            //ship.ListCargo();

            //// unload the last inserted cargo item, available space +3
            //ship.RemoveCargo();

            //Console.WriteLine($"{ship.Name}, space available: {ship.Available}");
            //ship.ListCargo();
            var express = new TransportShip("Planet Express", 10);
            var nostromo = new TransportShip("Nostromo", 50);

            // keep loading the Nostromo with eggs until there is not enough space left
            // keep loading the Nostromo with eggs until there is not enough space left
            while (true)
            {
                var cargo = new Cargo("Crate with strange eggs", 4);

                if (!nostromo.AddCargo(cargo))
                    break;
            }

            Console.WriteLine($"{nostromo.Name}, space available: {nostromo.Available}");
            Console.WriteLine("- Moving some cargo to Planet Express...");

            // move as much as possible (2 items = 8 units of space) to the Planet Express
            nostromo.MoveCargoToOtherShip(express);
            
            Console.WriteLine($"{nostromo.Name}, space available: {nostromo.Available}");
            Console.WriteLine($"{express.Name}, space available: {express.Available}");

            express.ListCargo();

            Console.ReadKey();
        }
    }
    public class TransportShip
    {
        public readonly string Name;
        int Size;
        public int Available;
        Stack<Cargo> Storage;

        public bool MoveCargoToOtherShip(TransportShip ship)
        {
            bool value = true;

            foreach(var cargo in Storage)
            {
                value = ship.AddCargo(cargo);
                
            }

            return value;
        }
        public TransportShip(string name, int size)
        {
            
            Name = name;
            SetSize(size);
            Available = size;
            Storage = new Stack<Cargo>();
            
        }
        public void SetSize(int value)
        {
            if (value < 0)
                throw new ArgumentException("Can't set account to a negative balance", "value");

            Size = value;

        }
        public bool AddCargo(Cargo item) 
        {
            
            if(Storage.Count >= Available || item == null)
            {
                return false;
            }
            else
            {
                Available -= item.GetSize();
                Storage.Push(item);
                return true;
            }
            
        }
        public Cargo RemoveCargo()
        {
            var cargo = Storage.Pop();
            Available += cargo.GetSize();
            return cargo;
        }
        public void ListCargo()
        {

            foreach(var item in Storage)
            {
                Console.WriteLine(item);
            }
        }


    }

  
    public class Cargo
    {
        public string Description;
        int Size;

        public Cargo (string description, int size)
        {
            if(size <= 0)
            {
                return;
            }
            Description = description;
            Size = size;
        }
        public int GetSize()
        {
            return Size;
        }
        public void SetSize(int value)
        {
            if (value < 0)
                throw new ArgumentException("Can't set account to a negative balance", "value");
        }
        public override string ToString()
        {
            return $"{Description}";
        }


    }


}
