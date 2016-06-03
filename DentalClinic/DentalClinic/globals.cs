using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DentalClinic
{
    class globals
    {
        /// <summary>
        /// Displays developer information in aboutbox
        /// </summary>
        /// <param name="targetDevName"></param>
        /// <param name="targetDevPosition"></param>
        /// <param name="targetDevPicture"></param>
        public static void displayDevInfo(Label targetDevName, Label targetDevPosition, PictureBox targetDevPicture)
        {
            if (targetDevName.Text.Contains("dev 1"))
            {
                targetDevName.Text = ProjResource.dev1Name;
                targetDevPosition.Text = ProjResource.dev1Position;
                targetDevPicture.Image = ProjResource.santiago;
            }
            else if (targetDevName.Text.Contains("dev 2"))
            {
                targetDevName.Text = ProjResource.dev2Name;
                targetDevPosition.Text = ProjResource.dev2Position;
                targetDevPicture.Image = ProjResource.benigno;
            }
            else if (targetDevName.Text.Contains("dev 3"))
            {
                targetDevName.Text = ProjResource.dev3Name;
                targetDevPosition.Text = ProjResource.dev3Position;
                targetDevPicture.Image = ProjResource.mandadero;
            }
            else if (targetDevName.Text.Contains("dev 4"))
            {
                targetDevName.Text = ProjResource.dev4Name;
                targetDevPosition.Text = ProjResource.dev4Position;
                targetDevPicture.Image = ProjResource.aloba;
            }
        }
    }
}
