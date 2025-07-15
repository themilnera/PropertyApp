using Microsoft.Maui.Controls.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyApp.Control
{
    public class CustomBorder : Border
    {
        public CustomBorder()
        {
            AddCornerRadius();
        }

        private List<int> CornerValues = new List<int> { 10, 40, 70, 100 };
        private void AddCornerRadius()
        {
            var index = new Random().Next(4);
            StrokeShape = new RoundRectangle
            {
                CornerRadius = new CornerRadius(CornerValues[index])
            };
        }
    }
}
