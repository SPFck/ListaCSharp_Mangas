using System;

namespace ListaCompras
{
    public class Manga
    {
        public string Nome { get; set; }
        public string Author { get; set; }
        public int MangaCode { get; set; }
        public int TotalViews { get; set; }
        public string CurrentStatus { get; set; }
        public double Custo { get; set; }
        public double Preco { get; set; }
        public string MangaImage { get; set; }
        public Manga(string n, string a, int m, int t, string c, double p, string mi)
        {
            this.Nome = n;
            this.Author = a;
            this.MangaCode = m;
            this.TotalViews = t;
            this.CurrentStatus = c;
            this.Preco = p;
            this.MangaImage = mi;
        }
        public void setStatus(string status)
        {
            this.CurrentStatus = status;
        }
        public string getStatus()
        {
            return this.CurrentStatus;
        }
        public void resetViews()
        {
            this.TotalViews = 0;
        }

        public void setCusto(double qnt)
        {
            this.Custo += this.Preco * qnt;
        }
        public double getCustoCompra(double qnt)
        {
            return qnt * this.Preco;
        }
        public void resetCusto()
        {
            this.Custo = 0;
        }
    }
}
