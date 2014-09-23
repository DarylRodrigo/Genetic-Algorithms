using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentII
{
    class Individual
    {
        private Chromosome[] c;
        private double totalFitness;
        private int iFitness;
        private int jFitness;

        public Individual(short length) {
            this.c = new Chromosome[1];

            for(int i = 0; i < c.Length; i ++) {
                this.c[i] = new Chromosome(length);
            }
        }

        public void mutate(){
            for(int i = 0; i < c.Length; i ++) {
                this.c[i].mutate();
            }
        }

        public double calculateFitness() {
            iFitness = this.c[0].ifit;
            jFitness = this.c[0].jfit;

            totalFitness = GlobalVar.getFitness(iFitness, jFitness);

            if (iFitness == (GlobalVar.landscapeSize - 1) && jFitness == (GlobalVar.landscapeSize-1)) { 
                GlobalVar.topFitnessReached = true; 
            }

            return totalFitness;
        }


        public Individual crossover(Individual ind) {
            Individual tmp = new Individual((short) ind.c.Length);

            for (int i = 0; i < tmp.c.Length; i++) {
                tmp.c[0] = this.c[0].crossover(ind.c[0]);
            }

            tmp.calculateFitness();
            return tmp;
        }

        public int ifit
        {
            get
            {
                return this.iFitness;
            }

            set
            {
                this.iFitness = value;
            }
        }

        public int jfit
        {
            get
            {
                return this.jFitness;
            }

            set
            {
                this.jFitness = value;
            }
        }

    }
}
