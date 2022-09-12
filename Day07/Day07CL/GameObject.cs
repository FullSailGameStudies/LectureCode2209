using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class GameObject
    {
        #region Access Modifiers
        // Private - ONLY this class can see it
        // Public  - EVERYONE can see it
        // Protected - this class AND every class that descends from this class can see it
        #endregion

        #region Static vs non-Static
        //Static - class level
        //      EX: Input.ReadChoice. can only access it through the class
        //non-Static - instance level
        //      EX: List<int> num = new();  num.Add(5);  Add is an instance method
        #endregion

        #region Fields
        //data of your class
        //generally, they are private
        //they follow _camelCasingNamingConvention

        private int _x = 0, _y = 0;
        private static int _numberOfGameObjects;

        #endregion

        #region Properties
        //follow PascalNamingConvention
        //the gatekeepers of your fields
        //generally they are public
        public int X
        {
            //getter (accessor)
            //same as..
            //public int GetX() {return _x;}
            get { return _x; }

            //setter (mutator)
            //value is a hidden parameter
            //same as...
            //public void SetX(int value) {_x = value;}
            set { 
                if(value >= 0 && value < Console.WindowWidth)
                    _x = value; 
            }
        }
        public int Y
        {
            //getter (accessor)
            //same as..
            //public int GetY() {return _y;}
            get { return _y; }

            //setter (mutator)
            //value is a hidden parameter
            //same as...
            //public void SetY(int value) {_y = value;}
            set
            {
                if (value >= 0 && value < Console.WindowHeight)
                    _y = value;
            }
        }

        //Full Properties - you create a backing field that the property uses

        //Auto-properties - the compiler makes the backing field.
        public ConsoleColor Color { get; private set; }

        //same as writing a get the returns the field and a set that assigns the value to the field
        #endregion

        #region Constructors (ctors)
        //used to initialize the data of your instance
        //a default constructor (takes no parameters) is provided by the compiler
        //UNTIL you create one
        public GameObject()
        {
            //initialize (assign) values to your data/properties
            Color = ConsoleColor.Green;
            _x = 0;
            _y = 0;

            _numberOfGameObjects++;
        }

        public GameObject(int x, int y, ConsoleColor color)
        {
            X = x;
            Y = y;
            Color = color;
            _numberOfGameObjects++;
        }


        #endregion

        #region Methods
        //follow PascalNamingConvention

        //draw itself at its x,y position with its color
        //instance methods have a hidden parameter called "this"
        //"this" points to the instance that the method was called on
        public void Render() 
        {
            Console.SetCursorPosition(this._x, this._y);
            Console.BackgroundColor = Color;
            Console.Write(" ");
            Console.ResetColor();
        }

        //static methods do NOT have the "this" b/c they are called
        //on the class, not instances
        public static void Info()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"Number of game objects: {_numberOfGameObjects}");
        }
        #endregion
    }
}
