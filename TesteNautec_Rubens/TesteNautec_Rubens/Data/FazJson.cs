using System.IO;
using TesteNautec_Rubens.Data;

namespace TesteNautec_Rubens
{
    class FazJson : IMenuAction
    {
        public void Run()
        {
            StreamReader buff = ArqVideoMan.RetBuff();
            JByLinq.NovoJson(ArqVideoMan.FazDados(buff));
            buff.Close();
        }
    }
}
