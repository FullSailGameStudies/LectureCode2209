using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public interface IGameObject
    {
        int X { get; set; }
        int Y { get; set; }

        void Render();
    }
}
