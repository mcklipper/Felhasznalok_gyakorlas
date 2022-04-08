namespace Felhasznalok
{
    public partial class MainForm : Form
    {
        private readonly AppDbContext context;

        public MainForm()
        {
            InitializeComponent();
            context = new();
        }

        private void FillDgv()
        {
            dgvFelhasznalok.Rows.Clear();

            foreach (User u in context.Users)
            {
                dgvFelhasznalok.Rows.Add(new string[]
                {
                    u.Id.ToString(),
                    u.Name,
                    u.Email,
                });
            }
        }

        private void MainForm_Load(object sender, EventArgs e) => FillDgv();

        private void btnRogzit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbNev.Text) || String.IsNullOrEmpty(tbEmail.Text))
                return;

            User newUser = new()
            {
                Name = tbNev.Text,
                Email = tbEmail.Text,
            };

            context.Users.Add(newUser);
            context.SaveChanges();

            tbNev.Text = "";
            tbEmail.Text = "";

            FillDgv();
        }

        private void dgvFelhasznalok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 3) 
                return;

            var selectedRow = dgvFelhasznalok.Rows[e.RowIndex];
            var form = new UpdateForm(
                context, 
                int.Parse($"{ selectedRow.Cells[0].Value }")
            );

            form.ShowDialog();
            FillDgv();
        }
    }
}