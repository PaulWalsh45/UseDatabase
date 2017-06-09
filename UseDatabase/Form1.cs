using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IniParser;
using IniParser.Model;
using System.Diagnostics;

namespace UseDatabase
{
    public partial class Form1 : Form
    {
        private List<KeyValuePair<string, string>> _databaseConfig = new List<KeyValuePair<string, string>>();
        private string _databaseChanged = string.Empty;
        private List<string> _filePaths = new List<string>();
        //filepaths
        private string _vsDevDebugFilepath = @"E:\TFS\PROJECTS\SE.02.0022 - InSolv Technologies (InSolv)\Visionblue .Net\Sandbox\TestClient\TestClient\bin\Debug\dbxconnections.ini";
        private string _vsQADebugFilepath = @"E:\TFS\PROJECTS\QA\Visionblue .Net\Sandbox\TestClient\TestClient\bin\Debug\dbxconnections.ini";
        private string _cInsolvUkFilepath = @"C:\InsolvUK\dbxconnections.ini";
        private string _delphi18Filepath = @"C:\Users\Public\Documents\Embarcadero\Studio\dbExpress\18.0\dbxconnections.ini";
        private string _delphiDevDebugFilepath = @"E:\TFS\PROJECTS\SE.02.0022 - InSolv Technologies (InSolv)\Delphi\02 - Insolv UK\GUI\win32\DLL\dbxconnections.ini";
        private string _delphiQADebugFilepath = @"E:\TFS\PROJECTS\QA\Delphi\02 - Insolv UK\GUI\win32\DLL\dbxconnections.ini";

        public Form1()
        {
            InitializeComponent();
            DatabaseComboBox.DataSource = Enum.GetNames(typeof(Database));

            //defaults
            VisionblueCheckBox.Checked = true;
            VisualStudioDevCheckBox.Checked = true;
            Delphi18CheckBox.Checked = true;
            VisualStudioQACheckBox.Checked = true;
            DelphiDebugQACheckbox.Checked = true;
            DelphiDebugDevCheckbox.Checked = true;


        }

        private void ChangeDatabaseButton_Click(object sender, EventArgs e)
        {
            _databaseChanged = DatabaseComboBox.SelectedItem.ToString();

            if (VisionblueCheckBox.Checked == true)//Visionblue.exe
            {
                //string filePath = @"C:\InsolvUK\dbxconnections.ini";
                _filePaths.Add(_cInsolvUkFilepath);
                string sectionName = "InsolvUK";
                foreach (var item in _databaseConfig)
                {
                    NativeMethods.WritePrivateProfileString(sectionName,
                                                        item.Key,
                                                        item.Value,
                                                        _cInsolvUkFilepath);
                }
               
            }
            if (VisualStudioDevCheckBox.Checked == true)//Visual Studio debug DEV
            {
                //string filePath = @"E:\TFS\PROJECTS\SE.02.0022 - InSolv Technologies (InSolv)\Visionblue .Net\Sandbox\TestClient\TestClient\bin\Debug\dbxconnections.ini";
                _filePaths.Add(_vsDevDebugFilepath); 
                string sectionName = "InsolvUK";
                foreach (var item in _databaseConfig)
                {
                    NativeMethods.WritePrivateProfileString(sectionName,
                                                        item.Key,
                                                        item.Value,
                                                        _vsDevDebugFilepath);
                }
            }
            
            if (Delphi18CheckBox.Checked == true)//Delphi debug
            {
                //string filePath = @"C:\Users\Public\Documents\Embarcadero\Studio\dbExpress\18.0\dbxconnections.ini";
                _filePaths.Add(_delphi18Filepath); 
                string sectionName = "InsolvUK";
                foreach (var item in _databaseConfig)
                {
                    NativeMethods.WritePrivateProfileString(sectionName,
                                                        item.Key,
                                                        item.Value,
                                                        _delphi18Filepath);
                }
            }

            if (VisualStudioQACheckBox.Checked == true)// Visual Studio debug QA
            {
                //string filePath = @"E:\TFS\PROJECTS\QA\Visionblue .Net\Sandbox\TestClient\TestClient\bin\Debug\dbxconnections.ini";
                _filePaths.Add(_vsQADebugFilepath); 
                string sectionName = "InsolvUK";
                foreach (var item in _databaseConfig)
                {
                    NativeMethods.WritePrivateProfileString(sectionName,
                                                        item.Key,
                                                        item.Value,
                                                        _vsQADebugFilepath);
                }
            }

            if (DelphiDebugQACheckbox.Checked == true)// Embarcadero debug QA
            {
                //string filePath = @"E:\TFS\PROJECTS\QA\Delphi\02 - Insolv UK\GUI\win32\DLL\dbxconnections.ini";
                _filePaths.Add(_delphiQADebugFilepath);
                string sectionName = "InsolvUK";
                foreach (var item in _databaseConfig)
                {
                    NativeMethods.WritePrivateProfileString(sectionName,
                                                        item.Key,
                                                        item.Value,
                                                        _delphiQADebugFilepath);
                }
            }
            
            if (DelphiDebugDevCheckbox.Checked == true)// Embarcadero debug Dev
            {
                //string filePath = @"E:\TFS\PROJECTS\SE.02.0022 - InSolv Technologies (InSolv)\Delphi\02 - Insolv UK\GUI\win32\DLL\dbxconnections.ini";
                _filePaths.Add(_delphiDevDebugFilepath);
                string sectionName = "InsolvUK";
                foreach (var item in _databaseConfig)
                {
                    NativeMethods.WritePrivateProfileString(sectionName,
                                                        item.Key,
                                                        item.Value,
                                                        _delphiDevDebugFilepath);
                }
            }


            //Option to open the files after changing to check the info is correct
            DialogResult dialogResult = MessageBox.Show("Database Config file(s) changed to " + _databaseChanged + " at selected location(s)\nDo you want to open these files?", "Database Ini File Change Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                OpenFiles();
            }
        }

        private void OpenFiles()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            foreach (var filepath in _filePaths)
            {
                Process process = new Process();
                process.StartInfo.FileName = filepath;
                process.StartInfo.UseShellExecute = true;
                process.Start();

            }
            _filePaths.Clear();
        }

        

        private void DatabaseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)DatabaseComboBox.SelectedItem == Database.Dev2.ToString())
            {
                _databaseConfig = Configuration.DevTwo();
            }
            if ((string)DatabaseComboBox.SelectedItem == Database.Standard_QA.ToString())
            {
                _databaseConfig = Configuration.StandardQA();
            }
            if ((string)DatabaseComboBox.SelectedItem==Database.Fairpoint_QA.ToString())
            {
                _databaseConfig = Configuration.FairpointQA();
            }
            if ((string)DatabaseComboBox.SelectedItem==Database.Custom_QA.ToString())
            {
                _databaseConfig = Configuration.CustomQA();
            }
            if ((string)DatabaseComboBox.SelectedItem==Database.Stepchange_QA.ToString())
            {
                _databaseConfig = Configuration.StepchangeQA();
            }
            if ((string)DatabaseComboBox.SelectedItem==Database.Aperture.ToString())
            {
                _databaseConfig = Configuration.Aperture();
            }
            if ((string)DatabaseComboBox.SelectedItem == Database.Internal_Training.ToString())
            {
                _databaseConfig = Configuration.InternalTraining();
            }
            if ((string)DatabaseComboBox.SelectedItem == Database.Dev_QA.ToString())
            {
                _databaseConfig = Configuration.DevQA();
            }
        }

        private void OpenFileButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            Process process = new Process();
            process.StartInfo.FileName = _vsDevDebugFilepath;
            process.StartInfo.UseShellExecute = true;
            process.Start();
        }

        private void OpenFileButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            Process process = new Process();
            process.StartInfo.FileName = _vsQADebugFilepath;
            process.StartInfo.UseShellExecute = true;
            process.Start();
        }

        private void OpenFileButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            Process process = new Process();
            process.StartInfo.FileName = _cInsolvUkFilepath;
            process.StartInfo.UseShellExecute = true;
            process.Start();
        }

        private void OpenFileButton4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            Process process = new Process();
            process.StartInfo.FileName = _delphi18Filepath;
            process.StartInfo.UseShellExecute = true;
            process.Start();
        }

        private void OpenFileButton5_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            Process process = new Process();
            process.StartInfo.FileName = _delphiQADebugFilepath;
            process.StartInfo.UseShellExecute = true;
            process.Start();
        }

        private void OpenFileButton6_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            Process process = new Process();
            process.StartInfo.FileName = _delphiDevDebugFilepath;
            process.StartInfo.UseShellExecute = true;
            process.Start();
        }
    }
}
