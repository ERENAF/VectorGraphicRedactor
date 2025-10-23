using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorGraphicRedactor.Shapes;
using VectorGraphicRedactor.Managers;

namespace VectorGraphicRedactor.ICommands
{
    internal class DeleteShapeCommand : ICommand
    {
        private Shape shape;
        private int index;
        private ShapeManager shapeManager;

        public DeleteShapeCommand(Shape shape, ShapeManager shapeManager)
        {
            this.shape = shape;
            this.shapeManager = shapeManager;
            this.index = shapeManager.shapes.IndexOf(shape);
        }

        public void Execute()
        {
            shapeManager.shapes.Remove(shape);
        }
        public void UnDo()
        {
            if (index >= 0 && index <= shapeManager.shapes.Count)
            {
                shapeManager.shapes.Insert(index, shape);
            }
            else
            {
                shapeManager.shapes.Add(shape);
            }
        }
    }
}
