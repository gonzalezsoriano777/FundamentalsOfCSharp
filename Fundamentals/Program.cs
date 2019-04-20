using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class AudiCar
    {

        #region Region example, for usage of code

        public void Ex()
        {
            Console.WriteLine("Example declared");
        }
        #endregion


        public AudiCar(string loc, string make, string model)
        {
            this.Location = loc;
            this.Make = make;
            this.Model = model;
        }

        // Private strings that can only be used in this class
        private string location;
        private string make;
        private string model;






        // Used GET and SET on both location and model to get both of them and assign them to a value assigned
        // This method is called encapsulation

        public string Location
        {
            get => location; set => location = value;
        }

        public string Model
        {
            get => model; set => model = value;
        }

        public string Make
        {
            get => make; set => make = value;
        }

        static void Main(string[] args)
        {

            // instantiate object
            // Since we created constructors for this object you need to add the properties it uses

            AudiCar myAudi = new AudiCar("Germany", "RS7", "RM1000");

            Console.WriteLine("Welcome to your new and improved Audi, sent and made from Germany!");

            Console.WriteLine(myAudi.Location);
            Console.WriteLine(myAudi.Make);
            Console.WriteLine(myAudi.Model);

            #region Next Lines are class for inherting
            #endregion

            Human human = new Human ();
            Alien alien = new Alien ();

            // Will be set to false since it value was never [ set ]
            Console.WriteLine(alien.moves);

            #region Another inheritance demostration

            TypesOfShoes myShoeOne = new TypesOfShoes("Jordans", 200.35f);
            Console.WriteLine("The Cost of those {0} would be {1}", myShoeOne.Brand, myShoeOne.Cost);

            TypesOfShoes myShoeTwo = new TypesOfShoes("Nikes", 125.50f, "Purple", 9.5f);
            Console.WriteLine("The Cost of those {0}, and they would be {1}, there also {2} and the size is {3}", myShoeTwo.Brand, myShoeTwo.Cost, myShoeTwo.Color, myShoeTwo.Size);

            #endregion

        }
    }

    #region Inheriting with Human and alien

    public class GeneralObject
    {
        // inheriting the general properties that both human and alien use
        public GeneralObject(){
        }

        public bool moves { get; set; }
        public string name { get; set; }
        public string color { get; set; }
    }

    public class Human : GeneralObject
    {
        public Human(){
        }

        public string NoseStructure { get; set; }
    }

    public class Alien : GeneralObject
    {
        public Alien(){
        }

        public bool CanSpeak { get; set; }
    }

    #endregion


    #region Created constructors w/ inheritance.. more simple and unique

    public class Shoes
    {
        public string Color;
        public float Size;
        public string HighOrLow;

        
    }


    public class TypesOfShoes : Shoes
    {
        public string Brand;
        public float Cost;

        public TypesOfShoes()
        {

        }

        public TypesOfShoes(string brand)
        {
            this.Brand = brand;
        }

        public TypesOfShoes(string brand, float cost)
        {
            this.Brand = brand;
            this.Cost = cost;
        }

        public TypesOfShoes(string brand, float cost, string color, float size)
        {
            this.Brand = brand;
            this.Cost = cost;
            this.Color = color;
            this.Size = size;
        }

        public TypesOfShoes(string brand, float cost, string color, float size, string highOrlow)
        {
            this.Brand = brand;
            this.Cost = cost;
            this.Color = color;
            this.Size = size;
            this.HighOrLow = highOrlow;
        }
    }

    #endregion
}


