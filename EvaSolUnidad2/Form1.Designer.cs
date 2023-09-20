namespace EvaSolUnidad2
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
            label1 = new Label();
            label2 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            dataGridView1 = new DataGridView();
            Desde = new DataGridViewTextBoxColumn();
            Hasta = new DataGridViewTextBoxColumn();
            numero_menor = new DataGridViewTextBoxColumn();
            numero_mayor = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            tiempo = new DataGridViewTextBoxColumn();
            Observaciones = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.InactiveBorder;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Size = new Size(277, 32);
            label1.TabIndex = 0;
            label1.Text = "Analisis Numeros Primos";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 80);
            label2.Name = "label2";
            label2.Size = new Size(322, 15);
            label2.TabIndex = 1;
            label2.Text = "Seleccione una opcion del rango para comenzar el proceso:\r\n";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(28, 121);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(56, 19);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "1 a 99";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(28, 171);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(91, 19);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "1000 a 9999";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(28, 146);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(72, 19);
            radioButton3.TabIndex = 4;
            radioButton3.TabStop = true;
            radioButton3.Text = "99 a 999";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(28, 196);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(105, 19);
            radioButton4.TabIndex = 5;
            radioButton4.TabStop = true;
            radioButton4.Text = "10000 a 99999";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(28, 221);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(119, 19);
            radioButton5.TabIndex = 6;
            radioButton5.TabStop = true;
            radioButton5.Text = "100000 a 999999";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(28, 246);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(133, 19);
            radioButton6.TabIndex = 7;
            radioButton6.TabStop = true;
            radioButton6.Text = "1000000 a 9999999";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Desde, Hasta, numero_menor, numero_mayor, cantidad, tiempo, Observaciones });
            dataGridView1.Location = new Point(28, 317);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(743, 80);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Desde
            // 
            Desde.HeaderText = "Desde";
            Desde.Name = "Desde";
            Desde.ReadOnly = true;
            // 
            // Hasta
            // 
            Hasta.HeaderText = "Hasta";
            Hasta.Name = "Hasta";
            Hasta.ReadOnly = true;
            // 
            // numero_menor
            // 
            numero_menor.HeaderText = "< numero";
            numero_menor.Name = "numero_menor";
            numero_menor.ReadOnly = true;
            // 
            // numero_mayor
            // 
            numero_mayor.HeaderText = "< numero";
            numero_mayor.Name = "numero_mayor";
            numero_mayor.ReadOnly = true;
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad";
            cantidad.Name = "cantidad";
            cantidad.ReadOnly = true;
            // 
            // tiempo
            // 
            tiempo.HeaderText = "Tiempo";
            tiempo.Name = "tiempo";
            tiempo.ReadOnly = true;
            // 
            // Observaciones
            // 
            Observaciones.HeaderText = "Observaciones";
            Observaciones.Name = "Observaciones";
            Observaciones.ReadOnly = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.Location = new Point(28, 271);
            button1.Name = "button1";
            button1.Size = new Size(145, 30);
            button1.TabIndex = 9;
            button1.Text = "Iniciar Proceso";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(radioButton6);
            Controls.Add(radioButton5);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "AnalisisPrimos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Desde;
        private DataGridViewTextBoxColumn Hasta;
        private DataGridViewTextBoxColumn numero_menor;
        private DataGridViewTextBoxColumn numero_mayor;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn tiempo;
        private DataGridViewTextBoxColumn Observaciones;
        private Button button1;
    }
}