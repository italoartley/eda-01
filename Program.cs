using System;
using System.Diagnostics;

namespace teste
{
    class Program
    {
        static void Main()
        {
            int[] vetor = new int[1000];
            int[] vetor2 = new int[5000];
            Random rnd = new Random();
            Stopwatch stopwatch = new Stopwatch();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            
            //1000
            stopwatch.Start();
            for (int i = 0; i < vetor.Length; i++){
                vetor[i] = rnd.Next(1, 1000);
            }
            
            bubbleSort(vetor, vetor.Length);            
            Console.WriteLine("\n\nVetor Ordenado pelo bubbleSort para 1000 valores\n");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("{0} ", vetor[i]);
            }
            watch.Stop();
            Console.WriteLine("\n\nTempo Decorrido do bubbleSort: {0}", watch.Elapsed);
            if (!watch.IsRunning)
            watch.Restart();
            
            insertionSort(vetor, vetor.Length);            
            Console.WriteLine("\n\nVetor Ordenado pelo insertionSort para 1000 valores\n");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("{0} ", vetor[i]);
            }
            watch.Stop();
            Console.WriteLine("\n\nTempo Decorrido do insertionSort: {0}", watch.Elapsed);
            if (!watch.IsRunning)
            watch.Restart();
            
            selectionSort(vetor, vetor.Length);            
            Console.WriteLine("\n\nVetor Ordenado pelo selectionSort para 1000 valores\n");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("{0} ", vetor[i]);
            }
            watch.Stop();
            Console.WriteLine("\n\nTempo Decorrido do selectionSort: {0}", watch.Elapsed);
            if (!watch.IsRunning)
            watch.Restart();

            quickSort(vetor);            
            Console.WriteLine("\n\nVetor Ordenado pelo quickSort para 1000 valores\n");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("{0} ", vetor[i]);
            }
            watch.Stop();
            Console.WriteLine("\n\nTempo Decorrido do quickSort: {0}", watch.Elapsed);
            if (!watch.IsRunning)
            watch.Restart();

            //5000
            for (int i = 0; i < vetor2.Length; i++){
                vetor2[i] = rnd.Next(1, 5000);
            }
            bubbleSort(vetor2, vetor2.Length);            
            Console.WriteLine("\n\nVetor Ordenado pelo bubbleSort para 5000 valores\n");
            for (int i = 0; i < vetor2.Length; i++)
            {
                Console.Write("{0} ", vetor2[i]);
            }
            watch.Stop();
            Console.WriteLine("\n\nTempo Decorrido do bubbleSort: {0}", watch.Elapsed);
            if (!watch.IsRunning)
            watch.Restart();
            
            insertionSort(vetor2, vetor2.Length);            
            Console.WriteLine("\n\nVetor Ordenado pelo insertionSort para 5000 valores\n");
            for (int i = 0; i < vetor2.Length; i++)
            {
                Console.Write("{0} ", vetor2[i]);
            }
            watch.Stop();
            Console.WriteLine("\n\nTempo Decorrido do insertionSort: {0}", watch.Elapsed);
            if (!watch.IsRunning)
            watch.Restart();
            
            selectionSort(vetor2, vetor2.Length);            
            Console.WriteLine("\n\nVetor Ordenado pelo selectionSort para 5000 valores\n");
            for (int i = 0; i < vetor2.Length; i++)
            {
                Console.Write("{0} ", vetor2[i]);
            }
            watch.Stop();
            Console.WriteLine("\n\nTempo Decorrido do selectionSort: {0}", watch.Elapsed);
            if (!watch.IsRunning)
            watch.Restart();

            quickSort(vetor2);            
            Console.WriteLine("\n\nVetor Ordenado pelo quickSort para 5000 valores\n");
            for (int i = 0; i < vetor2.Length; i++)
            {
                Console.Write("{0} ", vetor2[i]);
            }
            watch.Stop();
            Console.WriteLine("\n\nTempo Decorrido do quickSort: {0}", watch.Elapsed);
            if (!watch.IsRunning)
            watch.Restart();


            stopwatch.Stop();
            Console.WriteLine("\n\nO Tempo total Decorrido: {0}", stopwatch.Elapsed);
        }
        
        static void bubbleSort(int[] vetor, int length)
        {
            int trocas = 0;
            for (int i = 0; i < length - 1; i++)
            {           
                for (int j = 0; j < length - 1; j++)
                {
                    if (vetor[j] > vetor[j + 1])
                    {
                        trocas = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = trocas;
                    }
                }
            }
        }
        static void insertionSort(int[] vetor, int length)
        {
            int j, atual = 0;
            for (int i = 0; i < length; i++){
                atual = vetor[i];
                j = i-1;
                while (j >= 0 && vetor[j] > atual){
                    vetor[j + 1] = vetor[j];  
                    j = j - 1; 
                }
                vetor[j + 1] = atual;
            }
        }
        static int[] selectionSort(int[] vetor, int length)
        {
            int min, aux;
            for (int i = 0; i < length-1; i++){
                min = i;
                for (int j = i+1; j < length; j++){
                    if(vetor[j] < vetor[min])  
                    min = j; 
                }
                if(min != i){
                aux = vetor[min];
                vetor[min] = vetor[i];
                vetor[i] = aux;
                }
            }
            return vetor;
        }
        public static int[] quickSort(int[] vetor){
            int inicio = 0;
            int fim = vetor.Length - 1;
            quickSort(vetor, inicio, fim);
            return vetor;
        }
        private static void quickSort(int[] vetor, int inicio, int fim){
            if (inicio < fim){
                int p = vetor[inicio];
                int i = inicio + 1;
                int f = fim;
                while (i <= f){
                    if (vetor[i] <= p){
                        i++;
                    }
                    else if (p < vetor[f]){
                        f--;
                    }
                    else{
                        int troca = vetor[i];
                        vetor[i] = vetor[f];
                        vetor[f] = troca;
                        i++;
                        f--;
                    }
                }
                vetor[inicio] = vetor[f];
                vetor[f] = p;
                quickSort(vetor, inicio, f - 1);
                quickSort(vetor, f + 1, fim);
            }
        }
    }
}
