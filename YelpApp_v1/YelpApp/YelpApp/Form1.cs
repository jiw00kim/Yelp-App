namespace YelpApp
{
    public partial class Form1 : Form
    {
        private string SelectedState { get { return comboBoxState.SelectedItem != null ? comboBoxState.SelectedItem.ToString() : null; } }
        private string SelectedCity { get { return listBoxCity.SelectedItem != null ? listBoxCity.SelectedItem.ToString() : null; } }
        private string SelectedZipcode { get { return listBoxZipcode.SelectedItem != null ? listBoxZipcode.SelectedItem.ToString() : null; } }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DBManager.Instance.Connect();
            UpdateStates();
        }

        private void UpdateCities()
        {
            if (SelectedState == null)
                return;

            listBoxCity.Items.Clear();
            List<string> cities = DBManager.Instance.GetAllCities(SelectedState);

            for (int i = 0; i < cities.Count; i++)
            {
                listBoxCity.Items.Add(cities[i]);
            }
        }

        private void UpdateZipcodes()
        {
            if (SelectedState == null || SelectedCity == null)
                return;

            listBoxZipcode.Items.Clear();
            List<string> zipcodes = DBManager.Instance.GetAllZipcodes(SelectedState, SelectedCity);

            for (int i = 0; i < zipcodes.Count; i++)
            {
                listBoxZipcode.Items.Add(zipcodes[i]);
            }
        }

        private void UpdateCategories()
        {
            if (SelectedState == null || SelectedCity == null || SelectedZipcode == null)
                return;

            listBoxCategory.Items.Clear();
            List<string> categories = DBManager.Instance.GetAllCategories(SelectedState, SelectedCity, SelectedZipcode);

            for (int i = 0; i < categories.Count; i++)
            {
                listBoxCategory.Items.Add(categories[i]);
            }
        }

        private void UpdateBusinesses()
        {
            dataGridViewBusiness.Rows.Clear();

            List<BusinessModel> businesses = DBManager.Instance.GetBusinesses(SelectedState, SelectedCity, SelectedZipcode, "srnPSBxBl7ENG2CziRXk9A");

            for (int i = 0; i < businesses.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridViewBusiness.Rows[0].Clone();
                row.Cells[0].Value = businesses[i].name;
                row.Cells[1].Value = businesses[i].address;
                row.Cells[2].Value = businesses[i].city;
                row.Cells[3].Value = businesses[i].state;
                row.Cells[4].Value = businesses[i].distance;
                row.Cells[5].Value = businesses[i].stars;
                row.Cells[6].Value = businesses[i].numtips;
                row.Cells[7].Value = businesses[i].numcheckins;
                dataGridViewBusiness.Rows.Add(row);
            }
        }

        private void UpdateStates()
        {
            List<string> states = DBManager.Instance.GetAllStates();

            for (int i = 0; i < states.Count; i++)
            {
                comboBoxState.Items.Add(states[i]);
            }
        }

        // =================================================================================

        private void comboBoxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCities();
        }

        private void listBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateZipcodes();
        }

        private void listBoxZipcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCategories();
            UpdateBusinesses();
        }

        //private void button1_Click_1(object sender, EventArgs e)
        //{

        //}

        private void NumTipsButton_Click(object sender, EventArgs e)
        {
            NumsByTips numTips = new NumsByTips();
        
            numTips.ShowDialog();
            
          
        }
    }
}