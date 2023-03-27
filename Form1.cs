using ScottPlot;

namespace ScottRealtimeView
{
    public partial class Form1 : Form
    {
        private double[] data1 = new double[100]; // �O���t1�̃f�[�^���i�[����z��
        private double[] data2 = new double[100]; // �O���t2�̃f�[�^���i�[����z��
        private Random rand = new Random(); // �����_���Ȑ��l�𐶐����邽�߂̃I�u�W�F�N�g
        private int dataIndex = 0; // �f�[�^�̃C���f�b�N�X

        public Form1()
        {
            InitializeComponent();
            // �O���t1�̐ݒ�
            formsPlot1.Plot.YLabel("Value"); // Y���̃��x����ݒ�
            formsPlot1.Plot.XLabel("Time (s)"); // X���̃��x����ݒ�
            formsPlot1.Plot.YAxis2.Label("PPM"); // Y���̃��x����ݒ�
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double newValue1 = rand.NextDouble(); // �����_���Ȑ��l�𐶐�
            data1[dataIndex] = newValue1; // �V�������l��z��̃C���f�b�N�X�ɒǉ�

            double newValue2 = rand.NextDouble(); // �����_���Ȑ��l�𐶐�
            data2[dataIndex] = newValue2; // �V�������l��z��̃C���f�b�N�X�ɒǉ�

            dataIndex++; // �f�[�^�̃C���f�b�N�X�𑝂₷

            if (dataIndex >= data1.Length)
            {
                dataIndex = 0; // �f�[�^�̃C���f�b�N�X���z��̒����𒴂�����0�ɖ߂�
            }

            formsPlot1.Plot.Clear(); // �O���t���N���A
            formsPlot1.Plot.PlotSignal(data1); // �f�[�^1���v���b�g
            formsPlot1.Plot.PlotSignal(data2); // �f�[�^2���v���b�g
            formsPlot1.Render(); // �O���t���ĕ`��
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