﻿using System;
using System.Collections.Generic;

class Pagina
{
    public int Id { get; set; }
    public byte BitR { get; set; }
    public byte BitA { get; set; }
}

class AgingAlgoritmo
{
    private LinkedList<Pagina> listaPaginas;

    public AgingAlgoritmo()
    {
        listaPaginas = new LinkedList<Pagina>();
    }

    public void AdicionarPagina(int id)
    {
        var pagina = new Pagina { Id = id, BitR = 0, BitA = 0 };
        listaPaginas.AddLast(pagina);
    }

    public void AtualizarBitA(int id)
    {
        foreach (var pagina in listaPaginas)
        {
            if (pagina.Id == id)
            {
                if (pagina != null)
                    pagina.BitA = 1; // Atualizar o bit A da página
            }
        }
    }

    public void ExecutarEnvelhecimento()
    {
        foreach (var pagina in listaPaginas)
        {
            pagina.BitR = (byte)(pagina.BitR >> 1 | (pagina.BitA << 7)); // Atualizar o bit R com o bit A
            pagina.BitA = 0; // Zerar o bit A
        }
    }

    public void SubstituirPagina()
    {
        var paginaSubstituida = listaPaginas.First;
        var menorBitR = paginaSubstituida.Value.BitR;

        foreach (var pagina in listaPaginas)
        {
            if (pagina.BitR < menorBitR)
            {
                menorBitR = pagina.BitR;
                paginaSubstituida = listaPaginas.Find(pagina);
            }
        }

        // Realizar a substituição da página
        Console.WriteLine($"Substituindo página {paginaSubstituida.Value.Id}");
        listaPaginas.Remove(paginaSubstituida);
    }

    public void ImprimirEstadoPaginas()
    {
        foreach (var pagina in listaPaginas)
        {
            Console.WriteLine($"Página {pagina.Id}: BitR = {pagina.BitR}, BitA = {pagina.BitA}");
        }
    }
}

class Program
{
    static void Main()
    {
        AgingAlgoritmo aging = new AgingAlgoritmo();

        // Adicionar páginas
        aging.AdicionarPagina(1);
        aging.AdicionarPagina(2);
        aging.AdicionarPagina(3);
        aging.AdicionarPagina(4);

        // Atualizar bits A das páginas
        aging.AtualizarBitA(1);
        //aging.AtualizarBitA(2);
        aging.AtualizarBitA(3);
        aging.AtualizarBitA(4);

        // Executar envelhecimento
        aging.ExecutarEnvelhecimento();

        // Substituir página
        aging.SubstituirPagina();

        // Imprimir estado das páginas
        aging.ImprimirEstadoPaginas();
    }
}
