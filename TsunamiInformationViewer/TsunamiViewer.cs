using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace TsunamiInformationViewer
{
    public partial class TsunamiViewer : Form
    {
        //親画面からアクセスできるプロパティを作る----
        private String _set;

        public String set
        {
            get
            {
                return _set;
            }
            set
            {
                _set = value;
            }
        }

        private String _set2;

        public String set2
        {
            get
            {
                return _set2;
            }
            set
            {
                _set2 = value;
            }
        }
        public TsunamiViewer()
        {
            InitializeComponent();
            timer2.Start();
            timer3.Start();
            timer4.Start();

        }
        private static readonly HttpClient HttpClient = new HttpClient();
        List<string> result = new List<string>();
        ListBox ristBox1 = new ListBox();
        ListBox ristBox2 = new ListBox();
        ListBox ristBox3 = new ListBox();
        ListBox ristBox4 = new ListBox();
        private async void timer1_TickAsync(object sender, EventArgs e)
        {
            string Uri = "http://www.jma.go.jp/jp/tsunami/info_03_20150918030005.html";

            try
            {
                //*津波の発生の原因の地震情報*//
                using (var client = new System.Net.WebClient())
                {
                    client.Encoding = Encoding.UTF8;
                    var html1 = client.DownloadString(Uri);
                    var document1 = new HtmlAgilityPack.HtmlDocument();
                    document1.LoadHtml(html1);

                    EqText.Text = document1.DocumentNode.SelectSingleNode(@"//*[@id=""TsunamiQuakeInfoTbl""]")?.InnerText
                        .Replace("&nbsp;&nbsp;&nbsp;", " ").Replace("：&nbsp;", "　　")
                        .Replace("地震の発生日時", "地震の発生日時：").Replace("震源地", "\r\n震源地：")
                        .Replace("マグニチュード", "\r\nマグニチュード：")
                        .Replace("深さ", "  深さ：").Replace("津波情報本文へ", "").Replace("大津波警報・津波警報・津波注意報本文へ", "")
                        .Replace("　　", " ").Replace("    ", "").ToString();
                }
            }

            catch { }

            // HTMLを取得
            var html = await HttpClient.GetStringAsync(Uri);
            var document = new HtmlAgilityPack.HtmlDocument();
            document.LoadHtml(html);

            // 要素を抽出
            var table = document.DocumentNode.SelectNodes("//div[@class='infotable']//tr").Skip(1);

            Console.Write("津波予報区名".PadRight(11, '　'));
            Console.Write("色コード" + ' ');
            Console.Write("津波到達予想時刻" + '　');
            Console.WriteLine("予想される津波の高さ");
            for (var i = 0; i < 69; i++) Console.Write('-');
            Console.WriteLine();
            ristBox1.Sorted = false;
            ristBox2.Sorted = false;
            ristBox3.Sorted = false;
            ristBox4.Sorted = false;
            foreach (var item in table)
            {

                // 色コード
                Console.Write(item.Attributes["bgcolor"].Value + '　');
                ristBox1.Items.Add(item.Attributes["bgcolor"].Value.Replace("#FF4719", "津波警報").Replace("#FAF500", "津波注意報"));
                // 津波予報区名
                Console.Write(item.SelectNodes("td").Take(1).First().InnerText);
                ristBox2.Items.Add(item.SelectNodes("td").Take(1).First().InnerText
                .Replace("オホーツク海沿岸", "オホーツク海沿岸　　").Replace("北海道太平洋沿岸東部", "北海道太平洋沿岸東部　")
                .Replace("北海道太平洋沿岸中部", "北海道太平洋沿岸中部　").Replace("北海道太平洋沿岸西部", "北海道太平洋沿岸西部　")
                .Replace("北海道日本海沿岸北部", "北海道日本海沿岸北部　").Replace("北海道日本海沿岸南部", "北海道日本海沿岸南部　")
                .Replace("青森県太平洋沿岸", "青森県太平洋沿岸　　　").Replace("青森県日本海沿岸", "青森県日本海沿岸　　　")
                .Replace("岩手県", "岩　手　県　　　　　　").Replace("宮城県", "宮　城　県　　　　　　")
                .Replace("福島県", "福　島　県　　　　　　").Replace("秋田県", "秋　田　県　　　　　　")
                .Replace("山形県", "山　形　県　　　　　　").Replace("茨城県", "茨　城　県　　　　　　")
                .Replace("千葉県九十九里・外房", "千葉県九十九里・外房　").Replace("千葉県内房", "千葉県内房　　　　　　")
                .Replace("東京湾内湾", "東京湾内湾　　　　　　")
                .Replace("伊豆諸島", "伊　豆　諸　島　　").Replace("小笠原諸島", "小笠原諸島　　　　　　")
                .Replace("静岡県", "静　岡　県　　　　　　").Replace("相模湾・三浦半島", "相模湾・三浦半島　　　")
                .Replace("愛知県外海", "愛知県外海　　　　　　").Replace("伊勢・三河湾", "伊勢・三河湾　　　　　")
                .Replace("三重県南部", "三重県南部　　　　　　").Replace("新潟県上中下越", "新潟県上中下越　　")
                .Replace("佐渡", "佐　　渡　　　　　　").Replace("富山県", "富　山　県　　　　　　　")
                .Replace("石川県能登", "石川県能登　　　　　　").Replace("石川県加賀", "石川県加賀　　　　　　")
                .Replace("福井県", "福　井　県　　　　　　").Replace("京都府", "京　都　府　　　　　　")
                .Replace("兵庫県北部", "兵庫県北部　　　　　　").Replace("兵庫県瀬戸内海沿岸", "兵庫県瀬戸内海沿岸　")
                .Replace("淡路島南部", "淡路島南部　　　　　　").Replace("大阪府", "大　阪　府　　　　　　")
                .Replace("和歌山県", "和歌山県　　　　　　　").Replace("鳥取県", "鳥　取　県　　　　　　")
                .Replace("島根県出雲・石見", "島根県出雲・石見　　").Replace("隠岐", "隠　　岐　　　　　　")
                .Replace("岡山県", "岡　山　県　　　　　　").Replace("岡山県", "岡　山　県　　　　　　")
                .Replace("広島県", "広　島　県　　　　　　").Replace("香川県", "香　川　県　　　　　　")
                .Replace("愛媛県瀬戸内海沿岸", "愛媛県瀬戸内海沿岸　").Replace("愛媛県宇和海沿岸", "愛媛県宇和海沿岸　　　")
                .Replace("徳島県", "徳　島　県　　　　　　").Replace("高知県", "高　知　県　　　　　　")
                .Replace("山口県瀬戸内海沿岸", "山口県瀬戸内海沿岸　").Replace("山口県日本海沿岸", "山口県日本海沿岸　　　")
                .Replace("福岡県瀬戸内海沿岸", "福岡県瀬戸内海沿岸　").Replace("福岡県日本海沿岸", "福岡県日本海沿岸　　　")
                .Replace("佐賀県北部", "佐賀県北部　　　　　　").Replace("長崎県西方", "長崎県西方　　　　　　")
                .Replace("壱岐・対馬", "壱岐・対馬　　　　　　").Replace("有明・八代海", "有明・八代海　　　　　　")
                .Replace("熊本県天草灘沿岸", "熊本県天草灘沿岸　　").Replace("大分県瀬戸内海沿岸", "大分県瀬戸内海沿岸　　")
                .Replace("大分県瀬戸内海沿岸", "大分県豊後水道沿岸　　").Replace("宮崎県", "宮　崎　県　　　　　　")
                .Replace("鹿児島県東部", "鹿児島県東部　").Replace("鹿児島県西部", "鹿児島県西部　　　　　")
                .Replace("種子島・屋久島地方", "種子島・屋久島地方　").Replace("奄美群島・トカラ列島", "奄美群島・トカラ列島　")
                .Replace("沖縄本島地方", "沖縄本島地方　　　　　　")
                .Replace("宮古島・八重山地方", "宮古島・八重山地方　").Replace("大東島地方", "大東島地方　　　　　　"));

                // 津波到達予想時刻
                Console.Write(item.SelectNodes("td").Skip(1).Take(1).First().InnerText + "　　　");
                ristBox3.Items.Add(item.SelectNodes("td").Skip(1).Take(1).First().InnerText.Replace("＃", "")
                    .Replace("第１波の到達を確認", "第1波到達").Replace("第２波の到達を確認", "第2波到達").Replace("第３波の到達を確認", "第3波到達")
                    .Replace("第４波の到達を確認", "第4波到達").Replace("第５波の到達を確認", "第5波到達").Replace("第６波の到達を確認", "第6波到達")
                    .Replace("津波到達中と推測", "到　達　中"));
                // 予想される津波の高さ
                Console.WriteLine(item.SelectNodes("td").Skip(2).Take(1).First().InnerText.Replace("&nbsp;", ""));
                ristBox4.Items.Add(item.SelectNodes("td").Skip(2).Take(1).First().InnerText.Replace("&nbsp;", ""));
            }

        }
    

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                timer4.Stop();
                //津波警報・注意報の種類
                type1.Text = "" + (string)ristBox1.Items[0].ToString();
                type2.Text = "" + (string)ristBox1.Items[1].ToString();
                type3.Text = "" + (string)ristBox1.Items[2].ToString();
                type4.Text = "" + (string)ristBox1.Items[3].ToString();
                type5.Text = "" + (string)ristBox1.Items[4].ToString();
                type6.Text = "" + (string)ristBox1.Items[5].ToString();
                //津波到達予想区
                location1.Text = "" + (string)ristBox2.Items[0].ToString();
                location2.Text = "" + (string)ristBox2.Items[1].ToString();
                location3.Text = "" + (string)ristBox2.Items[2].ToString();
                location4.Text = "" + (string)ristBox2.Items[3].ToString();
                location5.Text = "" + (string)ristBox2.Items[4].ToString();
                location6.Text = "" + (string)ristBox2.Items[5].ToString();

                //津波の到達時刻
                arrival_time1.Text = "" + (string)ristBox3.Items[0].ToString();
                arrival_time2.Text = "" + (string)ristBox3.Items[1].ToString();
                arrival_time3.Text = "" + (string)ristBox3.Items[2].ToString();
                arrival_time4.Text = "" + (string)ristBox3.Items[3].ToString();
                arrival_time5.Text = "" + (string)ristBox3.Items[4].ToString();
                arrival_time6.Text = "" + (string)ristBox3.Items[5].ToString();
                //津波の予想高さ
                height1.Text = "" + (string)ristBox4.Items[0].ToString();
                height2.Text = "" + (string)ristBox4.Items[1].ToString();
                height3.Text = "" + (string)ristBox4.Items[2].ToString();
                height4.Text = "" + (string)ristBox4.Items[3].ToString();
                height5.Text = "" + (string)ristBox4.Items[4].ToString();
                height6.Text = "" + (string)ristBox4.Items[5].ToString();

                if (type1.Text == "津波警報")
                {
                    type1.BackColor = Color.Red;
                }
                else if (type1.Text == "津波注意報")
                {
                    type1.BackColor = Color.Orange;
                }
                else
                {
                    type1.BackColor = Color.MediumOrchid;
                }

                if (type2.Text == "津波警報")
                {
                    type2.BackColor = Color.Red;
                }
                else if (type2.Text == "津波注意報")
                {
                    type2.BackColor = Color.Orange;
                }
                else
                {
                    type2.BackColor = Color.MediumOrchid;
                }

                if (type3.Text == "津波警報")
                {
                    type3.BackColor = Color.Red;
                }
                else if (type3.Text == "津波注意報")
                {
                    type3.BackColor = Color.Orange;
                }
                else
                {
                    type3.BackColor = Color.MediumOrchid;
                }

                if (type4.Text == "津波警報")
                {
                    type4.BackColor = Color.Red;
                }
                else if (type4.Text == "津波注意報")
                {
                    type4.BackColor = Color.Orange;
                }
                else
                {
                    type4.BackColor = Color.MediumOrchid;
                }

                if (type5.Text == "津波警報")
                {
                    type5.BackColor = Color.Red;
                }
                else if (type5.Text == "津波注意報")
                {
                    type5.BackColor = Color.Orange;
                }
                else
                {
                    type5.BackColor = Color.MediumOrchid;
                }

                if (type6.Text == "津波警報")
                {
                    type6.BackColor = Color.Red;
                }
                else if (type6.Text == "津波注意報")
                {
                    type6.BackColor = Color.Orange;
                }
                else
                {
                    type6.BackColor = Color.MediumOrchid;
                }
                
                timer3.Start();
            }
            catch {
            }
        }


        private void timer3_Tick(object sender, EventArgs e)
        {
            try
            {
                timer2.Stop();
                //津波警報・注意報の種類
                type1.Text = "" + (string)ristBox1.Items[6].ToString();
                type2.Text = "" + (string)ristBox1.Items[7].ToString();
                type3.Text = "" + (string)ristBox1.Items[8].ToString();
                type4.Text = "" + (string)ristBox1.Items[9].ToString();
                type5.Text = "" + (string)ristBox1.Items[10].ToString();
                type6.Text = "" + (string)ristBox1.Items[11].ToString();
                //津波到達予想区
                location1.Text = "" + (string)ristBox2.Items[6].ToString();
                location2.Text = "" + (string)ristBox2.Items[7].ToString();
                location3.Text = "" + (string)ristBox2.Items[8].ToString();
                location4.Text = "" + (string)ristBox2.Items[9].ToString();
                location5.Text = "" + (string)ristBox2.Items[10].ToString();
                location6.Text = "" + (string)ristBox2.Items[11].ToString();

                //津波の到達時刻
                arrival_time1.Text = "" + (string)ristBox3.Items[6].ToString();
                arrival_time2.Text = "" + (string)ristBox3.Items[7].ToString();
                arrival_time3.Text = "" + (string)ristBox3.Items[8].ToString();
                arrival_time4.Text = "" + (string)ristBox3.Items[9].ToString();
                arrival_time5.Text = "" + (string)ristBox3.Items[10].ToString();
                arrival_time6.Text = "" + (string)ristBox3.Items[11].ToString();
                //津波の予想高さ
                height1.Text = "" + (string)ristBox4.Items[6].ToString();
                height2.Text = "" + (string)ristBox4.Items[7].ToString();
                height3.Text = "" + (string)ristBox4.Items[8].ToString();
                height4.Text = "" + (string)ristBox4.Items[9].ToString();
                height5.Text = "" + (string)ristBox4.Items[10].ToString();
                height6.Text = "" + (string)ristBox4.Items[11].ToString();

                if (type1.Text == "津波警報")
                {
                    type1.BackColor = Color.Red;
                }
                else if (type1.Text == "津波注意報")
                {
                    type1.BackColor = Color.Orange;
                }
                else
                {
                    type1.BackColor = Color.MediumOrchid;
                }

                if (type2.Text == "津波警報")
                {
                    type2.BackColor = Color.Red;
                }
                else if (type2.Text == "津波注意報")
                {
                    type2.BackColor = Color.Orange;
                }
                else
                {
                    type2.BackColor = Color.MediumOrchid;
                }

                if (type3.Text == "津波警報")
                {
                    type3.BackColor = Color.Red;
                }
                else if (type3.Text == "津波注意報")
                {
                    type3.BackColor = Color.Orange;
                }
                else
                {
                    type3.BackColor = Color.MediumOrchid;
                }

                if (type4.Text == "津波警報")
                {
                    type4.BackColor = Color.Red;
                }
                else if (type4.Text == "津波注意報")
                {
                    type4.BackColor = Color.Orange;
                }
                else
                {
                    type4.BackColor = Color.MediumOrchid;
                }

                if (type5.Text == "津波警報")
                {
                    type5.BackColor = Color.Red;
                }
                else if (type5.Text == "津波注意報")
                {
                    type5.BackColor = Color.Orange;
                }
                else
                {
                    type5.BackColor = Color.MediumOrchid;
                }

                if (type6.Text == "津波警報")
                {
                    type6.BackColor = Color.Red;
                }
                else if (type6.Text == "津波注意報")
                {
                    type6.BackColor = Color.Orange;
                }
                else
                {
                    type6.BackColor = Color.MediumOrchid;
                }
                
                timer4.Start();
            }
            catch { }
        }

        private void type2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TsunamiViewer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //switch (panel1.Visible)
            //{
            //    case true:
            //        panel1.Visible = false;
            //        panel2.Visible = true;
            //        break;
            //    case false:

            //        break;
            //}
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            try
            {
                timer3.Stop();
                //津波警報・注意報の種類
                type1.Text = "" + (string)ristBox1.Items[12].ToString();
                type2.Text = "" + (string)ristBox1.Items[13].ToString();
                type3.Text = "" + (string)ristBox1.Items[14].ToString();
                type4.Text = "" + (string)ristBox1.Items[15].ToString();
                type5.Text = "" + (string)ristBox1.Items[16].ToString();
                type6.Text = "" + (string)ristBox1.Items[17].ToString();
                //津波到達予想区
                location1.Text = "" + (string)ristBox2.Items[12].ToString();
                location2.Text = "" + (string)ristBox2.Items[13].ToString();
                location3.Text = "" + (string)ristBox2.Items[14].ToString();
                location4.Text = "" + (string)ristBox2.Items[15].ToString();
                location5.Text = "" + (string)ristBox2.Items[16].ToString();
                location6.Text = "" + (string)ristBox2.Items[17].ToString();

                //津波の到達時刻
                arrival_time1.Text = "" + (string)ristBox3.Items[12].ToString();
                arrival_time2.Text = "" + (string)ristBox3.Items[13].ToString();
                arrival_time3.Text = "" + (string)ristBox3.Items[14].ToString();
                arrival_time4.Text = "" + (string)ristBox3.Items[15].ToString();
                arrival_time5.Text = "" + (string)ristBox3.Items[16].ToString();
                arrival_time6.Text = "" + (string)ristBox3.Items[17].ToString();
                //津波の予想高さ
                height1.Text = "" + (string)ristBox4.Items[12].ToString();
                height2.Text = "" + (string)ristBox4.Items[13].ToString();
                height3.Text = "" + (string)ristBox4.Items[14].ToString();
                height4.Text = "" + (string)ristBox4.Items[15].ToString();
                height5.Text = "" + (string)ristBox4.Items[16].ToString();
                height6.Text = "" + (string)ristBox4.Items[17].ToString();

                if (type1.Text == "津波警報")
                {
                    type1.BackColor = Color.Red;
                }
                else if (type1.Text == "津波注意報")
                {
                    type1.BackColor = Color.Orange;
                }
                else
                {
                    type1.BackColor = Color.MediumOrchid;
                }

                if (type2.Text == "津波警報")
                {
                    type2.BackColor = Color.Red;
                }
                else if (type2.Text == "津波注意報")
                {
                    type2.BackColor = Color.Orange;
                }
                else
                {
                    type2.BackColor = Color.MediumOrchid;
                }

                if (type3.Text == "津波警報")
                {
                    type3.BackColor = Color.Red;
                }
                else if (type3.Text == "津波注意報")
                {
                    type3.BackColor = Color.Orange;
                }
                else
                {
                    type3.BackColor = Color.MediumOrchid;
                }

                if (type4.Text == "津波警報")
                {
                    type4.BackColor = Color.Red;
                }
                else if (type4.Text == "津波注意報")
                {
                    type4.BackColor = Color.Orange;
                }
                else
                {
                    type4.BackColor = Color.MediumOrchid;
                }

                if (type5.Text == "津波警報")
                {
                    type5.BackColor = Color.Red;
                }
                else if (type5.Text == "津波注意報")
                {
                    type5.BackColor = Color.Orange;
                }
                else
                {
                    type5.BackColor = Color.MediumOrchid;
                }

                if (type6.Text == "津波警報")
                {
                    type6.BackColor = Color.Red;
                }
                else if (type6.Text == "津波注意報")
                {
                    type6.BackColor = Color.Orange;
                }
                else
                {
                    type6.BackColor = Color.MediumOrchid;
                }
                timer2.Start();
            }
            catch { }
        }

        private void message_timer1_Tick(object sender, EventArgs e)
        {
            label1.Visible = true;

        }

        private void message_timer2_Tick(object sender, EventArgs e)
        {
            label1.Visible = true;

        }
    }
}