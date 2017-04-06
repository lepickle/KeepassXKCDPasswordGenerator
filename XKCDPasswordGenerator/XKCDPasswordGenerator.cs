using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

using KeePass.Plugins;
using KeePassLib.Cryptography;
using KeePassLib.Cryptography.PasswordGenerator;
using KeePassLib.Security;

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
            if (host == null) return false;
            m_host = host;

            m_gen = new Generator();
            m_host.PwGeneratorPool.Add(m_gen);

            return true;
        }


        public override void Terminate()
        {
            if (m_host != null)
            {
                m_host.PwGeneratorPool.Remove(m_gen.Uuid);
                m_gen = null;
                m_host = null;
            }
        }
    }
}
