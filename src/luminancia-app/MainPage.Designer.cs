namespace luminancia_app
{
    partial class MainPage
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
            Txt_Altura = new TextBox();
            Txt_Largura = new TextBox();
            Cbx_TipoAmbiente = new ComboBox();
            Lbl_Altura = new Label();
            Lbl_Largura = new Label();
            Lbl_TipoAmbiente = new Label();
            Btn_Calculate = new Button();
            Lbl_LampLed = new Label();
            textBox1 = new TextBox();
            Lbl_LampHalogeneo = new Label();
            textBox2 = new TextBox();
            Lbl_lampClassica = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // Txt_Altura
            // 
            Txt_Altura.Location = new Point(12, 27);
            Txt_Altura.Name = "Txt_Altura";
            Txt_Altura.Size = new Size(286, 23);
            Txt_Altura.TabIndex = 0;
            // 
            // Txt_Largura
            // 
            Txt_Largura.Location = new Point(12, 71);
            Txt_Largura.Name = "Txt_Largura";
            Txt_Largura.Size = new Size(286, 23);
            Txt_Largura.TabIndex = 1;
            // 
            // Cbx_TipoAmbiente
            // 
            Cbx_TipoAmbiente.FormattingEnabled = true;
            Cbx_TipoAmbiente.Location = new Point(12, 115);
            Cbx_TipoAmbiente.Name = "Cbx_TipoAmbiente";
            Cbx_TipoAmbiente.Size = new Size(286, 23);
            Cbx_TipoAmbiente.TabIndex = 2;
            // 
            // Lbl_Altura
            // 
            Lbl_Altura.AutoSize = true;
            Lbl_Altura.Location = new Point(12, 9);
            Lbl_Altura.Name = "Lbl_Altura";
            Lbl_Altura.Size = new Size(58, 15);
            Lbl_Altura.TabIndex = 3;
            Lbl_Altura.Text = "Altura(m)";
            // 
            // Lbl_Largura
            // 
            Lbl_Largura.AutoSize = true;
            Lbl_Largura.Location = new Point(12, 53);
            Lbl_Largura.Name = "Lbl_Largura";
            Lbl_Largura.Size = new Size(66, 15);
            Lbl_Largura.TabIndex = 4;
            Lbl_Largura.Text = "Largura(m)";
            // 
            // Lbl_TipoAmbiente
            // 
            Lbl_TipoAmbiente.AutoSize = true;
            Lbl_TipoAmbiente.Location = new Point(12, 97);
            Lbl_TipoAmbiente.Name = "Lbl_TipoAmbiente";
            Lbl_TipoAmbiente.Size = new Size(102, 15);
            Lbl_TipoAmbiente.TabIndex = 5;
            Lbl_TipoAmbiente.Text = "Tipo do Ambiente";
            // 
            // Btn_Calculate
            // 
            Btn_Calculate.Location = new Point(12, 144);
            Btn_Calculate.Name = "Btn_Calculate";
            Btn_Calculate.Size = new Size(121, 23);
            Btn_Calculate.TabIndex = 6;
            Btn_Calculate.Text = "Calcular";
            Btn_Calculate.UseVisualStyleBackColor = true;
            Btn_Calculate.Click += Btn_Calculate_Click;
            // 
            // Lbl_LampLed
            // 
            Lbl_LampLed.AutoSize = true;
            Lbl_LampLed.Location = new Point(12, 170);
            Lbl_LampLed.Name = "Lbl_LampLed";
            Lbl_LampLed.Size = new Size(115, 15);
            Lbl_LampLed.TabIndex = 8;
            Lbl_LampLed.Text = "Lampada LED (Watt)";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 188);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 23);
            textBox1.TabIndex = 7;
            // 
            // Lbl_LampHalogeneo
            // 
            Lbl_LampHalogeneo.AutoSize = true;
            Lbl_LampHalogeneo.Location = new Point(12, 214);
            Lbl_LampHalogeneo.Name = "Lbl_LampHalogeneo";
            Lbl_LampHalogeneo.Size = new Size(153, 15);
            Lbl_LampHalogeneo.TabIndex = 10;
            Lbl_LampHalogeneo.Text = "Lampada Halogéneo (Watt)";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 232);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(283, 23);
            textBox2.TabIndex = 9;
            // 
            // Lbl_lampClassica
            // 
            Lbl_lampClassica.AutoSize = true;
            Lbl_lampClassica.Location = new Point(12, 258);
            Lbl_lampClassica.Name = "Lbl_lampClassica";
            Lbl_lampClassica.Size = new Size(137, 15);
            Lbl_lampClassica.TabIndex = 12;
            Lbl_lampClassica.Text = "Lampada Clássica (Watt)";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 276);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(283, 23);
            textBox3.TabIndex = 11;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 450);
            Controls.Add(Lbl_lampClassica);
            Controls.Add(textBox3);
            Controls.Add(Lbl_LampHalogeneo);
            Controls.Add(textBox2);
            Controls.Add(Lbl_LampLed);
            Controls.Add(textBox1);
            Controls.Add(Btn_Calculate);
            Controls.Add(Lbl_TipoAmbiente);
            Controls.Add(Lbl_Largura);
            Controls.Add(Lbl_Altura);
            Controls.Add(Cbx_TipoAmbiente);
            Controls.Add(Txt_Largura);
            Controls.Add(Txt_Altura);
            Name = "MainPage";
            Text = "Luminancia App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Txt_Altura;
        private TextBox Txt_Largura;
        private ComboBox Cbx_TipoAmbiente;
        private Label Lbl_Altura;
        private Label Lbl_Largura;
        private Label Lbl_TipoAmbiente;
        private Button Btn_Calculate;
        private Label Lbl_LampLed;
        private TextBox textBox1;
        private Label Lbl_LampHalogeneo;
        private TextBox textBox2;
        private Label Lbl_lampClassica;
        private TextBox textBox3;
    }
}
