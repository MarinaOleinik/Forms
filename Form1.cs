using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form1 : Form
    {
        TreeView tree;
        Button btn;
        public Form1()
        {
            this.Height = 500;
            this.Width = 600;
            this.Text = "Vorm elementidega";
            tree = new TreeView();
            tree.Dock = DockStyle.Left;
            tree.AfterSelect += Tree_AfterSelect;
            TreeNode tn = new TreeNode("Elemendid");
            tn.Nodes.Add(new TreeNode("Nupp-Button"));

            tree.Nodes.Add(tn);
            this.Controls.Add(tree);
        }

        private void Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text=="Nupp-Button")
            {
                btn = new Button();
                btn.Text = "Vajuta siia";
                btn.Location = new Point(200, 100);
                btn.Height = 40;
                btn.Width = 120;
                btn.Click += Btn_Click;
                this.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (btn.BackColor == Color.Blue)
            {
                btn.BackColor = Color.Red;
            }
            else
            {
                btn.BackColor = Color.Blue;
            }
        }
    }
}
