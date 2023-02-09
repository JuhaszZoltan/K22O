namespace BukkMaraton2019GUI
{
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
            this.ifLbl1 = new System.Windows.Forms.Label();
            this.tavComboBox = new System.Windows.Forms.ComboBox();
            this.idoTextBox = new System.Windows.Forms.TextBox();
            this.szamolButton = new System.Windows.Forms.Button();
            this.ifLbl2 = new System.Windows.Forms.Label();
            this.ifLbl3 = new System.Windows.Forms.Label();
            this.ifLbl4 = new System.Windows.Forms.Label();
            this.kmphLabel = new System.Windows.Forms.Label();
            this.mpsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ifLbl1
            // 
            this.ifLbl1.AutoSize = true;
            this.ifLbl1.Location = new System.Drawing.Point(25, 27);
            this.ifLbl1.Name = "ifLbl1";
            this.ifLbl1.Size = new System.Drawing.Size(35, 21);
            this.ifLbl1.TabIndex = 100;
            this.ifLbl1.Text = "Táv:";
            // 
            // tavComboBox
            // 
            this.tavComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tavComboBox.FormattingEnabled = true;
            this.tavComboBox.Location = new System.Drawing.Point(66, 24);
            this.tavComboBox.Name = "tavComboBox";
            this.tavComboBox.Size = new System.Drawing.Size(208, 29);
            this.tavComboBox.TabIndex = 1;
            // 
            // idoTextBox
            // 
            this.idoTextBox.Location = new System.Drawing.Point(162, 75);
            this.idoTextBox.Name = "idoTextBox";
            this.idoTextBox.Size = new System.Drawing.Size(112, 29);
            this.idoTextBox.TabIndex = 2;
            this.idoTextBox.Text = " ";
            // 
            // szamolButton
            // 
            this.szamolButton.Location = new System.Drawing.Point(334, 24);
            this.szamolButton.Name = "szamolButton";
            this.szamolButton.Size = new System.Drawing.Size(120, 120);
            this.szamolButton.TabIndex = 3;
            this.szamolButton.Text = "Számol";
            this.szamolButton.UseVisualStyleBackColor = true;
            // 
            // ifLbl2
            // 
            this.ifLbl2.AutoSize = true;
            this.ifLbl2.Location = new System.Drawing.Point(25, 78);
            this.ifLbl2.Name = "ifLbl2";
            this.ifLbl2.Size = new System.Drawing.Size(131, 21);
            this.ifLbl2.TabIndex = 100;
            this.ifLbl2.Text = "Idő [óra:perc:mp]:";
            // 
            // ifLbl3
            // 
            this.ifLbl3.AutoSize = true;
            this.ifLbl3.Location = new System.Drawing.Point(25, 160);
            this.ifLbl3.Name = "ifLbl3";
            this.ifLbl3.Size = new System.Drawing.Size(163, 21);
            this.ifLbl3.TabIndex = 100;
            this.ifLbl3.Text = "Átlagsebesség [km/h]:";
            // 
            // ifLbl4
            // 
            this.ifLbl4.AutoSize = true;
            this.ifLbl4.Location = new System.Drawing.Point(25, 211);
            this.ifLbl4.Name = "ifLbl4";
            this.ifLbl4.Size = new System.Drawing.Size(153, 21);
            this.ifLbl4.TabIndex = 100;
            this.ifLbl4.Text = "Átlagsebesség [m/s]:";
            // 
            // kmphLabel
            // 
            this.kmphLabel.AutoSize = true;
            this.kmphLabel.Location = new System.Drawing.Point(194, 160);
            this.kmphLabel.Name = "kmphLabel";
            this.kmphLabel.Size = new System.Drawing.Size(37, 21);
            this.kmphLabel.TabIndex = 100;
            this.kmphLabel.Text = "###";
            // 
            // mpsLabel
            // 
            this.mpsLabel.AutoSize = true;
            this.mpsLabel.Location = new System.Drawing.Point(194, 211);
            this.mpsLabel.Name = "mpsLabel";
            this.mpsLabel.Size = new System.Drawing.Size(37, 21);
            this.mpsLabel.TabIndex = 100;
            this.mpsLabel.Text = "###";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.szamolButton);
            this.Controls.Add(this.idoTextBox);
            this.Controls.Add(this.tavComboBox);
            this.Controls.Add(this.ifLbl4);
            this.Controls.Add(this.mpsLabel);
            this.Controls.Add(this.kmphLabel);
            this.Controls.Add(this.ifLbl3);
            this.Controls.Add(this.ifLbl2);
            this.Controls.Add(this.ifLbl1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 300);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "MainForm";
            this.Text = "Bükk Maraton 2019";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ifLbl1;
        private ComboBox tavComboBox;
        private TextBox idoTextBox;
        private Button szamolButton;
        private Label ifLbl2;
        private Label ifLbl3;
        private Label ifLbl4;
        private Label kmphLabel;
        private Label mpsLabel;
    }
}