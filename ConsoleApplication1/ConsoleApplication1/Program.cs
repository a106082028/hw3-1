using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "葉俊廷", "張澤瑜", "王程捷 的咩？", "江儀婷", "張秉華", "陳柏霖", "黃紀瑜", "黃昱維", "蔡逸群", "登琳", "世新魏鈞孝吧", "劉定南", "陳信如", "童信傑", "李岳倫", "鄒和恆", "簡毓玟", "劉子瑄", "蕭紹洋", "李亞宸la", "張以潔", "邱仕紳", "呂家瑩", "世新林鑫佑", "徐均得", "陳佳欣", "張恩瑋", "周詮", "王湘婷", "蕭宇成", "Max Cheung(BANG)", "馬嘉誠Σヽ(ﾟД ﾟ; )ﾉ魔貫光殺砲(ﾟДﾟ)σ━0000", "陳昱嘉", "康珈熏", "盧奕宏", "陳郁佳的大哥黃博涵", "遲正雯", "世新林星彤", "許晏誠ｘ勒是奇多＿８＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝Ｄ　", "許子安", "高子晴", "陳思婷", "矝鵘鮿", "余彥廷", "吳耀輝", "鄭丞智", "林冠廷", "世新何曜宇", "邵喬雨", "張豐愷", "林子晴", "邱雁回", "陳家欣是韓妞", "鄧雅馨", "謝汶珊", "李曼寧", "世新徐偉哲", "张钰慈", "鍾宜珊", "raer_tsai", "世新李姳諼", "鄭曼君", "陳柏霖", "世新許子安", "世新方若帆", "李曼寧", "世新遲正雯", "世新周詮" };
            string[] gender = { "男", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "男", "女", "男", "男", "男", "女", "女", "男", "男", "女", "男", "女", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "女", "男", "男", "女", "女", "男", "男", "女", "女", "男", "男", "男", "男", "男", "男", "女", "男", "女", "女", "女", "女", "女", "女", "男", "女", "女", "女", "女", "女", "男", "男", "女", "女", "女", "男" };
            string[] blood = { "O", "其他", "O", "O", "A", "O", "A", "A", "O", "O", "A", "O", "A", "B", "O", "O", "A", "其他", "O", "O", "A", "", "B", "O", "", "O", "B", "O", "B", "B", "B", "O", "O", "AB", "O", "B", "A", "O", "O", "", "O", "A", "", "O", "O", "A", "O", "O", "其他", "B", "O", "O", "O", "A", "AB", "A", "O", "B", "AB", "", "O", "O", "O", "", "O", "A", "A", "O" };
            string[] star = { "金牛", "", "巨蟹", "白羊", "雙魚", "雙子", "天蠍", "巨蟹", "獅子", "雙魚", "雙子", "雙子", "獅子", "雙魚", "天蠍", "天蠍", "處女", "處女", "金牛", "雙魚", "處女", "摩羯", "雙魚", "白羊", "天蠍", "處女", "雙子", "金牛", "雙子", "白羊", "白羊", "摩羯", "射手", "巨蟹", "雙魚", "獅子", "射手", "摩羯", "天蠍", "", "雙魚", "雙子", "", "雙魚", "處女", "金牛", "天秤", "水瓶", "巨蟹", "處女", "白羊", "摩羯", "水瓶", "天秤", "金牛", "天蠍", "天蠍", "處女", "", "", "摩羯", "天蠍", "雙子", "", "獅子", "天蠍", "射手", "金牛" };
            int[] height = { 173, 0, 179, 155, 183, 170, 163, 174, 165, 189, 177, 180, 154, 167, 170, 173, 165, 158, 180, 165, 153, 175, 162, 165, 0, 160, 165, 173, 164, 177, 177, 180, 170, 151, 176, 180, 168, 152, 666, 2147483647, 165, 155, 777, 173, 169, 170, 169, 171, 0, 170, 150, 160, 155, 164, 163, 165, 184, 165, 155, 0, 168, 160, 169, 0, 150, 163, 168, 173 };

            int boy = 0;
            int girl = 0;
            int bloodA = 0;
            int bloodB = 0;
            int bloodAB = 0;
            int bloodO = 0;
            int sum = 0;
            int count = 0;
            int sumBoy = 0;
            int countBoy = 0;
            int sumGirl = 0;
            int countGirl = 0;

            // 人數
            for (int i = 0; i < gender.Length; i++)
            {
                if (gender[i] == "男")
                {
                    boy++;
                }
            }

            for (int i = 0; i < gender.Length; i++)
            {
                if (gender[i] == "女")
                {
                    girl++;
                }
            }

            // 血型
            for (int i = 0; i < blood.Length; i++)
            {
                if (blood[i] == "A")
                {
                    bloodA++;
                }
            }

            for (int i = 0; i < blood.Length; i++)
            {
                if (blood[i] == "B")
                {
                    bloodB++;
                }
            }

            for (int i = 0; i < blood.Length; i++)
            {
                if (blood[i] == "AB")
                {
                    bloodAB++;
                }
            }

            for (int i = 0; i < blood.Length; i++)
            {
                if (blood[i] == "O")
                {
                    bloodO++;
                }
            }

            // 全班身高
            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] > 100 && height[i] < 200)
                {
                    sum = sum + height[i];
                    count++;
                }
            }

            // 男身高
            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] > 100 && height[i] < 250 && gender[i] == "男")
                {
                    sumBoy = sumBoy + height[i];
                    countBoy++;
                }
            }

            // 女身高
            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] > 100 && height[i] < 200 && gender[i] == "女")
                {
                    sumGirl = sumGirl + height[i];
                    countGirl++;
                }
            }

            // 人數百分比
            double persentBoy = (double)boy / (double)gender.Length * 100;
            double persentGirl = (double)girl / (double)gender.Length * 100;

            // 血型百分比
            double persentA = (double)bloodA / (double)blood.Length * 100;
            double persentB = (double)bloodB / (double)blood.Length * 100;
            double persentAB = (double)bloodAB / (double)blood.Length * 100;
            double persentO = (double)bloodO / (double)blood.Length * 100;

            //身高平均
            double average = sum / count;
            double averageB = sumBoy / countBoy;
            double averageG = sumGirl / countGirl;

            Console.WriteLine("男生人數:" + boy + "，占全班：" + persentBoy + "%");
            Console.WriteLine("女生人數:" + girl + "，占全班：" + persentGirl + "%");
            Console.WriteLine("A型的有：" + bloodA + " 人，占 " + persentA + " %");
            Console.WriteLine("B型的有：" + bloodB + " 人，占 " + persentB + " %");
            Console.WriteLine("AB型的有：" + bloodAB + " 人，占 " + persentAB + " %");
            Console.WriteLine("O型的有：" + bloodO + " 人，占 " + persentO + " %");
            Console.WriteLine("男生身高總合為:" + sumBoy + "，平均為：" + averageB);
            Console.WriteLine("女生身高總合為:" + sumGirl + "，平均為：" + averageG);
            Console.WriteLine("全班身高總合為:" + sum + "，平均為：" + average);

            // 天蠍座O型
            for (int i = 0; i < name.Length; i++)
            {
                if (star[i] == "天蠍" && blood[i] == "O")
                {
                    Console.WriteLine("天蠍座O型的人有:" + name[i]);
                }
            }



            Console.ReadKey();
        }
    }
}
