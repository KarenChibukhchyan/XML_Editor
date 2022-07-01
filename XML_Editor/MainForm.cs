using System;
using System.Windows.Forms;
using XmlService1;

namespace XML_Editor;

public partial class MainForm : Form
{
    private readonly IXmlService _service;
    private readonly string _fileName;
    public MainForm(IXmlService service, string fileName)
    {
        InitializeComponent();
        _fileName = fileName;
        _service = service;
        _service.LoadXmlFromFile(_fileName);
        Redraw();
    }

    private void Redraw()
    {
        xmlTextBox.Text = _service.Content;
    }

    private void addBtn_Click(object sender, EventArgs e)
    {
        var form = new AddForm(_service);
        form.ShowDialog();
        Redraw();
    }

    private void removeBtn_Click(object sender, EventArgs e)
    {
        var form = new RemoveForm(_service);
        form.ShowDialog();
        Redraw();
    }

    private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        _service.SaveXmlToFile(_fileName);
    }
}