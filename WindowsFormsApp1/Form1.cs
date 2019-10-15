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
using System.Configuration;
using Newtonsoft.Json;

namespace NinePatch
{
    public partial class NinePathTool : Form
    {
        public NinePathTool()
        {
            InitializeComponent();
            LoadToolSettings();

            this.Icon = Properties.Resources.ninepatch;
        }

        private void LoadToolSettings()
        {
            SetImgRootPath(Properties.Settings.Default.RootPath);
            SetOutputFolder(Properties.Settings.Default.OutputFolder);
            SetNinePatchConfigPath(Properties.Settings.Default.NPConfigPath);
        }

        #if false
        class NinePatchConfigList
        {
            public Dictionary<String, NinePatchConfig> NinePatchConfigs = new Dictionary<String, NinePatchConfig>();
        };
        private NinePatchConfigList NPConfigs = new NinePatchConfigList();
        #else
        private Dictionary<String, NinePatchConfig> NPConfigs = new Dictionary<String, NinePatchConfig>();
        #endif

        private void LoadNinePatchConfig(String npConfigPath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(npConfigPath))
                {
                    #if false
                    NPConfigs = JsonConvert.DeserializeObject<NinePatchConfigList>(reader.ReadToEnd());
                    #else
                    NPConfigs = JsonConvert.DeserializeObject<Dictionary<String, NinePatchConfig>>(reader.ReadToEnd());
                    #endif

                    cbbConfig.Items.Clear();
                    foreach (KeyValuePair<String, NinePatchConfig> Item in NPConfigs)
                    {
                        cbbConfig.Items.Add(Item.Key);
                    }

                    if (!String.IsNullOrEmpty(Properties.Settings.Default.LastNPConfig))
                    {
                        int initIndex = cbbConfig.Items.IndexOf(Properties.Settings.Default.LastNPConfig);
                        if (initIndex >= 0)
                        {
                            cbbConfig.SelectedIndex = initIndex;
                        }
                    }
                }
            }
            catch(System.Exception Excpt)
            {

            }
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.SelectedPath = Properties.Settings.Default.RootPath;
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    SetImgRootPath(folderDialog.SelectedPath);

                    Properties.Settings.Default.RootPath = folderDialog.SelectedPath;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void btnSelectConfig_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Choose Config File";
                openFileDialog.Multiselect = false;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    #if true
                    SetNinePatchConfigPath(openFileDialog.FileName);
                    #else
                        DumpNpConfig(openFileDialog.FileName);
                    #endif

                    Properties.Settings.Default.NPConfigPath = openFileDialog.FileName;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void SetImgRootPath(String fileRootPath)
        {
            txtRootPath.Text = fileRootPath;
            this.lvImgs.Items.Clear();

            try
            {
                CollecteImageFiles(fileRootPath);
            }
            catch (System.Exception excpt)
            {
                // Handler Exception
            }
        }

        private void CollecteImageFiles(String sDir)
        {
            foreach (String f in Directory.GetFiles(sDir))
            {
                if (Path.GetExtension(f) == ".png")
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = Path.GetFileName(f);
                    //lvi.SubItems.Add(f.Remove(0, txtRootPath.Text.Length));
                    lvi.SubItems.Add(sDir);
                    this.lvImgs.Items.Add(lvi);
                }
            }

            foreach (string d in Directory.GetDirectories(sDir))
            {
                CollecteImageFiles(d);
            }
        }

        private void SetNinePatchConfigPath(String npConfigPath)
        {
            txtNPConfigPath.Text = npConfigPath;
            if (!String.IsNullOrEmpty(npConfigPath))
            {
                LoadNinePatchConfig(npConfigPath);
            }
        }

        // For Test
        private void DumpNpConfig(String npConfigPath)
        {
            try
            {
                using (StreamWriter Writer = new StreamWriter(npConfigPath, false))
                {
                    NinePatchConfig Config1 = new NinePatchConfig();
                    Config1.left = Config1.right = Config1.top = Config1.bottom = 10;

                    NinePatchConfig Config2 = new NinePatchConfig();
                    Config2.left = Config2.right = Config2.top = Config2.bottom = 10;
                    NPConfigs.Add("config1", Config1);
                    NPConfigs.Add("config2", Config2);

                    Writer.Write(JsonConvert.SerializeObject(NPConfigs));
                    Writer.Flush();
                    Writer.Close();
                }
            }
            catch (Exception Excpt)
            {
            }
        }

        private void cbbConfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            NinePatchConfig config = GetSelectedNinPatchConfig();
            if (config != null)
            {
                lbConfigSnapShot.Text = config.ToString();
                Properties.Settings.Default.LastNPConfig = cbbConfig.SelectedItem.ToString();
                Properties.Settings.Default.Save();
            }
        }

        private NinePatchConfig GetSelectedNinPatchConfig()
        {
            if (cbbConfig.SelectedItem != null)
            {
                String SelectedConfig = cbbConfig.SelectedItem.ToString();
                if (NPConfigs.ContainsKey(SelectedConfig))
                {
                    return NPConfigs[SelectedConfig];
                }
            }

            return null;
        }

        private void lvImgs_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(GetRawPathFromListItem(lvImgs.SelectedItems[0]));
            }
            catch (Exception Excpt)
            { }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            String outputFolder = txtOutputFolder.Text;
            if (String.IsNullOrEmpty(outputFolder))
            {
                this.ShowErrorMsgBox("未指定输出目录!!!");
                return ;
            }

            NinePatchConfig config = GetSelectedNinPatchConfig();
            if (config == null)
            {
                this.ShowErrorMsgBox("请选择用于导出9Patch的配置");
                return ;
            }

            foreach (ListViewItem lvItem in lvImgs.Items)
            {
                String imgPath = GetRawPathFromListItem(lvItem);
                String outputPath = Path.GetDirectoryName(imgPath).Replace(txtRootPath.Text, txtOutputFolder.Text);
                outputPath = Path.Combine(outputPath, Path.GetFileNameWithoutExtension(imgPath) + ".9.png");
                NinePatchCreator creator = new NinePatchCreator(imgPath, outputPath);
                creator.Create(config);
            }
        }

        private void ShowErrorMsgBox(String Msg)
        {
            MessageBox.Show(Msg, "Error", MessageBoxButtons.OK);
        }

        private String GetRawPathFromListItem(ListViewItem lvItem)
        {
            if (lvItem == null) return "";
            return Path.Combine(lvItem.SubItems[1].Text, lvItem.Text);
        }

        private void btnSelectOutputFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.SelectedPath = Properties.Settings.Default.OutputFolder;
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    SetOutputFolder(folderDialog.SelectedPath);
                    Properties.Settings.Default.OutputFolder = folderDialog.SelectedPath;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void SetOutputFolder(String outputFolder)
        {
            txtOutputFolder.Text = outputFolder;
        }

    }
}
