using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATest
{
    [Serializable]
    public class ClassTest
    {
        public string name;
        public List<ClassQuestion> Questions = new List<ClassQuestion>();
    }
}
