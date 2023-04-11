namespace IntroASistemas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFilho formFilho = new FrmFilho();
            formFilho.MdiParent= this;
            formFilho.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {       
            string msg, titulo;
            titulo = "Sair da aplicação";
            msg = "Você deseja realmente sair mano?";
               
         
            MessageBoxButtons msgButtons = MessageBoxButtons.YesNo;

            DialogResult result =  MessageBox.Show(msg, titulo, msgButtons, MessageBoxIcon.Question);

            if(result == DialogResult.Yes) {
                Application.Exit();
            }

            
        }

        private void toolStripBtnCliente_Click(object sender, EventArgs e)
        {
            FrmFilho formFilho = new FrmFilho();
            formFilho.MdiParent = this;
            formFilho.Show();
        }
    }
}
