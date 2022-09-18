using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_Events_and_Delegates
{
    public class VideoEncoder
    {
        // 1- Define a delegate
        // 2- Define an evnet based on that delegate
        // 3- Raise the event

        public delegate void VideoEncodedEventHandler(object source, EventArgs args);
        public event VideoEncodedEventHandler VideoEncoded;
        public void Encode(video video)
        {
            Console.WriteLine("Encoding Video.....");
            Thread.Sleep(3000);
        }

        protected virtual void onVideoEncoded()
        {
            if(VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
        }
    }
}
