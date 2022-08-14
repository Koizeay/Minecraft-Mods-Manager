using System.Diagnostics;

namespace Minecraft_Mods_Manager
{
    public partial class FormMain : Form
    {
        private string? modsDirectory;
        private string supportedExtensions = "*.jar,*.no";
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            string defaultDirectory = Environment.ExpandEnvironmentVariables(@"%APPDATA%\.minecraft\mods");

            if (Directory.Exists(defaultDirectory))
            {
                fillList(defaultDirectory);
                modsDirectory = defaultDirectory;
                textBoxPath.Text = modsDirectory;
            }
            else
            {
                string message = "The Minecraft mods folder has not been detected.\nChoose it now.";
                string title = "No mods folder detected";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                changeModFolder();
            }
        }

        private void changeModFolder()
        {
            DialogResult folderResult = folderBrowserDialog.ShowDialog();
            if (folderResult == DialogResult.OK)
            {
                fillList(folderBrowserDialog.SelectedPath);
                modsDirectory = folderBrowserDialog.SelectedPath;
                textBoxPath.Text = modsDirectory;
            }
            else
            {
                if (modsDirectory == null)
                {
                    string message = "You have not selected any folder.";
                    string title = "No mods folder selected";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                    changeModFolder();
                }
            }
        }

        private void fillList(string directory)
        {
            checkedListBoxMods.Items.Clear();

            IEnumerable<string> files = Directory.GetFiles(directory, "*.*", SearchOption.TopDirectoryOnly).Where(s => supportedExtensions.Contains(Path.GetExtension(s).ToLower()));
            for (int i = 0; i < files.Count(); i++)
            {
                var fileName = Path.GetFileNameWithoutExtension(new FileInfo(files.ElementAt(i)).Name);
                var fileExtension = new FileInfo(files.ElementAt(i)).Extension;

                checkedListBoxMods.Items.Add(fileName);

                if (fileExtension == ".jar")
                {
                    checkedListBoxMods.SetItemChecked(i, true);
                }
            }
        }

        private void buttonPath_Click(object sender, EventArgs e)
        {
            changeModFolder();
        }

        private void checkedListBoxMods_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string? fileName = checkedListBoxMods.Items[e.Index].ToString();

            changeFileExtension(fileName, e.NewValue == CheckState.Checked);

        }

        private void changeFileExtension(string? fileName, bool isNowEnabled)
        {
            if (fileName != null && modsDirectory != null)
            {
                string filePathWithoutExtension = Path.Combine(modsDirectory, fileName);
                if (isNowEnabled)
                {
                    string filePath = filePathWithoutExtension + ".no";
                    string fileNewPath = filePathWithoutExtension + ".jar";

                    renameFile(filePath, fileNewPath);
                }
                else
                {
                    string filePath = filePathWithoutExtension + ".jar";
                    string fileNewPath = filePathWithoutExtension + ".no";

                    renameFile(filePath, fileNewPath);
                }
            }
        }

        private void renameFile(string path, string newPath)
        {
            if (File.Exists(path) && !File.Exists(newPath))
            {
                File.Move(path, newPath, true);
            }
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            if (modsDirectory != null)
            {
                fillList(modsDirectory);
            }
        }

        private void buttonOpenModsDir_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", modsDirectory);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while opening the mods folder in file explorer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (checkedListBoxMods.SelectedIndex != -1)
            {
                string fileName = checkedListBoxMods.Text;
                string extension = checkedListBoxMods.GetItemCheckState(checkedListBoxMods.SelectedIndex) == CheckState.Checked ? ".jar" : ".no";

                DialogResult dialogResult = MessageBox.Show("Do you really want to delete the \"" + fileName + "\" mod?", "Delete this mod?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (modsDirectory != null)
                    {
                        try
                        {
                            string path = Path.Combine(modsDirectory, fileName + extension);
                            File.Delete(path);
                        }
                        catch
                        {
                            MessageBox.Show("Error when deleting selected mod.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        fillList(modsDirectory);
                    }
                }
            }
        }
    }
}