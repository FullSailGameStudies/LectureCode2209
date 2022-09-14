using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public static class Factory
    {
        //EVERYTHING inside the class MUST be static
        public static GameObject BuildGameObject(int x, int y, ConsoleColor color)
        {
            GameObject gameObject = new(x, y, color);
            return gameObject;
        }
    }
}
