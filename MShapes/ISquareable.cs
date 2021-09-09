using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MShapes {
    public interface ISquareable {
        int[] Dimensions { get; set; }
        double Square();
    }
}
