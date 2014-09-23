using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentII
{
    class GlobalVar
    {
        static Random rnd = new Random();
        static double[,] fitnessLnd;
        static int[,] _display;
        static double crossoverrate = 0.005;
        static double migrationrate = 0.005;
        static Boolean topfitnessreached = false;
        static double mutationrate = 0.025;
        static int crossovertype = 1;
        static int landscapesize = 21;
        static int npoint = 2;

        public static Random GlobalRandom
        {
            get
            {
                return rnd;
            }

            set
            {
                rnd = value;
            }
        }

        public static Boolean topFitnessReached
        {
            get
            {
                return topfitnessreached;
            }

            set
            {
                topfitnessreached = value;
            }
        }

        public static int[,] display
        {
            get
            {
                return _display;
            }

            set
            {
                _display = value;
            }
        }

        public static int landscapeSize
        {
            get
            {
                return landscapesize;
            }

            set
            {
                landscapesize = value;
            }
        }

        public static int nPoint
        {
            get
            {
                return npoint;
            }

            set
            {
                npoint = value;
            }
        }

        public static int crossoverType
        {
            get
            {
                return crossovertype;
            }

            set
            {
                crossovertype = value;
            }
        }

        public static double[,] fitnessLandscape
        {
            get
            {
                return fitnessLnd;
            }

            set
            {
                fitnessLnd = value;
            }
        }

        public static double getFitness(int i, int j)
        {

            return fitnessLandscape[i, j];
        }

        public static double crossoverRate
        {
            get
            {
                return crossoverrate;
            }

            set
            {
                crossoverrate = value;
            }
        }

        public static double migrationRate
        {
            get
            {
                return migrationrate;
            }

            set
            {
                migrationrate = value;
            }
        }

        public static double mutationRate
        {
            get
            {
                return mutationrate;
            }

            set
            {
                mutationrate = value;
            }
        }
    }
}
