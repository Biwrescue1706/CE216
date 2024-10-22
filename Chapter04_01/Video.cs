using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04_01
{
    class Video
    {
        private string videoId; //หมายเลขวีดีโอ
        private string videoName; //ชื่อ
        private string videoSynopsis; //เรื่องย่อ
        private int videoTime; //ความยาว
        private string videoType; //ประเภท
        private int videoPrice; //ราคา
        private int rentDays; //วันที่ยืมได้

        public Video(string id, string name)
        {
            videoId = id;
            videoName = name;
        }
        public string GetVideoId()
        {
            return videoId;
        }
        public string GetVideoName()
        {
            return videoName;
        }
        public void PrinrtDetials()
        {
            Console.WriteLine();
        }
    }
}