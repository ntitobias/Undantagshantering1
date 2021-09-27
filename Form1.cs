using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Undantagshantering1
{
    public partial class Form1 : Form
    {
        private int[] lista;
        Random generator = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerera_Click(object sender, EventArgs e)
        {
            // Läs in antal
            int antal;
            antal = int.Parse(tbxAntal.Text);

            //Generera slumptal från 1 till 6
            for (int i =0; i < antal; i++)
            {
                lista[i] = generator.Next(1, 7);
            }
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            //Läs in index
            int index = int.Parse(tbxIndex.Text);

            //Visa det aktuella slumptalet
            tbxVärde.Text = lista[index].ToString();
        }
    }
}
