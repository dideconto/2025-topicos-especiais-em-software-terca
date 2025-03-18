//2 - Criar um loop para percorrer todo o vetor
//3 - Preencher cada posição com um valor aleatório
//4 - Imprimir o vetor na tela

int[] vetor = new int[100];
Random r = new Random();

//Criar um vetor de 100 posições inteiras
for (int i = 0; i < vetor.Length; i++)
{
    vetor[i] = r.Next(100);
}

//Imprimir o vetor com os valores aleatórios
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}

bool troca = false;
do{
    troca = false;
    for (int i = 0; i < vetor.Length - 1; i++)
    {
        int atual = i;
        int prox = i + 1;
        if (vetor[atual] > vetor[prox])
        {
            int aux = vetor[atual];
            vetor[atual] = vetor[prox];
            vetor[prox] = aux;
            troca = true;
        }
    }
}while(troca == true);

//Imprimir o vetor com os valores ordenados
Console.WriteLine("\n");
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}