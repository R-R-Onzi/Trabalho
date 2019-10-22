namespace TesteNautec_Rubens.Math
{
    class BasicM
    {
        public static int CheckQuadVetPix(int a,int b)//checa o vetor que a pessoa andou para
        {
            if (a>=0)
            {
                if (b>=0)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                if (b>=0)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }


           
        }

        public static int CheckQuadPix(int a, int b)//checa o quadrante dos pixeis
        {
            if (a > 960)
            {
                if (b < 650)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
            else
            {
                if (b <750)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }



        }


        public static string SelectAction(int a, int b)//Seleciona a acao a partir de quadrantes recebidos
        {

            if (a == 1)
            {
                if (b == 2)
                {
                    return "Transitou da Direita para Esquerda na frente da loja";
                }
                else if (b == 4 || b == 3)
                {
                    return "Entrou na loja";
                }
                else
                {
                    return "Movimento Invalido";
                }
            }
            else if (a == 2)
            {
                if (b == 1)
                {
                    return "Transitou da Esquerda para Direita na frente da loja";
                }
                else if (b == 4 || b == 3)
                {
                    return "Entrou na loja";
                }
                else
                {
                    return "Movimento Invalido";
                }
            }
            else
            {
                if (b == 1 || b == 2)
                {
                    return "Saiu da Loja";
                }
                else
                {
                    return "Movimento Invalido";
                }

            }
            
        }
    }

   
}
