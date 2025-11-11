using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraRental.Models
{
    public static class DriverCameraKit
    {
        public static void Run()
        {
            CameraKit cameraKit = new CameraKit("Canon","Model1",230.33);
           
            cameraKit.Display();
        }
    }
}
