

namespace YelpApp
{
    public partial class NumsByTips : Form
    {
        int selectedRowIndex;
        public NumsByTips()
        {
            InitializeComponent();
        }

        private void NumsByTips_Load(object sender, EventArgs e)
        {
            DBManager.Instance.Connect();
            TipsByUsers();

        }

        private void TipsByUsers()
        {

            dataGridViewNumTips.Rows.Clear();
            List<NumTipsModel> tips = DBManager.Instance.GetAllTips();

            for (int i = 0; i < tips.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridViewNumTips.Rows[0].Clone();
                row.Cells[0].Value = tips[i].date;
                row.Cells[1].Value = tips[i].userName;
                row.Cells[2].Value = tips[i].likes;
                row.Cells[3].Value = tips[i].text;

                dataGridViewNumTips.Rows.Add(row);

            }
        }

        private void AddTipButton_Click(object sender, EventArgs e)
        {

            List<NumTipsModel> tips = DBManager.Instance.GetAllTips();

            for(int i = 0;i < tips.Count();i++)
            {
                DataGridViewRow newDataRow = (DataGridViewRow)dataGridViewNumTips.Rows[0].Clone();

                newDataRow.Cells[0].Value = tips[i].date;
                newDataRow.Cells[1].Value = tips[i].userName;
                newDataRow.Cells[2].Value = tips[i].likes;
                newDataRow.Cells[3].Value = tips[i].text;

                dataGridViewNumTips.Rows.Add(newDataRow);

            }

        }

        private void dataGridViewNumTips_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
