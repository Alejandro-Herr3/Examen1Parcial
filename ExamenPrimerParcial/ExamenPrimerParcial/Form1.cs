using Domain;
using InfraEstructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenPrimerParcial
{
    public partial class Form1 : Form
    {
        public ActivoFijoModel actModel { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FrmActivoFijo frmActivoFijo = new FrmActivoFijo();
            frmActivoFijo.Show();

            string json = string.Empty;
            for ( int i = 0; i<actModel.activoFijo.Length; i++)
            {
                json = $@"{json}{actModel.ConvertirAJson(actModel.activoFijo[i])}";
                richTextBox1.Text = json;
            }
        }
    }
}
