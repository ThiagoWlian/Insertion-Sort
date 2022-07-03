int[] vetorDesordenado = {7,9,4,40,6};

void ordenaVetorNumerico()
{
    for(int indice = 0; indice < vetorDesordenado.Length; indice++)
    {
        int atualValor = vetorDesordenado[indice];
        int maiorValor = vetorDesordenado[indiceMenorNumero];

        vetorDesordenado[indice] = maiorValor;
        vetorDesordenado[indiceMenorNumero] = atualValor;
    }
}

ordenaVetorNumerico();

foreach (int indice in vetorDesordenado)
{
    Console.WriteLine(indice);
}
