using System;
using Newtonsoft.Json;
using Gray_API_pt2.Objects;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gray_API_pt2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            PlanetCheck.CheckedChanged += CheckChangedHandler;
            CharacterCheck.CheckedChanged += CheckChangedHandler;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public async void GetSpecies(int id)
        {

        }
        private void CheckChangedHandler(object sender, EventArgs e)
        {
            // Ensure only one checkbox is checked
            if (sender == PlanetCheck && PlanetCheck.Checked)
            {
                CharacterCheck.Checked = false;
            }
            else if (sender == CharacterCheck && CharacterCheck.Checked)
            {
                PlanetCheck.Checked = false;
            }
        }
        private async void SearchButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(IDBox.Text, out int id) || id <= 0)
            {
                MessageBox.Show("Please enter a valid numeric ID.");
                return;
            }

            if (PlanetCheck.Checked)
            {
                string apiUrl = $"http://swapi.py4e.com/api/planets/{id}/";
                Planet planet = await JSONHelper.GetPlanet(apiUrl, id);

                InfoBox.Items.Clear();
                AddObjectPropertiesToInfoBox(planet);
            }
            else if (CharacterCheck.Checked)
            {
                string apiUrl = $"http://swapi.py4e.com/api/people/{id}/";
                Person person = await JSONHelper.GetPerson(apiUrl, id);

                InfoBox.Items.Clear();
                AddObjectPropertiesToInfoBox(person);
            }
            else
            {
                MessageBox.Show("Please select either Planet or Person.");
            }
        }
        private void AddObjectPropertiesToInfoBox(object obj)
        {
            var properties = obj.GetType().GetProperties();
            foreach (var property in properties)
            {
                var value = property.GetValue(obj);

                if (value is IList<string> list)
                {
                    var listString = string.Join(", ", list);
                    InfoBox.Items.Add($"{property.Name}: {listString}");
                }
                else
                {
                    InfoBox.Items.Add($"{property.Name}: {value}");
                }
            }
        }

        private async void ViewButton_Click(object sender, EventArgs e)
        {
            InfoBox.Items.Clear();

            for (int id = 1; id <= 37; id++)
            {
                string apiUrl = $"http://swapi.py4e.com/api/species/{id}/";
                Species species = await JSONHelper.GetSpecies(apiUrl);

                AddObjectPropertiesToInfoBox(species);
            }
        }
    }
}
