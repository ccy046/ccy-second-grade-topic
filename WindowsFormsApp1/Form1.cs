using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Media; //使用播放音效檔和存取系統所提供之音效的類別。
using WMPLib;       //windows內件音樂 避免與C#中的音檔庫衝突而無法同時撥放聲音
using System.IO;    //檔案串流
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int x, y, check = 0;
        int music = 3;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Resources\跑跑卡丁車.wav");//呼叫音樂       
        public Form1()  //建構函數 (form1_load則是表單觸發時)
        {
            MessageBox.Show("這是打磚塊遊戲!!");
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;    //表單是否出現邊框
            this.WindowState = FormWindowState.Maximized;       //設定成全螢幕
            this.TopMost = true;        //頂端是否要出現最上層的表單
            x = this.Width;
            y = this.Height;
            timer1.Enabled = false;
            Start.Top = y / 2;
            Start.Left = SystemInformation.PrimaryMonitorMaximizedWindowSize.Width / 2 - Start.Width / 2;   //取得螢幕解析度
            Select.Top = y / 2 + y / 3 + 5;
            Select.Left = SystemInformation.PrimaryMonitorMaximizedWindowSize.Width / 2 - Start.Width / 2;   //取得螢幕解析度
            label1.Left = SystemInformation.PrimaryMonitorMaximizedWindowSize.Width / 2 - label1.Width;
            label1.Top = SystemInformation.PrimaryMonitorMaximizedWindowSize.Height / 2;
            Exit.Top = y / 2 + 2 * y / 3 + 10;
            Exit.Left = SystemInformation.PrimaryMonitorMaximizedWindowSize.Width / 2 - Exit.Width / 2;   //取得螢幕解析度
            label1.Visible = false;
            label2.Visible = false;
            trackBar1.Visible = false;
            pictureBox1.Visible = false;
            this.label2.Font = new System.Drawing.Font("標楷體", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            label2.Left = SystemInformation.PrimaryMonitorMaximizedWindowSize.Width / 2 - label1.Width / 2;
            label2.Top = SystemInformation.PrimaryMonitorMaximizedWindowSize.Height / 2;
            Ball.Visible = false;
            plate.Visible = false;
            help.Top = SystemInformation.PrimaryMonitorMaximizedWindowSize.Height - help.Height;
            help.Left = SystemInformation.PrimaryMonitorMaximizedWindowSize.Width - help.Width - 30;
            help.Visible = true;    //設定位置
            label3.Top = SystemInformation.PrimaryMonitorMaximizedWindowSize.Height;
            label3.Left = 10;//設定計分表 位置
            label3.Visible = false;
            player.PlayLooping();   //撥放音樂
        }
        private void PlayBom() //播放撞擊音樂方法
        {
            if (music == 1 || music == 3)
            {
                var player = new WindowsMediaPlayer
                //因為不知道音檔是什麼型別 所以用var設定player 並使用windows內建的WindowsMediaPlayer來撥放音檔
                {
                    URL = @"Resources\hit.wav" //撞擊聲匯入到player中的地址(URL:統一資源定位器)
                };
            }
        }
        private void Start_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Random random1 = new Random();
            Start.Visible = false;
            Select.Visible = false;
            Exit.Visible = false;
            help.Visible = false;
            label2.Visible = true;            //隱藏按鈕
            i = 3;  //倒數計時
            label2.Text = (i).ToString();
            Ball.Top = (random.Next(400, 600));//球的位置 隨機生成
            Ball.Left = (random1.Next(1, 100));//球的位置 隨機生成
            plate.Top = panel1.Bottom - (panel1.Bottom / 10);
            Cursor.Hide();
            timer2.Enabled = true;
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            check = 1;
            DialogResult dialogResult = MessageBox.Show("確定要離開遊戲嗎?", "警告", MessageBoxButtons.OK | MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }
        // private System.Windows.Forms.Label label0;
        Label[] label = new Label[10];
        private void Select_Click(object sender, EventArgs e)
        {
            Start.Visible = false;
            Select.Visible = false;
            Exit.Visible = false;
            help.Visible = false;   //隱藏主畫面按鈕
            this.label1.Font = new System.Drawing.Font("標楷體", 68F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            label1.Text = "調整遊戲難度";
            label1.Left = SystemInformation.PrimaryMonitorMaximizedWindowSize.Width / 2 - label1.Width / 2;
            label1.Top = SystemInformation.PrimaryMonitorMaximizedWindowSize.Height / 4;    //位置設定
            this.label1.ForeColor = System.Drawing.Color.Black; //設定顏色
            label1.Visible = true;  //難度調整字樣顯示
            trackBar1.Top = SystemInformation.PrimaryMonitorMaximizedWindowSize.Height / 2;
            trackBar1.Left = SystemInformation.PrimaryMonitorMaximizedWindowSize.Width / 3; //拉條位置
            trackBar1.Visible = true;   //難度拉條
            pictureBox1.Top = SystemInformation.PrimaryMonitorMaximizedWindowSize.Height / 3 * 2;
            pictureBox1.Left = SystemInformation.PrimaryMonitorMaximizedWindowSize.Width / 2 - (pictureBox1.Width / 2); //設定儲存位置
            pictureBox1.Visible = true; //說明圖示顯示
            label3.Visible = false; //隱藏分數表
        }
        private void PictureBox1_MouseDown(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.save1;
        }
        int i = 3;
        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (i - 1 != 0)
            {
                label2.Text = (i - 1).ToString();
            }
            else
            {
                label2.Top = SystemInformation.PrimaryMonitorMaximizedWindowSize.Height / 2;
                label2.Text = "START !";
                label2.Left = SystemInformation.PrimaryMonitorMaximizedWindowSize.Width / 2 - label2.Width / 2;
            }
            if (i == 0) //當時間到 將東西隱藏 並讓計數器開始
            {
                label2.Visible = false;
                timer1.Enabled = true;
                Start_game(panel1);
                plate.Visible = true;
                Ball.Visible = true;
                label3.Visible = true;
                timer2.Enabled = false;
            }
            i--;
        }
        int horizontal = 5, longitudinal = 5, Go = 0, score = 0; int died = 1;   //橫向 、縱向、遊戲狀態、分數
        private void Timer1_Tick(object sender, EventArgs e)
        {
            Go = 1;
            if (Cursor.Position.X <= (plate.Width / 2))   //不要超過左邊
            {
                plate.Left = 0;          //盤子左邊歸0
            }
            else if (Cursor.Position.X >= (SystemInformation.PrimaryMonitorMaximizedWindowSize.Width - plate.Width))  //不要超過右邊
            {
                plate.Left = panel1.Width - plate.Width;        //盤子右邊頂牆
            }
            else                   //剩下中間位置都正常
            {
                plate.Left = Cursor.Position.X - (plate.Width / 2); //算出盤子左邊位置
            }

            Ball.Left += horizontal;        //球橫向移動
            Ball.Top -= longitudinal;       //球縱向移動
            if (Ball.Bottom >= plate.Top && Ball.Bottom <= plate.Bottom && Ball.Left >= plate.Left && Ball.Right <= plate.Right || Ball.Right > plate.Left && Ball.Bottom >= plate.Top && Ball.Left < plate.Right && Ball.Bottom <= plate.Bottom || Ball.Left > plate.Right && Ball.Bottom >= plate.Top && Ball.Right < plate.Left)
            //(如果球的底超過盤子的上面 與 又不超過盤子的下面 與 球的左邊超過盤子左邊 與 球的右邊超過盤子右邊)=球落入盤子裏面 (後面是修正敲到盤子最邊邊無反應 利用球彈過頭方式去使判斷更精準)
            {
                longitudinal = -longitudinal;//往上彈  
                combo = 0;
            }
            if (Ball.Left <= 0 || Ball.Right >= SystemInformation.PrimaryMonitorMaximizedWindowSize.Width)             //當球撞到左邊牆壁 與 右邊牆壁
            {
                horizontal = -horizontal;   //往反方向彈 (橫向)      
            }
            if (Ball.Top <= 0)  //當球衝上天花板 (縱向)彈下來
            {
                longitudinal = -longitudinal;
            }
            if (Ball.Bottom > this.panel1.Top + SystemInformation.PrimaryMonitorMaximizedWindowSize.Height + Ball.Height)//當球掉到最下面去 結束遊戲
            {
                timer1.Enabled = false;  //stop the game
                Go = 0;//如果遊戲結束讓這變數=0
                if (died >= 1 && Go == 0)
                {
                    Cursor.Show();
                    check = 1;
                    DialogResult dialog = MessageBox.Show("你讓球打死你自己了 是否要復活?\n\n你還有" + died + "次機會可以復活!", "選擇", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);//是否繼續  //另寫一個分數表 動工!
                    if (dialog == DialogResult.OK)
                    {
                        died--;
                        horizontal = -horizontal;
                        longitudinal = -longitudinal;
                        Ball.Top -= 50;
                        score -= 10;
                        timer1.Enabled = true;
                        timer1.Interval = 1000;
                        timer1.Interval = 30;
                        Cursor.Hide();
                        Go = 1;
                        check = 0;
                    }
                    else if (dialog == DialogResult.Cancel)
                    {                        
                        MessageBox.Show("Game Over  你獲得的分數為:" + score, "結束遊戲", MessageBoxButtons.OK);
                        Save_score();
                        this.Dispose();
                    }
                }
                else if (died == 0 && Go == 0)
                {
                    Cursor.Show();
                    check = 1;
                    Save_score();
                    DialogResult ck = MessageBox.Show("Game Over  你獲得的分數為:" + score, "結束遊戲", MessageBoxButtons.OK);
                    if (ck == DialogResult.OK)
                    {
                        MessageBox.Show("由於你已被球打至身亡 遊戲即將重啟");
                    }
                    Application.Restart();  //重啟遊戲
                }
            }
            Collision();    //碰到磚塊 另寫函數
            label3.Text = "";
            label3.Text = "目前分數: " + score.ToString() + " 分";
            label3.Top = SystemInformation.PrimaryMonitorMaximizedWindowSize.Height - 15;
            label3.Left = 50;
        }
        private void Save_score()
        {
            int record = 0;
            StreamReader reader = new StreamReader(@"Resources\score.txt");//讀入原始成績
            while (!reader.EndOfStream) //掃秒檔案是否見底
            {
                record = int.Parse(reader.ReadLine());  //轉換分數至record中
            }
            reader.Close(); //關閉
            Thread.Sleep(100);  //給100ms的處理時間
            StreamWriter filein = new StreamWriter(@"Resources\score.txt");
            if (score > record) //如果成績大於歷史紀錄
            {
                filein.WriteLine(score);    //寫入新成績
            }
            else
            {
                filein.WriteLine(record);   //寫舊成績
            }
            filein.Close(); //關閉
        }
        int gameover = 0; int combo = 0;
        private void Collision()    //碰到磚塊函數 這裡很難寫!
        {
            for (int i = 0; i < brickX; i++)    //跑X
            {
                for (int j = 0; j < brickY; j++)    //跑y
                {
                    if (brick[i, j].Visible == true) // 若磚塊是可見的話…，表示磚塊尚未被擊中
                    {
                        if ((Ball.Left <= brick[i, j].Right && Ball.Left >= brick[i, j].Right - 9) || (Ball.Right >= brick[i, j].Left && Ball.Right <= brick[i, j].Left + 9))//我將判斷的誤差設在9上下 因為移動速度最大到9 所以必須要有大小為9的空間作判斷
                        {
                            if ((Ball.Top >= brick[i, j].Top && Ball.Top <= brick[i, j].Bottom) || (Ball.Bottom >= brick[i, j].Top && Ball.Bottom <= brick[i, j].Bottom))
                            {
                                PlayBom();
                                horizontal = -horizontal;
                                brick[i, j].Visible = false; //判定擊中後，並將磚塊的Visible屬性設false，使其看不見
                                gameover++;
                                score += 10;
                                combo++;
                                goto next; //一旦擊中，就不用測試其他的磚塊…，跳離這個測試以節省時間
                            }
                        }
                        else if ((Ball.Top <= brick[i, j].Bottom && Ball.Top >= brick[i, j].Bottom - 9) || (Ball.Bottom >= brick[i, j].Top && Ball.Bottom <= brick[i, j].Bottom + 9))
                        {
                            if (Ball.Left <= brick[i, j].Right && Ball.Left >= brick[i, j].Left || Ball.Right >= brick[i, j].Left && Ball.Right <= brick[i, j].Right)
                            {
                                {
                                    PlayBom();
                                    longitudinal = -longitudinal;   //撞到磚塊假設是撞到上面或下面 要改變縱向
                                    brick[i, j].Visible = false;    //撞到後隱藏
                                    gameover++; //累積撞到的磚塊
                                    score += 10;//加分
                                    combo++;
                                    goto next;  //跳離這個迴圈 到下面去 不然會一直重複判斷導致其他磚塊也消失
                                }
                            }
                        }
                    }
                }
            }
        next:       //抱歉 我懶得想怎麼讓雙層迴圈不繼續跑 所以偷懶用了goto的函數
            if (gameover == (brickX * brickY))
            {
                timer1.Enabled = false; //當磚塊撞到完了以後計數器停止    
                Game_over(panel1);  //呼叫結束遊戲的函式
            }
            if (gameover + 1 % 40 == 0)//每撞到40個就有一次復活機會
            {
                died++; //死亡復活次數+1
            }
            if (gameover + 1 % 30 == 0) //每30個去做加速 +1的速度
            {
                if (horizontal < 0)
                {
                    horizontal -= 1;
                }
                else
                {
                    horizontal += 1;
                }
                if (longitudinal < 0)
                {
                    longitudinal -= 1;
                }
                else
                {
                    longitudinal += 1;
                }
            }
            if (combo > 2) //如果連續敲到兩個
            {
                score += 10;    //額外bonus
                combo = 0;      //計數歸0
            }
        }
        private void Start_MouseEnter(object sender, EventArgs e)
        {
            Start.Image = Properties.Resources.開始_2;
        }
        private void Start_MouseLeave(object sender, EventArgs e)
        {
            Start.Image = Properties.Resources.開始_1;
        }
        private void Select_MouseDown(object sender, MouseEventArgs e)
        {
            Select.Image = Properties.Resources.難度_2;
        }
        private void Select_MouseLeave(object sender, EventArgs e)
        {
            Select.Image = Properties.Resources.難度_1;
        }
        private void Exit_MouseDown(object sender, MouseEventArgs e)
        {
            Exit.Image = Properties.Resources.結束_2;
        }
        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.Image = Properties.Resources.結束_1;
        }
        int hard = 3;
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            hard = trackBar1.Value;
            switch (hard)
            {
                case 1:
                    horizontal = 4;
                    longitudinal = 4;
                    break;
                case 2:
                    horizontal = 5;
                    longitudinal = 5;
                    break;
                case 3:
                    horizontal = 6;
                    longitudinal = 6;
                    break;
                case 4:
                    horizontal = 7;
                    longitudinal = 7;
                    break;
                case 5:
                    horizontal = 8;
                    longitudinal = 8;
                    break;
                case 6:
                    horizontal = 9;
                    longitudinal = 9;
                    break;
            }
            label1.Visible = false;
            trackBar1.Visible = false;
            pictureBox1.Visible = false;
            Start.Visible = true;
            Select.Visible = true;
            help.Visible = true;
            Exit.Visible = true;
        }
        int brickX = 15, brickY = 8;    //磚塊多寡
        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.save;
        }
        private void Help_Click(object sender, EventArgs e)
        {
            check = 1;  //避免點擊後變縮小化
            int record = 0;
            StreamReader fileout = new StreamReader(@"Resources\score.txt");    //檔案讀入reader 
            while (!fileout.EndOfStream)    //當檔案不到結尾
            {
                record = int.Parse(fileout.ReadLine());    //將檔案寫入字串中
            }
            DialogResult dialog = MessageBox.Show("此遊戲是為了小時候曾經玩過的紅白機、任天堂等等..緬懷的打磚塊遊戲\n針對遊戲我們也盡力做出還原當時的遊戲介面與修正精準撞擊...\n\n" +
                "        故事的起源自從小，因為爸媽希望我好好讀書不要隨時都在玩遊戲機，在一次念完以後我憤而之下拿起手中的球踢向了隔壁家的牆，結果把隔壁家的牆給打破了，" +
                "隔壁老王出來破口大罵要玩球不會去找一個沒人的世界去喔，踢破我家的磚牆是在衝X毀，老王心中無數感慨 媽的我還有32年的貸款欸...，" +
                "此時的我的腦中閃過一現想法，徒手寫一個打磚塊不就好了，於是這遊戲就這麼誕生了!\n\n遊戲規則:\n\n1,只要球碰到磚塊磚塊就會消失\n" +
                "2,針對入門熟練以及專業玩家我們還設有難度調整 讓速度快到跟不上你的節奏!\n3,預設音效為背景音樂加音效 如需更改聲音請按TAB鍵 \n" +
                "按一次為關掉全部音效 按第二次只開音效 按第三次只開背景音樂 再按一下則歸復\n4,盡你所能的擊毀所有磚塊吧!\n\n預祝各位玩家遊戲愉快!\n\n" +
                "歷史遊玩最高紀錄為: " + record.ToString() + "分\n\n" +
                "隨便做遊戲製作團隊人員 : 梁博皓 顏子翔 董珈瑄 連子晴 郭佩珊\n\nCopyright ©2019~   by 隨便做製作團隊.Inc  All rights reserved", "看不懂中文是不是拉 這裡叫說明的啦");
            if (dialog == DialogResult.OK)
            {
                check = 0;      //歸0
            }
            fileout.Close();    //關檔
        }
        PictureBox[,] brick = new PictureBox[15, 8];
        private void Start_game(Panel panel)    //磚塊開始生成函數
        {
            for (int i = 0; i < brickX; i++)        //生成磚塊
            {
                for (int j = 0; j < brickY; j++)
                {
                    brick[i, j] = new PictureBox    //生成磚塊的建構函數 將生成屬性都寫成建構式中
                    {
                        BackColor = Color.Blue,
                        Name = "matrix",
                        Location = new System.Drawing.Point(20 + ((SystemInformation.PrimaryMonitorMaximizedWindowSize.Width - 75 - 40) / 15 + 5) * i, 40 + (((SystemInformation.PrimaryMonitorMaximizedWindowSize.Height / 2) - 50) / 8 + 5) * j),
                        Size = new System.Drawing.Size((SystemInformation.PrimaryMonitorMaximizedWindowSize.Width - 75 - 40) / 15, ((SystemInformation.PrimaryMonitorMaximizedWindowSize.Height / 2) - 50) / 8),
                        BorderStyle = BorderStyle.FixedSingle,
                    };
                    panel1.Controls.Add(brick[i, j]);
                }
            }
        }
        private void Game_over(Panel panel)
        {
            for (int i = 0; i < brickX; i++)        //確定隱藏所有磚塊
            {
                for (int j = 0; j < brickY; j++)
                {
                    brick[i, j].Visible = false;
                    panel1.Controls.Add(brick[i, j]);
                }
            }           
            Cursor.Show();  //遊戲結束 滑鼠要顯示
            MessageBox.Show("你總共敲了" + gameover + "個磚塊 應該對於老王有些息怒了吧", "恭喜獲得" + score + "分!");
            DialogResult result = MessageBox.Show("恭喜你完成了打磚塊!\n\n此時的老王已不在家...所以...\n趕快拿起球去踢壞他家的牆吧!\n" +
                "X的花我這麼多時間寫遊戲\n早知道就等老王不在家拿球踢他牆壁就好了\n累死我了", "恭喜完成遊戲", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                MessageBox.Show("哦對了 你以為破關有獎勵嗎?\n\n當然是沒有 小朋友給我好好的去讀書!\n\n破關後對於這遊戲的會修的玩家...也歡迎加入我們的團隊\n" +
                    "不然我寫這遊戲一堆的BUG\n然後還想不到結局要做什麼\n連個晉級關卡都沒有= =\n\n很高興你能遊玩我所製作的這款遊戲!\n期待更多的遊戲關卡以及更新吧!\n\n" +
                    "by 隨便做製作團隊.Inc  All rights reserved", "這遊戲跟我的人生一樣 只有一個字 \"難\"");
                Application.Restart();  //重新開始遊戲
            }
            gameover = 0;   //計數遊戲結束要歸0
        }
        //label1.Text = panel1.Width + "," + panel1.Height + "    " + this.Width + "," + this.Height; ;    /*測試panel的長寬 與 表單長寬 是否一致用*/
        private void Form1_Deactivate(object sender, EventArgs e)   //當跳離表單時會發生的事
        {
            if (check == 0) //所以不能讓離開遊戲去縮小視窗
                this.WindowState = FormWindowState.Minimized;   //最小化
            check = 0;  //設定玩要規0 不然下一次會產生問題
        }
        public void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)   //esc鍵
            {
                // MessageBox.Show("Sucess");   //測試跳脫用
                if (timer1.Enabled == true) //如果遊戲開始
                {
                    timer1.Enabled = false; //計數器暫停
                }
                if (timer1.Enabled == false)    //如果暫停
                {
                    Cursor.Show();  //鼠標要顯示
                }
                check = 1;      //離開遊戲會突然縮小視窗
                DialogResult dialogResult = MessageBox.Show("是否關閉遊戲?", "注意", MessageBoxButtons.OK | MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2);//離開視窗跳出通知 通知可用esc取消
                if (DialogResult.OK == dialogResult)  //按下確定進入 /*dialogresult為對話方塊回傳值*/
                {
                    this.Close();        //關閉程式
                }
                if (e.KeyCode == Keys.Escape)      //如果再按下esc鍵
                {
                    if (Go == 1)    //假如遊戲開始過
                    {
                        timer1.Enabled = true;  //讓遊戲繼續開始
                    }
                    Cursor.Hide();  //鼠標隱藏
                }
            }
            if (e.KeyCode == Keys.Tab)
            {
                music++;
                if (music > 3)
                {
                    music = 0;
                }
                if (music == 2)
                {
                    player.PlayLooping();
                }
                else if (music == 3) { }
                else
                {
                    player.Stop();
                }
            }
        }
    }
}
