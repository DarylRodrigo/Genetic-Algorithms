namespace AssignmentII
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.skip10Gen = new System.Windows.Forms.Button();
            this.skip20Gen = new System.Windows.Forms.Button();
            this.skip50Gen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.generationLbl = new System.Windows.Forms.Label();
            this.simulationDisplay = new System.Windows.Forms.PictureBox();
            this.skip100Gen = new System.Windows.Forms.Button();
            this.skip250Gen = new System.Windows.Forms.Button();
            this.skip1000Gen = new System.Windows.Forms.Button();
            this.skip1Gen = new System.Windows.Forms.Button();
            this.play_btn = new System.Windows.Forms.Button();
            this.generationTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.topFitnessLbl = new System.Windows.Forms.Label();
            this.play2_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.crossoverRate_Txt = new System.Windows.Forms.TextBox();
            this.migrationRate_txt = new System.Windows.Forms.TextBox();
            this.Reset_btn = new System.Windows.Forms.Button();
            this.mutationRate_txt = new System.Windows.Forms.TextBox();
            this.numberOfGenes_txt = new System.Windows.Forms.TextBox();
            this.populationSize_txt = new System.Windows.Forms.TextBox();
            this.numberOfDemes_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.randomGenetic_radio = new System.Windows.Forms.RadioButton();
            this.uniformCrossove_radio = new System.Windows.Forms.RadioButton();
            this.noCrossover_radio = new System.Windows.Forms.RadioButton();
            this.onePointCrossover_radio = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.finish_btn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.genLimit_txt = new System.Windows.Forms.TextBox();
            this.startSimulation = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.numberOfIterations_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.results_txt = new System.Windows.Forms.TextBox();
            this.npoint_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.simulationDisplay)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // skip10Gen
            // 
            this.skip10Gen.Location = new System.Drawing.Point(6, 48);
            this.skip10Gen.Name = "skip10Gen";
            this.skip10Gen.Size = new System.Drawing.Size(127, 23);
            this.skip10Gen.TabIndex = 1;
            this.skip10Gen.Text = "10 generations";
            this.skip10Gen.UseVisualStyleBackColor = true;
            this.skip10Gen.Click += new System.EventHandler(this.skip10Gen_Click);
            // 
            // skip20Gen
            // 
            this.skip20Gen.Location = new System.Drawing.Point(6, 77);
            this.skip20Gen.Name = "skip20Gen";
            this.skip20Gen.Size = new System.Drawing.Size(127, 23);
            this.skip20Gen.TabIndex = 2;
            this.skip20Gen.Text = "20 generations";
            this.skip20Gen.UseVisualStyleBackColor = true;
            this.skip20Gen.Click += new System.EventHandler(this.skip20Gen_Click);
            // 
            // skip50Gen
            // 
            this.skip50Gen.Location = new System.Drawing.Point(6, 106);
            this.skip50Gen.Name = "skip50Gen";
            this.skip50Gen.Size = new System.Drawing.Size(127, 23);
            this.skip50Gen.TabIndex = 3;
            this.skip50Gen.Text = "50 generations";
            this.skip50Gen.UseVisualStyleBackColor = true;
            this.skip50Gen.Click += new System.EventHandler(this.skip50Gen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Generation:";
            // 
            // generationLbl
            // 
            this.generationLbl.AutoSize = true;
            this.generationLbl.Location = new System.Drawing.Point(94, 12);
            this.generationLbl.Name = "generationLbl";
            this.generationLbl.Size = new System.Drawing.Size(13, 13);
            this.generationLbl.TabIndex = 5;
            this.generationLbl.Text = "0";
            // 
            // simulationDisplay
            // 
            this.simulationDisplay.Image = ((System.Drawing.Image)(resources.GetObject("simulationDisplay.Image")));
            this.simulationDisplay.Location = new System.Drawing.Point(15, 57);
            this.simulationDisplay.Name = "simulationDisplay";
            this.simulationDisplay.Size = new System.Drawing.Size(210, 210);
            this.simulationDisplay.TabIndex = 6;
            this.simulationDisplay.TabStop = false;
            // 
            // skip100Gen
            // 
            this.skip100Gen.Location = new System.Drawing.Point(6, 135);
            this.skip100Gen.Name = "skip100Gen";
            this.skip100Gen.Size = new System.Drawing.Size(127, 23);
            this.skip100Gen.TabIndex = 7;
            this.skip100Gen.Text = "100 generations";
            this.skip100Gen.UseVisualStyleBackColor = true;
            this.skip100Gen.Click += new System.EventHandler(this.skip100Gen_Click);
            // 
            // skip250Gen
            // 
            this.skip250Gen.Location = new System.Drawing.Point(6, 164);
            this.skip250Gen.Name = "skip250Gen";
            this.skip250Gen.Size = new System.Drawing.Size(127, 23);
            this.skip250Gen.TabIndex = 8;
            this.skip250Gen.Text = "250 generations";
            this.skip250Gen.UseVisualStyleBackColor = true;
            this.skip250Gen.Click += new System.EventHandler(this.skip250Gen_Click);
            // 
            // skip1000Gen
            // 
            this.skip1000Gen.Location = new System.Drawing.Point(6, 193);
            this.skip1000Gen.Name = "skip1000Gen";
            this.skip1000Gen.Size = new System.Drawing.Size(127, 23);
            this.skip1000Gen.TabIndex = 9;
            this.skip1000Gen.Text = "1000 generations";
            this.skip1000Gen.UseVisualStyleBackColor = true;
            this.skip1000Gen.Click += new System.EventHandler(this.skip1000Gen_Click);
            // 
            // skip1Gen
            // 
            this.skip1Gen.Location = new System.Drawing.Point(6, 19);
            this.skip1Gen.Name = "skip1Gen";
            this.skip1Gen.Size = new System.Drawing.Size(127, 23);
            this.skip1Gen.TabIndex = 10;
            this.skip1Gen.Text = "1 generations";
            this.skip1Gen.UseVisualStyleBackColor = true;
            this.skip1Gen.Click += new System.EventHandler(this.skip1Gen_Click);
            // 
            // play_btn
            // 
            this.play_btn.Location = new System.Drawing.Point(15, 295);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(102, 22);
            this.play_btn.TabIndex = 11;
            this.play_btn.Text = "play 100 Gen";
            this.play_btn.UseVisualStyleBackColor = true;
            this.play_btn.Click += new System.EventHandler(this.play_btn_Click);
            // 
            // generationTimer
            // 
            this.generationTimer.Interval = 250;
            this.generationTimer.Tick += new System.EventHandler(this.generationTimer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.skip1Gen);
            this.groupBox1.Controls.Add(this.skip20Gen);
            this.groupBox1.Controls.Add(this.skip1000Gen);
            this.groupBox1.Controls.Add(this.skip10Gen);
            this.groupBox1.Controls.Add(this.skip250Gen);
            this.groupBox1.Controls.Add(this.skip50Gen);
            this.groupBox1.Controls.Add(this.skip100Gen);
            this.groupBox1.Location = new System.Drawing.Point(451, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 343);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skip Generations";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 273);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(210, 16);
            this.progressBar1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Top fitness at generation:";
            // 
            // topFitnessLbl
            // 
            this.topFitnessLbl.AutoSize = true;
            this.topFitnessLbl.Location = new System.Drawing.Point(174, 31);
            this.topFitnessLbl.Name = "topFitnessLbl";
            this.topFitnessLbl.Size = new System.Drawing.Size(10, 13);
            this.topFitnessLbl.TabIndex = 15;
            this.topFitnessLbl.Text = "-";
            // 
            // play2_btn
            // 
            this.play2_btn.Location = new System.Drawing.Point(123, 295);
            this.play2_btn.Name = "play2_btn";
            this.play2_btn.Size = new System.Drawing.Size(102, 22);
            this.play2_btn.TabIndex = 16;
            this.play2_btn.Text = "play 200 Gen";
            this.play2_btn.UseVisualStyleBackColor = true;
            this.play2_btn.Click += new System.EventHandler(this.play2_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.npoint_txt);
            this.groupBox2.Controls.Add(this.crossoverRate_Txt);
            this.groupBox2.Controls.Add(this.migrationRate_txt);
            this.groupBox2.Controls.Add(this.Reset_btn);
            this.groupBox2.Controls.Add(this.mutationRate_txt);
            this.groupBox2.Controls.Add(this.numberOfGenes_txt);
            this.groupBox2.Controls.Add(this.populationSize_txt);
            this.groupBox2.Controls.Add(this.numberOfDemes_txt);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.randomGenetic_radio);
            this.groupBox2.Controls.Add(this.uniformCrossove_radio);
            this.groupBox2.Controls.Add(this.noCrossover_radio);
            this.groupBox2.Controls.Add(this.onePointCrossover_radio);
            this.groupBox2.Location = new System.Drawing.Point(231, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 343);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // crossoverRate_Txt
            // 
            this.crossoverRate_Txt.Location = new System.Drawing.Point(101, 283);
            this.crossoverRate_Txt.Name = "crossoverRate_Txt";
            this.crossoverRate_Txt.Size = new System.Drawing.Size(74, 20);
            this.crossoverRate_Txt.TabIndex = 15;
            this.crossoverRate_Txt.Text = "0.025";
            // 
            // migrationRate_txt
            // 
            this.migrationRate_txt.Location = new System.Drawing.Point(101, 257);
            this.migrationRate_txt.Name = "migrationRate_txt";
            this.migrationRate_txt.Size = new System.Drawing.Size(74, 20);
            this.migrationRate_txt.TabIndex = 14;
            this.migrationRate_txt.Text = "0.005";
            // 
            // Reset_btn
            // 
            this.Reset_btn.Location = new System.Drawing.Point(6, 309);
            this.Reset_btn.Name = "Reset_btn";
            this.Reset_btn.Size = new System.Drawing.Size(202, 23);
            this.Reset_btn.TabIndex = 11;
            this.Reset_btn.Text = "Set";
            this.Reset_btn.UseVisualStyleBackColor = true;
            this.Reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // mutationRate_txt
            // 
            this.mutationRate_txt.Location = new System.Drawing.Point(101, 231);
            this.mutationRate_txt.Name = "mutationRate_txt";
            this.mutationRate_txt.Size = new System.Drawing.Size(74, 20);
            this.mutationRate_txt.TabIndex = 13;
            this.mutationRate_txt.Text = "0.025";
            // 
            // numberOfGenes_txt
            // 
            this.numberOfGenes_txt.Location = new System.Drawing.Point(101, 187);
            this.numberOfGenes_txt.Name = "numberOfGenes_txt";
            this.numberOfGenes_txt.Size = new System.Drawing.Size(74, 20);
            this.numberOfGenes_txt.TabIndex = 12;
            this.numberOfGenes_txt.Text = "40";
            // 
            // populationSize_txt
            // 
            this.populationSize_txt.Location = new System.Drawing.Point(101, 161);
            this.populationSize_txt.Name = "populationSize_txt";
            this.populationSize_txt.Size = new System.Drawing.Size(74, 20);
            this.populationSize_txt.TabIndex = 11;
            this.populationSize_txt.Text = "20";
            // 
            // numberOfDemes_txt
            // 
            this.numberOfDemes_txt.Location = new System.Drawing.Point(101, 135);
            this.numberOfDemes_txt.Name = "numberOfDemes_txt";
            this.numberOfDemes_txt.Size = new System.Drawing.Size(74, 20);
            this.numberOfDemes_txt.TabIndex = 10;
            this.numberOfDemes_txt.Text = "20";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Crossover Rate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Migration Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mutation Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Number of Genes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Population Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of Demes";
            // 
            // randomGenetic_radio
            // 
            this.randomGenetic_radio.AutoSize = true;
            this.randomGenetic_radio.Location = new System.Drawing.Point(6, 94);
            this.randomGenetic_radio.Name = "randomGenetic_radio";
            this.randomGenetic_radio.Size = new System.Drawing.Size(106, 17);
            this.randomGenetic_radio.TabIndex = 3;
            this.randomGenetic_radio.Text = "n point crossover";
            this.randomGenetic_radio.UseVisualStyleBackColor = true;
            this.randomGenetic_radio.CheckedChanged += new System.EventHandler(this.randomGenetic_radio_CheckedChanged);
            // 
            // uniformCrossove_radio
            // 
            this.uniformCrossove_radio.AutoSize = true;
            this.uniformCrossove_radio.Location = new System.Drawing.Point(6, 48);
            this.uniformCrossove_radio.Name = "uniformCrossove_radio";
            this.uniformCrossove_radio.Size = new System.Drawing.Size(111, 17);
            this.uniformCrossove_radio.TabIndex = 2;
            this.uniformCrossove_radio.Text = "Uniform Crossover";
            this.uniformCrossove_radio.UseVisualStyleBackColor = true;
            // 
            // noCrossover_radio
            // 
            this.noCrossover_radio.AutoSize = true;
            this.noCrossover_radio.Location = new System.Drawing.Point(6, 71);
            this.noCrossover_radio.Name = "noCrossover_radio";
            this.noCrossover_radio.Size = new System.Drawing.Size(89, 17);
            this.noCrossover_radio.TabIndex = 1;
            this.noCrossover_radio.Text = "No Crossover";
            this.noCrossover_radio.UseVisualStyleBackColor = true;
            // 
            // onePointCrossover_radio
            // 
            this.onePointCrossover_radio.AutoSize = true;
            this.onePointCrossover_radio.Checked = true;
            this.onePointCrossover_radio.Location = new System.Drawing.Point(6, 25);
            this.onePointCrossover_radio.Name = "onePointCrossover_radio";
            this.onePointCrossover_radio.Size = new System.Drawing.Size(122, 17);
            this.onePointCrossover_radio.TabIndex = 0;
            this.onePointCrossover_radio.TabStop = true;
            this.onePointCrossover_radio.Text = "One Point Crossover";
            this.onePointCrossover_radio.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(623, 387);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.finish_btn);
            this.tabPage1.Controls.Add(this.simulationDisplay);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.generationLbl);
            this.tabPage1.Controls.Add(this.play2_btn);
            this.tabPage1.Controls.Add(this.play_btn);
            this.tabPage1.Controls.Add(this.topFitnessLbl);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(615, 361);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            // 
            // finish_btn
            // 
            this.finish_btn.Location = new System.Drawing.Point(15, 319);
            this.finish_btn.Name = "finish_btn";
            this.finish_btn.Size = new System.Drawing.Size(210, 22);
            this.finish_btn.TabIndex = 18;
            this.finish_btn.Text = "Play till Finish";
            this.finish_btn.UseVisualStyleBackColor = true;
            this.finish_btn.Click += new System.EventHandler(this.finish_btn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.results_txt);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(615, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Logging";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.genLimit_txt);
            this.groupBox3.Controls.Add(this.startSimulation);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.numberOfIterations_txt);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 171);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Settings";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Generation Limit";
            // 
            // genLimit_txt
            // 
            this.genLimit_txt.Location = new System.Drawing.Point(9, 85);
            this.genLimit_txt.Name = "genLimit_txt";
            this.genLimit_txt.Size = new System.Drawing.Size(100, 20);
            this.genLimit_txt.TabIndex = 3;
            this.genLimit_txt.Text = "1000";
            // 
            // startSimulation
            // 
            this.startSimulation.Location = new System.Drawing.Point(6, 118);
            this.startSimulation.Name = "startSimulation";
            this.startSimulation.Size = new System.Drawing.Size(103, 23);
            this.startSimulation.TabIndex = 2;
            this.startSimulation.Text = "Start Simulation";
            this.startSimulation.UseVisualStyleBackColor = true;
            this.startSimulation.Click += new System.EventHandler(this.startSimulation_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Number Of Iterations";
            // 
            // numberOfIterations_txt
            // 
            this.numberOfIterations_txt.Location = new System.Drawing.Point(9, 46);
            this.numberOfIterations_txt.Name = "numberOfIterations_txt";
            this.numberOfIterations_txt.Size = new System.Drawing.Size(100, 20);
            this.numberOfIterations_txt.TabIndex = 0;
            this.numberOfIterations_txt.Text = "3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(232, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Results";
            // 
            // results_txt
            // 
            this.results_txt.Location = new System.Drawing.Point(235, 19);
            this.results_txt.Multiline = true;
            this.results_txt.Name = "results_txt";
            this.results_txt.Size = new System.Drawing.Size(374, 321);
            this.results_txt.TabIndex = 1;
            // 
            // npoint_txt
            // 
            this.npoint_txt.Location = new System.Drawing.Point(134, 93);
            this.npoint_txt.Name = "npoint_txt";
            this.npoint_txt.Size = new System.Drawing.Size(74, 20);
            this.npoint_txt.TabIndex = 16;
            this.npoint_txt.Text = "2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 409);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "A Simple Two-Module Problem to Exemplify Building-Block Assembly Under Crossover";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.simulationDisplay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button skip10Gen;
        private System.Windows.Forms.Button skip20Gen;
        private System.Windows.Forms.Button skip50Gen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label generationLbl;
        private System.Windows.Forms.PictureBox simulationDisplay;
        private System.Windows.Forms.Button skip100Gen;
        private System.Windows.Forms.Button skip250Gen;
        private System.Windows.Forms.Button skip1000Gen;
        private System.Windows.Forms.Button skip1Gen;
        private System.Windows.Forms.Button play_btn;
        private System.Windows.Forms.Timer generationTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label topFitnessLbl;
        private System.Windows.Forms.Button play2_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton randomGenetic_radio;
        private System.Windows.Forms.RadioButton uniformCrossove_radio;
        private System.Windows.Forms.RadioButton noCrossover_radio;
        private System.Windows.Forms.RadioButton onePointCrossover_radio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox crossoverRate_Txt;
        private System.Windows.Forms.TextBox migrationRate_txt;
        private System.Windows.Forms.TextBox mutationRate_txt;
        private System.Windows.Forms.TextBox numberOfGenes_txt;
        private System.Windows.Forms.TextBox populationSize_txt;
        private System.Windows.Forms.TextBox numberOfDemes_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Reset_btn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button finish_btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button startSimulation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox numberOfIterations_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox results_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox genLimit_txt;
        private System.Windows.Forms.TextBox npoint_txt;
    }
}

