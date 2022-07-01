using System;
using System.Windows.Forms;
using XmlService1;


namespace XML_Editor
{
    public partial class RemoveForm : Form
    {
        private IXmlService _service;

        public RemoveForm(IXmlService service)
        {
            InitializeComponent();
            _service = service;
        }


        private void removeButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxName.Text))
            {
                _service.DeletePerson(textBoxName.Text);
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxName.Text))
            {
                this.Close();
            }
        }
    }
}