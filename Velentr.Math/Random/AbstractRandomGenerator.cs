using System;
using System.Collections.Generic;
using System.Text;

namespace Velentr.Math.Random
{
    internal abstract class AbstractRandomGenerator
    {
        protected const uint defaultSeed = 777;

        public abstract uint GetUint();
    }
}
