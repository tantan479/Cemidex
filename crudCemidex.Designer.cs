namespace Cemidex
{
    partial class crudCemidex
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crudCemidex));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbRequerente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btReqAdd = new System.Windows.Forms.Button();
            this.btReqEd = new System.Windows.Forms.Button();
            this.btReqRem = new System.Windows.Forms.Button();
            this.versao1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btFalAdd = new System.Windows.Forms.Button();
            this.btFalEd = new System.Windows.Forms.Button();
            this.btFalRem = new System.Windows.Forms.Button();
            this.dgvFalecidos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fal_idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fal_cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fal_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fal_mae = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fal_pai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fal_sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.versao1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFalecidos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Teal;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1143, 101);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Teal;
            this.pictureBox2.Location = new System.Drawing.Point(0, 702);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1143, 48);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Garamond", 16.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(406, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Requerente/Falecido";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Teal;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(2, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(122, 81);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Teal;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(1052, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(91, 91);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Teal;
            this.label10.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(968, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 22);
            this.label10.TabIndex = 22;
            this.label10.Text = "Encerrar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Teal;
            this.label9.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(906, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 22);
            this.label9.TabIndex = 21;
            this.label9.Text = "nome do usuário";
            // 
            // cbRequerente
            // 
            this.cbRequerente.Location = new System.Drawing.Point(30, 159);
            this.cbRequerente.Name = "cbRequerente";
            this.cbRequerente.Size = new System.Drawing.Size(182, 33);
            this.cbRequerente.TabIndex = 23;
            this.cbRequerente.SelectedIndexChanged += new System.EventHandler(this.cbRequerente_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 27);
            this.label2.TabIndex = 24;
            this.label2.Text = "Requerente:";
            // 
            // btReqAdd
            // 
            this.btReqAdd.Image = ((System.Drawing.Image)(resources.GetObject("btReqAdd.Image")));
            this.btReqAdd.Location = new System.Drawing.Point(218, 160);
            this.btReqAdd.Name = "btReqAdd";
            this.btReqAdd.Size = new System.Drawing.Size(32, 32);
            this.btReqAdd.TabIndex = 25;
            this.btReqAdd.UseVisualStyleBackColor = true;
            this.btReqAdd.Click += new System.EventHandler(this.btReqAdd_Click);
            // 
            // btReqEd
            // 
            this.btReqEd.Image = ((System.Drawing.Image)(resources.GetObject("btReqEd.Image")));
            this.btReqEd.Location = new System.Drawing.Point(256, 160);
            this.btReqEd.Name = "btReqEd";
            this.btReqEd.Size = new System.Drawing.Size(32, 32);
            this.btReqEd.TabIndex = 26;
            this.btReqEd.UseVisualStyleBackColor = true;
            this.btReqEd.Click += new System.EventHandler(this.btReqEd_Click);
            // 
            // btReqRem
            // 
            this.btReqRem.Image = ((System.Drawing.Image)(resources.GetObject("btReqRem.Image")));
            this.btReqRem.Location = new System.Drawing.Point(294, 160);
            this.btReqRem.Name = "btReqRem";
            this.btReqRem.Size = new System.Drawing.Size(32, 32);
            this.btReqRem.TabIndex = 27;
            this.btReqRem.UseVisualStyleBackColor = true;
            this.btReqRem.Click += new System.EventHandler(this.btReqRem_Click);
            // 
            // versao1BindingSource
            // 
            this.versao1BindingSource.DataSource = typeof(Cemidex.Migrations.Versao1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 27);
            this.label3.TabIndex = 29;
            this.label3.Text = "Falecidos do Requerente:";
            // 
            // btFalAdd
            // 
            this.btFalAdd.Image = ((System.Drawing.Image)(resources.GetObject("btFalAdd.Image")));
            this.btFalAdd.Location = new System.Drawing.Point(294, 259);
            this.btFalAdd.Name = "btFalAdd";
            this.btFalAdd.Size = new System.Drawing.Size(32, 32);
            this.btFalAdd.TabIndex = 30;
            this.btFalAdd.UseVisualStyleBackColor = true;
            this.btFalAdd.Click += new System.EventHandler(this.btFalAdd_Click);
            // 
            // btFalEd
            // 
            this.btFalEd.Image = ((System.Drawing.Image)(resources.GetObject("btFalEd.Image")));
            this.btFalEd.Location = new System.Drawing.Point(332, 259);
            this.btFalEd.Name = "btFalEd";
            this.btFalEd.Size = new System.Drawing.Size(32, 32);
            this.btFalEd.TabIndex = 31;
            this.btFalEd.UseVisualStyleBackColor = true;
            this.btFalEd.Click += new System.EventHandler(this.btFalEd_Click);
            // 
            // btFalRem
            // 
            this.btFalRem.Image = ((System.Drawing.Image)(resources.GetObject("btFalRem.Image")));
            this.btFalRem.Location = new System.Drawing.Point(370, 259);
            this.btFalRem.Name = "btFalRem";
            this.btFalRem.Size = new System.Drawing.Size(32, 32);
            this.btFalRem.TabIndex = 32;
            this.btFalRem.UseVisualStyleBackColor = true;
            this.btFalRem.Click += new System.EventHandler(this.btFalRem_Click);
            // 
            // dgvFalecidos
            // 
            this.dgvFalecidos.AllowUserToAddRows = false;
            this.dgvFalecidos.AllowUserToDeleteRows = false;
            this.dgvFalecidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFalecidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Nome,
            this.fal_idade,
            this.fal_cpf,
            this.fal_data,
            this.EstadoCivil,
            this.fal_mae,
            this.fal_pai,
            this.fal_sexo});
            this.dgvFalecidos.Location = new System.Drawing.Point(30, 315);
            this.dgvFalecidos.Name = "dgvFalecidos";
            this.dgvFalecidos.ReadOnly = true;
            this.dgvFalecidos.RowHeadersWidth = 62;
            this.dgvFalecidos.RowTemplate.Height = 33;
            this.dgvFalecidos.Size = new System.Drawing.Size(1092, 358);
            this.dgvFalecidos.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdFalecido";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 8;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 150;
            // 
            // fal_idade
            // 
            this.fal_idade.DataPropertyName = "Idade";
            this.fal_idade.HeaderText = "Idade";
            this.fal_idade.MinimumWidth = 8;
            this.fal_idade.Name = "fal_idade";
            this.fal_idade.ReadOnly = true;
            this.fal_idade.Width = 150;
            // 
            // fal_cpf
            // 
            this.fal_cpf.DataPropertyName = "Cpf";
            this.fal_cpf.HeaderText = "CPF";
            this.fal_cpf.MinimumWidth = 8;
            this.fal_cpf.Name = "fal_cpf";
            this.fal_cpf.ReadOnly = true;
            this.fal_cpf.Width = 150;
            // 
            // fal_data
            // 
            this.fal_data.DataPropertyName = "DataObito";
            this.fal_data.HeaderText = "Data de Óbito";
            this.fal_data.MinimumWidth = 8;
            this.fal_data.Name = "fal_data";
            this.fal_data.ReadOnly = true;
            this.fal_data.Width = 150;
            // 
            // EstadoCivil
            // 
            this.EstadoCivil.DataPropertyName = "EstadoCivil";
            this.EstadoCivil.HeaderText = "Estado Civil";
            this.EstadoCivil.MinimumWidth = 8;
            this.EstadoCivil.Name = "EstadoCivil";
            this.EstadoCivil.ReadOnly = true;
            this.EstadoCivil.Width = 150;
            // 
            // fal_mae
            // 
            this.fal_mae.DataPropertyName = "NomeMae";
            this.fal_mae.HeaderText = "Mãe";
            this.fal_mae.MinimumWidth = 8;
            this.fal_mae.Name = "fal_mae";
            this.fal_mae.ReadOnly = true;
            this.fal_mae.Width = 150;
            // 
            // fal_pai
            // 
            this.fal_pai.DataPropertyName = "NomePai";
            this.fal_pai.HeaderText = "Pai";
            this.fal_pai.MinimumWidth = 8;
            this.fal_pai.Name = "fal_pai";
            this.fal_pai.ReadOnly = true;
            this.fal_pai.Width = 150;
            // 
            // fal_sexo
            // 
            this.fal_sexo.DataPropertyName = "Sexo";
            this.fal_sexo.HeaderText = "Sexo";
            this.fal_sexo.MinimumWidth = 8;
            this.fal_sexo.Name = "fal_sexo";
            this.fal_sexo.ReadOnly = true;
            this.fal_sexo.Width = 150;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1090, 710);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 34;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // crudCemidex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvFalecidos);
            this.Controls.Add(this.btFalRem);
            this.Controls.Add(this.btFalEd);
            this.Controls.Add(this.btFalAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btReqRem);
            this.Controls.Add(this.btReqEd);
            this.Controls.Add(this.btReqAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbRequerente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "crudCemidex";
            this.Text = "crudCemidex";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.versao1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFalecidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label10;
        private Label label9;
        private ComboBox cbRequerente;
        private Label label2;
        private Button btReqAdd;
        private Button btReqEd;
        private Button btReqRem;
        private BindingSource versao1BindingSource;
        private Label label3;
        private Button btFalAdd;
        private Button btFalEd;
        private Button btFalRem;
        private DataGridView dgvFalecidos;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn fal_idade;
        private DataGridViewTextBoxColumn fal_cpf;
        private DataGridViewTextBoxColumn fal_data;
        private DataGridViewTextBoxColumn EstadoCivil;
        private DataGridViewTextBoxColumn fal_mae;
        private DataGridViewTextBoxColumn fal_pai;
        private DataGridViewTextBoxColumn fal_sexo;
        private Button btnClose;
    }
}