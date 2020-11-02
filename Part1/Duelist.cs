using System;
using System.Collections.Generic;
using System.Text;

namespace Part1
{
    class Duelist
    {
        private double acc;
        private string name;
        private bool isAlive;
        private Random rand;


        public Duelist (double a, string n)
        {
            isAlive = true;
            acc = a;
            name = n;
            rand = new Random();

        }

        public void ShootAt(Duelist other)
        {
            if (acc > (rand.NextDouble() * 100))
            {
                other.SetIsAlive(false);
            }
        }

        public double GetAcc()
        {
            return acc;
        }
        public string GetName()
        {
            return name;
        }
        public bool GetIsAlive()
        {
            return isAlive;
        }

        public void SetAcc(double a)
        {
            acc = a;
        }

        public void SetIsAlive(bool a)
        {
            isAlive = a;
        }

        
        // Didn't end up using this but may have been useful to see who shoots first or to see who
        // gets shot at for larger duels
        public bool MoreAcc(Duelist other)
        {
            return (this.acc > other.acc);
        }








        

    }
}
