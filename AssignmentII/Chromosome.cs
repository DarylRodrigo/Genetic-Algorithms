using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentII
{
    class Chromosome
    {
        private short[] genes;
        private double mutationRate;
        private short ifitness;
        private short jfitness;

        public Chromosome(short length) {
            this.genes = new short[length];
            //this.mutationRate = 1 / (double)length;
            this.mutationRate = GlobalVar.mutationRate;

            for (int i = 0; i < length; i++) {
                //this.genes[i] = (short) GlobalVar.GlobalRandom.Next(0, 2);
                //Console.Write(this.genes[i]);
                this.genes[i] = 0;
            }

            this.evaluateFitness();

        }

        public void mutate() {

            for (int i = 0; i < this.genes.Length; i++) {
                double random = (double) GlobalVar.GlobalRandom.Next(0, 10000) / 10000;

                if (random < this.mutationRate) {
                    if (this.genes[i] == 1) { this.genes[i] = 0; }
                    else { this.genes[i] = 1; }
                }

                //Console.Write(this.genes[i]);
            }

            //Console.WriteLine();

            this.evaluateFitness();
        }

        public void evaluateFitness() {
            short icount = 0;
            short jcount = 0;

            for (int i = 0; i < this.genes.Length/2; i++) {
                if (this.genes[i] == 1) { icount++; }
            }

            for (int i = this.genes.Length / 2; i < this.genes.Length; i++)
            {
                if (this.genes[i] == 1) { jcount++; }
            }

            this.ifitness = icount;
            this.jfitness = jcount;

            //Console.WriteLine("ifit = " + icount +  ", jfit = " + jcount);
        }

        public Chromosome crossover(Chromosome c) {

            Chromosome tmp = new Chromosome((short)c.genes.Length);
            double random = (double)GlobalVar.GlobalRandom.Next(0, 10000) / 10000;

            switch (GlobalVar.crossoverType) { 
                //one point crossover
                case 0:
                    int splitLocation = 0;
                    random = (double) GlobalVar.GlobalRandom.Next(0, 10000) / 10000;

                    while (random > GlobalVar.crossoverRate) {
                        random = (double)GlobalVar.GlobalRandom.Next(0, 10000) / 10000;
                        splitLocation++;
                    }

                    int limit = (GlobalVar.landscapeSize - 1) * 2;

                    if (splitLocation > limit) { splitLocation = limit - 1; }


                    for (int i = 0; i < splitLocation; i++) {
                        tmp.genes[i] = this.genes[i];
                    }

                    for (int i = splitLocation; i < tmp.genes.Length; i++)
                    {
                        tmp.genes[i] = c.genes[i];
                    }
                    break;

                //uniform crossover
                case 1:
                    for (int i = 0; i < tmp.genes.Length; i++)
                    {
                        double select = GlobalVar.GlobalRandom.Next(0, 100) / 100;

                        if (select > 0.5)
                        {
                            tmp.genes[i] = c.genes[i];
                        }
                        else {
                            tmp.genes[i] = this.genes[i];
                        }
                    }
                    break;

                //n point crossover
                case 3:
                    
                    int[] breakPoint = new int[GlobalVar.nPoint];
                    int currentPoint = 0;
                    int nSplitLocation = 0;
                    Boolean geneSelect = true;
                    Boolean finished = false;

                    for (int j = 0; j < GlobalVar.nPoint; j++)
                    {
                        
                        random = (double)GlobalVar.GlobalRandom.Next(0, 10000) / 10000;

                        while (!finished)
                        {
                            while (random > GlobalVar.crossoverRate)
                            {
                                random = (double)GlobalVar.GlobalRandom.Next(0, 10000) / 10000;
                                nSplitLocation++;
                            }

                            if (nSplitLocation > this.genes.Length || breakPoint.Contains(nSplitLocation))
                            {
                                random = (double)GlobalVar.GlobalRandom.Next(0, 10000) / 10000;
                                nSplitLocation = 0;
                            }
                            else {
                                finished = true;
                            }

                            
                        }

                        breakPoint[j] = nSplitLocation;
                        nSplitLocation = 0;
                        finished = false;
                    }  

                    Array.Sort(breakPoint);

                    
                    for (int j = 0; j < GlobalVar.nPoint; j++)
                    {

                        for (int i = currentPoint; i < breakPoint[j]; i++)
                        {
                            if (geneSelect == true)
                            {
                                tmp.genes[i] = c.genes[i];
                            }
                            else
                            {
                                tmp.genes[i] = this.genes[i];
                            }
                        }

                        currentPoint = breakPoint[j];
                        geneSelect = !geneSelect;
                    }

                     for (int i = currentPoint; i < this.genes.Length; i++)
                        {
                            if (geneSelect == true)
                            {
                                tmp.genes[i] = c.genes[i];
                            }
                            else
                            {
                                tmp.genes[i] = this.genes[i];
                            }
                        }

                     //Console.WriteLine();

                    break;
                
                default:
                    Console.Write("ERROR");
                    break;
                }

            tmp.evaluateFitness();
            return tmp;
            
        }

        public short ifit
        {
            get
            {
                return this.ifitness;
            }

            set
            {
                this.ifitness = value;
            }
        }

        public short jfit
        {
            get
            {
                return this.jfitness;
            }

            set
            {
                this.jfitness = value;
            }
        }
    }
}
