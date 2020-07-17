namespace Calculadora_09
{
    public class Cauculadora
    {
        public float numero1 {get;set;}
        public float numero2 {get;set;}
        public string operacao {get;set;}
        public float resultado {get;set;}
       

        public void soma(){
            resultado = 0;
            resultado = numero1 + numero2; 
        }

        public void subtracao(){
            resultado = 0;
            resultado = numero1 - numero2;
        }

        public void multiplicacao(){
            resultado = 0;
            resultado = numero1 * numero2;
        }

        public void divisao(){
            resultado = 0;
            resultado = numero1 % numero2;
        }

    }
}