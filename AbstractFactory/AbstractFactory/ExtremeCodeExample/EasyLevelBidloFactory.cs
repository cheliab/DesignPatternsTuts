using System.Collections.Generic;

namespace ExtremeCodeExample
{
    public class EasyLevelBidloFactory : IBidloFactory
    {
        public List<IBidlo> Create()
        {
            var bidlo = new List<IBidlo>();

            bidlo.Add(new Gopnik());
            bidlo.Add(new Alkash());
            
            return bidlo;
        }
    }
}