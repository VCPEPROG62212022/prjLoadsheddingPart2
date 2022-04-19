using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjLoadsheddingPart2
{
    public partial class Form1 : Form
    {
        Area<string> LoadsheddingData = new Area<string>(100);
        public Form1()
        {
            InitializeComponent();

            LoadsheddingData.Push("8:00-10:00", "8:00-10:00;18:00-20:00", "8:00-10:00;18:00-20:00",
                "8:00-10:00;18:00-20:00;22:00-23:59", "19/04/2022", "Greenacers");
            LoadsheddingData.Push("None", "18:00-20:00", "18:00-20:00",
                "8:00-10:00;18:00-20:00;22:00-23:59", "20/04/2022", "Greenacers");
            LoadsheddingData.Push("18:00-10:00", "18:00-10:00", "8:00-10:00;18:00-20:00",
                "18:00-20:00", "21/04/2022", "Greenacers");
            LoadsheddingData.Push("8:00-10:00", "8:00-10:00;18:00-20:00", "8:00-10:00;18:00-20:00",
                "8:00-10:00;18:00-20:00;22:00-23:59", "22/04/2022", "Greenacers");
            LoadsheddingData.Push("8:00-10:00", "8:00-10:00;18:00-20:00", "8:00-10:00;18:00-20:00",
                "8:00-10:00;18:00-20:00;22:00-23:59", "23/04/2022", "Greenacers");
            LoadsheddingData.Push("6:00-8:00", "6:00-10:00;19:00-22:00", "1:00-10:00;18:00-20:00",
                "8:00-10:00;18:00-23:00", "24/04/2022", "Greenacers");


            LoadsheddingData.Push("2:00-10:00", "8:00-10:00;18:00-20:00", "8:00-10:00;18:00-20:00",
                "8:00-10:00;18:00-20:00;22:00-23:59", "19/04/2022", "North_End");
            LoadsheddingData.Push("None", "18:00-20:00", "18:00-20:00",
                "8:00-10:00;18:00-20:00;22:00-23:59", "20/04/2022", "North_End");
            LoadsheddingData.Push("18:00-10:00", "18:00-10:00", "8:00-10:00;18:00-20:00",
                "18:00-20:00", "21/04/2022", "North_End");
            LoadsheddingData.Push("8:00-10:00", "8:00-10:00;18:00-20:00", "8:00-10:00;18:00-20:00",
                "8:00-10:00;18:00-20:00;22:00-23:59", "22/04/2022", "North_End");
            LoadsheddingData.Push("8:00-10:00", "8:00-10:00;18:00-20:00", "8:00-10:00;18:00-20:00",
                "8:00-10:00;18:00-20:00;22:00-23:59", "23/04/2022", "North_End");
            LoadsheddingData.Push("6:00-8:00", "6:00-10:00;19:00-22:00", "1:00-10:00;18:00-20:00",
                "8:00-10:00;18:00-23:00", "24/04/2022", "North_End");

            LoadsheddingData.Push("6:00-10:00", "3:00-10:00;18:00-20:00", "8:00-10:00;18:00-20:00",
                "8:00-10:00;18:00-20:00;22:00-23:59", "19/04/2022", "St_Georges");
            LoadsheddingData.Push("None", "18:00-20:00", "4:00-20:00",
                "8:00-10:00;18:00-20:00;22:00-23:59", "20/04/2022", "St_Georges");
            LoadsheddingData.Push("28:00-10:00", "18:00-10:00", "8:00-10:00;18:00-20:00",
                "18:00-20:00", "21/04/2022", "St_Georges");
            LoadsheddingData.Push("8:00-10:00", "3:00-10:00;18:00-20:00", "8:00-10:00;18:00-20:00",
                "8:00-10:00;18:00-20:00;22:00-23:59", "22/04/2022", "St_Georges");
            LoadsheddingData.Push("8:00-10:00", "8:00-10:00;18:00-20:00", "8:00-10:00;18:00-20:00",
                "8:00-10:00;18:00-20:00;22:00-23:59", "23/04/2022", "St_Georges");
            LoadsheddingData.Push("6:00-8:00", "6:00-10:00;19:00-22:00", "1:00-10:00;18:00-20:00",
                "8:00-10:00;18:00-23:00", "24/04/2022", "St_Georges");
            cmbArea.Items.Clear();

            
            foreach (string item in LoadsheddingData.getUniqueAreas())
            {
                if (item!=null)
                {
                    cmbArea.Items.Add(item);
                } 
            }
            cbmStage.Items.Clear();
            cbmStage.Items.Add("1");
            cbmStage.Items.Add("2");
            cbmStage.Items.Add("3");
            cbmStage.Items.Add("4");


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectArea_Click(object sender, EventArgs e)
        {

            redOutput.Text= LoadsheddingData.getData().ToString();

        }

        private void cmbArea_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadsheddingData.areaSelcted = cmbArea.SelectedItem.ToString();
        }

        private void cbmStage_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadsheddingData.stage = cbmStage.SelectedItem.ToString();
        }

        private void cmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
