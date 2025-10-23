using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorGraphicRedactor.Shapes;
namespace VectorGraphicRedactor.Managers
{
    public class ShapeManager
    {
        public List<Shape> shapes = new List<Shape>();
        public Stack<Shape> undostack = new Stack<Shape>();
        public Stack<Shape> redostack = new Stack<Shape>();

    }
}
