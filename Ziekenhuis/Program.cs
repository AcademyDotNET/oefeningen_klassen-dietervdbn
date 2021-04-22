using System;

namespace Ziekenhuis
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient patient = new Patient();
            patient.ToonInfo();
            VerzekerdePatient verzekerde = new VerzekerdePatient();
            verzekerde.ToonInfo();
        }
    }
}
