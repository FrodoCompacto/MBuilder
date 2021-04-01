namespace MBuilder
{
    partial class MBuilder
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MBuilder));
            this.txb_output = new System.Windows.Forms.TextBox();
            this.chart_mousePos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbl_mousePos = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.btn_record = new System.Windows.Forms.Button();
            this.btn_log = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.openMacro_dialog = new System.Windows.Forms.OpenFileDialog();
            this.macroFolder_dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_Mfolder = new System.Windows.Forms.Button();
            this.btn_Play = new System.Windows.Forms.Button();
            this.lbl_Macro = new System.Windows.Forms.Label();
            this.btn_SelectMacro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_mousePos)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_output
            // 
            this.txb_output.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txb_output.HideSelection = false;
            this.txb_output.Location = new System.Drawing.Point(7, 210);
            this.txb_output.Multiline = true;
            this.txb_output.Name = "txb_output";
            this.txb_output.ReadOnly = true;
            this.txb_output.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txb_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txb_output.Size = new System.Drawing.Size(400, 233);
            this.txb_output.TabIndex = 0;
            // 
            // chart_mousePos
            // 
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.Maximum = 1920D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.IsReversed = true;
            chartArea1.AxisY.LabelStyle.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.Maximum = 1080D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart_mousePos.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart_mousePos.Legends.Add(legend1);
            this.chart_mousePos.Location = new System.Drawing.Point(417, 227);
            this.chart_mousePos.Name = "chart_mousePos";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "MousePos";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart_mousePos.Series.Add(series1);
            this.chart_mousePos.Size = new System.Drawing.Size(376, 215);
            this.chart_mousePos.TabIndex = 1;
            // 
            // timer
            // 
            this.timer.Interval = 15;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbl_mousePos
            // 
            this.lbl_mousePos.AutoSize = true;
            this.lbl_mousePos.Location = new System.Drawing.Point(414, 211);
            this.lbl_mousePos.Name = "lbl_mousePos";
            this.lbl_mousePos.Size = new System.Drawing.Size(0, 13);
            this.lbl_mousePos.TabIndex = 2;
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.Location = new System.Drawing.Point(12, 9);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(119, 20);
            this.lb_status.TabIndex = 3;
            this.lb_status.Text = "Status: Inactive";
            // 
            // btn_record
            // 
            this.btn_record.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_record.Location = new System.Drawing.Point(7, 41);
            this.btn_record.Name = "btn_record";
            this.btn_record.Size = new System.Drawing.Size(124, 32);
            this.btn_record.TabIndex = 4;
            this.btn_record.Text = "Record";
            this.btn_record.UseVisualStyleBackColor = true;
            this.btn_record.Click += new System.EventHandler(this.btn_record_Click);
            // 
            // btn_log
            // 
            this.btn_log.Location = new System.Drawing.Point(7, 174);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(124, 23);
            this.btn_log.TabIndex = 5;
            this.btn_log.Text = "Enable/Disable Log";
            this.btn_log.UseVisualStyleBackColor = true;
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(417, 174);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(371, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // btn_Mfolder
            // 
            this.btn_Mfolder.Location = new System.Drawing.Point(328, 174);
            this.btn_Mfolder.Name = "btn_Mfolder";
            this.btn_Mfolder.Size = new System.Drawing.Size(79, 23);
            this.btn_Mfolder.TabIndex = 7;
            this.btn_Mfolder.Text = "Macro Folder";
            this.btn_Mfolder.UseVisualStyleBackColor = true;
            this.btn_Mfolder.Click += new System.EventHandler(this.btn_Mfolder_Click);
            // 
            // btn_Play
            // 
            this.btn_Play.Enabled = false;
            this.btn_Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Play.Location = new System.Drawing.Point(417, 41);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(124, 32);
            this.btn_Play.TabIndex = 8;
            this.btn_Play.Text = "Play Macro";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // lbl_Macro
            // 
            this.lbl_Macro.AutoSize = true;
            this.lbl_Macro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Macro.Location = new System.Drawing.Point(414, 12);
            this.lbl_Macro.Name = "lbl_Macro";
            this.lbl_Macro.Size = new System.Drawing.Size(166, 20);
            this.lbl_Macro.TabIndex = 9;
            this.lbl_Macro.Text = "Macro Selected: None";
            // 
            // btn_SelectMacro
            // 
            this.btn_SelectMacro.Location = new System.Drawing.Point(432, 79);
            this.btn_SelectMacro.Name = "btn_SelectMacro";
            this.btn_SelectMacro.Size = new System.Drawing.Size(94, 25);
            this.btn_SelectMacro.TabIndex = 10;
            this.btn_SelectMacro.Text = "Select Macro";
            this.btn_SelectMacro.UseVisualStyleBackColor = true;
            this.btn_SelectMacro.Click += new System.EventHandler(this.btn_SelectMacro_Click);
            // 
            // MBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_SelectMacro);
            this.Controls.Add(this.lbl_Macro);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.btn_Mfolder);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_log);
            this.Controls.Add(this.btn_record);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.lbl_mousePos);
            this.Controls.Add(this.chart_mousePos);
            this.Controls.Add(this.txb_output);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MBuilder";
            this.Text = "MBuilder";
            ((System.ComponentModel.ISupportInitialize)(this.chart_mousePos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_output;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_mousePos;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbl_mousePos;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Button btn_record;
        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.OpenFileDialog openMacro_dialog;
        private System.Windows.Forms.FolderBrowserDialog macroFolder_dialog;
        private System.Windows.Forms.Button btn_Mfolder;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Label lbl_Macro;
        private System.Windows.Forms.Button btn_SelectMacro;
    }
}

