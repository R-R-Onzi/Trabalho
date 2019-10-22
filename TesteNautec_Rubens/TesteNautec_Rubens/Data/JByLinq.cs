using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;


namespace TesteNautec_Rubens.Data
{
    class JByLinq
    {
        public static string NovoJson(LinkedList<DadosArquivo> data)//cria o JSON
        {
            int anew=0;
            while (File.Exists(Environment.CurrentDirectory + @"\output" + anew.ToString()+ ".data"))
            {
                anew++;
            }
            string path = Environment.CurrentDirectory + @"\output" + anew.ToString() + ".data";



            using (StreamWriter file = File.CreateText(path))
            {
                using (JsonTextWriter writer = new JsonTextWriter(file))
                {

                    foreach (var item in data)
                    {

                        JObject jObject = new JObject(
                            new JProperty("PersonId", item.PersonId),
                            new JProperty("Acao", item.Mens),
                            new JProperty("X Inicial", item.X),
                            new JProperty("Y Inicial", item.Y),
                            new JProperty("X Final", item.XF),
                            new JProperty("Y Final", item.YF),
                            new JProperty("X Vetor", item.XV),
                            new JProperty("Y Vetor", item.YV)

                            );
                        jObject.WriteTo(writer);
                    }
                }
            }
            

            return path;

        }

        

        
    }
}
