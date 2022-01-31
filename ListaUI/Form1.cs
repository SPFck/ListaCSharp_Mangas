using ListaCompras;
using ListaUI.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ListaUI
{
    public partial class Form1 : Form
    {
        double totalCompras = 0;

        private void lbinit()
        {
            lbDados.Items.Clear();
            lbDados.Items.AddRange(new object[]{"The Beginning After The End", "Solo Leveling", "Kimetsu No Yaiba", "Chainsaw Man", "Jujutsu Kaisen", "Boku No Hero Academia", "Tensei Shitara Slime Datta Ken", "One Punch Man", "Bleach", "Goblin Slayer" });
            totalCompras = 0;
        }

        private void ExibirItem(Manga i)
        {
            txt_nome.Text = i.Nome;
            txt_author.Text = i.Author;
            txt_mangacode.Text = i.MangaCode.ToString();
            txt_preco.Text = i.Preco.ToString("C");
            txt_views.Text = i.TotalViews.ToString();
            txt_estado.Text = i.CurrentStatus;
            Bitmap mangaimage = (Bitmap)Resources.ResourceManager.GetObject(i.MangaImage);
            manga_image.Image = mangaimage;
            /*if(i.Custo != 0)
            {
                x.Text = i.Custo.ToString("C");
            }*/
        }

        public Form1()
        {
            InitializeComponent();
            lbinit();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            foreach(var c in Controls)
            {
                if(c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
            }
            txt_mangacode.Text = "";
            txt_views.Text = "";
            txt_preco.Text = "";
            txt_quantidade.Text = "";
            txt_nome.Text = "";
            txt_author.Text = "";
            txt_estado.Text = "";
            totalCompras = 0;
            label_total.Text = "Total: 0";
            manga_image.Image = null;
        }

        Manga manga1 = new TheBeginningAfterTheEnd();
        Manga manga2 = new SoloLeveling();
        Manga manga3 = new KimetsuNoYaiba();
        Manga manga4 = new ChainsawMan();
        Manga manga5 = new JujutsuKaisen();
        Manga manga6 = new BokuNoHeroAcademia();
        Manga manga7 = new TenseiShitaraSlimeDattaKen();
        Manga manga8 = new OnePunchMan();
        Manga manga9 = new Bleach();
        Manga manga10 = new GoblinSlayer();

        private void lbDados_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
            switch(lbDados.Items[lbDados.SelectedIndex])
            {
                case "The Beginning After The End":
                    ExibirItem(manga1);
                    break;
                case "Solo Leveling":
                    ExibirItem(manga2);
                    break;
                case "Kimetsu No Yaiba":
                    ExibirItem(manga3);
                    break;
                case "Chainsaw Man":
                    ExibirItem(manga4);
                    break;
                case "Jujutsu Kaisen":
                    ExibirItem(manga5);
                    break;
                case "Boku No Hero Academia":
                    ExibirItem(manga6);
                    break;
                case "Tensei Shitara Slime Datta Ken":
                    ExibirItem(manga7);
                    break;
                case "One Punch Man":
                    ExibirItem(manga8);
                    break;
                case "Bleach":
                    ExibirItem(manga9);
                    break;
                case "Goblin Slayer":
                    ExibirItem(manga10);
                    break;
                default:
                    errorProvider.SetError(lbDados, "Manga inválido!");
                    break;
            }
        }

        private void AdicionarItem(Manga i)
        {
            double qnt = Convert.ToDouble(txt_quantidade.Text);
            i.setCusto(qnt);
            txt_quantidade.Text = "";
            totalCompras += i.getCustoCompra(qnt);
            string x = totalCompras.ToString("C");
            label_total.Text = $"Total: {x}";
        }

        private void RemoverItem(Manga i)
        {
            totalCompras -= i.Custo;
            i.resetCusto();
            txt_quantidade.Text = "";
            label_total.Text = "Total: 0";
            if(totalCompras != 0)
            {
                string x = totalCompras.ToString("C");
                label_total.Text = $"Total: {x}";
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            try
            {
                switch(lbDados.Items[lbDados.SelectedIndex])
                {
                    case "The Beginning After The End":
                        AdicionarItem(manga1);
                        break;
                    case "Solo Leveling":
                        AdicionarItem(manga2);
                        break;
                    case "Kimetsu No Yaiba":
                        AdicionarItem(manga3);
                        break;
                    case "Chainsaw Man":
                        AdicionarItem(manga4);
                        break;
                    case "Jujutsu Kaisen":
                        AdicionarItem(manga5);
                        break;
                    case "Boku No Hero Academia":
                        AdicionarItem(manga6);
                        break;
                    case "Tensei Shitara Slime Datta Ken":
                        AdicionarItem(manga7);
                        break;
                    case "One Punch Man":
                        AdicionarItem(manga8);
                        break;
                    case "Bleach":
                        AdicionarItem(manga9);
                        break;
                    case "Goblin Slayer":
                        AdicionarItem(manga10);
                        break;
                    default:
                        errorProvider.SetError(lbDados, "Manga inválido!");
                        break;
                }
            } catch (FormatException)
            {
                errorProvider.SetError(txt_quantidade, "Coloque um valor!");
                txt_quantidade.Focus();
            } catch (ArgumentOutOfRangeException)
            {
                errorProvider.SetError(lbDados, "Selecione um item da lista!");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            try
            {
                switch(lbDados.Items[lbDados.SelectedIndex])
                {
                    case "The Beginning After The End":
                        RemoverItem(manga1);
                        break;
                    case "Solo Leveling":
                        RemoverItem(manga2);
                        break;
                    case "Kimetsu No Yaiba":
                        RemoverItem(manga3);
                        break;
                    case "Chainsaw Man":
                        RemoverItem(manga4);
                        break;
                    case "Jujutsu Kaisen":
                        RemoverItem(manga5);
                        break;
                    case "Boku No Hero Academia":
                        RemoverItem(manga6);
                        break;
                    case "Tensei Shitara Slime Datta Ken":
                        RemoverItem(manga7);
                        break;
                    case "One Punch Man":
                        RemoverItem(manga8);
                        break;
                    case "Bleach":
                        RemoverItem(manga9);
                        break;
                    case "Goblin Slayer":
                        RemoverItem(manga10);
                        break;
                    default:
                        errorProvider.SetError(lbDados, "Manga inválido!");
                        break;
                }
            } catch (ArgumentOutOfRangeException)
            {
                errorProvider.SetError(lbDados, "Selecione um item da lista!");
            }
        }
    }
}
