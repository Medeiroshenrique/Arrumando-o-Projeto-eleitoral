using System.Collections.Generic;
using System.Linq;


class ColecaoPessoa : IContratoInfoPessoal
{
    List<InformacaoPessoa> PessoasRegistradas = new List<InformacaoPessoa>();
    public void Adicionar(InformacaoPessoa p)
    {
        PessoasRegistradas.Add(p);
    }
    public void Remover(InformacaoPessoa p)
    {
        PessoasRegistradas.Remove(p);
    }

    public void Procurar(InformacaoPessoa p) { }

}
