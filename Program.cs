using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrickyUnits;

namespace AltDir {
    class Program {
        private Program(string[] args) {
            MKL.Lic();
            MKL.Version();
        }

        void RunMain() { }

        static void Main(string[] args) => (new Program(args)).RunMain(); // Don't want statics, just ignore this line. It's there because C# needs it!
            
        
    }
}
