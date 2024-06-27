using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multifunzione.Matematica.Punteggi
{
    internal class PunteggiInizialiInit: BaseFunction
    {
        public override string GetMenuTitle() => "Calcolo Punteggi";

        public override void RunFunction()
        {
            Punteggiiniziali.Inserisci();
        }
    }
}
