using System;

namespace TesteNautec_Rubens
{
    
        public class Exit : IMenuAction
        {
            public void Run()
            {
                Environment.Exit(0);
            }
        }
    
}
