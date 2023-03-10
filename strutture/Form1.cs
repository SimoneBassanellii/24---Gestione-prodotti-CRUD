using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace strutture
{
    public partial class Form1 : Form
    {   public struct prodotto
        {
            public string nome;
            public float prezzo;
        }
        public prodotto [] p;
        public int dim;
        public Form1()
        {
            InitializeComponent();
            p = new prodotto[100];
            dim = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void salva_Click(object sender, EventArgs e)
        {
            p[dim].nome = nome.Text;
            p[dim].prezzo = float.Parse(prezzo.Text);
            dim++;
            visualizza(p);
            
        }
        public string prodString(prodotto p)
        {
            return "Nome: "+ p.nome + "" + "prezzo: "+ p.prezzo+"€".ToString();
        }
        public void visualizza(prodotto[] pp)
        {
            listView1.Items.Clear();
            for (int i = 0; i < dim; i++)
            {
                listView1.Items.Add(prodString(p[i]));
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public int Ricerca(prodotto[] p, String elemento, int dim)
        {
            int ritorno = -1;    
            for (int i = 0; i < dim; i++)
            {
                if (p[i].nome == elemento)
                {
                    ritorno = 1;
                    break;
                }            
            }
            return ritorno;
        }

        public int Eliminazione(prodotto[] p, ref int dim, String elemento)
        {
            int eliminato = -1;
            int b = Ricerca(p, textBox1.Text,dim);
            for(int i=b; i<dim-1; i++)
            {
                p[i] = p[i + 1];
            }
            dim--;
            visualizza(p);
            return eliminato;
            
        }

        //funzione eleminazione
        public void button1_Click(object sender, EventArgs e)
        {
            Eliminazione(p,dim);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void prezzo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
