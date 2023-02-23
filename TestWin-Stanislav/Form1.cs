using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWin_Stanislav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (spravradiobtn.Checked  ) MessageBox.Show($"Вие въведохте {nameofbooktxtbtn.Text} с автор {autortxtbox.Text} жанр {spravradiobtn.Text} литература с {softcheckbtn.Text} издателство{izdcombobx.Text}");
            else if (hydradiobtn.Checked )
            {
                MessageBox.Show($"Вие въведохте {nameofbooktxtbtn.Text} с автор {autortxtbox.Text} жанр {spravradiobtn.Text} литература с {hardcheckbx.Text} издателство {izdcombobx.Text}");
            }
            else if (nauchradiobtn.Checked)
            {
                MessageBox.Show($"Вие въведохте {nameofbooktxtbtn.Text} с автор {autortxtbox.Text} жанр {spravradiobtn.Text} литература с {hardcheckbx.Text} издателство {izdcombobx.Text}");
            }
            else
            {
                MessageBox.Show("Трябва да въведеш жанр");
                hydradiobtn.Focus();
            }
            if(autortxtbox.Text=="")
            {
                MessageBox.Show("Трябва да въведеш автор!!");
                autortxtbox.Focus();
            }
            if(nameofbooktxtbtn.Text=="")
            {
                MessageBox.Show("Трябва да въведеш заглавието на книгата!!");
                autortxtbox.Focus();
            }
            if(izdcombobx.Text=="Издателство")
            {
                MessageBox.Show("Трябва да въведеш издателство");
                izdcombobx.Focus();
            }
        }

        private void izdcombobx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
