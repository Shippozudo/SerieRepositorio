using System;

namespace DIO.Series
{
    public  class Serie : EntidadeBase
    {
        private Genero Genero    {get; set;}
        private string Titulo    {get; set;}
        private string Descricao {get; set;}
        private int    Ano       {get; set;}
        
        private bool Excluido {get; set;}

        public Serie(int id, Genero genero, string Titulo, string Descricao, int Ano)
        {
                this.Id = id;
                this.Genero = Genero;
                this.Titulo = Titulo;
                this.Descricao = Descricao;
                this.Ano = Ano;
                this.Excluido = false;

        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero +"\n";  //Environment.NewLine;
            retorno += "Título: " + this.Titulo + "\n"; //Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + "\n"; //Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + "\n"; //Environment.NewLine;
            retorno += "Excluído: " + this.Excluido;
            return retorno;
        }

        public string retornaTítulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }


    }
}