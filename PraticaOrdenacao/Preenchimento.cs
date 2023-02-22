using System;

namespace PraticaOrdenacao {
    class Preenchimento {
        public static void Aleatorio(int[] vet, int limite) {
            Random r = new Random();
            for (int i = 0; i < vet.Length; i++) {
                vet[i] = r.Next(0, limite);
            }
        }
        public static void Crescente(int[] vet, int limite) {
            
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = i * limite / vet.Length;
            }
        }
        public static void Decrescente(int[] vet, int limite) {
            int aux = 0;
            for (int i = vet.Length-1 ; i >= 0; i--)
            {
                vet[aux++] = i * limite / vet.Length;
            }
        }
    }
}
