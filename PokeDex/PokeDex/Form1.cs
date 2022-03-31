using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Text.Json;
using static System.Console;
using System.Text.Json.Serialization;

namespace PokeDex
{
    public partial class Form1 : Form
    {


        private ArrayList pl = new ArrayList();
        int m_current = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Pokemon.json"))
            {
                StreamReader inFile = File.OpenText("Pokemon.json");
                while (inFile.Peek() != -1)
                {
                    string line;
                    line = inFile.ReadLine();
                    if (line != null && line.Length != 0)
                    {
                        PokemonClass w = JsonSerializer.Deserialize<PokemonClass>(line);
                        pl.Add(w);
                    }
                }
                show(0);
                inFile.Close();


            }
        }



        private void pokemonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PicturePB_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (System.IO.File.Exists(openFileDialog1.FileName))
                PicturePB.Load(openFileDialog1.FileName);
        }

        private void clear()
        {
            HpTB.Clear();
            MoveTB.Clear();
            HeightTB.Clear();
            NameTB.Clear();
            PicturePB.Image = null;
            TypeTB.Clear();
            DescTB.Clear();
            WeightTB.Clear();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void AddNewButton_Click_1(object sender, EventArgs e)
        {
            save();
            clear();
        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            save();
        }

        private void show(int index)
        {
            if (index >= 0 && index < pl.Count)
            {
                PokemonClass p = (PokemonClass)pl[index];
                HpTB.Text = p.hp.ToString();
                MoveTB.Text = p.move;
                HeightTB.Text = p.height.ToString();
                NameTB.Text = p.name;
                if (File.Exists(p.pic))
                { PicturePB.Load(p.pic); }
                TypeTB.Text = p.type;
                DescTB.Text = p.desc;
                WeightTB.Text = p.weight.ToString();
            }
        }

        void save()
        {


            var Pokemon1 = new PokemonClass
            {
                type = TypeTB.Text,
                move = MoveTB.Text,
                name = NameTB.Text,
                desc = DescTB.Text,
                pic = PicturePB.ImageLocation,
                weight = int.Parse(WeightTB.Text),
                height = int.Parse(HeightTB.Text),
                hp = int.Parse(HpTB.Text)
            };

            pl.Add(Pokemon1);
            StreamWriter outFile = File.CreateText("Pokemon.json");
            foreach (var item in pl)
            {
                outFile.WriteLine(JsonSerializer.Serialize(item));
            }

            outFile.Close();

        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            show(0);
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            show(pl.Count - 1);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            pl.Remove(pl[m_current]);
            show(m_current);
            save();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (pl.Count == m_current + 1)
            {
                m_current = 0;
            }
            else if (m_current < pl.Count)
            {
                m_current++;
            }

            show(m_current);
        }


        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (pl.Count == 0)
            {
                m_current = pl.Count - 1;
            }
            else if (m_current > 0)
            {
                m_current--;
            }

            show(m_current);
        }
    }
}
