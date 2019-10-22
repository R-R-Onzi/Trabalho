using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteNautec_Rubens.Data
{
    class DadosArquivo
    {

        public string Id { get; set; }

        public string PersonId { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public int XF { get; set; }

        public int YF { get; set; }

        public int XV { get; set; }

        public int YV { get; set; }

        public int P1x { get; set; }

        public string P2x { get; set; }

        public int P1y { get; set; }

        public string P2y { get; set; }
        public int ValMaxX { get; set; }

        public int ValMaxY { get; set; }

        public int ValMinX { get; set; }

        public int ValMinY { get; set; }
        public string Mens { get; set; }


        public DadosArquivo(string all)//constroi obj a partir de uma linha do arq
        {

            string[] separ = new string[8];
            
            separ = all.Split(',');


            Id = separ[0].Split('"')[3];
            PersonId = separ[1].Split('"')[3];
            X = Convert.ToInt32(separ[2].Split('"')[2].Trim(' ', ':'));
            Y = Convert.ToInt32(separ[3].Split('"')[2].Trim(' ', ':'));
            P1x = Convert.ToInt32(separ[4].Split('"')[2].Trim(' ', ':'));
            P1y = Convert.ToInt32(separ[5].Split('"')[2].Trim(' ', ':'));
            P2x = separ[6].Split('"')[2].Trim(' ', ':');
            P2y = separ[7].Split('"')[2].Trim('}',' ',':');
            ValMaxX = X;
            ValMinX = X;
            ValMaxY = Y;
            ValMinY = Y;
        }

        


    }
}
