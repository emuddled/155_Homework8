using System;
using System.Collections.Generic;
using System.Text;

namespace Part1
{
    class Duel
    {
        private Duelist d1;  
        private Duelist d2; 
        private Duelist d3;  

        

        public Duel(Duelist a, Duelist b, Duelist c)
        {
            d1 = a;
            d2 = b;
            d3 = c;

        }

        
        public string RunDuelStrat1()
        {
            do
            {
                if (d1.GetIsAlive())
                {
                    if (d3.GetIsAlive())
                    {
                        d1.ShootAt(d3);
                    }
                    else if (d2.GetIsAlive())
                    {
                        d1.ShootAt(d2);
                    }
                    else
                    {
                        return d1.GetName();
                    }

                }

                if (d2.GetIsAlive())
                {
                    if (d3.GetIsAlive())
                    {
                        d2.ShootAt(d3);
                    }
                    else if (d1.GetIsAlive())
                    {
                        d2.ShootAt(d1);
                    }
                    else
                    {
                        return d2.GetName();
                    }
                }

                if (d3.GetIsAlive())
                {
                    if (d2.GetIsAlive())
                    {
                        d3.ShootAt(d2);
                    }
                    else if (d1.GetIsAlive())
                    {
                        d3.ShootAt(d1);
                    }
                    else
                    {
                        return d3.GetName();
                    }
                }
            } while (d1.GetIsAlive() || d2.GetIsAlive() || d3.GetIsAlive());
            return "This shouldn't happen";
        }


        public string RunDuelStrat2()
        {
            do
            {
                if (d2.GetIsAlive())
                {
                    if (d3.GetIsAlive())
                    {
                        d2.ShootAt(d3);
                    }
                    else if (d1.GetIsAlive())
                    {
                        d2.ShootAt(d1);
                    }
                    else
                    {
                        return d2.GetName();
                    }
                }

                if (d3.GetIsAlive())
                {
                    if (d2.GetIsAlive())
                    {
                        d3.ShootAt(d2);
                    }
                    else if (d1.GetIsAlive())
                    {
                        d3.ShootAt(d1);
                    }
                    else
                    {
                        return d3.GetName();
                    }
                }

                if (d1.GetIsAlive())  //shifted the first shooter to shoot last
                {
                    if (d3.GetIsAlive())
                    {
                        d1.ShootAt(d3);
                    }
                    else if (d2.GetIsAlive())
                    {
                        d1.ShootAt(d2);
                    }
                    else
                    {
                        return d1.GetName();
                    }

                }
            } while (d1.GetIsAlive() || d2.GetIsAlive() || d3.GetIsAlive());
            
            return "This shouldn't happen";
        }

        public void ResetLife()
        {
            d1.SetIsAlive(true);
            d2.SetIsAlive(true);
            d3.SetIsAlive(true);
        }


    }
}
