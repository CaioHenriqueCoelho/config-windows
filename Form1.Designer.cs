namespace ConfigWindows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            temaWhite = new RadioButton();
            temaDark = new RadioButton();
            submit = new Button();
            segundoPlano = new CheckBox();
            updateDesempenho = new CheckBox();
            removeXbox = new CheckBox();
            label1 = new Label();
            gamebar = new CheckBox();
            notices = new CheckBox();
            label2 = new Label();
            modeGame = new CheckBox();
            energy = new CheckBox();
            SuspendLayout();
            // 
            // temaWhite
            // 
            temaWhite.AutoSize = true;
            temaWhite.Location = new Point(56, 33);
            temaWhite.Name = "temaWhite";
            temaWhite.Size = new Size(53, 19);
            temaWhite.TabIndex = 0;
            temaWhite.TabStop = true;
            temaWhite.Text = "Claro";
            temaWhite.UseVisualStyleBackColor = true;
            // 
            // temaDark
            // 
            temaDark.AutoSize = true;
            temaDark.Location = new Point(133, 33);
            temaDark.Name = "temaDark";
            temaDark.Size = new Size(60, 19);
            temaDark.TabIndex = 1;
            temaDark.TabStop = true;
            temaDark.Text = "Escuro";
            temaDark.UseVisualStyleBackColor = true;
            // 
            // submit
            // 
            submit.Location = new Point(66, 276);
            submit.Name = "submit";
            submit.Size = new Size(102, 23);
            submit.TabIndex = 2;
            submit.Text = "Iniciar Config";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // segundoPlano
            // 
            segundoPlano.AutoSize = true;
            segundoPlano.Location = new Point(22, 99);
            segundoPlano.Name = "segundoPlano";
            segundoPlano.Size = new Size(187, 19);
            segundoPlano.TabIndex = 3;
            segundoPlano.Text = "Desativar Apps Segundo Plano";
            segundoPlano.UseVisualStyleBackColor = true;
            segundoPlano.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // updateDesempenho
            // 
            updateDesempenho.AutoSize = true;
            updateDesempenho.Location = new Point(22, 124);
            updateDesempenho.Name = "updateDesempenho";
            updateDesempenho.Size = new Size(134, 19);
            updateDesempenho.TabIndex = 4;
            updateDesempenho.Text = "Opção Desempenho";
            updateDesempenho.UseVisualStyleBackColor = true;
            // 
            // removeXbox
            // 
            removeXbox.AutoSize = true;
            removeXbox.Location = new Point(22, 149);
            removeXbox.Name = "removeXbox";
            removeXbox.Size = new Size(125, 19);
            removeXbox.TabIndex = 5;
            removeXbox.Text = "Remover XboxAPP";
            removeXbox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(195, 21);
            label1.TabIndex = 6;
            label1.Text = "Tema dos Apps e Windows";
            // 
            // gamebar
            // 
            gamebar.AutoSize = true;
            gamebar.Location = new Point(22, 174);
            gamebar.Name = "gamebar";
            gamebar.Size = new Size(155, 19);
            gamebar.TabIndex = 7;
            gamebar.Text = "Desativar Xbox GameBar";
            gamebar.UseVisualStyleBackColor = true;
            // 
            // notices
            // 
            notices.AutoSize = true;
            notices.Location = new Point(22, 74);
            notices.Name = "notices";
            notices.Size = new Size(183, 19);
            notices.TabIndex = 8;
            notices.Text = "Desativar Noticias e Interesses";
            notices.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 302);
            label2.Name = "label2";
            label2.Size = new Size(167, 15);
            label2.TabIndex = 9;
            label2.Text = "Desenvolvido por Caio Coelho";
            // 
            // modeGame
            // 
            modeGame.AutoSize = true;
            modeGame.Location = new Point(22, 199);
            modeGame.Name = "modeGame";
            modeGame.Size = new Size(137, 19);
            modeGame.TabIndex = 10;
            modeGame.Text = "Desativar Modo Jogo";
            modeGame.UseVisualStyleBackColor = true;
            // 
            // energy
            // 
            energy.AutoSize = true;
            energy.Location = new Point(22, 224);
            energy.Name = "energy";
            energy.Size = new Size(145, 19);
            energy.TabIndex = 11;
            energy.Text = "Ativar Energia Máxima";
            energy.UseVisualStyleBackColor = true;
            energy.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(245, 326);
            Controls.Add(energy);
            Controls.Add(modeGame);
            Controls.Add(label2);
            Controls.Add(notices);
            Controls.Add(gamebar);
            Controls.Add(label1);
            Controls.Add(removeXbox);
            Controls.Add(updateDesempenho);
            Controls.Add(segundoPlano);
            Controls.Add(submit);
            Controls.Add(temaDark);
            Controls.Add(temaWhite);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Config Rápida";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton temaWhite;
        private RadioButton temaDark;
        private Button submit;
        private CheckBox segundoPlano;
        private CheckBox updateDesempenho;
        private CheckBox removeXbox;
        private Label label1;
        private CheckBox gamebar;
        private CheckBox notices;
        private Label label2;
        private CheckBox modeGame;
        private CheckBox energy;
    }
}
