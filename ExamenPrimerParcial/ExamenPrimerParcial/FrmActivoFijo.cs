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
    public partial class FrmActivoFijo : Form
    {
        public ActivoFijoModel actModel;
        public FrmActivoFijo()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(txtId.Text, out id);
            if ( txtId == null || txtCodigo == null || txtNombre == null || txtDescripcion == null || nudValor == null || nudValorResidual == null || dtpFechaAdquisicion == null || cmbTipoActivo == null || cmbTipoDepreciacion == null)
            {
                throw new ArgumentException("Todos los datos del activo fijo deben ser llenados");
            }
            ActivoFijo act = new ActivoFijo()
            {
                Id = id,
                CodigoActivo = txtCodigo.Text,
                NombreActivo = txtNombre.Text,
                ValorActivo = (decimal)nudValor.Value,
                ValorResidual = (decimal)nudValorResidual.Value,
                FechaAdquisicion = dtpFechaAdquisicion.Value,
                tipoActivo = (TipoActivo)cmbTipoActivo.SelectedIndex,
                metodoDespreciacion = (MetodoDespreciacion)cmbTipoDepreciacion.SelectedIndex
            };
            actModel.Agregar(act);
            Dispose();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FrmActivoFijo_Load(object sender, EventArgs e)
        {
            cmbTipoActivo.Items.AddRange(Enum.GetValues(typeof(TipoActivo)).Cast<object>().ToArray());
            cmbTipoDepreciacion.Items.AddRange(Enum.GetValues(typeof(MetodoDespreciacion)).Cast<object>().ToArray());
        }
    }
}
