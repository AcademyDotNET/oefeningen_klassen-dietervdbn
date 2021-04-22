using System;
using System.Collections.Generic;
using System.Text;

namespace Ziekenhuis
{
    class VerzekerdePatient : Patient
    {
        public override int BerekenKost()
        {
            int totalKost = 0;
            totalKost = (HoursInHospital * 20) + 50;
            totalKost = (totalKost -(totalKost/10));
            return totalKost;
        }
    }
}
