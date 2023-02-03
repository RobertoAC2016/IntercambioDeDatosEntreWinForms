using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormControlDemo
{
    public partial class frmContenido : Form
    {
        #region VARIABLES
        public event EventHandler OnCloseWindow;
        #endregion
        #region OBJETOS
        #endregion
        #region CONSTRUCTOR
        public frmContenido()
        {
            InitializeComponent();
        }
        #endregion
        #region EVENTOS
        public void update_date(List<Registro> rows)
        {
            dgvdatos.DataSource = null;
            dgvdatos.DataSource = rows;
        }
        private void frmContenido_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnCloseWindow.Invoke(this, e);
        }
        #endregion
    }
}
