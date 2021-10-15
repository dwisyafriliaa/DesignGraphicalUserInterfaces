using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiSelamatDatang
{
    public partial class frmSelamatDatang : Form
    {
        public frmSelamatDatang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblKeterangan.Text = "Selamat Datang Di Pemrograman C#";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblKeterangan.Text = "Begitu mudahnya membuat aplikasi berbasis windows";
        }
    }
}
