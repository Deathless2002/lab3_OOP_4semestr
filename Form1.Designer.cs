namespace OOP3
{
    partial class Form1
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
            this.dgvDishes = new System.Windows.Forms.DataGridView();
            this.colunm_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_temperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_garnish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_meat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_salad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_soup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_subtitute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSerialize = new System.Windows.Forms.Button();
            this.btnDeserialize = new System.Windows.Forms.Button();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDishes
            // 
            this.dgvDishes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDishes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDishes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvDishes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDishes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDishes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDishes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunm_type,
            this.column_name,
            this.column_price,
            this.column_weight,
            this.column_temperature,
            this.column_method,
            this.column_garnish,
            this.column_meat,
            this.column_salad,
            this.column_soup,
            this.column_subtitute});
            this.dgvDishes.Location = new System.Drawing.Point(2, 3);
            this.dgvDishes.Name = "dgvDishes";
            this.dgvDishes.RowHeadersVisible = false;
            this.dgvDishes.RowHeadersWidth = 51;
            this.dgvDishes.RowTemplate.Height = 29;
            this.dgvDishes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDishes.Size = new System.Drawing.Size(1384, 729);
            this.dgvDishes.TabIndex = 0;
            // 
            // colunm_type
            // 
            this.colunm_type.HeaderText = "Тип";
            this.colunm_type.MinimumWidth = 6;
            this.colunm_type.Name = "colunm_type";
            // 
            // column_name
            // 
            this.column_name.HeaderText = "Название";
            this.column_name.MinimumWidth = 6;
            this.column_name.Name = "column_name";
            // 
            // column_price
            // 
            this.column_price.HeaderText = "Цена";
            this.column_price.MinimumWidth = 6;
            this.column_price.Name = "column_price";
            // 
            // column_weight
            // 
            this.column_weight.HeaderText = "Вес(г.)";
            this.column_weight.MinimumWidth = 6;
            this.column_weight.Name = "column_weight";
            // 
            // column_temperature
            // 
            this.column_temperature.HeaderText = "t";
            this.column_temperature.MinimumWidth = 6;
            this.column_temperature.Name = "column_temperature";
            // 
            // column_method
            // 
            this.column_method.HeaderText = "Метод приготовления";
            this.column_method.MinimumWidth = 6;
            this.column_method.Name = "column_method";
            // 
            // column_garnish
            // 
            this.column_garnish.HeaderText = "Наличие гарнира";
            this.column_garnish.MinimumWidth = 6;
            this.column_garnish.Name = "column_garnish";
            // 
            // column_meat
            // 
            this.column_meat.HeaderText = "Мясо";
            this.column_meat.MinimumWidth = 6;
            this.column_meat.Name = "column_meat";
            // 
            // column_salad
            // 
            this.column_salad.HeaderText = "Тип салата";
            this.column_salad.MinimumWidth = 6;
            this.column_salad.Name = "column_salad";
            // 
            // column_soup
            // 
            this.column_soup.HeaderText = "Крем-суп";
            this.column_soup.MinimumWidth = 6;
            this.column_soup.Name = "column_soup";
            // 
            // column_subtitute
            // 
            this.column_subtitute.HeaderText = "Заменитель мяса";
            this.column_subtitute.MinimumWidth = 6;
            this.column_subtitute.Name = "column_subtitute";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(2, 723);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(138, 42);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(181, 723);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(158, 42);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(368, 723);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(165, 42);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSerialize
            // 
            this.btnSerialize.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSerialize.Location = new System.Drawing.Point(720, 723);
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(258, 42);
            this.btnSerialize.TabIndex = 4;
            this.btnSerialize.Text = "Сериализация";
            this.btnSerialize.UseVisualStyleBackColor = true;
            this.btnSerialize.Click += new System.EventHandler(this.btnSerialize_Click);
            // 
            // btnDeserialize
            // 
            this.btnDeserialize.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeserialize.Location = new System.Drawing.Point(1063, 723);
            this.btnDeserialize.Name = "btnDeserialize";
            this.btnDeserialize.Size = new System.Drawing.Size(243, 42);
            this.btnDeserialize.TabIndex = 5;
            this.btnDeserialize.Text = "Десериализация";
            this.btnDeserialize.UseVisualStyleBackColor = true;
            this.btnDeserialize.Click += new System.EventHandler(this.btnDeserialize_Click);
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 844);
            this.Controls.Add(this.btnDeserialize);
            this.Controls.Add(this.btnSerialize);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvDishes);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvDishes;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSerialize;
        private Button btnDeserialize;
        private OpenFileDialog openFD;
        private SaveFileDialog saveFD;
        private DataGridViewTextBoxColumn colunm_type;
        private DataGridViewTextBoxColumn column_name;
        private DataGridViewTextBoxColumn column_price;
        private DataGridViewTextBoxColumn column_weight;
        private DataGridViewTextBoxColumn column_temperature;
        private DataGridViewTextBoxColumn column_method;
        private DataGridViewTextBoxColumn column_garnish;
        private DataGridViewTextBoxColumn column_meat;
        private DataGridViewTextBoxColumn column_salad;
        private DataGridViewTextBoxColumn column_soup;
        private DataGridViewTextBoxColumn column_subtitute;
    }
}