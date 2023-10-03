using System;
using System.IO;

namespace basicsModule2
{
    public abstract class AbstractExample
    {
        //abstract class for shape having sides,color,draw method;
        int sides;
        string color;
        public void setDetails(int sides,string color)
        {
            this.sides = sides;
            this.color = color;
        }
        public void getDetails()
        {
            Console.WriteLine("This Shape has " + sides + " sides and " + color + " color.");
        }
        public abstract void draw();

    }

    public class Square : AbstractExample
    {
        public override void draw()
        {
            Console.WriteLine("Drawing square");
        }
    }

    public class Circle : AbstractExample
    {
        public override void draw()
        {
            Console.WriteLine("Drawing circle");
        }
    }
}
