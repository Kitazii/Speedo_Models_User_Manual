using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_User_Manual
{
    /// <summary>
    /// Author: Kieran Burns
    /// Date Finalized: 05/06/2024
    /// </summary>
    public interface IMedia
    {
        void InitializeVLC(); //Initializes the VLC component
        void InititalizeSpecificVideo(string title, string videoFileName); //Initializes specific video
    }
}
