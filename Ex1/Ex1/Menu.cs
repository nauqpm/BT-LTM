namespace Ex1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            Ex1.Server server = new Ex1.Server();
            server.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Ex1.Client client = new Ex1.Client();
            client.Show();
        }
    }
}
