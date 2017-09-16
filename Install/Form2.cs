using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Configuration;


namespace Install
{
 

    public partial class Form2 : Form
    { 

        public Form2()
        {
            InitializeComponent();
            CbType.SelectedItem = 0; //to set the default value in type program
       
        }

        private void Form2_Load(object sender, EventArgs e)
        {
             }

        private void AutoSizeTextBox(TextBox txt)
        {
            const int x_margin = 0;
            const int y_margin = 2;
            Size size = TextRenderer.MeasureText(txt.Text, txt.Font);
            txt.ClientSize =
            new Size(size.Width + x_margin, size.Height + y_margin);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            DialogResult Result = openFileDialog1.ShowDialog();
            if(Result == DialogResult.OK)
            {
                if (openFileDialog1.FileNames.Length > 1)  //caso seja uma pasta pois seleciona mais que um ficheiro
                {
                    TbPath.Text = Path.GetDirectoryName(openFileDialog1.FileNames[0]);
                    ButtonBrowse.Visible = true;
                    cell8.Text = cell7.Text;
                    cell7.Text = cell6.Text;
                    cell6.Text = cell5.Text;
                    cell5.Text = cell4.Text;
                    cell8.Visible = true;
                    cell4.Text = "File to execute";
                    TbTags1.Visible = true;
                }
                else
                    TbPath.Text = openFileDialog1.FileName;
                AutoSizeTextBox(TbPath); //make a resize in the textbox       
            }
        }

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            DialogResult Result = openFileDialog1.ShowDialog();
            if (Result == DialogResult.OK)
            {
                TbArguments.Text = openFileDialog1.FileName;
                AutoSizeTextBox(TbArguments); //make a resize in the textbox       
            }
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            FileStream writer = new FileStream(@"C:\Users\User\Desktop\SourceXml.xml", FileMode.Create);

            //check if all fields is filled
            if (TbName.Text.Length == 0 || TbPath.Text.Length == 0 || TbDescription.Text.Length == 0 || TbTags.Text.Length == 0 )
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }
           
            Variables.NrPrograms++;
            if(cell8.Visible==true)
                Variables.ProgramList.Add(new Progr() { id = Variables.NrPrograms, name = TbName.Text, type = CbType.SelectedItem.ToString(), path = TbPath.Text, executable = TbArguments.Text, arguments = TbTags.Text, version = TbDescription.Text, tags = TbVersion.Text, description = TbTags1.Text });
            else
                Variables.ProgramList.Add(new Progr() { id = Variables.NrPrograms, name = TbName.Text, type = CbType.SelectedItem.ToString(), path = TbPath.Text, arguments = TbArguments.Text, tags = TbTags.Text, description = TbDescription.Text, version = TbVersion.Text });
            
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(typeof(List<Progr>));
            x.Serialize(writer, Variables.ProgramList);
            writer.Close();

            this.Close();
            MessageBox.Show("Programa foi adicionado");
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
     

 


        
    }
}
