namespace Trabalho.Escola.Natacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Aluno alunoNatacao = new Aluno();

            alunoNatacao.aluno = txtAluno.Text;
            alunoNatacao.professor = txtProfessor.Text;
            alunoNatacao.aula = txtHorario.Text;
            alunoNatacao.marcar = dtpMarcador.Text;

            MessageBox.Show("O aluno " + alunoNatacao.aluno + "foi cadastrado");



        }

        public void CriadorMackup()
        {
            Aluno turmas = new Professor();
            turmas.professor = "Cesar";
            turmas.aula = "14:00-15:00";


        }


    }
}
}