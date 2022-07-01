using System.Windows.Forms;

namespace XML_Editor
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.ageUpDown = new System.Windows.Forms.NumericUpDown();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ageUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(22, 29);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(140, 28);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Person\'s Name";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ageLabel.Location = new System.Drawing.Point(22, 87);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(123, 28);
            this.ageLabel.TabIndex = 1;
            this.ageLabel.Text = "Person\'s Age";
            this.ageLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.Location = new System.Drawing.Point(168, 23);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(208, 34);
            this.textBoxName.TabIndex = 2;
            // 
            // ageUpDown
            // 
            this.ageUpDown.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ageUpDown.Location = new System.Drawing.Point(168, 81);
            this.ageUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ageUpDown.Name = "ageUpDown";
            this.ageUpDown.Size = new System.Drawing.Size(120, 34);
            this.ageUpDown.TabIndex = 4;
            this.ageUpDown.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(34, 195);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(128, 82);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add Person";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(206, 195);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(128, 82);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddForm
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.ageUpDown);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Person";
            ((System.ComponentModel.ISupportInitialize)(this.ageUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nameLabel;
        private Label ageLabel;
        private TextBox textBoxName;
        private NumericUpDown ageUpDown;
        private Button addButton;
        private Button cancelButton;
    }
}