using Newtonsoft.Json;

namespace WinFormsApp1
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

        private async void Button1_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://api.randomuser.me");
                    var response = await client.GetAsync("https://api.randomuser.me");
                    response.EnsureSuccessStatusCode();

                    var stringResult = await response.Content.ReadAsStringAsync();
                    var rawData = JsonConvert.DeserializeObject<Rootobject>(stringResult);
                    nameLabel.Text = String.Join(" ", "Name: ", rawData.results[0].name.title, rawData.results[0].name.first, rawData.results[0].name.last);
                    emailLabel.Text = String.Join(" ", "E-mail: ", rawData.results[0].email);
                    pictureBox1.Load(rawData.results[0].picture.large.ToString());
                    pictureBox2.Load("https://robohash.org/" + rawData.results[0].name.first);
                    locationLabel.Text = "Location: " + rawData.results[0].location.city + ", " + rawData.results[0].location.country;
                    radioButtonMale.Checked = rawData.results[0].gender == "male";
                    radioButtonFemale.Checked = rawData.results[0].gender == "female";
                }

                catch (Exception ex)
                {
                    nameLabel.Text = "wrong data";
                    emailLabel.Text = "";
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    labelFile.Text = openFileDialog.SafeFileName;

                    //Read the contents of the file into a stream
                    //var fileStream = openFileDialog.OpenFile();

                    //using (StreamReader reader = new StreamReader(fileStream))
                    //{
                    //    fileContent = reader.ReadToEnd();
                    //}
                }
            }
        }
    }
}