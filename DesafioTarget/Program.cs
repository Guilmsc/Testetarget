using System.Security.Cryptography.X509Certificates;

namespace DesafioTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desafio 1:");
            int i = 13;
            int soma = 0;
            int k = 0;
            while (k < i){
                k++;
                soma = soma + k;
                Console.WriteLine(soma);
            }
            Console.WriteLine("Desafio 2: ");
            int a = 0, b = 1;
            int numero;
            bool retorno = false;
            Console.WriteLine("Entre com um número para verificar: ");
            numero = int.Parse(Console.ReadLine());
            while (b <= numero)
            {
                if(numero == b)
                {
                    
                    retorno = true;
                    break;
                }
                int temp = b;

                b = a + b;
                a= temp;
                retorno = false;
            }
            if(retorno)
            {
                Console.WriteLine("O número existe na sequência de fibonacci");
            }else
            {
                Console.WriteLine("O número não existe na sequência");
            }


            Console.WriteLine("Desafio 3:");
            double[] faturamento = new double[5];
            double menorValor = 0;
            double maiorValor = 0;
            double media = 0;
            int diasComMaioresFaturamentos = 0;
            for (int j=0; j<faturamento.Length; j++)
            {
                faturamento[j] = j * 10;
                if(menorValor > faturamento[j])
                {
                    menorValor = faturamento[j];
                }
                if(maiorValor < faturamento[j])
                {
                    maiorValor = faturamento[j];
                }
                media += faturamento[j];
            }
            media = media / faturamento.Length;
            for (int j = 0; j < faturamento.Length; j++)
            {
                if (faturamento[j] > media)
                {
                    diasComMaioresFaturamentos++;
                }
            }
            Console.WriteLine("Menor valor "+menorValor+", maior valor "+maiorValor+", dias com faturamento maior que a media "+diasComMaioresFaturamentos);

            Console.WriteLine("Desafio 4:");
            double sp = 67836.43, rj = 36678.66, mg = 29229.88, es = 27165.48, outros = 19849.53;
            double sum = sp+rj+mg+es+outros;

            Console.WriteLine("Valor em porcentagem: SP-" + calculatePercentage(sp, sum).ToString("F2") + " RJ-" + calculatePercentage(rj, sum).ToString("F2") + " MG-" + calculatePercentage(mg, sum).ToString("F2") + " ES-" + calculatePercentage(es, sum).ToString("F2") + " Outros-" + calculatePercentage(outros, sum).ToString("F2"));

            static double calculatePercentage(double value, double sum)
            {
                value = value / sum * 100;
                return value;
            }
            Console.WriteLine("Desafio 5: ");
            Console.WriteLine("Digite uma palavra: ");
            string palavra = Console.ReadLine();
            char[] charVetor = palavra.ToCharArray();
            char[] invertido = new char[charVetor.Length];
            for (int z = charVetor.Length - 1, j = 0; z >= 0; z--, j++)
            {
                invertido[j] = charVetor[z];
            }
            string textoInvertido = new string(invertido);
            Console.WriteLine(textoInvertido);
        }
    }
}
