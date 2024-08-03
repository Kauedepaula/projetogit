namespace Projeto_Git
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
            txValor2 = new TextBox();
            lblValor1 = new Label();
            txValor1 = new TextBox();
            lblValor2 = new Label();
            lblTotal = new Label();
            lblResultado = new Label();
            btnsoma = new Button();
            btnmultiplica = new Button();
            btnsubtrai = new Button();
            SuspendLayout();
            // 
            // txValor2
            // 
            txValor2.Location = new Point(104, 78);
            txValor2.Name = "txValor2";
            txValor2.Size = new Size(100, 23);
            txValor2.TabIndex = 0;
            // 
            // lblValor1
            // 
            lblValor1.AutoSize = true;
            lblValor1.Location = new Point(12, 24);
            lblValor1.Name = "lblValor1";
            lblValor1.Size = new Size(39, 15);
            lblValor1.TabIndex = 1;
            lblValor1.Text = "Valor1";
            // 
            // txValor1
            // 
            txValor1.Location = new Point(104, 21);
            txValor1.Name = "txValor1";
            txValor1.Size = new Size(100, 23);
            txValor1.TabIndex = 2;
            // 
            // lblValor2
            // 
            lblValor2.AutoSize = true;
            lblValor2.Location = new Point(12, 81);
            lblValor2.Name = "lblValor2";
            lblValor2.Size = new Size(39, 15);
            lblValor2.TabIndex = 3;
            lblValor2.Text = "Valor2";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(12, 123);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(32, 15);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total";
            lblTotal.Click += label3_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(104, 123);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(16, 15);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "...";
            // 
            // btnsoma
            // 
            btnsoma.Location = new Point(12, 161);
            btnsoma.Name = "btnsoma";
            btnsoma.Size = new Size(75, 23);
            btnsoma.TabIndex = 6;
            btnsoma.Text = "Soma";
            btnsoma.UseVisualStyleBackColor = true;
            btnsoma.Click += btnsoma_Click;
            // 
            // btnmultiplica
            // 
            btnmultiplica.Location = new Point(123, 161);
            btnmultiplica.Name = "btnmultiplica";
            btnmultiplica.Size = new Size(92, 23);
            btnmultiplica.TabIndex = 7;
            btnmultiplica.Text = "Multiplica";
            btnmultiplica.UseVisualStyleBackColor = true;
            btnmultiplica.Click += btnmultiplica_Click;
            // 
            // btnsubtrai
            // 
            btnsubtrai.Location = new Point(243, 161);
            btnsubtrai.Name = "btnsubtrai";
            btnsubtrai.Size = new Size(92, 23);
            btnsubtrai.TabIndex = 8;
            btnsubtrai.Text = "Subtrai";
            btnsubtrai.UseVisualStyleBackColor = true;
            btnsubtrai.Click += btnsubtrai_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnsubtrai);
            Controls.Add(btnmultiplica);
            Controls.Add(btnsoma);
            Controls.Add(lblResultado);
            Controls.Add(lblTotal);
            Controls.Add(lblValor2);
            Controls.Add(txValor1);
            Controls.Add(lblValor1);
            Controls.Add(txValor2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txValor2;
        private Label lblValor1;
        private TextBox txValor1;
        private Label lblValor2;
        private Label lblTotal;
        private Label lblResultado;
        private Button btnsoma;
        private Button btnmultiplica;
        private Button btnsubtrai;
    }
}
