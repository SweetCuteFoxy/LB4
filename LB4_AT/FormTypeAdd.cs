using System.ComponentModel;
using System.Windows.Forms;

namespace LB4_AT
{

    public partial class FormTypeAdd : Form
    {
        string msgError = "Поле не может быть пустым";

        public string MsgError { get => msgError; set => msgError = value; }

        public FormTypeAdd()
        {
            InitializeComponent();
        }

        private void TextBoxTypeName_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxTypeName.Text))
            {
                errorProvider.SetError(textBoxTypeName, MsgError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void TextBoxTypeName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxTypeName.Text))
            {
                errorProvider.SetError(textBoxTypeName, MsgError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }
    }
}
