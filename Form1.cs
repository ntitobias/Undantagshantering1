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
            bool antalOK = int.TryParse(tbxAntal.Text, out antal);

            //Kontrollera inmatning
            if (antalOK && antal > 0)
                lista = new int[antal];
            else
            {
                MessageBox.Show("Ange ett tal över 0.");
                return;
            }

            //Generera slumptal från 1 till 6
            for (int i =0; i < antal; i++)
            {
                lista[i] = generator.Next(1, 7);
            }
        }
    }
}
