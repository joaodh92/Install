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


namespace Install
{
   
    public partial class Form1 : Form
    {

        public void LoadData()
        {
           
            DataTable table = new DataTable();

           // CheckBox colCheckbox = new CheckBox();
            table.Columns.Add(new DataColumn("Install", typeof(bool)));

            table.Columns.Add("Name");
            table.Columns.Add("Type");
            table.Columns.Add("Version");
            table.Columns.Add("Description");
            table.Columns.Add("Path");
            table.Columns.Add("Executable");
            table.Columns.Add("Arguments");
            table.Columns.Add("Tags");

            /*read from list to table to inser in data gride view*/
            for (int i = 0; i < Variables.NrPrograms; i++)
            {
                table.Rows.Add(false, Name = Variables.ProgramList[i].name, Variables.ProgramList[i].type,
                Variables.ProgramList[i].version, Variables.ProgramList[i].description, Variables.ProgramList[i].path, Variables.ProgramList[i].executable, Variables.ProgramList[i].arguments, Variables.ProgramList[i].tags);
            }
            DataShow.DataSource = table;

            DataShow.Columns[0].ReadOnly = false;//allow change columns install
            for(int i=1; i<DataShow.ColumnCount;i++)
                DataShow.Columns[i].ReadOnly=true; //block all other to columns as read only
                    
        }

        public Form1()
        {
            InitializeComponent();
            try
            {

                FileStream Reader = new FileStream(@"C:\Users\User\Desktop\SourceXml.xml", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(typeof(List<Progr>));
                Variables.ProgramList = (List<Progr>)x.Deserialize(Reader);

                Variables.NrPrograms = Variables.ProgramList.Count;
                MessageBox.Show(Variables.NrPrograms.ToString());
                LoadData();
            }
            catch { }
           
        }
        private void addProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataShow.DataSource = Variables.ProgramList;
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
            LoadData();
        }

        private void versToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            DataShow.EndEdit();
            DataShow.CurrentCell = null;
            DataShow.Columns["Install"].Visible = false;
            for(int i=0; i<DataShow.RowCount;i++)
            {
                if ((bool)DataShow.Rows[i].Cells["Install"].Value == false)
                    DataShow.Rows[i].Visible = false;
            }
            ButtonReview.Visible=false;
            ButtonInstall.Visible = true;
            ButtonBack.Visible = true;

         }

        private void DataShow_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DataShow.Columns["Install"].Index)
            {
                DataShow.EndEdit();  //Stop editing of cell.
                if ((bool)DataShow.Rows[e.RowIndex].Cells["Install"].Value)
                    MessageBox.Show("The Value is Checked", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("UnChecked", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private static void CopyDirectory(string sourcePath, string destPath)
        {
            if (!Directory.Exists(destPath))
            {
                Directory.CreateDirectory(destPath);
            }

            foreach (string file in Directory.GetFiles(sourcePath))
            {
                string dest = Path.Combine(destPath, Path.GetFileName(file));
                File.Copy(file, dest,true);
            }

            foreach (string folder in Directory.GetDirectories(sourcePath))
            {
                string dest = Path.Combine(destPath, Path.GetFileName(folder));
                CopyDirectory(folder, dest);
            }
        }

        private void ButtonInstall_Click(object sender, EventArgs e)
        {
            string DstFolder;
            List<ToInstall> InstallPaths= new List<ToInstall>();
            
            int ProgramsCopy = DataShow.DisplayedRowCount(true), Copied = 0, ProgramInstall=0,Installed = 0;

            DataShow.Visible = false;
            CopyStatus.Visible = true;
            InstallStatus.Visible = true;
            ButtonBack.Visible = false;
            ButtonInstall.Visible = false;
            TBoxStatus.Visible = true;

            //check how many programs need to be installed
            foreach (DataGridViewRow Row in DataShow.Rows)
                if ((string)Row.Cells["Type"].Value != "Portable" && Row.Visible==true)
                    ProgramInstall++;
            int i=0;
            //stay there untill 
            while (ProgramInstall > Installed)
            {
                if (i < DataShow.RowCount)
                {
                    
                    if (DataShow.Rows[i].Visible == true &&(string) DataShow.Rows[i].Cells["Type"].Value == "Executable")
                    {
                        /*set the location to copy the files*/
                        //if this program is a folder
                        if (DataShow.Rows[i].Cells["Executable"].Value != System.DBNull.Value)
                        {
                            DstFolder = Environment.GetEnvironmentVariable("TEMP") + "\\AllInOne\\" + DataShow.Rows[i].Cells["Name"].Value;
                            CopyDirectory((string)DataShow.Rows[i].Cells["Path"].Value, DstFolder);
                            DstFolder = DstFolder + "\\" + DataShow.Rows[i].Cells["Executable"].Value ;     
                        }
                        //if this program is just one file
                        else
                        {
                            DstFolder = Environment.GetEnvironmentVariable("TEMP") + "\\AllInOne\\" + DataShow.Rows[i].Cells["Name"].Value;
                            if (!System.IO.Directory.Exists(DstFolder))
                                System.IO.Directory.CreateDirectory(DstFolder);
                            DstFolder = DstFolder +"\\" + Path.GetFileName((string)DataShow.Rows[i].Cells["Path"].Value);
                            System.IO.File.Copy((string)DataShow.Rows[i].Cells["Path"].Value, DstFolder, true);
                        }
                 
                       // text.Replace("@", "@" + Environment.NewLine);
                        TBoxStatus.Text += DataShow.Rows[i].Cells["Name"].Value + "- Copied with success\r\n";
                        InstallPaths.Add(new ToInstall() { path =DstFolder ,arguments=(string) DataShow.Rows[i].Cells["Arguments"].Value,name=(string) DataShow.Rows[i].Cells["Name"].Value});
                        Copied++;
                       
                    }
                    i++;
                }
                if (Installed < Copied && Variables.Installing == 0)
                {
                    Process p = new Process();  
                    try
                    {
                        p.StartInfo.FileName = InstallPaths[Installed].path;
                        p.Exited += new EventHandler(p_Exited);
                        p.EnableRaisingEvents = true;
                        if (InstallPaths[Installed].arguments.Length > 1)
                            p.StartInfo.Arguments = InstallPaths[Installed].arguments;
                        Variables.Installing = 1;
                    }
                    catch
                    {
                        MessageBox.Show("Probelms to install" + InstallPaths[Installed].path);
                    }
                    Installed++;
                    p.Start();
                }
                CopyStatus.Text = "Copyied " + Copied + " of " + ProgramsCopy + "programs";//counter to show the status of copy
                CopyStatus.Refresh();
                InstallStatus.Text = "Installed " + Installed + " of " + ProgramInstall + "programs";//counter to show the status of copy
                InstallStatus.Refresh();   
            }
            i = 0;
            //if there is portable programs to copy
            while (Copied < ProgramsCopy)
            {

                if (i < DataShow.RowCount)
                {

                    if (DataShow.Rows[i].Visible == true && (string)DataShow.Rows[i].Cells["Type"].Value == "Portable")
                    {
                         /*set the location to copy the files*/
                        //if this program is a folder
                        if (DataShow.Rows[i].Cells["Executable"].Value != System.DBNull.Value)
                        {
                            DstFolder = Environment.GetEnvironmentVariable("homepath") + "\\Desktop\\AllInOne\\" + DataShow.Rows[i].Cells["Name"].Value;
                            CopyDirectory((string)DataShow.Rows[i].Cells["Path"].Value, DstFolder);
                            DstFolder = DstFolder + "\\" + DataShow.Rows[i].Cells["Executable"].Value;
                        }
                        //if this program is just one file
                        else
                        {
                            DstFolder = Environment.GetEnvironmentVariable("homepath") + "\\Desktop\\AllInOne\\" + DataShow.Rows[i].Cells["Name"].Value;
                            if (!System.IO.Directory.Exists(DstFolder))
                                System.IO.Directory.CreateDirectory(DstFolder);
                            DstFolder = DstFolder + "\\" + Path.GetFileName((string)DataShow.Rows[i].Cells["Path"].Value);
                            System.IO.File.Copy((string)DataShow.Rows[i].Cells["Path"].Value, DstFolder, true);
                        }
                        TBoxStatus.Text += DataShow.Rows[i].Cells["Name"].Value + "- Copied with success\r\n";

                        Copied++;

                    }
                    i++;
                }
                CopyStatus.Text = "Copyied " + Copied + " of " + ProgramsCopy + "Programs";//counter to show the status of copy
                CopyStatus.Refresh();
                InstallStatus.Text = "Installed " + Installed + " of " + ProgramInstall + "programs";//counter to show the status of copy
                InstallStatus.Refresh();
            }
            MessageBox.Show("Complete Installation");
            ButtonReview.Visible = true;
            DataShow.Visible = true;
            InstallStatus.Visible = false;
            CopyStatus.Visible = false;
            LoadData();
        }

        void p_Exited(object sender, EventArgs e)
        {
            Variables.Installing = 0;
        }
        

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DataShow.RowCount; i++)
                DataShow.Rows[i].Visible = true;

            DataShow.Columns["Install"].Visible = true;
            ButtonReview.Visible = true;
            ButtonInstall.Visible = false;
            ButtonBack.Visible = false;
        }
    }

    public class ToInstall
    {
        public string path;
        public string arguments;
        public string name;
    }

    public class Progr
    {
        public int id;
        public string name;
        public string type;
        public string path;
        public string executable;
        public string arguments;
        public string tags;
        public string description;
        public string version;
    }

    

    class Variables
    {
        public static int Installing=0;
        public static List<Progr> ProgramList = new List<Progr>();
        public static int NrPrograms = 0;
    }
}
