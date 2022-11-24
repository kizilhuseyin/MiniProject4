namespace HızGöstergesi
{
    public partial class Velucityİnducator : Form
    {
        public Velucityİnducator()
        {
            InitializeComponent();
        }
        private void aGauge1_ValueInRangeChanged(object sender, AGaugeApp.AGauge.ValueInRangeChangedEventArgs e)
        {
            
        }
        private void inducator_Load(object sender, EventArgs e)
        {

        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            aGauge1.Value = HızCubugu.Value;
        }


    }
}