using System;
using System.Collections.Generic;
using System.IO;
using TesteNautec_Rubens.Data;
using TesteNautec_Rubens.Math;

namespace TesteNautec_Rubens
{
    class ArqVideoMan
    {
        public static StreamReader RetBuff()//retorna o path para o arquivo
        {
            Console.WriteLine("Digite o nome do arquivo desejado como base ou aperte enter para o arquivo padrão");
            
            string path = Console.ReadLine();

            try
            {

                if (!path.Equals(""))
                {
                    path = Environment.CurrentDirectory + "\\" + path + ".data";

                }
                else
                {
                    path = Environment.CurrentDirectory + "\\boxes.data.txt";

                }

                if (!File.Exists(path))
                {
                    File.Create(path);
                }
                StreamReader binary = new StreamReader(File.OpenRead(path));
                return binary;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static LinkedList<DadosArquivo> FazDados(StreamReader buff)//Management dos dados
        {
           
            
            LinkedList<DadosArquivo> data=new LinkedList<DadosArquivo>();
           
            DadosArquivo nov = new DadosArquivo(buff.ReadLine());
            
            data.AddFirst(nov);


            do
            {

                nov = new DadosArquivo(buff.ReadLine());
                int quant = 0;


                foreach (DadosArquivo PersonId in data)
                {
                    if (nov.PersonId.Equals(PersonId.PersonId))
                    {
                        
                        PersonId.XV = nov.P1x - PersonId.P1x;
                        PersonId.YV = nov.P1y - PersonId.P1y;
                        PersonId.XF = nov.X;    
                        PersonId.YF = nov.Y;
                         if (nov.X < PersonId.ValMinX)
                            {
                                PersonId.ValMinX = nov.X;
                            
                        }
                        else if (nov.X > PersonId.ValMaxX)
                         {
                                PersonId.ValMaxX = nov.X;
                         }
                        

                        if (nov.Y < PersonId.ValMinY)
                        {
                                PersonId.ValMinY = nov.Y;
                            
                        }
                        else if (nov.Y > PersonId.ValMaxY)
                        {
                                PersonId.ValMaxY = nov.Y;
                            
                        }

                        break;
                    }
                    else
                    {
                        quant++;
                    }
                }
                
                if (quant == data.Count)
                {
                    data.AddLast(nov);
                }
            
                

            } while (!buff.EndOfStream);
            

            foreach (var PersonId in data)
            {
                int respf = BasicM.CheckQuadPix(PersonId.XF, PersonId.YF);
                int resv = BasicM.CheckQuadVetPix(PersonId.XV, PersonId.YV);
                int resp = BasicM.CheckQuadPix(PersonId.X, PersonId.Y);
               
                if((PersonId.Mens = BasicM.SelectAction(resp, resv)).Equals("Movimento Invalido"))
                {
                    if ((PersonId.Mens = BasicM.SelectAction(resp, BasicM.CheckQuadPix(PersonId.ValMaxX, PersonId.ValMaxY))).Equals("Movimento Invalido"))
                    {
                        PersonId.Mens = BasicM.SelectAction(resp, BasicM.CheckQuadPix(PersonId.ValMinX, PersonId.ValMinY));
                    }
                }
                
            }
            
                

                



                return data;
          
            
        } 
    }
}
