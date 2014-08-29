using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;


namespace Chapter3
{
    public partial class MainForm : Form
    {
        private BindingSource myBindingSource = new BindingSource();

        public MainForm()
        {
            InitializeComponent();

            dataGridView1.DataSource = myBindingSource;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Personnel newPersonnel = new Personnel();
            newPersonnel.FirstName = textBoxFirst.Text;
            newPersonnel.LastName = textBoxLast.Text;
            newPersonnel.HireDate = dateTimeHireDate.Value;
            newPersonnel.Position = listBoxPosition.SelectedItem.ToString();
           
            myBindingSource.Add(newPersonnel);
            pnpPersonnel.Add(newPersonnel);
        }

        private void textBoxFirst_Click(object sender, EventArgs e)
        {
            textBoxFirst.Text = "";
        }

        private void textBoxLast_Click(object sender, EventArgs e)
        {
            textBoxLast.Text = "";
        }


        List<Personnel> pnpPersonnel = new List<Personnel>();

        
        private void buttonSave_Click(object sender, EventArgs e)
        {

            var myData = JsonConvert.SerializeObject(pnpPersonnel);
            File.WriteAllText(@"C:\Users\Public\New folder\myData.json", myData);
        }

       private void buttonLoad_Click(object sender, EventArgs e)
        {
            
            var myData = File.ReadAllText(@"C:\Users\Public\New folder\myData.json");
            List<Personnel> newPnpPersonnel = JsonConvert.DeserializeObject<List<Personnel>>(myData);     
      
            foreach (var personnel in newPnpPersonnel)
            {
                pnpPersonnel.Add(personnel);
                myBindingSource.Add(personnel);
            }
        }
       
        

       
    }
}
