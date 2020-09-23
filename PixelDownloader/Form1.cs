using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using VideoLibrary;
using System.IO;
using System.Net.Http;
using FFMpegCore;
using Xabe.FFmpeg.Downloader;
namespace PixelDownloader
{
    public partial class Form1 : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private YouTube youTube = YouTube.Default;
        private long totalbytes = 0;
        private long collectedbytes = 0;
        private string selectedVideoQality = "";
        private string selectedAudioQuality = "";
        public static string re = @"list=([A-z0-9-]+)(&|$)";
        public static Regex listreg = new Regex(re);
        public HashSet<string> listVidsIds = new HashSet<string>();
        public static string watchLink = "https://www.youtube.com/watch?v=";


        public Form1()
        {
            InitializeComponent();
            toppanelshadow.BackColor = Color.FromArgb(130, toppanelshadow.BackColor);
            Status.Text = "Waiting for link";
            FilePath.Text = Environment.CurrentDirectory;
    }

        private void Top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Close_MouseHover(object sender, EventArgs e)
        {
            Closebtn.BackColor = Color.Red;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Closebtn.BackColor = Topbtn.BackColor;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Top_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Top_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Top_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SelectFolder_Click(object sender, EventArgs e)
        {
            if (FolderDialog.ShowDialog() == DialogResult.OK)
                FilePath.Text = FolderDialog.SelectedPath + "\\";
        }

        private void SelectFolder_MouseHover(object sender, EventArgs e)
        {

        }
        
        private void Checkbtn_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                // Start the asynchronous operation.
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void Start_MouseHover(object sender, EventArgs e)
        {
            Start.BackColor = Color.Green;
            Start.ForeColor = label1.BackColor; ;
        }

        private void Start_MouseLeave(object sender, EventArgs e)
        {
            Start.BackColor = label1.BackColor;
            Start.ForeColor = label1.ForeColor;
        }
        private void VideoData(string link,bool playlist = false)
        {
            var video = youTube.GetAllVideos(link); // gets a Video object with info about the video
            var resolutions = video.Where(j => j.AdaptiveKind == AdaptiveKind.Video && j.Format == VideoFormat.Mp4).Select(j => j.Resolution);
            var bitRates = video.Where(j => j.AdaptiveKind == AdaptiveKind.Audio).Select(j => j.AudioBitrate);
            foreach (var val in resolutions)
                Quality.Invoke((MethodInvoker)(() => Quality.Items.Add(val)));
            foreach (var val in bitRates)
                AudioQuality.Invoke((MethodInvoker)(() => AudioQuality.Items.Add(val)));

            if (Quality.Items.Count>0)
            {
                Quality.Invoke((MethodInvoker)(() => Quality.Sorted = true));
                Quality.Invoke((MethodInvoker)(() => Quality.SelectedIndex = 0));
                AudioQuality.Invoke((MethodInvoker)(() => AudioQuality.Sorted = true));
                AudioQuality.Invoke((MethodInvoker)(() => AudioQuality.SelectedIndex = 0));
                Vid.Invoke((MethodInvoker)(() => Vid.Enabled = true));
                VidTitle.Invoke((MethodInvoker)(() => VidTitle.Text = video.ToList()[0].Title));
            }
            if (playlist)
                Status.Text = listVidsIds.Count + " Videos";
            else 
            Status.Text = "Single Video";

        }
        private void disableVid()
        {
            Quality.Invoke((MethodInvoker)(() => Quality.Items.Clear()));
            AudioQuality.Invoke((MethodInvoker)(() => AudioQuality.Items.Clear()));
            Vid.Invoke((MethodInvoker)(() => Vid.Enabled = false));
            Vid.Invoke((MethodInvoker)(() => VidTitle.Text = ""));
            selectedAudioQuality = "";
            selectedVideoQality = "";
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            listVidsIds.Clear();
            disableVid();
            Status.Text = "Checking your link";
            if (videoLink.Text == "")
            {
                disableVid();
                Status.Text = "Empty Box Detected";
            }
            else
                try{
                    Match m =listreg.Match(videoLink.Text);
                    if(m.Success)
                    {
                        string listId = m.Groups[1].Value;
                        using (var client = new WebClient())
                        {
                            var responseString = client.DownloadString(videoLink.Text);
                            string re2 = "\"videoId\":\"([A-z0-9-]+)\",\"playlistId\":\""+listId+"\"";
                            Regex listvids = new Regex(re2);
                            foreach  (Match ma in listvids.Matches(responseString))
                            {
                                listVidsIds.Add(ma.Groups[1].Value);
                            }
                            if (listVidsIds.Count>0)
                                VideoData(watchLink + listVidsIds.ElementAt(0), true);

                        }
                    }
                    else 
                        VideoData(videoLink.Text);
                }
                catch
                {
                    disableVid();
                    Status.Text = "Wrong link";
                }
        }
        private void barupdate(int val)
        {
            progressBar1.Value = val;

        }
       
        private string bytetobigger(long b)
        {
            string final;
            //to kb 
            float c = (float)b;
            c /= 1024;
            final = c.ToString("0.00") + " KB";
            if (c >= (float)1)
            {//to mb
                c /= 1024;
                final = c.ToString("0.00") + " MB";
            }
            else if (c >= (float)1) { 
                //to gb
                c /= 1024;
                final = c.ToString("0.00") + " GB";
            }
            return final;
        }
        private void fileDelete(string pa)
        {
            if (File.Exists(pa))
                File.Delete(pa);
        }
        private void Start_Click(object sender, EventArgs e)
        {

            if(Downloader_BackProcess.IsBusy!=true)
            {
                Downloader_BackProcess.RunWorkerAsync();
            }
        }

        async void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            totalbytes = 0;
            collectedbytes = 0;
            string audiomp4 = "Audio.mp4";
            string Audiomp3 = "Audio.mp3";
            string VideoFile = "Video.mp4";
            Status.Text = "Checking tools";

            async Task SourceDownloader(string name, YouTubeVideo vid)
            {
                var client = new HttpClient();
                long? totalByte = 0;
                using (Stream output = File.OpenWrite(name))
                {
                    using (var request = new HttpRequestMessage(HttpMethod.Head, vid.Uri))
                    {
                        totalByte = client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).Result.Content.Headers.ContentLength;
                    }
                    totalbytes += (long)totalByte;
                    using (var input = await client.GetStreamAsync(vid.Uri))
                    {
                        byte[] buffer = new byte[16 * 1024];
                        int read;
                        int totalRead = 0;

                        while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            output.Write(buffer, 0, read);
                            totalRead += read;
                            collectedbytes += read;
                            long x = collectedbytes * 100/ totalbytes;
                            Dataprogress.Text = bytetobigger(collectedbytes) + "/" + bytetobigger(totalbytes);
                            progressBar1.Invoke((MethodInvoker)(() => progressBar1.Value = (int)x)); 
                            
                            
                        }
                    }
                }
                client.Dispose();
            }
            await FFmpegDownloader.GetLatestVersion(FFmpegVersion.Full);
            async Task DownloadWork(string link,int playlist = -1)
            {
                if (playlist <0)
                    Status.Text = "Downloading ..";
                else
                    Status.Text = (playlist+1).ToString()+"/"+listVidsIds.Count.ToString();
                var video = youTube.GetAllVideos(link);
                var Targetaudio = video.Where(j => j.AdaptiveKind == AdaptiveKind.Audio && j.AudioBitrate.ToString() == selectedAudioQuality).Select(j => j);
                var TargetVideo = video.Where(j => j.AdaptiveKind == AdaptiveKind.Video && j.Format == VideoFormat.Mp4 && j.Resolution.ToString() == selectedVideoQality).Select(j => j);
                VidTitle.Invoke((MethodInvoker)(() => VidTitle.Text = video.ToList()[0].Title));
                Task au = SourceDownloader(audiomp4, Targetaudio.ToList()[0]);
                if (SoundOnly.Checked!=true)
                {
                    Task vide = SourceDownloader(VideoFile, TargetVideo.ToList()[0]);
                    await au;
                    FFMpeg.ExtractAudio(audiomp4, Audiomp3);
                    fileDelete(audiomp4);
                    await vide;
                    FFMpeg.ReplaceAudio(VideoFile, Audiomp3, FilePath.Text + TargetVideo.ToList()[0].FullName);
                    fileDelete(VideoFile);
                    fileDelete(Audiomp3);
                }
                else
                {
                    await au;
                    FFMpeg.ExtractAudio(audiomp4, FilePath.Text + TargetVideo.ToList()[0].Title+".mp3");
                    fileDelete(audiomp4);
                }
                
                if (playlist<0)
                    Status.Text = "Done. ";
                else 
                    Status.Text ="Done (" + (playlist+1).ToString() + "/" + listVidsIds.Count.ToString()+")";
                Dataprogress.Text = "";
            }
            if (listVidsIds.Count > 0)
            {
                for (int i = 0; i < listVidsIds.Count;i++)
                {
                    await DownloadWork(watchLink + listVidsIds.ElementAt(i), i);
                }
            }
            else
                await DownloadWork(videoLink.Text);
        }

        private void Quality_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedVideoQality = Quality.SelectedItem.ToString();
        }

        private void AudioQuality_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAudioQuality = AudioQuality.SelectedItem.ToString();
        }

        private void Vid_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
