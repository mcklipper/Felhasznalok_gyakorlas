namespace Felhasznalok
{
    public partial class UpdateForm : Form
    {
        private readonly AppDbContext context;
        private readonly User? user;

        public UpdateForm(AppDbContext context, int id)
        {
            InitializeComponent();

            this.context = context;
            user = context.Users.Where(x => x.Id == id).FirstOrDefault();

            if (user == null)
                Close();

            tbNev.Text = user?.Name;
            tbEmail.Text = user?.Email;
        }

        private void btnModosit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbNev.Text) || String.IsNullOrEmpty(tbEmail.Text))
                return;

            user.Name = tbNev.Text;
            user.Email = tbEmail.Text;

            context.SaveChanges();
            Close();
        }
    }
}
