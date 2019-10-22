using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace TesteNautec_Rubens
{
    public sealed class Menu
    {
        public List<MenuOption> Options { get; set; }

        public Menu()// faz menu
        {
            Options = new List<MenuOption>();

            MenuOption creator = new MenuOption
            {
                Number = 1,
                DisplayText = string.Format($"{"Cria o Arquivo",-30}"),
                Action = new FazJson()

            };


            MenuOption Exit = new MenuOption
            {
                Number = 0,
                DisplayText = string.Format($"{"Sai do Programa",-30}"),
                Action = new Exit()

            };
            Options.Add(creator);
            
            Options.Add(Exit);


        }


        public void ParseAndDestroy(string input)
        {


            if (int.TryParse(input, out int option))
            {

                var list = Options.Where(x => x.Number == option);
                if (list.Count() > 0)
                {
                    MenuOption op = list.First();
                    op.Action.Run();
                }


            }


        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("--------------MENU-------------");
            sb.AppendLine();
            foreach (MenuOption item in Options)
            {
                sb.AppendLine(string.Format("Menu {0}  -  {1}  ", item.Number, item.DisplayText));

            }
            sb.AppendLine();
            sb.AppendLine("DIGITE OPCAO DESEJADA");

            return sb.ToString();
        }



    }
}
