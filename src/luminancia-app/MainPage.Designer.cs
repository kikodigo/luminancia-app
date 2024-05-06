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
            Lbl_LampHalogeneo = new Label();
            Lbl_lampClassica = new Label();
            Txt_MinClass = new TextBox();
            Txt_MaxClass = new TextBox();
            Txt_MaxHalo = new TextBox();
            Txt_MinHalo = new TextBox();
            Txt_MaxLed = new TextBox();
            Txt_MinLed = new TextBox();
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
            Lbl_LampLed.Size = new Size(227, 15);
            Lbl_LampLed.TabIndex = 8;
            Lbl_LampLed.Text = "Lampada LED (Min / Max Watts Indicado)";
            // 
            // Lbl_LampHalogeneo
            // 
            Lbl_LampHalogeneo.AutoSize = true;
            Lbl_LampHalogeneo.Location = new Point(12, 214);
            Lbl_LampHalogeneo.Name = "Lbl_LampHalogeneo";
            Lbl_LampHalogeneo.Size = new Size(265, 15);
            Lbl_LampHalogeneo.TabIndex = 10;
            Lbl_LampHalogeneo.Text = "Lampada Halogéneo (Min / Max Watts Indicado)";
            // 
            // Lbl_lampClassica
            // 
            Lbl_lampClassica.AutoSize = true;
            Lbl_lampClassica.Location = new Point(12, 258);
            Lbl_lampClassica.Name = "Lbl_lampClassica";
            Lbl_lampClassica.Size = new Size(249, 15);
            Lbl_lampClassica.TabIndex = 12;
            Lbl_lampClassica.Text = "Lampada Clássica (Min / Max Watts Indicado)";
            // 
            // Txt_MinClass
            // 
            Txt_MinClass.Enabled = false;
            Txt_MinClass.Location = new Point(12, 276);
            Txt_MinClass.Name = "Txt_MinClass";
            Txt_MinClass.Size = new Size(141, 23);
            Txt_MinClass.TabIndex = 11;
            // 
            // Txt_MaxClass
            // 
            Txt_MaxClass.Enabled = false;
            Txt_MaxClass.Location = new Point(157, 276);
            Txt_MaxClass.Name = "Txt_MaxClass";
            Txt_MaxClass.Size = new Size(141, 23);
            Txt_MaxClass.TabIndex = 13;
            // 
            // Txt_MaxHalo
            // 
            Txt_MaxHalo.Enabled = false;
            Txt_MaxHalo.Location = new Point(157, 232);
            Txt_MaxHalo.Name = "Txt_MaxHalo";
            Txt_MaxHalo.Size = new Size(141, 23);
            Txt_MaxHalo.TabIndex = 15;
            // 
            // Txt_MinHalo
            // 
            Txt_MinHalo.Enabled = false;
            Txt_MinHalo.Location = new Point(12, 232);
            Txt_MinHalo.Name = "Txt_MinHalo";
            Txt_MinHalo.Size = new Size(141, 23);
            Txt_MinHalo.TabIndex = 14;
            // 
            // Txt_MaxLed
            // 
            Txt_MaxLed.Enabled = false;
            Txt_MaxLed.Location = new Point(157, 188);
            Txt_MaxLed.Name = "Txt_MaxLed";
            Txt_MaxLed.Size = new Size(141, 23);
            Txt_MaxLed.TabIndex = 17;
            // 
            // Txt_MinLed
            // 
            Txt_MinLed.Enabled = false;
            Txt_MinLed.Location = new Point(12, 188);
            Txt_MinLed.Name = "Txt_MinLed";
            Txt_MinLed.Size = new Size(141, 23);
            Txt_MinLed.TabIndex = 16;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 315);
            Controls.Add(Txt_MaxLed);
            Controls.Add(Txt_MinLed);
            Controls.Add(Txt_MaxHalo);
            Controls.Add(Txt_MinHalo);
            Controls.Add(Txt_MaxClass);
            Controls.Add(Lbl_lampClassica);
            Controls.Add(Txt_MinClass);
            Controls.Add(Lbl_LampHalogeneo);
            Controls.Add(Lbl_LampLed);
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
        private Label Lbl_LampHalogeneo;
        private Label Lbl_lampClassica;
        private TextBox Txt_MinClass;
        private TextBox Txt_MaxClass;
        private TextBox Txt_MaxHalo;
        private TextBox Txt_MinHalo;
        private TextBox Txt_MaxLed;
        private TextBox Txt_MinLed;
    }
}
