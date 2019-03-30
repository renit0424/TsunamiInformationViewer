using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TsunamiInformationViewer
{
    public partial class Form1 : Form
    {
        public string text_URL = "";

        public string ccc = "";

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TsunamiViewer tsunamiViewer = new TsunamiViewer();
            tsunamiViewer.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //TsunamiViewer tsunamiViewer = new TsunamiViewer(this);

            //try
            //{
            //    //*津波の発生の原因の地震情報*//
            //    using (var client = new System.Net.WebClient())
            //    {
            //        client.Encoding = Encoding.UTF8;
            //        var html1 = client.DownloadString(textBox_URL.Text);
            //        var document1 = new HtmlAgilityPack.HtmlDocument();
            //        document1.LoadHtml(html1);

            //        tsunamilist3 = document1.DocumentNode.SelectSingleNode(@"//*[@id=""TsunamiQuakeInfoTbl""]")?.InnerText
            //            .Replace("&nbsp;&nbsp;&nbsp;", " ").Replace("：&nbsp;", "　　")
            //            .Replace("地震の発生日時", "地震の発生日時：").Replace("震源地", "\r\n震源地：")
            //            .Replace("マグニチュード", "\r\nマグニチュード：")
            //            .Replace("深さ", "  深さ：").Replace("津波情報本文へ", "").Replace("大津波警報・津波警報・津波注意報本文へ", "")
            //            .Replace("　　", " ").Replace("    ", "").ToString();


            //    }
            //    tsunamiViewer.set = tsunamilist3.ToString();
            //}

            //catch { }
            //try
            //{
            //    // HTMLを取得
            //    var html = await HttpClient.GetStringAsync(textBox_URL.Text);
            //    var document = new HtmlAgilityPack.HtmlDocument();
            //    document.LoadHtml(html);

            //    // 要素を抽出
            //    var table = document.DocumentNode.SelectNodes("//div[@class='infotable']//tr").Skip(1);

            //    Console.Write("津波予報区名".PadRight(11, '　'));
            //    Console.Write("色コード" + ' ');
            //    Console.Write("津波到達予想時刻" + '　');
            //    Console.WriteLine("予想される津波の高さ");
            //    for (var i = 0; i < 69; i++) Console.Write('-');
            //    Console.WriteLine();
            //    foreach (var item in table)
            //    {
            //        // 津波予報区名
            //        Console.Write(item.SelectNodes("td").Take(1).First().InnerText.PadRight(11, '　'));
            //        dataGridView1.Rows.Add(item.SelectNodes("td").Take(1).First().InnerText
            //                .Replace("オホーツク海沿岸", "オホーツク海沿岸　　").Replace("北海道太平洋沿岸東部", "北海道太平洋沿岸東部　")
            //                .Replace("北海道太平洋沿岸中部", "北海道太平洋沿岸中部　").Replace("北海道太平洋沿岸西部", "北海道太平洋沿岸西部　")
            //                .Replace("北海道日本海沿岸北部", "北海道日本海沿岸北部　").Replace("北海道日本海沿岸南部", "北海道日本海沿岸南部　")
            //                .Replace("青森県太平洋沿岸", "青森県太平洋沿岸　　　").Replace("青森県日本海沿岸", "青森県日本海沿岸　　　")
            //                .Replace("岩手県", "岩　手　県　　　　　　").Replace("宮城県", "宮　城　県　　　　　　")
            //                .Replace("福島県", "福　島　県　　　　　　").Replace("秋田県", "秋　田　県　　　　　　")
            //                .Replace("山形県", "山　形　県　　　　　　").Replace("茨城県", "茨　城　県　　　　　　")
            //                .Replace("千葉県九十九里・外房", "千葉県九十九里・外房　").Replace("千葉県内房", "千葉県内房　　　　　　")
            //                .Replace("東京湾内湾", "東京湾内湾　　　　　　")
            //                .Replace("伊豆諸島", "伊　豆　諸　島　　").Replace("小笠原諸島", "小笠原諸島　　　　　　")
            //                .Replace("静岡県", "静　岡　県　　　　　　").Replace("相模湾・三浦半島", "相模湾・三浦半島　　　")
            //                .Replace("愛知県外海", "愛知県外海　　　　　　").Replace("伊勢・三河湾", "伊勢・三河湾　　　　　")
            //                .Replace("三重県南部", "三重県南部　　　　　　").Replace("新潟県上中下越", "新潟県上中下越　　")
            //                .Replace("佐渡", "佐　　渡　　　　　　").Replace("富山県", "富　山　県　　　　　　　")
            //                .Replace("石川県能登", "石川県能登　　　　　　").Replace("石川県加賀", "石川県加賀　　　　　　")
            //                .Replace("福井県", "福　井　県　　　　　　").Replace("京都府", "京　都　府　　　　　　")
            //                .Replace("兵庫県北部", "兵庫県北部　　　　　　").Replace("兵庫県瀬戸内海沿岸", "兵庫県瀬戸内海沿岸　")
            //                .Replace("淡路島南部", "淡路島南部　　　　　　").Replace("大阪府", "大　阪　府　　　　　　")
            //                .Replace("和歌山県", "和歌山県　　　　　　　").Replace("鳥取県", "鳥　取　県　　　　　　")
            //                .Replace("島根県出雲・石見", "島根県出雲・石見　　").Replace("隠岐", "隠　　岐　　　　　　")
            //                .Replace("岡山県", "岡　山　県　　　　　　").Replace("岡山県", "岡　山　県　　　　　　")
            //                .Replace("広島県", "広　島　県　　　　　　").Replace("香川県", "香　川　県　　　　　　")
            //                .Replace("愛媛県瀬戸内海沿岸", "愛媛県瀬戸内海沿岸　").Replace("愛媛県宇和海沿岸", "愛媛県宇和海沿岸　　　")
            //                .Replace("徳島県", "徳　島　県　　　　　　").Replace("高知県", "高　知　県　　　　　　")
            //                .Replace("山口県瀬戸内海沿岸", "山口県瀬戸内海沿岸　").Replace("山口県日本海沿岸", "山口県日本海沿岸　　　")
            //                .Replace("福岡県瀬戸内海沿岸", "福岡県瀬戸内海沿岸　").Replace("福岡県日本海沿岸", "福岡県日本海沿岸　　　")
            //                .Replace("佐賀県北部", "佐賀県北部　　　　　　").Replace("長崎県西方", "長崎県西方　　　　　　")
            //                .Replace("壱岐・対馬", "壱岐・対馬　　　　　　").Replace("有明・八代海", "有明・八代海　　　　　　")
            //                .Replace("熊本県天草灘沿岸", "熊本県天草灘沿岸　　").Replace("大分県瀬戸内海沿岸", "大分県瀬戸内海沿岸　　")
            //                .Replace("大分県瀬戸内海沿岸", "大分県豊後水道沿岸　　").Replace("宮崎県", "宮　崎　県　　　　　　")
            //                .Replace("鹿児島県東部", "鹿児島県東部　").Replace("鹿児島県西部", "鹿児島県西部　　　　　")
            //                .Replace("種子島・屋久島地方", "種子島・屋久島地方　").Replace("奄美群島・トカラ列島", "奄美群島・トカラ列島　")
            //                .Replace("沖縄本島地方", "沖縄本島地方　　　　　　")
            //                .Replace("宮古島・八重山地方", "宮古島・八重山地方　").Replace("大東島地方", "大東島地方　　　　　　"),
            //        (item.Attributes["bgcolor"].Value.Replace("#FF4719", "津波警報").Replace("#FAF500", "津波注意報")));
            //        // 色コード
            //        Console.Write(item.Attributes["bgcolor"].Value + '　');



            //        // 津波到達予想時刻
            //        Console.Write(item.SelectNodes("td").Skip(1).Take(1).First().InnerText + "　　　");
            //        listBox3.Items.Add(item.SelectNodes("td").Skip(1).Take(1).First().InnerText);
            //        // 予想される津波の高さ
            //        Console.WriteLine(item.SelectNodes("td").Skip(2).Take(1).First().InnerText.Replace("&nbsp;", ""));
            //        listBox4.Items.Add(item.SelectNodes("td").Skip(2).Take(1).First().InnerText.Replace("&nbsp;", ""));


            //        //tsunamiViewer.tsunami2 = (string)listBox2.Items[1];

            //        //tsunamiViewer.tsunami3 = (string)listBox2.Items[2];


            //    }

            //}
            //catch { }

            //try
            //{
            //    using (var client = new System.Net.WebClient())
            //    {
            //        client.Encoding = Encoding.UTF8;
            //        var html1 = client.DownloadString(Uri);
            //        var document4 = new HtmlAgilityPack.HtmlDocument();
            //        document4.LoadHtml(html1);
            //        var tsunamilist4 = document4.DocumentNode.SelectSingleNode(@"//*[@id=""info""]/div/table")?.InnerText
            //            .Replace("津波予報区名津波到達予想時刻予想される津波の高さ", "")
            //            .Replace("津波予報区名大津波警報・津波警報・津波注意報グレード", "")
            //            .Replace("＃津波到達中と推測", "＃津波到達中と推測　")
            //            .Replace("大津波警報", "　　大津波警報").Replace("津波警報", "   津波警報").Replace("津波注意報", "   津波注意報")
            //            .Replace("オホーツク海沿岸", "オホーツク海沿岸　　").Replace("北海道太平洋沿岸東部", "北海道太平洋沿岸東部　")
            //            .Replace("北海道太平洋沿岸中部", "北海道太平洋沿岸中部　").Replace("北海道太平洋沿岸西部", "北海道太平洋沿岸西部　")
            //            .Replace("北海道日本海沿岸北部", "北海道日本海沿岸北部　").Replace("北海道日本海沿岸南部", "北海道日本海沿岸南部　")
            //            .Replace("青森県太平洋沿岸", "青森県太平洋沿岸　　　").Replace("青森県日本海沿岸", "青森県日本海沿岸　　　")
            //            .Replace("岩手県", "岩　手　県　　　　　　").Replace("宮城県", "宮　城　県　　　　　　")
            //            .Replace("福島県", "福　島　県　　　　　　").Replace("秋田県", "秋　田　県　　　　　　")
            //            .Replace("山形県", "山　形　県　　　　　　").Replace("茨城県", "茨　城　県　　　　　　")
            //            .Replace("千葉県九十九里・外房", "千葉県九十九里・外房　").Replace("千葉県内房", "千葉県内房　　　　　　")
            //            .Replace("東京湾内湾", "東京湾内湾　　　　　　")
            //            .Replace("伊豆諸島", "伊　豆　諸　島　　").Replace("小笠原諸島", "小笠原諸島　　　　　　")
            //            .Replace("静岡県", "静　岡　県　　　　　　").Replace("相模湾・三浦半島", "相模湾・三浦半島　　　")
            //            .Replace("愛知県外海", "愛知県外海　　　　　　").Replace("伊勢・三河湾", "伊勢・三河湾　　　　　")
            //            .Replace("三重県南部", "三重県南部　　　　　　").Replace("新潟県上中下越", "新潟県上中下越　　")
            //            .Replace("佐渡", "佐　　渡　　　　　　").Replace("富山県", "富　山　県　　　　　　　")
            //            .Replace("石川県能登", "石川県能登　　　　　　").Replace("石川県加賀", "石川県加賀　　　　　　")
            //            .Replace("福井県", "福　井　県　　　　　　").Replace("京都府", "京　都　府　　　　　　")
            //            .Replace("兵庫県北部", "兵庫県北部　　　　　　").Replace("兵庫県瀬戸内海沿岸", "兵庫県瀬戸内海沿岸　")
            //            .Replace("淡路島南部", "淡路島南部　　　　　　").Replace("大阪府", "大　阪　府　　　　　　")
            //            .Replace("和歌山県", "和歌山県　　　　　　　").Replace("鳥取県", "鳥　取　県　　　　　　")
            //            .Replace("島根県出雲・石見", "島根県出雲・石見　　").Replace("隠岐", "隠　　岐　　　　　　")
            //            .Replace("岡山県", "岡　山　県　　　　　　").Replace("岡山県", "岡　山　県　　　　　　")
            //            .Replace("広島県", "広　島　県　　　　　　").Replace("香川県", "香　川　県　　　　　　")
            //            .Replace("愛媛県瀬戸内海沿岸", "愛媛県瀬戸内海沿岸　").Replace("愛媛県宇和海沿岸", "愛媛県宇和海沿岸　　　")
            //            .Replace("徳島県", "徳　島　県　　　　　　").Replace("高知県", "高　知　県　　　　　　")
            //            .Replace("山口県瀬戸内海沿岸", "山口県瀬戸内海沿岸　").Replace("山口県日本海沿岸", "山口県日本海沿岸　　　")
            //            .Replace("福岡県瀬戸内海沿岸", "福岡県瀬戸内海沿岸　").Replace("福岡県日本海沿岸", "福岡県日本海沿岸　　　")
            //            .Replace("佐賀県北部", "佐賀県北部　　　　　　").Replace("長崎県西方", "長崎県西方　　　　　　")
            //            .Replace("壱岐・対馬", "壱岐・対馬　　　　　　").Replace("有明・八代海", "有明・八代海　　　　　　")
            //            .Replace("熊本県天草灘沿岸", "熊本県天草灘沿岸　　").Replace("大分県瀬戸内海沿岸", "大分県瀬戸内海沿岸　　")
            //            .Replace("大分県瀬戸内海沿岸", "大分県豊後水道沿岸　　").Replace("宮崎県", "宮　崎　県　　　　　　")
            //            .Replace("鹿児島県東部", "鹿児島県東部　").Replace("鹿児島県西部", "鹿児島県西部　　　　　")
            //            .Replace("種子島・屋久島地方", "種子島・屋久島地方　").Replace("奄美群島・トカラ列島", "奄美群島・トカラ列島　")
            //            .Replace("沖縄本島地方", "沖縄本島地方　　　　　　")
            //            .Replace("宮古島・八重山地方", "宮古島・八重山地方　").Replace("大東島地方", "大東島地方　　　　　　")
            //            .Replace("&nbsp;＃&nbsp;", "　　").Replace("&nbsp;&nbsp;&nbsp;", "　　").Replace("m", "m\r\n").ToString();
            //        string[] separator = new string[] { "\r\n" };
            //        string[] splitted = tsunamilist4.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            //        foreach (var s in splitted)
            //        {
            //            listBox2.Items.Add(s);
            //            string adress = (string)listBox1.Items[1];
            //            tsunamiViewer.tsunami1 = adress;
            //        }
            //        // ここで実行を停止する。
            //        foreach (var s in splitted)
            //        {
            //            Console.WriteLine(s + "\r\n");
            //        }
            //    }
            //}
            //catch
            //{

            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //        // HTMLを取得
            //        var html = await HttpClient.GetStringAsync(Uri);
            //        var document = new HtmlAgilityPack.HtmlDocument();
            //        document.LoadHtml(html);

            //        // 要素を抽出
            //        var table = document.DocumentNode.SelectNodes("//div[@class='infotable']//tr").Skip(1);

            //        Console.Write("津波予報区名".PadRight(11, '　'));
            //        Console.Write("色コード" + ' ');
            //        Console.Write("津波到達予想時刻" + '　');
            //        Console.WriteLine("予想される津波の高さ");
            //        for (var i = 0; i < 69; i++) Console.Write('-');
            //        Console.WriteLine();

            //        TsunamiViewer tsunamiViewer = new TsunamiViewer(this);
            //        foreach (var item in table)
            //        {
            //            string[] aaaaa = new string[7];
            //            string[] aaaaab = new string[1];
            //            string[] aaaaac = new string[1];
            //            string[] aaaaad = new string[1];
            //            // 津波予報区名
            //            //Console.WriteLine(item.SelectNodes("td").Take(1).First().InnerText);
            //            //result.Add(item.Attributes["bgcolor"].Value.Replace("#FF4719", "津波警報").Replace("#FAF500", "津波注意報"));
            //            aaaaa[2] = (item.Attributes["bgcolor"].Value.Replace("#FF4719", "津波警報").Replace("#FAF500", "津波注意報")+"\r\n");

            //            // 津波到達予想時刻
            //            //Console.Write(item.SelectNodes("td").Skip(1).Take(1).First().InnerText + "　　　");
            //            aaaaab[0] = (item.SelectNodes("td").Skip(1).Take(1).First().InnerText.Replace("＃", "")
            //                .Replace("第１波の到達を確認", "第1波到達").Replace("第２波の到達を確認", "第2波到達").Replace("第３波の到達を確認", "第3波到達")
            //                .Replace("第４波の到達を確認", "第4波到達").Replace("第５波の到達を確認", "第5波到達").Replace("第６波の到達を確認", "第6波到達")
            //                .Replace("津波到達中と推測", "到　達　中"));
            //            // 予想される津波の高さ
            //            // Console.WriteLine(item.SelectNodes("td").Skip(2).Take(1).First().InnerText.Replace("&nbsp;", ""));
            //            aaaaad[0] = (item.SelectNodes("td").Skip(2).Take(1).First().InnerText.Replace("&nbsp;", "") + "\r\n");

            //            //int i = listBox1.Items.Count;
            //            //count1.Text = i.ToString();
            //            aaaaac[0] = (item.SelectNodes("td").Take(1).First().InnerText
            //.Replace("オホーツク海沿岸", "オホーツク海沿岸　　").Replace("北海道太平洋沿岸東部", "北海道太平洋沿岸東部　")
            //.Replace("北海道太平洋沿岸中部", "北海道太平洋沿岸中部　").Replace("北海道太平洋沿岸西部", "北海道太平洋沿岸西部　")
            //.Replace("北海道日本海沿岸北部", "北海道日本海沿岸北部　").Replace("北海道日本海沿岸南部", "北海道日本海沿岸南部　")
            //.Replace("青森県太平洋沿岸", "青森県太平洋沿岸　　　").Replace("青森県日本海沿岸", "青森県日本海沿岸　　　")
            //.Replace("岩手県", "岩　手　県　　　　　　").Replace("宮城県", "宮　城　県　　　　　　")
            //.Replace("福島県", "福　島　県　　　　　　").Replace("秋田県", "秋　田　県　　　　　　")
            //.Replace("山形県", "山　形　県　　　　　　").Replace("茨城県", "茨　城　県　　　　　　")
            //.Replace("千葉県九十九里・外房", "千葉県九十九里・外房　").Replace("千葉県内房", "千葉県内房　　　　　　")
            //.Replace("東京湾内湾", "東京湾内湾　　　　　　")
            //.Replace("伊豆諸島", "伊　豆　諸　島　　").Replace("小笠原諸島", "小笠原諸島　　　　　　")
            //.Replace("静岡県", "静　岡　県　　　　　　").Replace("相模湾・三浦半島", "相模湾・三浦半島　　　")
            //.Replace("愛知県外海", "愛知県外海　　　　　　").Replace("伊勢・三河湾", "伊勢・三河湾　　　　　")
            //.Replace("三重県南部", "三重県南部　　　　　　").Replace("新潟県上中下越", "新潟県上中下越　　")
            //.Replace("佐渡", "佐　　渡　　　　　　").Replace("富山県", "富　山　県　　　　　　　")
            //.Replace("石川県能登", "石川県能登　　　　　　").Replace("石川県加賀", "石川県加賀　　　　　　")
            //.Replace("福井県", "福　井　県　　　　　　").Replace("京都府", "京　都　府　　　　　　")
            //.Replace("兵庫県北部", "兵庫県北部　　　　　　").Replace("兵庫県瀬戸内海沿岸", "兵庫県瀬戸内海沿岸　")
            //.Replace("淡路島南部", "淡路島南部　　　　　　").Replace("大阪府", "大　阪　府　　　　　　")
            //.Replace("和歌山県", "和歌山県　　　　　　　").Replace("鳥取県", "鳥　取　県　　　　　　")
            //.Replace("島根県出雲・石見", "島根県出雲・石見　　").Replace("隠岐", "隠　　岐　　　　　　")
            //.Replace("岡山県", "岡　山　県　　　　　　").Replace("岡山県", "岡　山　県　　　　　　")
            //.Replace("広島県", "広　島　県　　　　　　").Replace("香川県", "香　川　県　　　　　　")
            //.Replace("愛媛県瀬戸内海沿岸", "愛媛県瀬戸内海沿岸　").Replace("愛媛県宇和海沿岸", "愛媛県宇和海沿岸　　　")
            //.Replace("徳島県", "徳　島　県　　　　　　").Replace("高知県", "高　知　県　　　　　　")
            //.Replace("山口県瀬戸内海沿岸", "山口県瀬戸内海沿岸　").Replace("山口県日本海沿岸", "山口県日本海沿岸　　　")
            //.Replace("福岡県瀬戸内海沿岸", "福岡県瀬戸内海沿岸　").Replace("福岡県日本海沿岸", "福岡県日本海沿岸　　　")
            //.Replace("佐賀県北部", "佐賀県北部　　　　　　").Replace("長崎県西方", "長崎県西方　　　　　　")
            //.Replace("壱岐・対馬", "壱岐・対馬　　　　　　").Replace("有明・八代海", "有明・八代海　　　　　　")
            //.Replace("熊本県天草灘沿岸", "熊本県天草灘沿岸　　").Replace("大分県瀬戸内海沿岸", "大分県瀬戸内海沿岸　　")
            //.Replace("大分県瀬戸内海沿岸", "大分県豊後水道沿岸　　").Replace("宮崎県", "宮　崎　県　　　　　　")
            //.Replace("鹿児島県東部", "鹿児島県東部　").Replace("鹿児島県西部", "鹿児島県西部　　　　　")
            //.Replace("種子島・屋久島地方", "種子島・屋久島地方　").Replace("奄美群島・トカラ列島", "奄美群島・トカラ列島　")
            //.Replace("沖縄本島地方", "沖縄本島地方　　　　　　")
            //.Replace("宮古島・八重山地方", "宮古島・八重山地方　").Replace("大東島地方", "大東島地方　　　　　　")+"\r\n");
            //            List<string> vlist = new List<string>(aaaaa);
            //            foreach (string fff in vlist)
            //            {
            //                ccc += (string)fff;
            //                textBox1.Text += fff;
            //            }
            //        }
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            using (Setting setting = new Setting())
            {
                // プロパティに値を設定して子フォームを開く
                setting.InputText = this.text_URL;
                setting.ShowDialog(this);

                // 子フォームで設定されたプロパティから値を反映する
                this.text_URL = setting.InputText;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            TsunamiViewer tsunamiViewer = new TsunamiViewer();
            tsunamiViewer.label1.Visible = true;
            tsunamiViewer.label1.Text = "fdkjfs";
            if(radioButton1.Checked == true)
            {
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                tsunamiViewer.label1.Visible = false;
                tsunamiViewer.message_timer1.Stop();
                tsunamiViewer.message_timer2.Stop();
            }
            else
            {
                
            }
            if (radioButton2.Checked == true)
            {
                radioButton1.Checked = false;
                tsunamiViewer.label1.Visible = true;
                if (radioButton3.Checked == true)
                {
                    tsunamiViewer.label2.Text = "にゃんぱすー";
                }
            }


         
            switch (radioButton2.Checked)
            {
                case true:
                   
                    switch(radioButton3.Checked)
                    {
                        case true:
                            tsunamiViewer.message_timer1.Start();
                            tsunamiViewer.label1.Text = "sdfkjsfkjsa";
                            break;
                        case false:
                            tsunamiViewer.message_timer1.Stop();
                            break;
                    }
                    switch(radioButton4.Checked)
                    {
                        case true:
                            tsunamiViewer.message_timer2.Start();
                            break;
                        case false:
                            tsunamiViewer.message_timer2.Stop();
                            break;
                    }
                    break;
            }
            switch (checkBox1.Checked)
            {
                case true:
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    tsunamiViewer.message_timer1.Start();
                    tsunamiViewer.message_timer2.Start();
                    break;
                case false:
                    tsunamiViewer.message_timer1.Stop();
                    tsunamiViewer.message_timer2.Stop();
                    break;
            }
        }

    }
}
