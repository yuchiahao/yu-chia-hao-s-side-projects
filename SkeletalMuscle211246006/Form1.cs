using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace SkeletalMuscle211246006
{
    public partial class Form1 : Form
    {
        string[] front =   { "胸鎖乳突肌",  /*正面左側肌肉*/
                             "胸大肌",
                            "肱二頭肌",
                            "肱肌",
                           "肱橈肌",
                           "橈側屈腕肌",
                           "尺側屈腕肌",
                           "闊筋膜張肌",
                           "縫匠肌",
                           "股外側肌",
                           "股直肌",
                           "股內側肌", 

                            /*正面右側：*/

                 

                              "前鋸肌", 
                              "斜方肌", 
                               "三角肌", 
                              "腹直肌",
                              "腹外斜肌",
                              "恥骨肌", 
                              "內收長肌", 
                              "股薄肌", 
                               "腓骨長肌",
                               "脛骨前肌",
                               "伸趾長肌"

        };


                            /*正面左側肌肉定義*/

        string[] frontD = { "頸部肌肉，推動頭部前移或轉動，連接胸骨、鎖骨和頭顱。其單側收縮可使頭部轉動。",  /*正面左側肌肉定義*/
                            "兩側胸部肌肉，將手臂拉向胸部，附著於肱骨、鎖骨和胸骨。主要負責手臂內拉和旋轉。",
                            "上臂肌肉，使手臂彎曲，分為兩個頭，展示時可明顯鼓起。協助肘關節的彎曲。",
                            "上臂肌肉，參與肘關節的屈曲，深層肌肉，協同肱二頭肌動作。",
                            "前臂外側肌肉，參與前臂屈曲和上臂靠攏的動作，主要在特定動作中發揮作用。",
                            "前臂肌肉，使手腕向外側屈曲，支援手腕的橈側屈曲動作。",
                            "前臂肌肉，穩定腕關節並促使拇指運動，主要參與手腕的屈曲。" ,
                            "股部深筋膜肌肉，參與髖關節的屈曲，形成骼脛束，支持髖部穩定。",
                            "全身最長肌肉，參與膝蓋舉起、放下和盤腿動作，支持髖、膝和踝的協同運動。",
                            "大腿最外側肌肉，主要伸展膝關節，支持站立和行走。",
                             "大腿前部中間肌肉，參與髖關節彎曲和膝蓋伸展，維持站立和走路時的穩定。",
                             "大腿內側肌肉，參與大腿動作，協同其他股四頭肌。",

                             
                             
                             /*正面右側定義*/
                            "是將肩胛骨內側向前拉的胸部肌肉。每組兩塊的前鋸肌從胸前部的肋骨開始，圍繞體側延伸到肩胛骨。",
                            "是將頭部和肩部向後拉的背部肌肉。兩塊斜方肌從脊椎和頭骨底部，經過背部和肩部連接到肩胛骨和鎖骨。",
                            "俗稱「大頭肌」，圍繞著肩膀連接的肩胛骨、鎖骨及肱骨，肩部和上臂的大多數運動都離不開三角肌",
                            "是指軀幹下半部（或稱腹部）的器官，由若干片狀的肌肉保護著，並固定在適當的位置。這包括兩塊腹直肌，沿著身體前面，從胸廓延伸到骨盆。",
                            "是使腹部緊束的斜肌，兩塊腹外斜肌從最低的肋骨延伸到身體前面的中線。在這裡，他們連接成薄而堅固的纖維層。",
                            "恥骨肌起自恥骨的恥骨線，稍起於其前面的髂突與恥骨結節之間的骨面，起於覆蓋肌肉前部的筋膜。纖維向下、向後和橫向進入股骨的恥骨線，該恥骨線從小轉子延伸至股骨環。",
                            "內收長肌起自恥骨嵴下方的恥骨體，位於恥骨聯合的側面。 短收肌位於大收肌腹側，夾在股骨附近的這兩塊肌肉之間。在遠端，內收長肌纖維延伸到內收肌管中並插入椎間線內側唇的中間三分之一。",
                            "起點: Inferior pubic ramus(下恥骨支)的腹側面和pubic body(恥骨體)止點: pes anserinus(額掌腱)：Medial condyle of tibia下方和tibial tuberosity內側間的凹槽",
                            "位於小腿外側皮下，緊貼腓骨的外側面，為雙羽肌。起自腓骨頭、腓骨上2/3的外側面和小腿深筋膜。肌束向下移行長的肌腱，經外踝後方、跟骨外側面及腓骨肌下支持帶轉至足底，斜行於足的內側緣，止於第1楔骨和第1蹠骨基底部",
                            "脛骨前肌：系小腿前羣肌之一。與趾長伸肌、長伸肌共同起自脛、腓骨上端與骨間膜，下行經小腿橫韌帶和十字韌帶的深方，止於第1楔骨和第1蹠骨底。",
                            "起點: 上半段腓骨及脛骨的Lateral condyle(外髁) 止點: 第2到5遠端趾骨基部及中端趾骨基部。", };





        string[] black = {

               /* 背面左側*/
                            "斜方肌",
                            "三角肌",
                            "岡下肌 Infraspinatus",
                            "背闊肌 Latissimus Dorsi",
                            "臀中肌 Gluteus Medius",
                            "臀大肌 Gluteus Maximus",
                            "腓腸肌 Gastrocnemlus",
                            "比目魚肌 Soleus",
                            "阿基里斯肌腱(Achilles Tendon-",






                            /*背面右側*/
                            "小圓肌 Teres Minor",
                            "大圓肌 Teres Major",
                            "肱三頭肌 Triceps Brachu",
                            "橈側伸腕長肌 Extensor Carpi Radialis Ledgus",
                            "尺側伸腕肌 Extensor Carpi Ulnaris",
                            "橈側伸腕短肌 Extensor Carmi Radialis Brevis",
                            "大內收肌 Adductor Magnus",
                            "股二頭肌 Bices Femoris",
                            "半腱肌 Semitendinosus",
                            "半膜肌 Semimembranoss",


        };


         string[] blackD = {
            /*背面左側定義*/
            "是將頭部和肩部向後拉的背部肌肉。",
            "圍繞著肩膀連接的肩胛骨、鎖骨及肱骨。",
            "位於岡下窩內，一部分被三角肌和斜方肌復蓋，作用是使肩關節鏇外。",
            "將手臂向下和下後拉的背部肌肉。",
            "臀前、臀後線間的髂骨翼外表面。",
            "臀部後部肌肉組織中最大的肌肉。",
            "沿著小腿背後，從股骨的遠端向下延伸到跟骨。",
            "於腓腸肌下側位於小腿深層，因為外型扁平類似比目魚形狀而得名。",
            "是位於腳後跟的跟腱。",


            
            
            
            
            
            /*背面右側定義*/
            "是肩袖的一塊狹窄、細長的肌肉。 該肌肉起源於相應的右肩胛骨或左肩胛骨的外側邊緣和相鄰的後部，並插入肱骨大結節和關節囊的後部。",
            "是一束上肢肌，形態厚實，截面呈橢圓形，起於肩胛骨下角背面，止於肱骨小結節嵴，位於背闊肌上方，小圓肌下方，參與構成腋窩後壁，是七塊肩胛肱骨肌之一。",
            "簡稱三頭肌，是人體手上臂的肌肉。",
            "是上臂重要的伸腕肌群之一。",
            "位於手肘內側，功能是伸展手腕並在手腕伸展時進一步將手腕往尺側（內側）偏移，對於遠端橈尺關節也具有穩定效果。",
            "橈側伸腕短肌(extensor carpi radialis brevis)是血管比較不豐富的，也比較容易產生缺氧傷害和退化，而導致反覆疼痛的主因。",
            "內收大肌屬於髖伸肌而非髖屈肌，多數的內收肌都是屬於髖屈的肌肉，而內收大肌不論髖關節的哪個位置，都是一條強力的髖伸肌，是臀大肌與腿後肌以外，非常重要但容易被忽略的肌肉。",
            "交叉在膝關節附近的肌腱群，主要負責控制膝蓋彎曲與大腿伸展的動作。",
            "半腱肌及半膜肌位於大腿後方內側，而股二頭肌位於大腿後方外側。",
           "半膜肌扁平寬闊，位於半腱肌的下方，當腳穩固地放在地面上時，半膜肌伸展臀部，使軀幹進入直立位置；當腳抬高時，半膜肌會彎曲並內旋腿部。",
 
        
        
        
        };

        int i, j;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[1];

            listBox1.Items.Clear();
            for (int i = 0; i <= front.GetUpperBound(0); i++) 
            {
                listBox1.Items.Add(front[i]);
            
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];
            listBox1.Items.Clear();
            for (int j = 0; j <= black.GetUpperBound(0); j++)
            {
                listBox1.Items.Add(black[j]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( radioButton1.Checked)
            {
                textBox1.Text = frontD[listBox1.SelectedIndex];
            }
            else
            {
                textBox1.Text = blackD[listBox1.SelectedIndex];
            }
        }
    }
}
