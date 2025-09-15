namespace _34.Bases_de_dados
{
    partial class Agenda
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lbResultado = new System.Windows.Forms.Label();
            dgvLista = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lbNome = new System.Windows.Forms.Label();
            lbEmail = new System.Windows.Forms.Label();
            txbNome = new System.Windows.Forms.TextBox();
            txbEmail = new System.Windows.Forms.TextBox();
            btnConectar = new System.Windows.Forms.Button();
            btnInserir = new System.Windows.Forms.Button();
            btnProcurar = new System.Windows.Forms.Button();
            btnExcluir = new System.Windows.Forms.Button();
            btnEditar = new System.Windows.Forms.Button();
            btnCriarTabelas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            SuspendLayout();
            // 
            // lbResultado
            // 
            lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lbResultado.Location = new System.Drawing.Point(14, 10);
            lbResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new System.Drawing.Size(248, 73);
            lbResultado.TabIndex = 0;
            lbResultado.Text = "Resultado";
            // 
            // dgvLista
            // 
            dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, nome, email });
            dgvLista.Location = new System.Drawing.Point(270, 10);
            dgvLista.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvLista.Name = "dgvLista";
            dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvLista.Size = new System.Drawing.Size(386, 355);
            dgvLista.TabIndex = 1;
            // 
            // Id
            // 
            Id.FillWeight = 45.68528F;
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // nome
            // 
            nome.FillWeight = 127.1574F;
            nome.HeaderText = "NOME";
            nome.Name = "nome";
            nome.ReadOnly = true;
            // 
            // email
            // 
            email.FillWeight = 127.1574F;
            email.HeaderText = "EMAIL";
            email.Name = "email";
            email.ReadOnly = true;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lbNome.Location = new System.Drawing.Point(14, 83);
            lbNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbNome.Name = "lbNome";
            lbNome.Size = new System.Drawing.Size(79, 29);
            lbNome.TabIndex = 2;
            lbNome.Text = "Nome";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lbEmail.Location = new System.Drawing.Point(14, 170);
            lbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(74, 29);
            lbEmail.TabIndex = 3;
            lbEmail.Text = "Email";
            // 
            // txbNome
            // 
            txbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txbNome.Location = new System.Drawing.Point(20, 120);
            txbNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txbNome.Name = "txbNome";
            txbNome.Size = new System.Drawing.Size(242, 31);
            txbNome.TabIndex = 4;
            // 
            // txbEmail
            // 
            txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txbEmail.Location = new System.Drawing.Point(20, 207);
            txbEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new System.Drawing.Size(242, 31);
            txbEmail.TabIndex = 5;
            // 
            // btnConectar
            // 
            btnConectar.Location = new System.Drawing.Point(20, 270);
            btnConectar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new System.Drawing.Size(88, 27);
            btnConectar.TabIndex = 6;
            btnConectar.Text = "Contectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location = new System.Drawing.Point(20, 303);
            btnInserir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new System.Drawing.Size(88, 27);
            btnInserir.TabIndex = 7;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnProcurar
            // 
            btnProcurar.Location = new System.Drawing.Point(116, 303);
            btnProcurar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnProcurar.Name = "btnProcurar";
            btnProcurar.Size = new System.Drawing.Size(88, 27);
            btnProcurar.TabIndex = 8;
            btnProcurar.Text = "Procurar";
            btnProcurar.UseVisualStyleBackColor = true;
            btnProcurar.Click += btnProcurar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new System.Drawing.Point(114, 339);
            btnExcluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new System.Drawing.Size(88, 27);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new System.Drawing.Point(20, 339);
            btnEditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new System.Drawing.Size(88, 27);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCriarTabelas
            // 
            btnCriarTabelas.Location = new System.Drawing.Point(116, 270);
            btnCriarTabelas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCriarTabelas.Name = "btnCriarTabelas";
            btnCriarTabelas.Size = new System.Drawing.Size(88, 27);
            btnCriarTabelas.TabIndex = 11;
            btnCriarTabelas.Text = "Criar Tabelas";
            btnCriarTabelas.UseVisualStyleBackColor = true;
            btnCriarTabelas.Click += btnCriarTabelas_Click;
            // 
            // Agenda
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(670, 380);
            Controls.Add(btnCriarTabelas);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(btnProcurar);
            Controls.Add(btnInserir);
            Controls.Add(btnConectar);
            Controls.Add(txbEmail);
            Controls.Add(txbNome);
            Controls.Add(lbEmail);
            Controls.Add(lbNome);
            Controls.Add(dgvLista);
            Controls.Add(lbResultado);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Agenda";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCriarTabelas;
    }
}

