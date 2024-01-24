using RYMApi.Controllers;
using RYMApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RYMApi
{
    public partial class Form1 : Form
    {
        private CharacterControllers characterControllers;
        private Characters characters;
        public Form1()
        {
            InitializeComponent();
            characterControllers = new CharacterControllers();
            characters = new Characters();
        }

        public async void GetCharacters()
        {
            characters = await CharacterControllers.GetAllCharacters();

            if (characters != null)
            {
                foreach (var character in characters?.results)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvCharacters);

                    row.Cells[0].Value = character.name;
                    row.Cells[1].Value = character.gender;
                    row.Cells[2].Value = character.species;
                    row.Cells[3].Value = character.origin.name;

                    dgvCharacters.Rows.Add(row);
                }
            } else
            {
                MessageBox.Show("No se pudo obtener la peticion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetCharacters();
        }
    }
}
