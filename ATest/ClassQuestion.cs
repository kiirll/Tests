using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATest
{
    [Serializable]
    public class ClassQuestion
    {
        public string name;
        public List<ClassVar> Varieblles = new List<ClassVar>();

    }
    [Serializable]
    public class ClassVar
    {
        public string name;
        public bool correctly;
    }
}
