namespace TCC_GestaoFinanceira
{
    partial class Form1
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
            this.btnSalvarSalario = new System.Windows.Forms.Button();
            this.lblInsiraSalario = new System.Windows.Forms.Label();
            this.txtInsiraSalarioBruto = new System.Windows.Forms.TextBox();
            this.txtSalarioBruto = new System.Windows.Forms.TextBox();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSaldoGuardado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDespesasMensais = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDeMovimentacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvarSalario
            // 
            this.btnSalvarSalario.Location = new System.Drawing.Point(217, 22);
            this.btnSalvarSalario.Name = "btnSalvarSalario";
            this.btnSalvarSalario.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarSalario.TabIndex = 0;
            this.btnSalvarSalario.Text = "Salvar";
            this.btnSalvarSalario.UseVisualStyleBackColor = true;
            // 
            // lblInsiraSalario
            // 
            this.lblInsiraSalario.AutoSize = true;
            this.lblInsiraSalario.Location = new System.Drawing.Point(12, 9);
            this.lblInsiraSalario.Name = "lblInsiraSalario";
            this.lblInsiraSalario.Size = new System.Drawing.Size(92, 13);
            this.lblInsiraSalario.TabIndex = 1;
            this.lblInsiraSalario.Text = "Insira salario bruto";
            // 
            // txtInsiraSalarioBruto
            // 
            this.txtInsiraSalarioBruto.Location = new System.Drawing.Point(12, 25);
            this.txtInsiraSalarioBruto.Name = "txtInsiraSalarioBruto";
            this.txtInsiraSalarioBruto.Size = new System.Drawing.Size(199, 20);
            this.txtInsiraSalarioBruto.TabIndex = 2;
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Enabled = false;
            this.txtSalarioBruto.Location = new System.Drawing.Point(373, 28);
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(143, 20);
            this.txtSalarioBruto.TabIndex = 4;
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Enabled = false;
            this.txtSalarioLiquido.Location = new System.Drawing.Point(553, 28);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(143, 20);
            this.txtSalarioLiquido.TabIndex = 5;
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Location = new System.Drawing.Point(370, 9);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(66, 13);
            this.lblSalarioBruto.TabIndex = 6;
            this.lblSalarioBruto.Text = "Salario bruto";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(550, 9);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(72, 13);
            this.lblSalarioLiquido.TabIndex = 7;
            this.lblSalarioLiquido.Text = "Salario liquido";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.TipoDeMovimentacao,
            this.Valor,
            this.Descricao});
            this.dataGridView1.Location = new System.Drawing.Point(12, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1467, 814);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblSaldoGuardado
            // 
            this.lblSaldoGuardado.AutoSize = true;
            this.lblSaldoGuardado.Location = new System.Drawing.Point(841, 35);
            this.lblSaldoGuardado.Name = "lblSaldoGuardado";
            this.lblSaldoGuardado.Size = new System.Drawing.Size(48, 13);
            this.lblSaldoGuardado.TabIndex = 10;
            this.lblSaldoGuardado.Text = "R$ 2300";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(737, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Saldo guardado";
            // 
            // lblDespesasMensais
            // 
            this.lblDespesasMensais.AutoSize = true;
            this.lblDespesasMensais.Location = new System.Drawing.Point(841, 9);
            this.lblDespesasMensais.Name = "lblDespesasMensais";
            this.lblDespesasMensais.Size = new System.Drawing.Size(48, 13);
            this.lblDespesasMensais.TabIndex = 12;
            this.lblDespesasMensais.Text = "R$ 1700";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(737, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Despesas mensais:";
            // 
            // Data
            // 
            this.Data.DividerWidth = 2;
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // TipoDeMovimentacao
            // 
            this.TipoDeMovimentacao.HeaderText = "Tipo De Movimentação";
            this.TipoDeMovimentacao.Name = "TipoDeMovimentacao";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 300;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 963);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDespesasMensais);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSaldoGuardado);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.txtSalarioBruto);
            this.Controls.Add(this.lblInsiraSalario);
            this.Controls.Add(this.txtInsiraSalarioBruto);
            this.Controls.Add(this.btnSalvarSalario);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblInsiraSalario;
        private System.Windows.Forms.TextBox txtInsiraSalarioBruto;
        private System.Windows.Forms.TextBox txtSalarioBruto;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSaldoGuardado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDespesasMensais;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button btnSalvarSalario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDeMovimentacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
    }
}

