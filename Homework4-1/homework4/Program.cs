using System;

namespace clock
{
    class Program
    {
        //声明参数类型
        public class TimeEventArgs : EventArgs
        {
            private DateTime TimeNow;
            public DateTime Time
            {
                set
                {
                    TimeNow = value;
                }
                get
                {
                    return this.TimeNow;
                }
            }
        }

        //定义事件源（闹钟）
        public class clock
        {
            private string timeset = null;

            public void setter()
            {
                Console.WriteLine("请输入您想设置的时间:");
                this.timeset = Console.ReadLine();

            }
            public string getter()
            {
                return this.timeset;
            }
        }

        public class Metronome
        {
            //事件定义
            public event TimeEventHandler Tick;
            //声明委托
            public delegate void TimeEventHandler(Metronome m, TimeEventArgs e);

            public void Start()
            {
                while (true)
                {
                    //
                    // TimeOfTick time=new TimeOfTick();
                    string str = null;
                    clock ts = new clock();
                    ts.setter();
                    str = ts.getter();

                    DateTime dt1 = DateTime.Parse(str);

                    if (DateTime.Now > dt1)
                    {
                        Console.WriteLine("闹钟时间小于系统时间，请重新设置:");
                        continue;
                    }

                    while (true)
                    {
                        string strnow = DateTime.Now.ToString();
                        DateTime dt = DateTime.Parse(strnow);

                        string str1 = dt.ToString();
                        //判断时间到了吗
                        if (str1 == str)
                        {
                            if (Tick != null)
                            {

                                TimeEventArgs TEA = new TimeEventArgs();
                                TEA.Time = DateTime.Now;
                                Tick(this, TEA);
                            }
                            System.Console.WriteLine("设置时间到");

                        }
                    }
                }
            }
        }

        ////设置监听
        //public class Listener
        //{
        //    public void Subscribe(Metronome m)
        //    {
        //        System.Console.WriteLine("设置时间到");
        //    }


            public class UseClock
            {
                static void Main()
                {
                    //为了容易设置，以防在当前时间之前
                    Console.WriteLine("当前时间为：");
                    Console.WriteLine(DateTime.Now);
                    //注册事件
                    Metronome m = new Metronome();
                    m.Start();
                    Console.ReadLine();

                }
            }





        }

    }
}

    
