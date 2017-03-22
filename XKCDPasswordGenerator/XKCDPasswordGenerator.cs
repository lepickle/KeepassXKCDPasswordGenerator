using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

using KeePass.Plugins;

namespace XKCDPasswordGenerator
{
    public sealed class XKCDPasswordGeneratorExt : Plugin
    {
        private IPluginHost m_host = null;
        private ToolStripSeparator m_tsSeparator = null;
        private ToolStripMenuItem m_tsmiMenuItem = null;
        private Generator m_gen = null;

        public override bool Initialize(IPluginHost host)
        {
            
            m_host = host;
            m_gen = new Generator();
            //ToolStripItemCollection tsMenu = m_host.MainWindow.ToolsMenu.DropDownItems;

            //// Add a separator at the bottom
            //m_tsSeparator = new ToolStripSeparator();
            //tsMenu.Add(m_tsSeparator);

            //// Add menu item 'Do Something'
            //m_tsmiMenuItem = new ToolStripMenuItem();
            //m_tsmiMenuItem.Text = "Do Something";
            //m_tsmiMenuItem.Click += this.OnMenuDoSomething;
            //tsMenu.Add(m_tsmiMenuItem);
            m_host.PwGeneratorPool.Add(m_gen);
            return true;
            //return base.Initialize(host);
        }

        public override void Terminate()
        {
            ToolStripItemCollection tsMenu = m_host.MainWindow.ToolsMenu.DropDownItems;
            m_tsmiMenuItem.Click -= this.OnMenuDoSomething;
            tsMenu.Remove(m_tsmiMenuItem);
            tsMenu.Remove(m_tsSeparator);
            //base.Terminate();
        }

        private void OnMenuDoSomething(object sender, EventArgs e)
        {
            // Called when the menu item is clicked
        }
    }
}
