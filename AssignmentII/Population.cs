using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentII
{
    class Population
    {
        private Individual[] individuals;
        private int geneLength;

        public Population(short populationSize, short _geneLength)
        {
            this.individuals = new Individual[populationSize];
            geneLength = _geneLength;
            
            for(int i = 0; i < individuals.Length; i ++) {
                this.individuals[i] = new Individual(_geneLength);
                this.individuals[i].calculateFitness();
            }

            
        }

        public Population migration(Population p1) {

            Population tmpPop = this;

            Individual tmp1;
            Individual tmp2;
            
            Array.Sort(p1.individuals, delegate(Individual ind1, Individual ind2)
            {
                return (ind2.calculateFitness().CompareTo(ind1.calculateFitness()));
            });

            Array.Sort(this.individuals, delegate(Individual ind1, Individual ind2)
            {
                return (ind2.calculateFitness().CompareTo(ind1.calculateFitness()));
            });

            //Migration of second best individual
            int individualSelect = GlobalVar.GlobalRandom.Next(0, this.individuals.Length);
            //int individualSelect = 0;

            tmp1 = this.individuals[individualSelect];
            tmp2 = p1.individuals[individualSelect];

            this.individuals[individualSelect] = tmp2;
            p1.individuals[individualSelect] = tmp1;

            return tmpPop;
        }

        public void mutate(int elitism){
            //Find top candidates
            Array.Sort(individuals, delegate(Individual ind1, Individual ind2) { 
                    return( ind1.calculateFitness().CompareTo(ind2.calculateFitness()));
                });
            
            //Mutate all in the population
            for (int i = 0; i < individuals.Length - elitism; i++)
            {
                this.individuals[i].mutate();
            }
        }

        public void hillclimb(int elitism){
            //Find top candidates
            Array.Sort(individuals, delegate(Individual ind1, Individual ind2)
            {
                return (ind1.calculateFitness().CompareTo(ind2.calculateFitness()));
            });

            Individual old = new Individual((short)this.geneLength);

            for (int i = 0; i < individuals.Length - elitism; i++)
            {
                old = this.individuals[i];
                this.individuals[i].mutate();

                if (this.individuals[i].calculateFitness() < old.calculateFitness())
                {
                    this.individuals[i] = old;
                }
            }
        }

        public Individual maxFitness() {
            double maxFit = 0;
            Individual maxFitIndividual = new Individual(0);

            for (int i = 0; i < individuals.Length; i++)
            {
                 double temp = this.individuals[i].calculateFitness();

                 if (maxFit < temp) {
                     maxFit = temp;
                     maxFitIndividual = this.individuals[i];
                 }
            }

            return maxFitIndividual;
            
        }

        public double averageFitness() {
            double average = 0;

            for (int i = 0; i < this.individuals.Length; i++) {
                average += this.individuals[i].calculateFitness();
            }

            average = average / this.individuals.Length;

            return average;
        }

        public Population crossover() {
            Population tmp = new Population((short) this.individuals.Length, (short) this.geneLength);

            //Make Roulette Wheel
            int sum = 0;
            double[] wheel = new double[this.individuals.Length];

            for (int i = 0; i < this.individuals.Length; i++)
            {
                sum += Convert.ToInt32(this.individuals[i].calculateFitness());
                wheel[i] = sum;

            }

            //Do crossover
            for (int i = 0; i < tmp.individuals.Length; i++) {
                Individual ind1, ind2;

                //pick two individuals to crossover based on fitness
                ulong random = (ulong) GlobalVar.GlobalRandom.Next(0, sum);
                int j = 0, k = 0;

                while (wheel[j] <= random)
                {
                    ind1 = this.individuals[j];
                    j++;
                }

                random = (ulong) GlobalVar.GlobalRandom.Next(0, sum);

                while (wheel[k] <= random)
                {
                    ind2 = this.individuals[k];
                    k++;
                }
                
                tmp.individuals[i] = this.individuals[k].crossover(this.individuals[j]);
                
            }

            return tmp;
        }
        
    }
}
