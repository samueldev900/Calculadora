namespace Calculadora
{
    partial class calculadora
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
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            buttonMais = new Button();
            buttonIgual = new Button();
            buttonDivisao = new Button();
            buttonMenos = new Button();
            buttonMulti = new Button();
            button3 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button0 = new Button();
            buttonClear = new Button();
            btnVirgula = new Button();
            btnApagar = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(69, 119);
            button2.Name = "button2";
            button2.Size = new Size(56, 55);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(7, 119);
            button1.Name = "button1";
            button1.Size = new Size(56, 55);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(7, 27);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(242, 23);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // buttonMais
            // 
            buttonMais.Location = new Point(193, 119);
            buttonMais.Name = "buttonMais";
            buttonMais.Size = new Size(56, 55);
            buttonMais.TabIndex = 11;
            buttonMais.Text = "+";
            buttonMais.UseVisualStyleBackColor = true;
            buttonMais.Click += buttonMais_Click;
            // 
            // buttonIgual
            // 
            buttonIgual.Location = new Point(193, 363);
            buttonIgual.Name = "buttonIgual";
            buttonIgual.Size = new Size(56, 89);
            buttonIgual.TabIndex = 15;
            buttonIgual.Text = "=";
            buttonIgual.UseVisualStyleBackColor = true;
            buttonIgual.Click += buttonIgual_Click;
            // 
            // buttonDivisao
            // 
            buttonDivisao.Location = new Point(193, 241);
            buttonDivisao.Name = "buttonDivisao";
            buttonDivisao.Size = new Size(56, 55);
            buttonDivisao.TabIndex = 16;
            buttonDivisao.Text = "/";
            buttonDivisao.UseVisualStyleBackColor = true;
            buttonDivisao.Click += buttonDivisao_Click;
            // 
            // buttonMenos
            // 
            buttonMenos.Location = new Point(193, 180);
            buttonMenos.Name = "buttonMenos";
            buttonMenos.Size = new Size(56, 55);
            buttonMenos.TabIndex = 17;
            buttonMenos.Text = "-";
            buttonMenos.UseVisualStyleBackColor = true;
            buttonMenos.Click += buttonMenos_Click;
            // 
            // buttonMulti
            // 
            buttonMulti.Location = new Point(193, 302);
            buttonMulti.Name = "buttonMulti";
            buttonMulti.Size = new Size(56, 55);
            buttonMulti.TabIndex = 18;
            buttonMulti.Text = "x";
            buttonMulti.UseVisualStyleBackColor = true;
            buttonMulti.Click += buttonMulti_Click;
            // 
            // button3
            // 
            button3.Location = new Point(131, 119);
            button3.Name = "button3";
            button3.Size = new Size(56, 55);
            button3.TabIndex = 19;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button6
            // 
            button6.Location = new Point(131, 180);
            button6.Name = "button6";
            button6.Size = new Size(56, 55);
            button6.TabIndex = 22;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(69, 180);
            button5.Name = "button5";
            button5.Size = new Size(56, 55);
            button5.TabIndex = 21;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 180);
            button4.Name = "button4";
            button4.Size = new Size(56, 55);
            button4.TabIndex = 20;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button9
            // 
            button9.Location = new Point(131, 241);
            button9.Name = "button9";
            button9.Size = new Size(56, 55);
            button9.TabIndex = 25;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Location = new Point(69, 241);
            button8.Name = "button8";
            button8.Size = new Size(56, 55);
            button8.TabIndex = 24;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(7, 241);
            button7.Name = "button7";
            button7.Size = new Size(56, 55);
            button7.TabIndex = 23;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button0
            // 
            button0.Location = new Point(12, 302);
            button0.Name = "button0";
            button0.Size = new Size(56, 55);
            button0.TabIndex = 26;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(193, 56);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(56, 55);
            buttonClear.TabIndex = 27;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.Location = new Point(131, 302);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(56, 55);
            btnVirgula.TabIndex = 28;
            btnVirgula.Text = ".";
            btnVirgula.UseVisualStyleBackColor = true;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btnApagar
            // 
            btnApagar.Location = new Point(131, 56);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(56, 55);
            btnApagar.TabIndex = 29;
            btnApagar.Text = "<=";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 463);
            Controls.Add(btnApagar);
            Controls.Add(btnVirgula);
            Controls.Add(buttonClear);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(buttonMulti);
            Controls.Add(buttonMenos);
            Controls.Add(buttonDivisao);
            Controls.Add(buttonIgual);
            Controls.Add(buttonMais);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "calculadora";
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button1;
        public TextBox textBox1;
        private Button buttonMais;
        private Button buttonIgual;
        private Button buttonDivisao;
        private Button buttonMenos;
        private Button buttonMulti;
        private Button button3;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button0;
        private Button buttonClear;
        private Button btnVirgula;
        private Button btnApagar;
    }
}