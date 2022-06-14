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
using System.Diagnostics;
using System.Management;

namespace Urho3DSamplesLauncher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CreateResolutionsList();
            InitOptionsList();
            RefreshFileListAndMaskLabel();
        }

        Dictionary<string, string> options = new Dictionary<string, string>();

        private void InitOptionsList()
        {
            string name, value;

            name = "Start in windowed mode";
            value = " -w";
            checkedListBoxOptions.Items.Add(name);
            options.Add(name, value);

            name = "Enable resizing when in windowed mode";
            value = " -s";
            checkedListBoxOptions.Items.Add(name);
            options.Add(name, value);

            name = "Force OpenGL 2 use even if OpenGL 3 is available";
            value = " -gl2";
            checkedListBoxOptions.Items.Add(name);
            options.Add(name, value);

            name = "Disable frame limiter";
            value = " -nolimit";
            checkedListBoxOptions.Items.Add(name);
            options.Add(name, value);

            name = "Disable shadow rendering";
            value = " -noshadows";
            checkedListBoxOptions.Items.Add(name);
            options.Add(name, value);

            name = "Use light pre-pass rendering";
            value = " -prepass";
            checkedListBoxOptions.Items.Add(name);
            options.Add(name, value);

            name = "Use deferred rendering";
            value = " -deferred";
            checkedListBoxOptions.Items.Add(name);
            options.Add(name, value);
        }

        private void radioButtonAngelScript_CheckedChanged(object sender, EventArgs e)
        {
            RefreshFileListAndMaskLabel();
        }

        private void radioButtonLua_CheckedChanged(object sender, EventArgs e)
        {
            RefreshFileListAndMaskLabel();
        }

        private void RefreshFileListAndMaskLabel()
        {
            string dir, mask;

            if (radioButtonAngelScript.Checked)
            {
                dir = "Data\\Scripts";
                mask = "*_*.as";
                labelFileMask.Text = "Data\\Scripts\\*_*.as";
            }
            else
            {
                dir = "Data\\LuaScripts";
                mask = "*_*.lua";
                labelFileMask.Text = "Data\\LuaScripts\\*_*.lua";
            }

            listBoxScripts.Items.Clear();

            try
            {
                listBoxScripts.Items.AddRange(Directory.GetFiles(dir, mask));
                listBoxScripts.SelectedIndex = 0; // it calls UpdateCommandLineLabel();
            }
            catch
            {
                MessageBox.Show("Scripts not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartPlayer()
        {
            try
            {
                Process.Start(GetPlayerName(), GetArguments());
            }
            catch
            {
                MessageBox.Show("Player not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonStart_Click(object sender, EventArgs e)
        {
            StartPlayer();
        }

        private void listBoxScripts_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCommandLineLabel();
        }

        private void UpdateCommandLineLabel()
        {
            if (comboBoxResolutions.Items.Count == 0 || listBoxScripts.Items.Count == 0) // before initialisation
                return;

            string result = GetPlayerName() + " " + GetArguments();
            labelCommandLine.Text = result;
        }

        string GetPlayerName()
        {
            string result = "Urho3DPlayer_d.exe";

            if (radioButtonRelease.Checked)
                result = "Urho3DPlayer.exe";

            return result;
        }

        string GetArguments()
        {
            string result = listBoxScripts.SelectedItem.ToString();
            
            if (comboBoxResolutions.SelectedItem.ToString() != "Use current resolution")
                result += resolutions[comboBoxResolutions.SelectedItem.ToString()];

            foreach (var item in checkedListBoxOptions.CheckedItems)
                result += options[item.ToString()];

            return result;
        }

        private void checkedListBoxOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCommandLineLabel();
        }

        private void radioButtonRelease_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCommandLineLabel();
        }

        private void radioButtonDebug_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCommandLineLabel();
        }

        private void listBoxScripts_DoubleClick(object sender, EventArgs e)
        {
            StartPlayer();
        }

        Dictionary<string, string> resolutions = new Dictionary<string, string>();

        private void CreateResolutionsList()
        {
            var scope = new ManagementScope();
            var query = new ObjectQuery("SELECT * FROM CIM_VideoControllerResolution");

            using (var searcher = new ManagementObjectSearcher(scope, query))
            {
                var results = searcher.Get();

                comboBoxResolutions.Items.Add("Use current resolution");

                foreach (var result in results)
                {
                    string name = result["HorizontalResolution"].ToString() + "x" + result["VerticalResolution"];
                    string value = " -x " + result["HorizontalResolution"].ToString() + " -y " + result["VerticalResolution"];
                    if (!comboBoxResolutions.Items.Contains(name))
                    {
                        comboBoxResolutions.Items.Add(name);
                        resolutions[name] = value;
                    }
                }
            }

            comboBoxResolutions.SelectedIndex = 0; // it calls UpdateCommandLineLabel();
        }

        private void comboBoxResolutions_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCommandLineLabel();
        }
    }
}
