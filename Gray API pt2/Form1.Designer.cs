namespace Gray_API_pt2
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PlanetCheck = new System.Windows.Forms.CheckBox();
            this.CharacterCheck = new System.Windows.Forms.CheckBox();
            this.InfoBox = new System.Windows.Forms.ListBox();
            this.ViewButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(96, 69);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(31, 69);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(59, 22);
            this.IDBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(448, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select whether you want to view a planet or a character and then input an ID";
            // 
            // PlanetCheck
            // 
            this.PlanetCheck.AutoSize = true;
            this.PlanetCheck.Location = new System.Drawing.Point(31, 40);
            this.PlanetCheck.Name = "PlanetCheck";
            this.PlanetCheck.Size = new System.Drawing.Size(67, 20);
            this.PlanetCheck.TabIndex = 4;
            this.PlanetCheck.Text = "Planet";
            this.PlanetCheck.UseVisualStyleBackColor = true;
            // 
            // CharacterCheck
            // 
            this.CharacterCheck.AutoSize = true;
            this.CharacterCheck.Location = new System.Drawing.Point(104, 40);
            this.CharacterCheck.Name = "CharacterCheck";
            this.CharacterCheck.Size = new System.Drawing.Size(87, 20);
            this.CharacterCheck.TabIndex = 5;
            this.CharacterCheck.Text = "Character";
            this.CharacterCheck.UseVisualStyleBackColor = true;
            // 
            // InfoBox
            // 
            this.InfoBox.FormattingEnabled = true;
            this.InfoBox.HorizontalScrollbar = true;
            this.InfoBox.ItemHeight = 16;
            this.InfoBox.Location = new System.Drawing.Point(31, 98);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(731, 324);
            this.InfoBox.TabIndex = 6;
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(619, 69);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(75, 23);
            this.ViewButton.TabIndex = 7;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "View all species";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.CharacterCheck);
            this.Controls.Add(this.PlanetCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.SearchButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox PlanetCheck;
        private System.Windows.Forms.CheckBox CharacterCheck;
        private System.Windows.Forms.ListBox InfoBox;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Label label1;
    }
}

