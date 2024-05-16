namespace EDnevnik
{
    partial class Ocena
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
            this.cmb_Godina = new System.Windows.Forms.ComboBox();
            this.cmb_Profesor = new System.Windows.Forms.ComboBox();
            this.cmb_Predmet = new System.Windows.Forms.ComboBox();
            this.cmb_Odeljenje = new System.Windows.Forms.ComboBox();
            this.cmb_Ucenik = new System.Windows.Forms.ComboBox();
            this.cmb_Ocena = new System.Windows.Forms.ComboBox();
            this.Datum = new System.Windows.Forms.DateTimePicker();
            this.Grid_Ocene = new System.Windows.Forms.DataGridView();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Ocene)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Godina
            // 
            this.cmb_Godina.FormattingEnabled = true;
            this.cmb_Godina.Location = new System.Drawing.Point(83, 38);
            this.cmb_Godina.Name = "cmb_Godina";
            this.cmb_Godina.Size = new System.Drawing.Size(139, 24);
            this.cmb_Godina.TabIndex = 0;
            this.cmb_Godina.SelectedValueChanged += new System.EventHandler(this.cmb_Godina_SelectedValueChanged);
            // 
            // cmb_Profesor
            // 
            this.cmb_Profesor.FormattingEnabled = true;
            this.cmb_Profesor.Location = new System.Drawing.Point(275, 38);
            this.cmb_Profesor.Name = "cmb_Profesor";
            this.cmb_Profesor.Size = new System.Drawing.Size(139, 24);
            this.cmb_Profesor.TabIndex = 1;
            this.cmb_Profesor.SelectedValueChanged += new System.EventHandler(this.cmb_Profesor_SelectedValueChanged);
            // 
            // cmb_Predmet
            // 
            this.cmb_Predmet.FormattingEnabled = true;
            this.cmb_Predmet.Location = new System.Drawing.Point(446, 38);
            this.cmb_Predmet.Name = "cmb_Predmet";
            this.cmb_Predmet.Size = new System.Drawing.Size(139, 24);
            this.cmb_Predmet.TabIndex = 2;
            this.cmb_Predmet.SelectedValueChanged += new System.EventHandler(this.cmb_Predmet_SelectedValueChanged);
            // 
            // cmb_Odeljenje
            // 
            this.cmb_Odeljenje.FormattingEnabled = true;
            this.cmb_Odeljenje.Location = new System.Drawing.Point(623, 38);
            this.cmb_Odeljenje.Name = "cmb_Odeljenje";
            this.cmb_Odeljenje.Size = new System.Drawing.Size(139, 24);
            this.cmb_Odeljenje.TabIndex = 3;
            this.cmb_Odeljenje.SelectedValueChanged += new System.EventHandler(this.cmb_Odeljenje_SelectedValueChanged);
            // 
            // cmb_Ucenik
            // 
            this.cmb_Ucenik.FormattingEnabled = true;
            this.cmb_Ucenik.Location = new System.Drawing.Point(83, 109);
            this.cmb_Ucenik.Name = "cmb_Ucenik";
            this.cmb_Ucenik.Size = new System.Drawing.Size(139, 24);
            this.cmb_Ucenik.TabIndex = 4;
            // 
            // cmb_Ocena
            // 
            this.cmb_Ocena.FormattingEnabled = true;
            this.cmb_Ocena.Location = new System.Drawing.Point(275, 109);
            this.cmb_Ocena.Name = "cmb_Ocena";
            this.cmb_Ocena.Size = new System.Drawing.Size(139, 24);
            this.cmb_Ocena.TabIndex = 5;
            // 
            // Datum
            // 
            this.Datum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Datum.Location = new System.Drawing.Point(623, 107);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(139, 22);
            this.Datum.TabIndex = 7;
            // 
            // Grid_Ocene
            // 
            this.Grid_Ocene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Ocene.Location = new System.Drawing.Point(70, 219);
            this.Grid_Ocene.Name = "Grid_Ocene";
            this.Grid_Ocene.RowHeadersWidth = 51;
            this.Grid_Ocene.RowTemplate.Height = 24;
            this.Grid_Ocene.Size = new System.Drawing.Size(754, 219);
            this.Grid_Ocene.TabIndex = 8;
            this.Grid_Ocene.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Ocene_CellClick_1);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(446, 111);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(134, 22);
            this.txt_id.TabIndex = 9;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(835, 38);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 10;
            this.btn_insert.Text = "dodaj";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(835, 77);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "promeni";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(835, 106);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "obrisi";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Godina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Profesor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Predmet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(620, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Odeljenje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ucenik";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ocena";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(443, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(620, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "datum";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 170);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(690, 22);
            this.textBox2.TabIndex = 21;
            // 
            // Ocena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.Grid_Ocene);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.cmb_Ocena);
            this.Controls.Add(this.cmb_Ucenik);
            this.Controls.Add(this.cmb_Odeljenje);
            this.Controls.Add(this.cmb_Predmet);
            this.Controls.Add(this.cmb_Profesor);
            this.Controls.Add(this.cmb_Godina);
            this.Name = "Ocena";
            this.Text = "Ocena";
            this.Load += new System.EventHandler(this.Ocena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Ocene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Godina;
        private System.Windows.Forms.ComboBox cmb_Profesor;
        private System.Windows.Forms.ComboBox cmb_Predmet;
        private System.Windows.Forms.ComboBox cmb_Odeljenje;
        private System.Windows.Forms.ComboBox cmb_Ucenik;
        private System.Windows.Forms.ComboBox cmb_Ocena;
        private System.Windows.Forms.DateTimePicker Datum;
        private System.Windows.Forms.DataGridView Grid_Ocene;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
    }
}