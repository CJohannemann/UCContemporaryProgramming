namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxProteinSelector = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radBtnBurrito = new System.Windows.Forms.RadioButton();
            this.radBtnBowl = new System.Windows.Forms.RadioButton();
            this.radBtnTaco = new System.Windows.Forms.RadioButton();
            this.radBtnSalad = new System.Windows.Forms.RadioButton();
            this.chkBoxExtras = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radBtnBeer = new System.Windows.Forms.RadioButton();
            this.radBtnH20 = new System.Windows.Forms.RadioButton();
            this.radBtnSoda = new System.Windows.Forms.RadioButton();
            this.container = new System.Windows.Forms.GroupBox();
            this.foodStyleBox = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.textAreaReceipt = new System.Windows.Forms.TextBox();
            this.container.SuspendLayout();
            this.foodStyleBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Burritos, Tacos && Salads";
            // 
            // comboBoxProteinSelector
            // 
            this.comboBoxProteinSelector.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxProteinSelector.FormattingEnabled = true;
            this.comboBoxProteinSelector.Items.AddRange(new object[] {
            "Chicken          6.25",
            "Steak              6.70",
            "Carnitas          6.70",
            "Barbacoa        6.70",
            "Vegetarian      6.25"});
            this.comboBoxProteinSelector.Location = new System.Drawing.Point(45, 143);
            this.comboBoxProteinSelector.Name = "comboBoxProteinSelector";
            this.comboBoxProteinSelector.Size = new System.Drawing.Size(139, 21);
            this.comboBoxProteinSelector.TabIndex = 2;
            this.comboBoxProteinSelector.Text = "     --Select--";
            this.comboBoxProteinSelector.SelectedIndexChanged += new System.EventHandler(this.comboBoxProteinSelector_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(282, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 182);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(508, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 182);
            this.label3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(15, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1000, 2);
            this.label4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F);
            this.label5.Location = new System.Drawing.Point(307, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 18);
            this.label5.TabIndex = 99;
            this.label5.Text = "What Goes Inside";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Cilantro-Lime Rice",
            "Pinto** Or Black Beans",
            "Salso",
            "Cheese Or Sour Cream",
            "Guacamole",
            "Lettuce"});
            this.checkedListBox1.Location = new System.Drawing.Point(301, 55);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(173, 100);
            this.checkedListBox1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F);
            this.label6.Location = new System.Drawing.Point(609, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 98;
            this.label6.Text = "Extras";
            // 
            // radBtnBurrito
            // 
            this.radBtnBurrito.AutoSize = true;
            this.radBtnBurrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.radBtnBurrito.Location = new System.Drawing.Point(6, 18);
            this.radBtnBurrito.Name = "radBtnBurrito";
            this.radBtnBurrito.Size = new System.Drawing.Size(64, 20);
            this.radBtnBurrito.TabIndex = 0;
            this.radBtnBurrito.TabStop = true;
            this.radBtnBurrito.Text = "Burrito";
            this.radBtnBurrito.UseVisualStyleBackColor = true;
            // 
            // radBtnBowl
            // 
            this.radBtnBowl.AutoSize = true;
            this.radBtnBowl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.radBtnBowl.Location = new System.Drawing.Point(102, 18);
            this.radBtnBowl.Name = "radBtnBowl";
            this.radBtnBowl.Size = new System.Drawing.Size(55, 20);
            this.radBtnBowl.TabIndex = 1;
            this.radBtnBowl.TabStop = true;
            this.radBtnBowl.Text = "Bowl";
            this.radBtnBowl.UseVisualStyleBackColor = true;
            // 
            // radBtnTaco
            // 
            this.radBtnTaco.AutoSize = true;
            this.radBtnTaco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.radBtnTaco.Location = new System.Drawing.Point(6, 44);
            this.radBtnTaco.Name = "radBtnTaco";
            this.radBtnTaco.Size = new System.Drawing.Size(65, 20);
            this.radBtnTaco.TabIndex = 2;
            this.radBtnTaco.TabStop = true;
            this.radBtnTaco.Text = "Tacos";
            this.radBtnTaco.UseVisualStyleBackColor = true;
            // 
            // radBtnSalad
            // 
            this.radBtnSalad.AutoSize = true;
            this.radBtnSalad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.radBtnSalad.Location = new System.Drawing.Point(102, 41);
            this.radBtnSalad.Name = "radBtnSalad";
            this.radBtnSalad.Size = new System.Drawing.Size(62, 20);
            this.radBtnSalad.TabIndex = 3;
            this.radBtnSalad.TabStop = true;
            this.radBtnSalad.Text = "Salad";
            this.radBtnSalad.UseVisualStyleBackColor = true;
            // 
            // chkBoxExtras
            // 
            this.chkBoxExtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.chkBoxExtras.CheckOnClick = true;
            this.chkBoxExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.chkBoxExtras.FormattingEnabled = true;
            this.chkBoxExtras.Items.AddRange(new object[] {
            "Chips & Guacamole      3.15",
            "Chips & Salsa                  1.75",
            "Guacamole                      1.90",
            "Chips                                  1.25"});
            this.chkBoxExtras.Location = new System.Drawing.Point(532, 55);
            this.chkBoxExtras.Name = "chkBoxExtras";
            this.chkBoxExtras.Size = new System.Drawing.Size(208, 84);
            this.chkBoxExtras.TabIndex = 4;
            this.chkBoxExtras.SelectedIndexChanged += new System.EventHandler(this.chkBoxExtras_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(780, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(2, 182);
            this.label7.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 12F);
            this.label8.Location = new System.Drawing.Point(869, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 18);
            this.label8.TabIndex = 99;
            this.label8.Text = "Drinks";
            // 
            // radBtnBeer
            // 
            this.radBtnBeer.AutoSize = true;
            this.radBtnBeer.Checked = true;
            this.radBtnBeer.Location = new System.Drawing.Point(24, 19);
            this.radBtnBeer.Name = "radBtnBeer";
            this.radBtnBeer.Size = new System.Drawing.Size(47, 17);
            this.radBtnBeer.TabIndex = 17;
            this.radBtnBeer.TabStop = true;
            this.radBtnBeer.Text = "Beer";
            this.radBtnBeer.UseVisualStyleBackColor = true;
            // 
            // radBtnH20
            // 
            this.radBtnH20.AutoSize = true;
            this.radBtnH20.Location = new System.Drawing.Point(24, 42);
            this.radBtnH20.Name = "radBtnH20";
            this.radBtnH20.Size = new System.Drawing.Size(90, 17);
            this.radBtnH20.TabIndex = 18;
            this.radBtnH20.Text = "Bottled Water";
            this.radBtnH20.UseVisualStyleBackColor = true;
            // 
            // radBtnSoda
            // 
            this.radBtnSoda.AutoSize = true;
            this.radBtnSoda.Location = new System.Drawing.Point(24, 65);
            this.radBtnSoda.Name = "radBtnSoda";
            this.radBtnSoda.Size = new System.Drawing.Size(50, 17);
            this.radBtnSoda.TabIndex = 19;
            this.radBtnSoda.Text = "Soda";
            this.radBtnSoda.UseVisualStyleBackColor = true;
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.Green;
            this.container.Controls.Add(this.radBtnBeer);
            this.container.Controls.Add(this.radBtnSoda);
            this.container.Controls.Add(this.radBtnH20);
            this.container.Location = new System.Drawing.Point(807, 55);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(200, 100);
            this.container.TabIndex = 5;
            this.container.TabStop = false;
            // 
            // foodStyleBox
            // 
            this.foodStyleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.foodStyleBox.Controls.Add(this.radBtnBurrito);
            this.foodStyleBox.Controls.Add(this.radBtnTaco);
            this.foodStyleBox.Controls.Add(this.radBtnBowl);
            this.foodStyleBox.Controls.Add(this.radBtnSalad);
            this.foodStyleBox.Location = new System.Drawing.Point(39, 53);
            this.foodStyleBox.Name = "foodStyleBox";
            this.foodStyleBox.Size = new System.Drawing.Size(200, 71);
            this.foodStyleBox.TabIndex = 1;
            this.foodStyleBox.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(435, 312);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(532, 312);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textAreaReceipt
            // 
            this.textAreaReceipt.BackColor = System.Drawing.Color.Chartreuse;
            this.textAreaReceipt.Location = new System.Drawing.Point(435, 207);
            this.textAreaReceipt.Multiline = true;
            this.textAreaReceipt.Name = "textAreaReceipt";
            this.textAreaReceipt.ReadOnly = true;
            this.textAreaReceipt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textAreaReceipt.Size = new System.Drawing.Size(162, 89);
            this.textAreaReceipt.TabIndex = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1019, 347);
            this.Controls.Add(this.textAreaReceipt);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.foodStyleBox);
            this.Controls.Add(this.container);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkBoxExtras);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxProteinSelector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Chipotle Menu";
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.foodStyleBox.ResumeLayout(false);
            this.foodStyleBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxProteinSelector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radBtnBurrito;
        private System.Windows.Forms.RadioButton radBtnBowl;
        private System.Windows.Forms.RadioButton radBtnTaco;
        private System.Windows.Forms.RadioButton radBtnSalad;
        private System.Windows.Forms.CheckedListBox chkBoxExtras;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radBtnBeer;
        private System.Windows.Forms.RadioButton radBtnH20;
        private System.Windows.Forms.RadioButton radBtnSoda;
        private System.Windows.Forms.GroupBox container;
        private System.Windows.Forms.GroupBox foodStyleBox;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox textAreaReceipt;
    }
}

