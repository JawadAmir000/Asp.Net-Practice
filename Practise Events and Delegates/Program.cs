namespace Practise_Events_and_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); //publisher
            var mailSerice = new MailService(); // subscriber

            videoEncoder.VideoEncoded += mailSerice.onVideoEncoded;

            videoEncoder.Encode(video);
        }
    }

    public class MailService
    {
        public void onVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("MailService : Sending an Email");
        }
    }
}
