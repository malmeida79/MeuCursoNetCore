using System;
using System.Windows.Forms;

namespace Segundo
{
    public partial class Segundo : Form
    {
        public Segundo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           var teste = MessageBox.Show("Palmeiras tem mundial?", ":: Verdade ::", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (teste == DialogResult.Yes)
            {
                MessageBox.Show("Mentira .....");
            }
            else {
                MessageBox.Show("E sabemos, que nunca terá .....");
            }

        }
    }
}
