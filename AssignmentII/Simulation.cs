using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AssignmentII
{
    class Simulation
    {
        //global variables within simulation
        private int LANDSCAPE_SIZE;
        private const int ELITISM = 2; //top 2 remain

        private Population[] pop;
        private double[,] fitnessLandscape;
        private double[,] noise;

        public Simulation(short populationSize, short geneLength, short numberOfPopulations){         
            //initialise fitnesslandscape
            LANDSCAPE_SIZE = GlobalVar.landscapeSize;

            fitnessLandscape = new double[LANDSCAPE_SIZE, LANDSCAPE_SIZE];
            noise = new double[LANDSCAPE_SIZE, LANDSCAPE_SIZE];
            

            this.generateFitnessLandscape();



            pop = new Population[numberOfPopulations];

            for (int i = 0; i < numberOfPopulations; i++)
            {
                this.pop[i] = new Population(populationSize, geneLength);
            }
        }

        public void simulateGen(int gen) {
            //Loop over desired number of populations
            for (int i = 0; i < gen; i++)
            {
                //update each individual population
                for (int j = 0; j < pop.Length; j++)
                {
                    if (GlobalVar.crossoverType != 2)
                    {
                        this.pop[j] = this.pop[j].crossover();
                        this.pop[j].mutate(0);
                    }
                    else {
                        this.pop[j].hillclimb(ELITISM);
                        //this.pop[j].mutate(ELITISM);
                    }
                    

                    double randMig = (double)GlobalVar.GlobalRandom.Next(0, 10000) / 10000;

                    if (randMig < GlobalVar.migrationRate)
                    {
                        int random = GlobalVar.GlobalRandom.Next(0, pop.Length);
                        this.pop[random] = this.pop[j].migration(this.pop[random]); 
                        //Console.WriteLine("migrate from :" + j +  " to " + random);
                    }
                }
            }

            //update display and show most fit individual for each population
            for (int j = 0; j < pop.Length; j++) {
                Individual maxFitInPop = this.pop[j].maxFitness();
                GlobalVar.display[maxFitInPop.ifit, maxFitInPop.jfit] = 1;
            }

            
        }

        public void generateFitnessLandscape()
        {
            String noiseText = "";

            //Generate Noise
            for (int i = 0; i < LANDSCAPE_SIZE; i++) {
                for (int j = 0; j < LANDSCAPE_SIZE; j++){
                    double random = (double)GlobalVar.GlobalRandom.Next(5000, 10000) / 10000;
                    this.noise[i, j] = random;

                    noiseText = noiseText + this.noise[i, j] + ", ";
                }

                noiseText = noiseText + Environment.NewLine;
            }

            using (StreamWriter writer = new StreamWriter("noise.csv"))
            {
                writer.Write(noiseText);
            }

            //Generate Fitnesslandscape
            String landscapeText = "";
            String function = "";

            for (int i = 0; i < LANDSCAPE_SIZE; i++)
            {
                

                for (int j = 0; j < LANDSCAPE_SIZE; j++)
                {
                    double e1 = Math.Pow(2, i);
                    double e2 = Math.Pow(2,j);

                    //Ensures 2^imax and 2^jmax is always the largest
                     if (i == LANDSCAPE_SIZE - 1 && j == LANDSCAPE_SIZE - 1) { this.fitnessLandscape[i, j] = (e1 + e2);  }
                    else { this.fitnessLandscape[i, j] = (e1 + e2) * this.noise[i, j]; }

                     double bla = e1 + e2;
                     function = function + bla + ", ";

                    //this.fitnessLandscape[i, j] = (e1 + e2) * this.noise[i, j];

                    landscapeText = landscapeText + this.fitnessLandscape[i,j] + ", ";
                }

                landscapeText = landscapeText + Environment.NewLine;
                function = function + Environment.NewLine;

               
            }

            //write landscape to file
            using (StreamWriter writer = new StreamWriter("fitnesslandscape.csv"))
            {
                writer.Write(landscapeText);
            }

            using (StreamWriter writer = new StreamWriter("landscape.csv"))
            {
                writer.Write(function);
            }

            //set fitnesslandscape as a global Variable to be used in other classes
            GlobalVar.fitnessLandscape = this.fitnessLandscape;
        }
    }
}
