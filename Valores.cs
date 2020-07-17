namespace Calculadora_09
{
    public class Valores : Cauculadora
    {
        private string [] Valor {get;set;}
        private float somar {get;set;}
        
        public void CalcularMedia (string txtConsole){
            resultado = 0;

            Valor = txtConsole.Split(";");

            for (int i = 0; i < Valor.Length; i++)
            {
                somar += float.Parse(Valor[i]);
            }

            resultado = somar / Valor.Length;
        }

        public void ControlarMetodos(string entrada){
            string[] dados = entrada.Split(" ");

            numero1  = float.Parse(dados[0]);
            operacao = dados[1];
            numero2  = float.Parse(dados[2]);

            switch (operacao)
            {
                case "+":
                soma();
                break;

                case "-":
                subtracao();
                break;

                case "x":
                multiplicacao();
                break;

                default:
                soma();
                break;
            }
        }
        
    }
}