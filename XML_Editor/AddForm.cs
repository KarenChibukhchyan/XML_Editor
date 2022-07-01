using System;
using System.Windows.Forms;
using XmlService1;


namespace XML_Editor
{
    public partial class AddForm : Form
    {
        private IXmlService _service;

        public AddForm(IXmlService service)
        {
            InitializeComponent();
            _service = service;
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxName.Text))
            {
                _service.AddPerson(age: (int) ageUpDown.Value, name: textBoxName.Text, id: Guid.NewGuid());
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}