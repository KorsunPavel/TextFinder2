using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextFinder.Properties;

namespace TextFinder.Controller {
    class Scarry {
        public EventHandler<LogTextEventArgs> scarryEventHandler;

        public bool ScarryMyFriends() {

            var ressourceList = Assembly.GetExecutingAssembly().GetManifestResourceNames();
            var resource = ressourceList.Where(x => x.Contains("Properties")).First().Replace(".resources","");
            
            var assembly = Assembly.GetExecutingAssembly();
            var resourceManager = new ResourceManager(resource, assembly);
            var resourceName = "scarry_sound";

            try
            {
                using (Stream resourceStream = resourceManager.GetStream(resourceName))
                {
                    using (SoundPlayer player = new SoundPlayer(resourceStream))
                    {
                        player.Play();
                    }
                }
            }
            catch {}
            FormScarry frm2 = new FormScarry();
            frm2.Show();

            scarryEventHandler(this, new LogTextEventArgs(Resources.SorryMessage, fontColor: Color.LightGreen));
            return false;
        }
    }
}
