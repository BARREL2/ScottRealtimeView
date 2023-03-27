using ScottPlot;

namespace ScottRealtimeView
{
    public partial class Form1 : Form
    {
        private double[] data1 = new double[100]; // グラフ1のデータを格納する配列
        private double[] data2 = new double[100]; // グラフ2のデータを格納する配列
        private Random rand = new Random(); // ランダムな数値を生成するためのオブジェクト
        private int dataIndex = 0; // データのインデックス

        public Form1()
        {
            InitializeComponent();
            // グラフ1の設定
            formsPlot1.Plot.YLabel("Value"); // Y軸のラベルを設定
            formsPlot1.Plot.XLabel("Time (s)"); // X軸のラベルを設定
            formsPlot1.Plot.YAxis2.Label("PPM"); // Y軸のラベルを設定
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double newValue1 = rand.NextDouble(); // ランダムな数値を生成
            data1[dataIndex] = newValue1; // 新しい数値を配列のインデックスに追加

            double newValue2 = rand.NextDouble(); // ランダムな数値を生成
            data2[dataIndex] = newValue2; // 新しい数値を配列のインデックスに追加

            dataIndex++; // データのインデックスを増やす

            if (dataIndex >= data1.Length)
            {
                dataIndex = 0; // データのインデックスが配列の長さを超えたら0に戻す
            }

            formsPlot1.Plot.Clear(); // グラフをクリア
            formsPlot1.Plot.PlotSignal(data1); // データ1をプロット
            formsPlot1.Plot.PlotSignal(data2); // データ2をプロット
            formsPlot1.Render(); // グラフを再描画
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}