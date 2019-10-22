using System;

namespace TesteNautec_Rubens
{
    public sealed class MenuOption
    {
        
        public String DisplayText { get; set; }

        public int Number { get; set; }

        public IMenuAction Action { get; set; }

        
    }
}
