using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace sharp_3
{
    class Rocket
    {
        public static readonly Random random = new Random();

        public IList<Cosmonaut> Cosmonauts { get; set; }

        private System.Timers.Timer timer = new System.Timers.Timer();

        private int progress = 0;

        public event Action<IList<Cosmonaut>> StartEvent;
        public event Action SuccessEvent;
        public event Action FailtureEvent;
        public event Action FinishEvent;
        public event Action<int> RoutineEvent;

        public static Rocket GetRocket()
        {
            return new Rocket { Cosmonauts = Enumerable.Range(1, 4).Select(x => Cosmonaut.GetCosmonaut()).ToList() };
        }

        public void Start()
        {
            StartEvent?.Invoke(this.Cosmonauts);
            timer.Interval = 20;
            timer.AutoReset = true;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(Tick);
            timer.Start();
        }

        private void Tick(object sender, ElapsedEventArgs e)
        {
            progress += 1;
            if (progress >= 100)
            {
                Success();
            } else
            {
                var roll = random.Next(100);
                if (roll < progress / 70)
                {
                    Failture();
                } else
                {
                    Routine();
                }
            }
        }

        private void Success()
        {
            SuccessEvent?.Invoke();
            FinishEvent?.Invoke();
            timer.Stop();
        }

        private void Failture()
        {
            FailtureEvent?.Invoke();
            FinishEvent?.Invoke();
            timer.Stop();
        }

        private void Routine()
        {
            RoutineEvent?.Invoke(this.progress);
        }
    }
}
