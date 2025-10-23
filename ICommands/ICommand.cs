using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorGraphicRedactor.Shapes;
using VectorGraphicRedactor.Managers;
namespace VectorGraphicRedactor.ICommands
{
    public interface ICommand
    {
        void Execute();
        void UnDo();
    }
}
