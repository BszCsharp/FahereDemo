using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsDemo
{
    public partial class FormFaehre : Form
    {
        Faehre faehre = null;
        public FormFaehre()
        {
            InitializeComponent();
            
        }

        private void buttonFaehreErzeugen_Click(object sender, EventArgs e)
        {
            faehre = new Faehre();
            faehre.Baujahr =  Convert.ToInt32( textBoxFaehreBaujahr.Text);
            faehre.Name = textBoxFaehreName.Text;
            faehre.Laenge = Convert.ToDecimal(textBoxFaehreLaenge.Text);
            toolStripStatusLabelMeldung.Text = "Fähre " + faehre.Name + " wurde angelegt";
        }

 
    }
}
