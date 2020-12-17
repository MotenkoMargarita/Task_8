using sharp_3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task8_15
{
    public partial class Form : System.Windows.Forms.Form
    {
        private int launches = 0;
        private int insurances = 0;

        public Form()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            rocket.Items.Add("Ракета");
        }

        private void OnRocketLaunched(IList<Cosmonaut> cosmonauts)
        {
            rocket.Items.Clear();
            rocket.Items.Add("Ракета");
            cosmonauts.ToList().ForEach(x => rocket.Items.Add(x.Name));
        }

        private void OnRocketSucceed()
        {
            LaunchCount.Text = $"Успешных запусков: {++launches}";
        }

        private void OnRocketFailed()
        {
            InsuranceSum.Text = $"Выплачено денег: {++insurances * 1000000}$";
        }

        private void OnRocketFinished()
        {
            newRocket();
        }

        private void OnRocketProgress(int progress)
        {
            rocket.Location = new Point(21 + 4 * progress, rocket.Location.Y);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            newRocket();
        }

        private void newRocket()
        {

            var rocket = Rocket.GetRocket();
            rocket.StartEvent += OnRocketLaunched;
            rocket.SuccessEvent += OnRocketSucceed;
            rocket.FailtureEvent += OnRocketFailed;
            rocket.FinishEvent += OnRocketFinished;
            rocket.RoutineEvent += OnRocketProgress;
            rocket.Start();
        }
    }
}
