namespace FileBrowser
{
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

    public partial class HackFileBrowser : Form
    {
        private readonly DirectoryInfo root = new DirectoryInfo(@"C:\Users\Viktor\Desktop\GitHub\HackBulgaria-CSharp");

        private string currentDir;

        public HackFileBrowser()
        {
            InitializeComponent();
        }

        private void HackFileBrowser_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(this.root.FullName))
            {
                try
                {
                    DirectoryInfo info = new DirectoryInfo(this.root.FullName);
                    if (!info.Exists)
                    {
                        return;
                    }

                    var rootNode = new TreeNode(info.Name) { Tag = info };
                    GetDirectories(info.GetDirectories(), rootNode);
                    this.treeView1.Nodes.Add(rootNode);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private static void GetDirectories(IEnumerable<DirectoryInfo> subDirs,
   TreeNode nodeToAddTo)
        {
            foreach (DirectoryInfo subDir in subDirs)
            {
                var aNode = new TreeNode(subDir.Name, 0, 0) { Tag = subDir, ImageIndex = 0 };
                var subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }

                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            this.OpenFolder((DirectoryInfo)newSelected.Tag);
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            var item = (sender as ListView).SelectedItems[0];
            if (item.Tag == "File")
            {
                System.Diagnostics.Process.Start(Path.Combine(this.currentDir, item.Text));
            }
            else if (item.Tag == "Directory")
            {
                OpenFolder(new DirectoryInfo(Path.Combine(this.currentDir, item.Text)));
            }
        }

        private void OpenFolder(DirectoryInfo folder)
        {
            listView1.Items.Clear();
            DirectoryInfo nodeDirInfo = folder;
            this.currentDir = nodeDirInfo.FullName;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
                          {new ListViewItem.ListViewSubItem(item, "Directory"),
                   new ListViewItem.ListViewSubItem(item,
                dir.LastAccessTime.ToShortDateString())};
                item.Tag = "Directory";
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }

            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name, 1);
                subItems = new ListViewItem.ListViewSubItem[]
                          { new ListViewItem.ListViewSubItem(item, "File"),
                   new ListViewItem.ListViewSubItem(item,
                file.LastAccessTime.ToShortDateString())};
                item.Tag = "File";

                item.ImageIndex = 1;
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }
        }
    }
}
