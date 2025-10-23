using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorGraphicRedactor.Managers;
using VectorGraphicRedactor.Shapes;

namespace VectorGraphicRedactor.ICommands
{
    public class AddShapeCommand : ICommand
    {
        private Shape shape;
        private ShapeManager shapeManager;
        public AddShapeCommand(Shape shape, ShapeManager shapeManager)
        {
            this.shape = shape;
            this.shapeManager = shapeManager;
        }
        public void Execute()
        {
            shapeManager.shapes.Add(shape);
        }
        public void UnDo()
        {
            shapeManager.shapes.Remove(shape);
        }

    }

}
