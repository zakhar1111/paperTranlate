using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace Particals
{
    public class Particle
    {
        public static Random Generator = new Random();

        float X,Y, VX, VY;
        int scl, alpha;

        public bool ToDelete()
        {
            return alpha <= 10;
        }        
        public Particle()
        {
            X = 300;
            Y = 380;
            scl = 20;
            alpha = 255;
            VX = Generator.Next(-1, 2);
            VY = Generator.Next(-10, -1);
        }
        public void Update()
        {
            X =X + VX; Y += VY;
            if ( alpha > 10)
                alpha-=10;
        }

        public void Show(Graphics gdi)
        {
            using (var newBrush 
                = new SolidBrush(Color.FromArgb(this.alpha, Color.Wheat)))
                gdi.FillEllipse(newBrush, X, Y, scl, scl);
        }

    }
    public class Particles : List<Particle>
    {
        public Particles()
        {
            this.Add(new Particle());
        }
        public void Show(Graphics gdi)
        {
            AddNumParticles(5);
            Update();
            foreach (var el in this)
                    el.Show(gdi);
        }
        
        void AddNumParticles(int num)
        {
            foreach(var i in Enumerable.Range(0,num))
                this.Add(new Particle());
        }
        void Update()
        {
            foreach (var el in this)
                el.Update();
            int limitAlpha = 10;
            ClearElements(limitAlpha);
        }
        void ClearElements(int alphaThreeshould)
        {
            var temp = new List<Particle>();
            foreach (var el in this)
                if (!el.ToDelete())
                    temp.Add(el);
            this.Clear();
            this.AddRange(temp);
        }
    }
    public class Canva
    {
        public int Width { get { return 600; } }
        public int Hieght { get { return 600; } }
        public Color CanvaColor { get { return Color.Black; } } 
        public void Show(Graphics gdi)
        {
            gdi.Clear(this.CanvaColor);
        }
    }

}
