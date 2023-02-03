using System.ComponentModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormControlDemo
{
    public partial class frmPrincipal : Form, INotifyPropertyChanged
    {
        #region  VARIABLES
        public event PropertyChangedEventHandler? PropertyChanged;
        private List<Registro> _rows = null;
        private frmContenido _window = null;
        #endregion
        #region  CONSTRUCTOR
        public frmPrincipal()
        {
            InitializeComponent();
            rows = new List<Registro>();
        }
        #endregion
        #region  OBJETOS
        public frmContenido window
        {
            get { return _window; }
            set
            {
                _window = value;
                OnPropertyChanged("rows");
            }
        }
        public List<Registro> rows
        {
            get { return _rows; }
            set {
                _rows = value;
                OnPropertyChanged("rows");
            }
        }
        #endregion
        #region  EVENTOS
        private void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            var name = txtname.Text ?? "";
            var lname = txtname.Text ?? "";
            var phone = txtname.Text ?? "";
            var job = txtname.Text ?? "";
            if (String.IsNullOrWhiteSpace(name) ||
                String.IsNullOrWhiteSpace(lname) ||
                String.IsNullOrWhiteSpace(phone) ||
                String.IsNullOrWhiteSpace(job))
            {
                MessageBox.Show("Completar todos los campos", "Informativo");
            }
            else
            {
                if (window == null)
                {
                    window = new frmContenido();
                    window.OnCloseWindow += Window_OnCloseWindow;
                    window.Show(this);
                }
                rows.Add(new Registro
                {
                    name = name,
                    job = job,
                    phone = phone,
                    lastname = lname
                });
                window.update_date(rows);
            }
        }
        private void Window_OnCloseWindow(object? sender, EventArgs e)
        {
            window.Dispose();
            window = null;
        }
        #endregion
    }
}