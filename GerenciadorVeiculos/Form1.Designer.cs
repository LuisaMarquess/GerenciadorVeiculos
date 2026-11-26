namespace GerenciadorVeiculos
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtModelo = new TextBox();
            txtDiaria = new TextBox();
            txtEspecifico = new TextBox();
            cmbTipo = new ComboBox();
            lblModelo = new Label();
            lblDiaria = new Label();
            lblEspecifico = new Label();
            lblTipo = new Label();
            btnLimpar = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnAtualizar = new Button();
            btnExcluir = new Button();
            dgvVeiculos = new DataGridView();
            lblTitulo = new Label();
            lblLista = new Label();

            ((System.ComponentModel.ISupportInitialize)dgvVeiculos).BeginInit();
            SuspendLayout();

            // lblTitulo
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(35, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(230, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gerenciador de Veículos";

            // lblModelo
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(40, 78);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(48, 15);
            lblModelo.TabIndex = 1;
            lblModelo.Text = "Modelo:";

            // txtModelo
            txtModelo.Location = new Point(145, 74);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(220, 23);
            txtModelo.TabIndex = 2;

            // lblDiaria
            lblDiaria.AutoSize = true;
            lblDiaria.Location = new Point(40, 118);
            lblDiaria.Name = "lblDiaria";
            lblDiaria.Size = new Size(91, 15);
            lblDiaria.TabIndex = 3;
            lblDiaria.Text = "Valor da diária:";

            // txtDiaria
            txtDiaria.Location = new Point(145, 114);
            txtDiaria.Name = "txtDiaria";
            txtDiaria.Size = new Size(220, 23);
            txtDiaria.TabIndex = 4;

            // lblEspecifico
            lblEspecifico.AutoSize = true;
            lblEspecifico.Location = new Point(40, 158);
            lblEspecifico.Name = "lblEspecifico";
            lblEspecifico.Size = new Size(43, 15);
            lblEspecifico.TabIndex = 5;
            lblEspecifico.Text = "Portas:";

            // txtEspecifico
            txtEspecifico.Location = new Point(145, 154);
            txtEspecifico.Name = "txtEspecifico";
            txtEspecifico.Size = new Size(220, 23);
            txtDiaria.TabIndex = 6;

            // lblTipo
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(40, 198);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(34, 15);
            lblTipo.TabIndex = 7;
            lblTipo.Text = "Tipo:";

            // cmbTipo
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Carro", "Moto" });
            cmbTipo.Location = new Point(145, 194);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(220, 23);
            cmbTipo.TabIndex = 8;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;

            // btnLimpar
            btnLimpar.Location = new Point(40, 238);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(105, 35);
            btnLimpar.TabIndex = 9;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;

            // btnSalvar
            btnSalvar.Location = new Point(155, 238);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(105, 35);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Cadastrar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;

            // btnEditar
            btnEditar.Location = new Point(270, 238);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(105, 35);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;

            // btnAtualizar
            btnAtualizar.Location = new Point(385, 238);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(105, 35);
            btnAtualizar.TabIndex = 12;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;

            // btnExcluir
            btnExcluir.Location = new Point(500, 238);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(105, 35);
            btnExcluir.TabIndex = 13;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;

            // lblLista
            lblLista.AutoSize = true;
            lblLista.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblLista.Location = new Point(40, 295);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(137, 20);
            lblLista.TabIndex = 14;
            lblLista.Text = "Veículos cadastrados";

            // dgvVeiculos
            dgvVeiculos.AllowUserToAddRows = false;
            dgvVeiculos.AllowUserToDeleteRows = false;
            dgvVeiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVeiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVeiculos.Location = new Point(40, 325);
            dgvVeiculos.MultiSelect = false;
            dgvVeiculos.Name = "dgvVeiculos";
            dgvVeiculos.ReadOnly = true;
            dgvVeiculos.RowHeadersWidth = 51;
            dgvVeiculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVeiculos.Size = new Size(850, 290);
            dgvVeiculos.TabIndex = 15;
            dgvVeiculos.CellClick += dgvVeiculos_CellClick;

            // Form1
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 650);

            Controls.Add(dgvVeiculos);
            Controls.Add(lblLista);
            Controls.Add(btnExcluir);
            Controls.Add(btnAtualizar);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(btnLimpar);
            Controls.Add(cmbTipo);
            Controls.Add(lblTipo);
            Controls.Add(txtEspecifico);
            Controls.Add(lblEspecifico);
            Controls.Add(txtDiaria);
            Controls.Add(lblDiaria);
            Controls.Add(txtModelo);
            Controls.Add(lblModelo);
            Controls.Add(lblTitulo);

            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciador de Veículos";

            ((System.ComponentModel.ISupportInitialize)dgvVeiculos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtModelo;
        private TextBox txtDiaria;
        private TextBox txtEspecifico;
        private ComboBox cmbTipo;
        private Label lblModelo;
        private Label lblDiaria;
        private Label lblEspecifico;
        private Label lblTipo;
        private Button btnLimpar;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnAtualizar;
        private Button btnExcluir;
        private DataGridView dgvVeiculos;
        private Label lblTitulo;
        private Label lblLista;
    }
}