using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Talents {
    public class Calculadora {

        private List<string> listarhistorico;
        private string data;

        public Calculadora(string data) {
            listarhistorico = new List<string>();
            this.data = data;
        }

        public int somar(int num1, int num2) {
            int resultado = num1 + num2;
            RegistrarResultado(resultado.ToString());
            return resultado;
        }

        public int subtrair(int num1, int num2) {
            int resultado = num1 - num2;
            RegistrarResultado(resultado.ToString());
            return resultado;
        }

        public int multiplicar(int num1, int num2) {
            int resultado = num1 * num2;
            RegistrarResultado(resultado.ToString());
            return resultado;
        }

        public int dividir(int num1, int num2) {
            int resultado = num1 / num2;
            RegistrarResultado(resultado.ToString());
            return resultado;
        }

        public List<string> historico() {
            listarhistorico.RemoveRange(3, listarhistorico.Count - 3);
            return listarhistorico; 
        }

        private void RegistrarResultado(string resultado) {
            listarhistorico.Insert(0, "Resultado: " + resultado + " - data: " + data);
        }
    }
}
