using Agenda.DBServices;
namespace Agenda
{
    public partial class Agenda : Form
    {
        private readonly IDatabaseService _db;
        public Agenda(IDatabaseService dbService)
        {
            InitializeComponent();
            _db = dbService;
            BuscarContatos(null);
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            lbResultado.Text = _db.TestarConexao() ? "Conectado" : "Não Conectado";
        }

        private void btnCriarTabelas_Click(object sender, EventArgs e)
        {
            _db.CriarTabelaContatos();
            MessageBox.Show("Tabela criada com sucesso.");
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (!ValidaCampos()) return;
            _db.InserirContato(txbNome.Text, txbEmail.Text);
            MessageBox.Show("Registro adicionado com sucesso!");
            LimparCampos();
            btnProcurar_Click(sender, e);
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            BuscarContatos(txbNome.Text);

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!ValidaCampos()) return;

            if (dgvLista.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um contato para editar.");
                return;
            }
            else
            {
                int id = (int)dgvLista.SelectedRows[0].Cells[0].Value;
                _db.AtualizarContato(id, txbNome.Text, txbEmail.Text);
                MessageBox.Show("Registro atualizado com sucesso!");
                LimparCampos();
                dgvLista.ClearSelection();
                btnProcurar_Click(sender, e);
                
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvLista.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um contato para excluir.");
                return;
            }
            else
            {
                int id = (int)dgvLista.SelectedRows[0].Cells[0].Value;
                _db.ExcluirContato(id);
                MessageBox.Show("Registro deletado com sucesso!");
                LimparCampos();
                dgvLista.ClearSelection();
                btnProcurar_Click(sender, e);
            }
        }
        private bool ValidaCampos()
        {
            if (string.IsNullOrWhiteSpace(txbNome.Text))
            {
                MessageBox.Show("Preencha o campo Nome.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txbEmail.Text))
            {
                MessageBox.Show("Preencha o campo Email.");
                return false;
            }
            return true;
        }

        private void LimparCampos()
        {
            txbNome.Clear();
            txbEmail.Clear();
        }

        private void BuscarContatos(string dados)
        {
            dgvLista.Rows.Clear();
            var contatos = _db.BuscarContatos(txbNome.Text);
            foreach (var c in contatos)
            {
                dgvLista.Rows.Add(c.Id, c.Nome, c.Email);
            }
        }
    }
}
