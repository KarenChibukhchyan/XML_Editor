using System.Windows.Forms;

namespace XML_Editor;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.addBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.xmlTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(12, 12);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(156, 62);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add Person";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(632, 12);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(156, 62);
            this.removeBtn.TabIndex = 1;
            this.removeBtn.Text = "Remove Person";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // xmlTextBox
            // 
            this.xmlTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.xmlTextBox.Location = new System.Drawing.Point(12, 100);
            this.xmlTextBox.Multiline = true;
            this.xmlTextBox.Name = "xmlTextBox";
            this.xmlTextBox.ReadOnly = true;
            this.xmlTextBox.Size = new System.Drawing.Size(776, 558);
            this.xmlTextBox.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 670);
            this.Controls.Add(this.xmlTextBox);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.Name = "MainForm";
            this.Text = "XML Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Button addBtn;
    private Button removeBtn;
    private TextBox xmlTextBox;
}