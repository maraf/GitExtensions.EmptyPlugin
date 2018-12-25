using GitUIPluginInterfaces;
using ResourceManager;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitExtensions.BundleBackuper
{
    [Export(typeof(IGitPlugin))]
    public class Plugin : GitPluginBase
    {
        public Plugin()
        {
            Name = "EmptyPlugin";
            Description = "Empty Plugin";
        }

        public override bool Execute(GitUIEventArgs gitUiCommands)
        {
            MessageBox.Show("Hello from Empty Plugin.");
            return true;
        }
    }
}
