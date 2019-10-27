// Lic:
// Alternate Dir
// Alternate way to show the directory. Powershell's Get-Item sucks!
// 
// 
// 
// (c) Jeroen P. Broks, 
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
// 
// Please note that some references to data like pictures or audio, do not automatically
// fall under this licenses. Mostly this is noted in the respective files.
// 
// Version: 19.10.27
// EndLic
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrickyUnits;

namespace AltDir {
    class Program {

        readonly FlagParse fp;

        private Program(string[] args) {
            fp = new FlagParse(args);
            Dirry.InitAltDrives();
            MKL.Lic    ("Alternate Dir - Program.cs","GNU General Public License 3");
            MKL.Version("Alternate Dir - Program.cs","19.10.27");
        }

        void Header() {
            QCol.Yellow("Alternate Directory\t");
            QCol.Cyan($"Version {MKL.Newest}\n");
            QCol.Magenta("Coded and copyrighted by: Jeroen P. Broks\n");
            QCol.Green("Licensed and released under terms of the GPL 3\n\n");
        }

        void HelpScreen() {
            Header();
        }

        void RunMain() { }

        static void Main(string[] args) => (new Program(args)).RunMain(); // Don't want statics, just ignore this line. It's there because C# needs it!
            
        
    }
}

