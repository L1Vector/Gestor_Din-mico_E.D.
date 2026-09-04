namespace GuiaLab1
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
            groupBox1 = new GroupBox();
            txtPrioridad = new TextBox();
            label4 = new Label();
            txtDescripcion = new TextBox();
            txtCodigo = new TextBox();
            label1 = new Label();
            btnRegistrar = new Button();
            lstLista = new ListBox();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            btnVer = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPrioridad);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Location = new Point(12, 113);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(316, 376);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // txtPrioridad
            // 
            txtPrioridad.Location = new Point(124, 35);
            txtPrioridad.Name = "txtPrioridad";
            txtPrioridad.Size = new Size(138, 27);
            txtPrioridad.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 38);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 5;
            label4.Text = "Prioridad:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(6, 104);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.RightToLeft = RightToLeft.No;
            txtDescripcion.ScrollBars = ScrollBars.Vertical;
            txtDescripcion.Size = new Size(304, 208);
            txtDescripcion.TabIndex = 4;
            txtDescripcion.Text = "Descripción";
            txtDescripcion.UseWaitCursor = true;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(124, 67);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(138, 27);
            txtCodigo.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 70);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 3;
            label1.Text = "Código:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(94, 318);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(110, 45);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lstLista
            // 
            lstLista.FormattingEnabled = true;
            lstLista.Location = new Point(356, 145);
            lstLista.Name = "lstLista";
            lstLista.Size = new Size(250, 344);
            lstLista.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(612, 283);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(296, 154);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(112, 51);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(138, 27);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 54);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // button2
            // 
            button2.Location = new Point(112, 99);
            button2.Name = "button2";
            button2.Size = new Size(106, 39);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(356, 80);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(112, 49);
            btnVer.TabIndex = 4;
            btnVer.Text = "Ver Tickets";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 501);
            Controls.Add(btnVer);
            Controls.Add(groupBox2);
            Controls.Add(lstLista);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lstLista;
        private Label label1;
        private Button btnRegistrar;
        private TextBox txtCodigo;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private Label label2;
        private Button button2;
        private TextBox txtPrioridad;
        private Label label4;
        private TextBox txtDescripcion;
        private Button btnVer;
    }
}
