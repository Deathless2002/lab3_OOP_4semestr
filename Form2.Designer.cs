namespace OOP3
{
    partial class Form2
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
            this.gbDish = new System.Windows.Forms.GroupBox();
            this.rbSalad = new System.Windows.Forms.RadioButton();
            this.rbSoup = new System.Windows.Forms.RadioButton();
            this.rbVeganMD = new System.Windows.Forms.RadioButton();
            this.rbMeatMD = new System.Windows.Forms.RadioButton();
            this.rbGarnish = new System.Windows.Forms.RadioButton();
            this.rbDrink = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbCent = new System.Windows.Forms.Label();
            this.lbDollar = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.lbMethod = new System.Windows.Forms.Label();
            this.lbMeatType = new System.Windows.Forms.Label();
            this.lbSubs = new System.Windows.Forms.Label();
            this.lbSalad = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.lbGramm = new System.Windows.Forms.Label();
            this.tbDollar = new System.Windows.Forms.TextBox();
            this.tbCent = new System.Windows.Forms.TextBox();
            this.gbTemperature = new System.Windows.Forms.GroupBox();
            this.rbHot = new System.Windows.Forms.RadioButton();
            this.rbCold = new System.Windows.Forms.RadioButton();
            this.chbGarnish = new System.Windows.Forms.CheckBox();
            this.chbSoup = new System.Windows.Forms.CheckBox();
            this.tbUnique = new System.Windows.Forms.TextBox();
            this.gbDish.SuspendLayout();
            this.gbTemperature.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDish
            // 
            this.gbDish.Controls.Add(this.rbSalad);
            this.gbDish.Controls.Add(this.rbSoup);
            this.gbDish.Controls.Add(this.rbVeganMD);
            this.gbDish.Controls.Add(this.rbMeatMD);
            this.gbDish.Controls.Add(this.rbGarnish);
            this.gbDish.Controls.Add(this.rbDrink);
            this.gbDish.Location = new System.Drawing.Point(14, 11);
            this.gbDish.Name = "gbDish";
            this.gbDish.Size = new System.Drawing.Size(296, 255);
            this.gbDish.TabIndex = 0;
            this.gbDish.TabStop = false;
            this.gbDish.Text = "Блюдо:";
            // 
            // rbSalad
            // 
            this.rbSalad.AutoSize = true;
            this.rbSalad.Location = new System.Drawing.Point(6, 212);
            this.rbSalad.Name = "rbSalad";
            this.rbSalad.Size = new System.Drawing.Size(114, 37);
            this.rbSalad.TabIndex = 7;
            this.rbSalad.TabStop = true;
            this.rbSalad.Text = "Салат";
            this.rbSalad.UseVisualStyleBackColor = true;
            this.rbSalad.CheckedChanged += new System.EventHandler(this.rbSalad_CheckedChanged);
            // 
            // rbSoup
            // 
            this.rbSoup.AutoSize = true;
            this.rbSoup.Location = new System.Drawing.Point(6, 180);
            this.rbSoup.Name = "rbSoup";
            this.rbSoup.Size = new System.Drawing.Size(92, 37);
            this.rbSoup.TabIndex = 6;
            this.rbSoup.TabStop = true;
            this.rbSoup.Text = "Суп";
            this.rbSoup.UseVisualStyleBackColor = true;
            this.rbSoup.CheckedChanged += new System.EventHandler(this.rbSoup_CheckedChanged);
            // 
            // rbVeganMD
            // 
            this.rbVeganMD.AutoSize = true;
            this.rbVeganMD.Location = new System.Drawing.Point(7, 147);
            this.rbVeganMD.Name = "rbVeganMD";
            this.rbVeganMD.Size = new System.Drawing.Size(410, 37);
            this.rbVeganMD.TabIndex = 5;
            this.rbVeganMD.TabStop = true;
            this.rbVeganMD.Text = "Вегетарианское главное блюдо";
            this.rbVeganMD.UseVisualStyleBackColor = true;
            this.rbVeganMD.CheckedChanged += new System.EventHandler(this.rbVeganMD_CheckedChanged);
            // 
            // rbMeatMD
            // 
            this.rbMeatMD.AutoSize = true;
            this.rbMeatMD.Location = new System.Drawing.Point(7, 115);
            this.rbMeatMD.Name = "rbMeatMD";
            this.rbMeatMD.Size = new System.Drawing.Size(316, 37);
            this.rbMeatMD.TabIndex = 3;
            this.rbMeatMD.TabStop = true;
            this.rbMeatMD.Text = "Мясное главное блюдо";
            this.rbMeatMD.UseVisualStyleBackColor = true;
            this.rbMeatMD.CheckedChanged += new System.EventHandler(this.rbMeatMD_CheckedChanged);
            // 
            // rbGarnish
            // 
            this.rbGarnish.AutoSize = true;
            this.rbGarnish.Location = new System.Drawing.Point(7, 81);
            this.rbGarnish.Name = "rbGarnish";
            this.rbGarnish.Size = new System.Drawing.Size(131, 37);
            this.rbGarnish.TabIndex = 2;
            this.rbGarnish.TabStop = true;
            this.rbGarnish.Text = "Гарнир";
            this.rbGarnish.UseVisualStyleBackColor = true;
            this.rbGarnish.CheckedChanged += new System.EventHandler(this.rbGarnish_CheckedChanged);
            // 
            // rbDrink
            // 
            this.rbDrink.AutoSize = true;
            this.rbDrink.Location = new System.Drawing.Point(6, 38);
            this.rbDrink.Name = "rbDrink";
            this.rbDrink.Size = new System.Drawing.Size(147, 37);
            this.rbDrink.TabIndex = 1;
            this.rbDrink.TabStop = true;
            this.rbDrink.Text = "Напиток";
            this.rbDrink.UseVisualStyleBackColor = true;
            this.rbDrink.CheckedChanged += new System.EventHandler(this.rbDrink_CheckedChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(817, 340);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(106, 36);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(336, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(212, 33);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Название блюда:";
            // 
            // lbCent
            // 
            this.lbCent.AutoSize = true;
            this.lbCent.Location = new System.Drawing.Point(882, 44);
            this.lbCent.Name = "lbCent";
            this.lbCent.Size = new System.Drawing.Size(68, 33);
            this.lbCent.TabIndex = 4;
            this.lbCent.Text = "Cent";
            // 
            // lbDollar
            // 
            this.lbDollar.AutoSize = true;
            this.lbDollar.Location = new System.Drawing.Point(742, 40);
            this.lbDollar.Name = "lbDollar";
            this.lbDollar.Size = new System.Drawing.Size(28, 33);
            this.lbDollar.TabIndex = 5;
            this.lbDollar.Text = "$";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(641, 11);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(81, 33);
            this.lbPrice.TabIndex = 6;
            this.lbPrice.Text = "Цена:";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(336, 75);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(67, 33);
            this.lbWeight.TabIndex = 7;
            this.lbWeight.Text = "Вес:";
            // 
            // lbMethod
            // 
            this.lbMethod.AutoSize = true;
            this.lbMethod.Location = new System.Drawing.Point(336, 150);
            this.lbMethod.Name = "lbMethod";
            this.lbMethod.Size = new System.Drawing.Size(282, 33);
            this.lbMethod.TabIndex = 10;
            this.lbMethod.Text = "Метод приготовления:";
            // 
            // lbMeatType
            // 
            this.lbMeatType.AutoSize = true;
            this.lbMeatType.Location = new System.Drawing.Point(336, 150);
            this.lbMeatType.Name = "lbMeatType";
            this.lbMeatType.Size = new System.Drawing.Size(133, 33);
            this.lbMeatType.TabIndex = 11;
            this.lbMeatType.Text = "Вид мяса:";
            // 
            // lbSubs
            // 
            this.lbSubs.AutoSize = true;
            this.lbSubs.Location = new System.Drawing.Point(336, 150);
            this.lbSubs.Name = "lbSubs";
            this.lbSubs.Size = new System.Drawing.Size(222, 33);
            this.lbSubs.TabIndex = 12;
            this.lbSubs.Text = "Заменитель мяса:";
            // 
            // lbSalad
            // 
            this.lbSalad.AutoSize = true;
            this.lbSalad.Location = new System.Drawing.Point(336, 153);
            this.lbSalad.Name = "lbSalad";
            this.lbSalad.Size = new System.Drawing.Size(151, 33);
            this.lbSalad.TabIndex = 14;
            this.lbSalad.Text = "Вид салата:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(336, 40);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(217, 39);
            this.tbName.TabIndex = 15;
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(336, 111);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(94, 39);
            this.tbWeight.TabIndex = 17;
            // 
            // lbGramm
            // 
            this.lbGramm.AutoSize = true;
            this.lbGramm.Location = new System.Drawing.Point(438, 96);
            this.lbGramm.Name = "lbGramm";
            this.lbGramm.Size = new System.Drawing.Size(30, 33);
            this.lbGramm.TabIndex = 18;
            this.lbGramm.Text = "г.";
            // 
            // tbDollar
            // 
            this.tbDollar.Location = new System.Drawing.Point(641, 40);
            this.tbDollar.Name = "tbDollar";
            this.tbDollar.Size = new System.Drawing.Size(94, 39);
            this.tbDollar.TabIndex = 19;
            // 
            // tbCent
            // 
            this.tbCent.Location = new System.Drawing.Point(782, 40);
            this.tbCent.Name = "tbCent";
            this.tbCent.Size = new System.Drawing.Size(94, 39);
            this.tbCent.TabIndex = 20;
            // 
            // gbTemperature
            // 
            this.gbTemperature.Controls.Add(this.rbHot);
            this.gbTemperature.Controls.Add(this.rbCold);
            this.gbTemperature.Location = new System.Drawing.Point(633, 93);
            this.gbTemperature.Name = "gbTemperature";
            this.gbTemperature.Size = new System.Drawing.Size(290, 120);
            this.gbTemperature.TabIndex = 21;
            this.gbTemperature.TabStop = false;
            this.gbTemperature.Text = "Температура:";
            // 
            // rbHot
            // 
            this.rbHot.AutoSize = true;
            this.rbHot.Location = new System.Drawing.Point(15, 65);
            this.rbHot.Name = "rbHot";
            this.rbHot.Size = new System.Drawing.Size(145, 37);
            this.rbHot.TabIndex = 9;
            this.rbHot.TabStop = true;
            this.rbHot.Text = "Горячий";
            this.rbHot.UseVisualStyleBackColor = true;
            // 
            // rbCold
            // 
            this.rbCold.AutoSize = true;
            this.rbCold.Location = new System.Drawing.Point(15, 33);
            this.rbCold.Name = "rbCold";
            this.rbCold.Size = new System.Drawing.Size(168, 37);
            this.rbCold.TabIndex = 8;
            this.rbCold.TabStop = true;
            this.rbCold.Text = "Холодный";
            this.rbCold.UseVisualStyleBackColor = true;
            // 
            // chbGarnish
            // 
            this.chbGarnish.AutoSize = true;
            this.chbGarnish.Location = new System.Drawing.Point(21, 266);
            this.chbGarnish.Name = "chbGarnish";
            this.chbGarnish.Size = new System.Drawing.Size(185, 37);
            this.chbGarnish.TabIndex = 22;
            this.chbGarnish.Text = "С гарниром";
            this.chbGarnish.UseVisualStyleBackColor = true;
            // 
            // chbSoup
            // 
            this.chbSoup.AutoSize = true;
            this.chbSoup.Location = new System.Drawing.Point(21, 309);
            this.chbSoup.Name = "chbSoup";
            this.chbSoup.Size = new System.Drawing.Size(159, 37);
            this.chbSoup.TabIndex = 23;
            this.chbSoup.Text = "Крем-суп";
            this.chbSoup.UseVisualStyleBackColor = true;
            // 
            // tbUnique
            // 
            this.tbUnique.Location = new System.Drawing.Point(336, 189);
            this.tbUnique.Name = "tbUnique";
            this.tbUnique.Size = new System.Drawing.Size(229, 39);
            this.tbUnique.TabIndex = 24;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 573);
            this.Controls.Add(this.tbUnique);
            this.Controls.Add(this.chbSoup);
            this.Controls.Add(this.chbGarnish);
            this.Controls.Add(this.gbTemperature);
            this.Controls.Add(this.tbCent);
            this.Controls.Add(this.tbDollar);
            this.Controls.Add(this.lbGramm);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbSalad);
            this.Controls.Add(this.lbSubs);
            this.Controls.Add(this.lbMeatType);
            this.Controls.Add(this.lbMethod);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbDollar);
            this.Controls.Add(this.lbCent);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbDish);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form2";
            this.Text = "Form2";
            this.gbDish.ResumeLayout(false);
            this.gbDish.PerformLayout();
            this.gbTemperature.ResumeLayout(false);
            this.gbTemperature.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public GroupBox gbDish;
        public RadioButton rbSalad;
        public RadioButton rbSoup;
        public RadioButton rbVeganMD;
        public RadioButton rbMeatMD;
        public RadioButton rbGarnish;
        public RadioButton rbDrink;
        public Button btnOK;
        private Label lbName;
        private Label lbCent;
        private Label lbDollar;
        private Label lbPrice;
        private Label lbWeight;
        public Label lbMethod;
        public Label lbMeatType;
        public Label lbSubs;
        public Label lbSalad;
        public TextBox tbName;
        public TextBox tbWeight;
        private Label lbGramm;
        public TextBox tbDollar;
        public TextBox tbCent;
        public GroupBox gbTemperature;
        public RadioButton rbHot;
        public RadioButton rbCold;
        public CheckBox chbGarnish;
        public CheckBox chbSoup;
        public TextBox tbUnique;
    }
}