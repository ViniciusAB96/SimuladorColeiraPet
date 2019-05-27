namespace SimuladorPET
{
    partial class Simulador
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simulador));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tempBar = new System.Windows.Forms.TrackBar();
            this.textDistancia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.batmCardBar = new System.Windows.Forms.TrackBar();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.comboColeiras = new System.Windows.Forms.ComboBox();
            this.buttonDesligarColeira = new System.Windows.Forms.Button();
            this.TimerAplicacao = new System.Windows.Forms.Timer(this.components);
            this.labelBatmCard = new System.Windows.Forms.Label();
            this.labelTemp = new System.Windows.Forms.Label();
            this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batmCardBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SimuladorPET.Properties.Resources.banner;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1182, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tempBar
            // 
            this.tempBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tempBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tempBar.LargeChange = 2;
            this.tempBar.Location = new System.Drawing.Point(24, 184);
            this.tempBar.Maximum = 55;
            this.tempBar.Name = "tempBar";
            this.tempBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tempBar.Size = new System.Drawing.Size(56, 553);
            this.tempBar.TabIndex = 2;
            this.tempBar.Value = 36;
            this.tempBar.Scroll += new System.EventHandler(this.tempBar_Scroll);
            // 
            // textDistancia
            // 
            this.textDistancia.Location = new System.Drawing.Point(820, 294);
            this.textDistancia.Name = "textDistancia";
            this.textDistancia.ReadOnly = true;
            this.textDistancia.Size = new System.Drawing.Size(183, 22);
            this.textDistancia.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Temperatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 616);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "10ºC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 665);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "5ºC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 570);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "15ºC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 523);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "20ºC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "25ºC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "30ºC";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "35ºC";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "45ºC";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(63, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "50ºC";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(63, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "55ºC";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(63, 710);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "0ºC";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(63, 332);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 17);
            this.label13.TabIndex = 17;
            this.label13.Text = "40ºC";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(817, 274);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 17);
            this.label14.TabIndex = 18;
            this.label14.Text = "Distancia Percorrida";
            // 
            // batmCardBar
            // 
            this.batmCardBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.batmCardBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.batmCardBar.Location = new System.Drawing.Point(167, 184);
            this.batmCardBar.Maximum = 250;
            this.batmCardBar.Name = "batmCardBar";
            this.batmCardBar.Size = new System.Drawing.Size(964, 56);
            this.batmCardBar.SmallChange = 2;
            this.batmCardBar.TabIndex = 19;
            this.batmCardBar.TickFrequency = 5;
            this.batmCardBar.Value = 55;
            this.batmCardBar.Scroll += new System.EventHandler(this.batmCardBar_Scroll);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(612, 164);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(143, 17);
            this.label15.TabIndex = 20;
            this.label15.Text = "Batimentos cardíacos";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(174, 223);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 17);
            this.label16.TabIndex = 21;
            this.label16.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(209, 224);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 17);
            this.label17.TabIndex = 22;
            this.label17.Text = "10";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(249, 223);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(24, 17);
            this.label18.TabIndex = 23;
            this.label18.Text = "20";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(284, 223);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(24, 17);
            this.label19.TabIndex = 24;
            this.label19.Text = "30";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(323, 223);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(24, 17);
            this.label20.TabIndex = 25;
            this.label20.Text = "40";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(357, 223);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(24, 17);
            this.label21.TabIndex = 26;
            this.label21.Text = "50";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(395, 223);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(24, 17);
            this.label22.TabIndex = 27;
            this.label22.Text = "60";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(467, 223);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(24, 17);
            this.label23.TabIndex = 28;
            this.label23.Text = "80";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(504, 223);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(24, 17);
            this.label24.TabIndex = 29;
            this.label24.Text = "90";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(538, 223);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(32, 17);
            this.label25.TabIndex = 30;
            this.label25.Text = "100";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(576, 223);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(32, 17);
            this.label26.TabIndex = 31;
            this.label26.Text = "110";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(612, 223);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(32, 17);
            this.label27.TabIndex = 32;
            this.label27.Text = "120";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(649, 223);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(32, 17);
            this.label28.TabIndex = 33;
            this.label28.Text = "130";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(686, 223);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(32, 17);
            this.label29.TabIndex = 34;
            this.label29.Text = "140";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(723, 223);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(32, 17);
            this.label30.TabIndex = 35;
            this.label30.Text = "150";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(761, 223);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(32, 17);
            this.label31.TabIndex = 36;
            this.label31.Text = "160";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(800, 223);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(32, 17);
            this.label32.TabIndex = 37;
            this.label32.Text = "170";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(837, 223);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(32, 17);
            this.label33.TabIndex = 38;
            this.label33.Text = "180";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(874, 223);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(32, 17);
            this.label34.TabIndex = 39;
            this.label34.Text = "190";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(910, 223);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(32, 17);
            this.label35.TabIndex = 40;
            this.label35.Text = "200";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(947, 223);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(32, 17);
            this.label36.TabIndex = 41;
            this.label36.Text = "210";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(984, 223);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(32, 17);
            this.label37.TabIndex = 42;
            this.label37.Text = "220";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(1022, 223);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(32, 17);
            this.label38.TabIndex = 43;
            this.label38.Text = "230";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(1059, 223);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(32, 17);
            this.label39.TabIndex = 44;
            this.label39.Text = "240";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(1097, 223);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(32, 17);
            this.label40.TabIndex = 45;
            this.label40.Text = "250";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(432, 223);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(24, 17);
            this.label42.TabIndex = 47;
            this.label42.Text = "70";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(1129, 188);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(35, 17);
            this.label41.TabIndex = 48;
            this.label41.Text = "bpm";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(12, 87);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(52, 17);
            this.label43.TabIndex = 49;
            this.label43.Text = "Coleira";
            // 
            // comboColeiras
            // 
            this.comboColeiras.FormattingEnabled = true;
            this.comboColeiras.Location = new System.Drawing.Point(9, 108);
            this.comboColeiras.Name = "comboColeiras";
            this.comboColeiras.Size = new System.Drawing.Size(231, 24);
            this.comboColeiras.TabIndex = 50;
            // 
            // buttonDesligarColeira
            // 
            this.buttonDesligarColeira.Location = new System.Drawing.Point(1087, 290);
            this.buttonDesligarColeira.Name = "buttonDesligarColeira";
            this.buttonDesligarColeira.Size = new System.Drawing.Size(75, 28);
            this.buttonDesligarColeira.TabIndex = 4;
            this.buttonDesligarColeira.Text = "Desligar";
            this.buttonDesligarColeira.UseVisualStyleBackColor = true;
            // 
            // TimerAplicacao
            // 
            this.TimerAplicacao.Interval = 6000;
            this.TimerAplicacao.Tick += new System.EventHandler(this.TimerAplicacao_Tick);
            // 
            // labelBatmCard
            // 
            this.labelBatmCard.AutoSize = true;
            this.labelBatmCard.Location = new System.Drawing.Point(762, 332);
            this.labelBatmCard.Name = "labelBatmCard";
            this.labelBatmCard.Size = new System.Drawing.Size(36, 17);
            this.labelBatmCard.TabIndex = 52;
            this.labelBatmCard.Text = "card";
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Location = new System.Drawing.Point(762, 294);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(31, 17);
            this.labelTemp.TabIndex = 53;
            this.labelTemp.Text = "tem";
            // 
            // gMapControl
            // 
            this.gMapControl.Bearing = 0F;
            this.gMapControl.CanDragMap = true;
            this.gMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl.GrayScaleMode = false;
            this.gMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl.LevelsKeepInMemmory = 5;
            this.gMapControl.Location = new System.Drawing.Point(176, 274);
            this.gMapControl.MarkersEnabled = true;
            this.gMapControl.MaxZoom = 2;
            this.gMapControl.MinZoom = 2;
            this.gMapControl.MouseWheelZoomEnabled = true;
            this.gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl.Name = "gMapControl";
            this.gMapControl.NegativeMode = false;
            this.gMapControl.PolygonsEnabled = true;
            this.gMapControl.RetryLoadTile = 0;
            this.gMapControl.RoutesEnabled = true;
            this.gMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl.ShowTileGridLines = false;
            this.gMapControl.Size = new System.Drawing.Size(579, 449);
            this.gMapControl.TabIndex = 54;
            this.gMapControl.Zoom = 0D;
            // 
            // Simulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1181, 743);
            this.Controls.Add(this.gMapControl);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.labelBatmCard);
            this.Controls.Add(this.comboColeiras);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.batmCardBar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDesligarColeira);
            this.Controls.Add(this.textDistancia);
            this.Controls.Add(this.tempBar);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Simulador";
            this.Text = "Simulador Coleira";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batmCardBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar tempBar;
        private System.Windows.Forms.TextBox textDistancia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TrackBar batmCardBar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.ComboBox comboColeiras;
        private System.Windows.Forms.Button buttonDesligarColeira;
        private System.Windows.Forms.Timer TimerAplicacao;
        private System.Windows.Forms.Label labelBatmCard;
        private System.Windows.Forms.Label labelTemp;
        private GMap.NET.WindowsForms.GMapControl gMapControl;
    }
}

