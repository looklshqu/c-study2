using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Brick
    {
        //필드
        private int width;
        private int height;
        private int depth;
        private Color color;

        // 생성자: 리턴 타입이 없음
        public Brick()
        {
            width = 10;
            height = 10;
            depth = 5;
            color = Color.Red;
        }

        public Brick(int width, int height, int depth, Color color)
        {
            this.width = width; // 필드값 = 입력 파리마터 값 형태
            this.height = height;
            this.depth = depth;
            this.color = color;
        }

        //속성
        public int Width
        {
            get { return this.width; }
            set
            {
                if (value > 0)
                {
                    this.width = value;
                }
                
            }
        }

        public Color Color
        {
            get { return this.color; }
        }

        public int Volume
        {
            get { return width * height * depth; }
        }

        // 메서드
        public void MakeBrick()
        {
            //event fire
            if (ProcessStarted != null)
            {
                ProcessStarted(this, EventArgs.Empty);
            }
            Step1();
            Step2();
            Step3();
            if (ProcessCompleted != null)
            {
                ProcessCompleted(this, EventArgs.Empty);
            }
        }

        private void Step1()
        {
            Console.WriteLine("step1");
        }

        private void Step2()
        {
            Console.WriteLine("step2");
        }

        private void Step3()
        {
            Console.WriteLine("step3");
        }

        // 이벤트
        public event EventHandler ProcessStarted;
        public event EventHandler ProcessCompleted;
    }

}
