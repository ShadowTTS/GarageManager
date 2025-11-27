namespace GarageManager
{

    public partial class Form1 : Form
    {
        List<Car> myGarage = new List<Car>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtHP.Text, out int hp))
            {
                Car newCar = new Car();
                newCar.Model = txtModel.Text;
                newCar.HP = hp;
                myGarage.Add(newCar);
                lstGarage.Items.Add(newCar.GetInfo());
                int totalPower = 0;
                foreach (Car c in myGarage)
                {
                    totalPower += c.HP;
                }
                lblTotalHP.Text = $"Total Garage HP: {totalPower} 🐎";
                lblTotalHP.ForeColor = Color.Red;
                txtModel.Text = "";
                txtHP.Text = "";
                txtModel.Focus();
            }
            else
            {
                MessageBox.Show("Bro, Horsepower needs to be a number.");
            }   
            lstGarage.TopIndex = lstGarage.Items.Count - 1;
        }

        private void lblTotalHP_Click(object sender, EventArgs e)
        {

        }
    }
    public class Car
    {
        public string Model { get; set; } = "";
        public int HP { get; set; }
        public string GetInfo()
        {
            return $"{Model} - {HP} HP";
        }
    }
}
