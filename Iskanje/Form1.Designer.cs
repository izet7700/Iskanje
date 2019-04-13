namespace Iskanje
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.vnosTextBox = new System.Windows.Forms.TextBox();
            this.dodajButton = new System.Windows.Forms.Button();
            this.vsebujeButton = new System.Windows.Forms.Button();
            this.minButton = new System.Windows.Forms.Button();
            this.maxButton = new System.Windows.Forms.Button();
            this.povpButton = new System.Windows.Forms.Button();
            this.vsotaButton = new System.Windows.Forms.Button();
            this.vsBinarButton = new System.Windows.Forms.Button();
            this.urediIzbButton = new System.Windows.Forms.Button();
            this.urediMehButton = new System.Windows.Forms.Button();
            this.urediVstButton = new System.Windows.Forms.Button();
            this.hitUredButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.labOutPanel = new System.Windows.Forms.Panel();
            this.napolniButton = new System.Windows.Forms.Button();
            this.labOutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // vnosTextBox
            // 
            this.vnosTextBox.Location = new System.Drawing.Point(13, 19);
            this.vnosTextBox.Name = "vnosTextBox";
            this.vnosTextBox.Size = new System.Drawing.Size(181, 20);
            this.vnosTextBox.TabIndex = 0;
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(223, 11);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(75, 35);
            this.dodajButton.TabIndex = 1;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // vsebujeButton
            // 
            this.vsebujeButton.Location = new System.Drawing.Point(304, 11);
            this.vsebujeButton.Name = "vsebujeButton";
            this.vsebujeButton.Size = new System.Drawing.Size(75, 35);
            this.vsebujeButton.TabIndex = 2;
            this.vsebujeButton.Text = "Vsebuje";
            this.vsebujeButton.UseVisualStyleBackColor = true;
            this.vsebujeButton.Click += new System.EventHandler(this.vsebujeButton_Click);
            // 
            // minButton
            // 
            this.minButton.Location = new System.Drawing.Point(13, 49);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(82, 41);
            this.minButton.TabIndex = 3;
            this.minButton.Text = "Min";
            this.minButton.UseVisualStyleBackColor = true;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // maxButton
            // 
            this.maxButton.Location = new System.Drawing.Point(110, 49);
            this.maxButton.Name = "maxButton";
            this.maxButton.Size = new System.Drawing.Size(84, 41);
            this.maxButton.TabIndex = 4;
            this.maxButton.Text = "Max";
            this.maxButton.UseVisualStyleBackColor = true;
            this.maxButton.Click += new System.EventHandler(this.maxButton_Click);
            // 
            // povpButton
            // 
            this.povpButton.Location = new System.Drawing.Point(110, 105);
            this.povpButton.Name = "povpButton";
            this.povpButton.Size = new System.Drawing.Size(84, 41);
            this.povpButton.TabIndex = 6;
            this.povpButton.Text = "Povprečje";
            this.povpButton.UseVisualStyleBackColor = true;
            this.povpButton.Click += new System.EventHandler(this.povpButton_Click);
            // 
            // vsotaButton
            // 
            this.vsotaButton.Location = new System.Drawing.Point(13, 105);
            this.vsotaButton.Name = "vsotaButton";
            this.vsotaButton.Size = new System.Drawing.Size(82, 41);
            this.vsotaButton.TabIndex = 5;
            this.vsotaButton.Text = "Vsota";
            this.vsotaButton.UseVisualStyleBackColor = true;
            this.vsotaButton.Click += new System.EventHandler(this.vsotaButton_Click);
            // 
            // vsBinarButton
            // 
            this.vsBinarButton.Location = new System.Drawing.Point(388, 11);
            this.vsBinarButton.Name = "vsBinarButton";
            this.vsBinarButton.Size = new System.Drawing.Size(75, 56);
            this.vsBinarButton.TabIndex = 7;
            this.vsBinarButton.Text = "Vsebuje binarno";
            this.vsBinarButton.UseVisualStyleBackColor = true;
            this.vsBinarButton.Click += new System.EventHandler(this.vsBinarButton_Click);
            // 
            // urediIzbButton
            // 
            this.urediIzbButton.Location = new System.Drawing.Point(388, 73);
            this.urediIzbButton.Name = "urediIzbButton";
            this.urediIzbButton.Size = new System.Drawing.Size(75, 56);
            this.urediIzbButton.TabIndex = 8;
            this.urediIzbButton.Text = "Uredi z izbiranjem";
            this.urediIzbButton.UseVisualStyleBackColor = true;
            this.urediIzbButton.Click += new System.EventHandler(this.urediIzbButton_Click);
            // 
            // urediMehButton
            // 
            this.urediMehButton.Location = new System.Drawing.Point(223, 73);
            this.urediMehButton.Name = "urediMehButton";
            this.urediMehButton.Size = new System.Drawing.Size(75, 56);
            this.urediMehButton.TabIndex = 9;
            this.urediMehButton.Text = "Uredi z mehurčki";
            this.urediMehButton.UseVisualStyleBackColor = true;
            this.urediMehButton.Click += new System.EventHandler(this.urediMehButton_Click);
            // 
            // urediVstButton
            // 
            this.urediVstButton.Location = new System.Drawing.Point(304, 73);
            this.urediVstButton.Name = "urediVstButton";
            this.urediVstButton.Size = new System.Drawing.Size(75, 56);
            this.urediVstButton.TabIndex = 11;
            this.urediVstButton.Text = "Uredi z vstavljanjem";
            this.urediVstButton.UseVisualStyleBackColor = true;
            this.urediVstButton.Click += new System.EventHandler(this.urediVstButton_Click);
            // 
            // hitUredButton
            // 
            this.hitUredButton.Location = new System.Drawing.Point(223, 135);
            this.hitUredButton.Name = "hitUredButton";
            this.hitUredButton.Size = new System.Drawing.Size(240, 36);
            this.hitUredButton.TabIndex = 12;
            this.hitUredButton.Text = "Hitro uredi";
            this.hitUredButton.UseVisualStyleBackColor = true;
            this.hitUredButton.Click += new System.EventHandler(this.hitUredButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.outputLabel.Location = new System.Drawing.Point(3, 0);
            this.outputLabel.MaximumSize = new System.Drawing.Size(163, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(57, 20);
            this.outputLabel.TabIndex = 13;
            this.outputLabel.Text = "Tabela";
            // 
            // labOutPanel
            // 
            this.labOutPanel.AutoScroll = true;
            this.labOutPanel.Controls.Add(this.outputLabel);
            this.labOutPanel.Location = new System.Drawing.Point(12, 152);
            this.labOutPanel.Name = "labOutPanel";
            this.labOutPanel.Size = new System.Drawing.Size(187, 91);
            this.labOutPanel.TabIndex = 14;
            // 
            // napolniButton
            // 
            this.napolniButton.Location = new System.Drawing.Point(388, 178);
            this.napolniButton.Name = "napolniButton";
            this.napolniButton.Size = new System.Drawing.Size(74, 65);
            this.napolniButton.TabIndex = 15;
            this.napolniButton.Text = "Napolni";
            this.napolniButton.UseVisualStyleBackColor = true;
            this.napolniButton.Click += new System.EventHandler(this.napolniButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(475, 257);
            this.Controls.Add(this.napolniButton);
            this.Controls.Add(this.labOutPanel);
            this.Controls.Add(this.hitUredButton);
            this.Controls.Add(this.urediVstButton);
            this.Controls.Add(this.urediMehButton);
            this.Controls.Add(this.urediIzbButton);
            this.Controls.Add(this.vsBinarButton);
            this.Controls.Add(this.povpButton);
            this.Controls.Add(this.vsotaButton);
            this.Controls.Add(this.maxButton);
            this.Controls.Add(this.minButton);
            this.Controls.Add(this.vsebujeButton);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.vnosTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iskanje";
            this.labOutPanel.ResumeLayout(false);
            this.labOutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vnosTextBox;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Button vsebujeButton;
        private System.Windows.Forms.Button minButton;
        private System.Windows.Forms.Button maxButton;
        private System.Windows.Forms.Button povpButton;
        private System.Windows.Forms.Button vsotaButton;
        private System.Windows.Forms.Button vsBinarButton;
        private System.Windows.Forms.Button urediIzbButton;
        private System.Windows.Forms.Button urediMehButton;
        private System.Windows.Forms.Button urediVstButton;
        private System.Windows.Forms.Button hitUredButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Panel labOutPanel;
        private System.Windows.Forms.Button napolniButton;
    }
}

