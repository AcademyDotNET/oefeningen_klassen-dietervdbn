using System;
using System.Collections.Generic;
using System.Text;

namespace Magic
{
    enum LandTypes {White, Black, Red, Green, Blue, Multicoller }
    class LandCard : Card
    {
        public LandTypes type { get; set; }
    }
}
