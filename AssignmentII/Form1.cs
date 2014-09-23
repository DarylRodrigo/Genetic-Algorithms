using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace AssignmentII
{
    public partial class Form1 : Form
    {
        //Initial Variables
        Simulation s;
        int generation;
        int playgen = 0;
        short numberOfPopulations;
        short populationSize;
        short geneLength;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initial Variabls
            updateSettings();
            resetDisplay(GlobalVar.landscapeSize);
            generation = 0;
            s = new Simulation(populationSize, geneLength, numberOfPopulations);      
        }

        private void updateSettings(){
            

            numberOfPopulations = (short) Convert.ToInt16(numberOfDemes_txt.Text);
            populationSize = (short)Convert.ToInt16(populationSize_txt.Text);
            geneLength = (short)Convert.ToInt16(numberOfGenes_txt.Text);

            GlobalVar.migrationRate = Convert.ToDouble(migrationRate_txt.Text);
            GlobalVar.crossoverRate = Convert.ToDouble(crossoverRate_Txt.Text);
            GlobalVar.mutationRate = Convert.ToDouble(mutationRate_txt.Text);

            if (onePointCrossover_radio.Checked == true) { GlobalVar.crossoverType = 0; }
            else if (uniformCrossove_radio.Checked == true) { GlobalVar.crossoverType = 1; }
            else if (noCrossover_radio.Checked == true) { GlobalVar.crossoverType = 2; }
            else if (randomGenetic_radio.Checked == true) { GlobalVar.crossoverType = 3; }

            GlobalVar.nPoint = Convert.ToInt16(npoint_txt.Text);
            GlobalVar.landscapeSize = (geneLength / 2) + 1;
        }

        private void updateForm()
        {
            generationLbl.Text = generation.ToString();
            drawDisplay(GlobalVar.landscapeSize);

        }

        private void resetDisplay(int size)
        {

            int[,] temp = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    temp[i, j] = 0;
                }
            }

            GlobalVar.display = temp;
        }

        private void drawDisplay(int size) {
            Bitmap tmp = new Bitmap(simulationDisplay.Image);

            int division = (size - 1) / 2;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (GlobalVar.display[i, j] == 1)
                    {
                        tmp.SetPixel(i * 200 / size, j * 200 / size, Color.Black);
                    }
                    else {
                        tmp.SetPixel(i * 200 / size, j * 200 / size, Color.White);
                    }
                }
            }

            simulationDisplay.Image = tmp;
        }

        private void skipGen(int numberOfGen)
        {
            resetDisplay(GlobalVar.landscapeSize);

            s.simulateGen(numberOfGen);
            generation += numberOfGen;

            updateForm();
        }

        #region Buttons

        private void skip10Gen_Click(object sender, EventArgs e)
        {
            skipGen(10);
        }

        private void skip20Gen_Click(object sender, EventArgs e)
        {
            skipGen(20);
        }

        private void skip50Gen_Click(object sender, EventArgs e)
        {
            skipGen(50);
        }

        private void skip100Gen_Click(object sender, EventArgs e)
        {
            skipGen(100);
        }

        private void skip250Gen_Click(object sender, EventArgs e)
        {
            skipGen(250);
        }

        private void skip1000Gen_Click(object sender, EventArgs e)
        {
            skipGen(1000);
        }

        

        private void skip1Gen_Click(object sender, EventArgs e)
        {
            skipGen(1);
        }

        private void play_btn_Click(object sender, EventArgs e)
        {
            //Initial Variabls
            resetDisplay(GlobalVar.landscapeSize);
            drawDisplay(GlobalVar.landscapeSize);
            generation = 0;
            updateSettings();
            progressBar1.Value = 0;
            s = new Simulation(populationSize, geneLength, numberOfPopulations);   

            generationTimer.Enabled = true;
            playgen = 100;
        }

        private void play2_btn_Click(object sender, EventArgs e)
        {
            //Initial Variabls
            resetDisplay(GlobalVar.landscapeSize);
            drawDisplay(GlobalVar.landscapeSize);
            generation = 0;
            updateSettings();
            progressBar1.Value = 0;
            s = new Simulation(populationSize, geneLength, numberOfPopulations);   

            generationTimer.Enabled = true;
            playgen = 200;
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            //Initial Variabls
            resetDisplay(GlobalVar.landscapeSize);
            drawDisplay(GlobalVar.landscapeSize);
            generation = 0;
            updateSettings();
            progressBar1.Value = 0;
            s = new Simulation(populationSize, geneLength, numberOfPopulations);

            GlobalVar.topFitnessReached = false;
        }

        private void generationTimer_Tick(object sender, EventArgs e)
        {
            if (playgen == 100)
            {
                skipGen(1);
                progressBar1.Value = generation;

                if (generation == 100 || GlobalVar.topFitnessReached == true) { 
                    generationTimer.Enabled = false; 
                }
            }
            else if (playgen == 200)
            {
                skipGen(1);
                progressBar1.Value = generation / 2;

                if (generation == 200 || GlobalVar.topFitnessReached == true) { 
                    generationTimer.Enabled = false; 
                }
            }
        }

        private void finish_btn_Click(object sender, EventArgs e)
        {
            GlobalVar.topFitnessReached = false;
            resetDisplay(GlobalVar.landscapeSize);
            generation = 0;
            updateSettings();
            s = new Simulation(populationSize, geneLength, numberOfPopulations); 

            while (GlobalVar.topFitnessReached == false)
            {
                s.simulateGen(1);
                generation += 1;
            }

            generationLbl.Text = generation.ToString();
        }

        private void startSimulation_Click(object sender, EventArgs e)
        {
            updateSettings();

            int numberOfIterations = Convert.ToInt16(numberOfIterations_txt.Text);
            int genLimit = Convert.ToInt16(genLimit_txt.Text);

            String resultText = "-> Start Results <-" + Environment.NewLine + Environment.NewLine;

            for (int i = 0; i < numberOfIterations; i++){
                generation = 0;

                s = new Simulation(populationSize, geneLength, numberOfPopulations);
                GlobalVar.topFitnessReached = false;

                while (GlobalVar.topFitnessReached == false)
                {
                    s.simulateGen(1);
                    generation += 1;
                    if (generation > genLimit) { GlobalVar.topFitnessReached = true; }
                }

                results_txt.Text = results_txt.Text + generation + Environment.NewLine;
                
            }

        }

        #endregion

        private void randomGenetic_radio_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
