namespace Agenda
{
    partial class Agenda
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
            dgvLista = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            lbResultado = new Label();
            btnCriarTabelas = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnProcurar = new Button();
            btnInserir = new Button();
            btnConectar = new Button();
            txbEmail = new TextBox();
            txbNome = new TextBox();
            lbEmail = new Label();
            lbNome = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            SuspendLayout();
            // 
            // dgvLista
            // 
            dgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Columns.AddRange(new DataGridViewColumn[] { Id, nome, email });
            dgvLista.Location = new Point(263, 10);
            dgvLista.Margin = new Padding(4, 3, 4, 3);
            dgvLista.Name = "dgvLista";
            dgvLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLista.Size = new Size(386, 355);
            dgvLista.TabIndex = 13;
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
            // lbResultado
            // 
            lbResultado.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbResultado.Location = new Point(7, 10);
            lbResultado.Margin = new Padding(4, 0, 4, 0);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(248, 73);
            lbResultado.TabIndex = 12;
            lbResultado.Text = "Resultado";
            // 
            // btnCriarTabelas
            // 
            btnCriarTabelas.Location = new Point(109, 270);
            btnCriarTabelas.Margin = new Padding(4, 3, 4, 3);
            btnCriarTabelas.Name = "btnCriarTabelas";
            btnCriarTabelas.Size = new Size(88, 27);
            btnCriarTabelas.TabIndex = 23;
            btnCriarTabelas.Text = "Criar Tabelas";
            btnCriarTabelas.UseVisualStyleBackColor = true;
            btnCriarTabelas.Click += btnCriarTabelas_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(13, 339);
            btnEditar.Margin = new Padding(4, 3, 4, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(88, 27);
            btnEditar.TabIndex = 22;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(107, 339);
            btnExcluir.Margin = new Padding(4, 3, 4, 3);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(88, 27);
            btnExcluir.TabIndex = 21;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnProcurar
            // 
            btnProcurar.Location = new Point(109, 303);
            btnProcurar.Margin = new Padding(4, 3, 4, 3);
            btnProcurar.Name = "btnProcurar";
            btnProcurar.Size = new Size(88, 27);
            btnProcurar.TabIndex = 20;
            btnProcurar.Text = "Procurar";
            btnProcurar.UseVisualStyleBackColor = true;
            btnProcurar.Click += btnProcurar_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(13, 303);
            btnInserir.Margin = new Padding(4, 3, 4, 3);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(88, 27);
            btnInserir.TabIndex = 19;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(13, 270);
            btnConectar.Margin = new Padding(4, 3, 4, 3);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(88, 27);
            btnConectar.TabIndex = 18;
            btnConectar.Text = "Contectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // txbEmail
            // 
            txbEmail.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbEmail.Location = new Point(13, 207);
            txbEmail.Margin = new Padding(4, 3, 4, 3);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(242, 31);
            txbEmail.TabIndex = 17;
            // 
            // txbNome
            // 
            txbNome.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbNome.Location = new Point(13, 120);
            txbNome.Margin = new Padding(4, 3, 4, 3);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(242, 31);
            txbNome.TabIndex = 16;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEmail.Location = new Point(7, 170);
            lbEmail.Margin = new Padding(4, 0, 4, 0);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(74, 29);
            lbEmail.TabIndex = 15;
            lbEmail.Text = "Email";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNome.Location = new Point(7, 83);
            lbNome.Margin = new Padding(4, 0, 4, 0);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(79, 29);
            lbNome.TabIndex = 14;
            lbNome.Text = "Nome";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 377);
            Controls.Add(dgvLista);
            Controls.Add(lbResultado);
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
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLista;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn email;
        private Label lbResultado;
        private Button btnCriarTabelas;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnProcurar;
        private Button btnInserir;
        private Button btnConectar;
        private TextBox txbEmail;
        private TextBox txbNome;
        private Label lbEmail;
        private Label lbNome;
    }
}
