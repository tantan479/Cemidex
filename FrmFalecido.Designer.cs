namespace Cemidex
{
    partial class FrmFalecido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFalecido));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.numericCova = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textCpf = new System.Windows.Forms.TextBox();
            this.fdhdhdgjhfg = new System.Windows.Forms.Label();
            this.txtMae = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericIdade = new System.Windows.Forms.NumericUpDown();
            this.cbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateObito = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.numericRequerente = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericCova)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIdade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRequerente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 44);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(180, 31);
            this.txtNome.TabIndex = 1;
            // 
            // numericCova
            // 
            this.numericCova.Location = new System.Drawing.Point(12, 118);
            this.numericCova.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericCova.Name = "numericCova";
            this.numericCova.Size = new System.Drawing.Size(180, 31);
            this.numericCova.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cova:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Requerente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(257, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "CPF:";
            // 
            // textCpf
            // 
            this.textCpf.Location = new System.Drawing.Point(257, 44);
            this.textCpf.MaxLength = 11;
            this.textCpf.MinimumSize = new System.Drawing.Size(11, 0);
            this.textCpf.Name = "textCpf";
            this.textCpf.Size = new System.Drawing.Size(223, 31);
            this.textCpf.TabIndex = 7;
            // 
            // fdhdhdgjhfg
            // 
            this.fdhdhdgjhfg.AutoSize = true;
            this.fdhdhdgjhfg.BackColor = System.Drawing.Color.Transparent;
            this.fdhdhdgjhfg.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fdhdhdgjhfg.Location = new System.Drawing.Point(257, 93);
            this.fdhdhdgjhfg.Name = "fdhdhdgjhfg";
            this.fdhdhdgjhfg.Size = new System.Drawing.Size(135, 22);
            this.fdhdhdgjhfg.TabIndex = 8;
            this.fdhdhdgjhfg.Text = "Nome da Mãe:";
            // 
            // txtMae
            // 
            this.txtMae.Location = new System.Drawing.Point(257, 118);
            this.txtMae.MaxLength = 100;
            this.txtMae.MinimumSize = new System.Drawing.Size(11, 0);
            this.txtMae.Name = "txtMae";
            this.txtMae.Size = new System.Drawing.Size(223, 31);
            this.txtMae.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(257, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nome do Pai:";
            // 
            // txtPai
            // 
            this.txtPai.Location = new System.Drawing.Point(257, 196);
            this.txtPai.MaxLength = 100;
            this.txtPai.MinimumSize = new System.Drawing.Size(11, 0);
            this.txtPai.Name = "txtPai";
            this.txtPai.Size = new System.Drawing.Size(223, 31);
            this.txtPai.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Idade:";
            // 
            // numericIdade
            // 
            this.numericIdade.Location = new System.Drawing.Point(12, 273);
            this.numericIdade.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericIdade.Name = "numericIdade";
            this.numericIdade.Size = new System.Drawing.Size(180, 31);
            this.numericIdade.TabIndex = 13;
            // 
            // cbEstadoCivil
            // 
            this.cbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoCivil.FormattingEnabled = true;
            this.cbEstadoCivil.Items.AddRange(new object[] {
            "Solteiro",
            "Casado",
            "Víuvo",
            "Divorciado"});
            this.cbEstadoCivil.Location = new System.Drawing.Point(255, 273);
            this.cbEstadoCivil.MaxLength = 1;
            this.cbEstadoCivil.Name = "cbEstadoCivil";
            this.cbEstadoCivil.Size = new System.Drawing.Size(225, 33);
            this.cbEstadoCivil.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Sexo:";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(255, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "Estado Civil";
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbSexo.Location = new System.Drawing.Point(12, 364);
            this.cbSexo.MaxLength = 1;
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(182, 33);
            this.cbSexo.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(255, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 22);
            this.label10.TabIndex = 19;
            this.label10.Text = "Data de Óbito:";
            // 
            // dateObito
            // 
            this.dateObito.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateObito.Location = new System.Drawing.Point(257, 362);
            this.dateObito.Name = "dateObito";
            this.dateObito.Size = new System.Drawing.Size(223, 31);
            this.dateObito.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(38, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 21;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Location = new System.Drawing.Point(315, 425);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(112, 34);
            this.btnSalvar.TabIndex = 22;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // numericRequerente
            // 
            this.numericRequerente.Enabled = false;
            this.numericRequerente.Location = new System.Drawing.Point(12, 196);
            this.numericRequerente.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericRequerente.Name = "numericRequerente";
            this.numericRequerente.ReadOnly = true;
            this.numericRequerente.Size = new System.Drawing.Size(180, 31);
            this.numericRequerente.TabIndex = 5;
            // 
            // FrmFalecido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(508, 480);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateObito);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbEstadoCivil);
            this.Controls.Add(this.numericIdade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMae);
            this.Controls.Add(this.fdhdhdgjhfg);
            this.Controls.Add(this.textCpf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericRequerente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericCova);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFalecido";
            this.Text = "FrmFalecido";
            ((System.ComponentModel.ISupportInitialize)(this.numericCova)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIdade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRequerente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label fdhdhdgjhfg;
        private Label label5;
        private Label label6;
        private Label label7;
        public TextBox txtNome;
        public NumericUpDown numericCova;
        public TextBox textCpf;
        public TextBox txtMae;
        public TextBox txtPai;
        public NumericUpDown numericIdade;
        public ComboBox cbEstadoCivil;
        private Label label8;
        public ComboBox cbSexo;
        private Label label10;
        public DateTimePicker dateObito;
        private Button button1;
        private Button btnSalvar;
        public NumericUpDown numericRequerente;
    }
}