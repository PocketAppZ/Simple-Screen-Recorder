﻿using System.Diagnostics;

namespace Simple_Screen_Recorder.UI
{
    partial class AudioRecorderMainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing)
                {
                    if (components is object)
                    {
                        components.Dispose();
                    }
                    microphoneManager?.Dispose();
                    systemAudioManager?.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AudioRecorderMainWindow));
            crownGroupBox3 = new ReaLTaiizor.Controls.CrownGroupBox();
            btnOutputRecordings = new Button();
            btnStartRecording = new Button();
            BtnStop = new Button();
            crownGroupBox2 = new ReaLTaiizor.Controls.CrownGroupBox();
            comboBoxAudioSourceAudio = new ReaLTaiizor.Controls.CrownComboBox();
            label6 = new Label();
            Label4 = new Label();
            Label5 = new Label();
            label7 = new Label();
            ComboBoxMicrophone = new ReaLTaiizor.Controls.CrownComboBox();
            ComboBoxSpeaker = new ReaLTaiizor.Controls.CrownComboBox();
            CountRecAudio = new System.Windows.Forms.Timer(components);
            LbTimer = new Label();
            BtnBackScreen = new Button();
            crownGroupBox3.SuspendLayout();
            crownGroupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // crownGroupBox3
            // 
            crownGroupBox3.BorderColor = Color.Gray;
            crownGroupBox3.Controls.Add(btnOutputRecordings);
            crownGroupBox3.Controls.Add(btnStartRecording);
            crownGroupBox3.Controls.Add(BtnStop);
            crownGroupBox3.Font = new Font("Segoe UI", 12F);
            crownGroupBox3.Location = new Point(13, 4);
            crownGroupBox3.Name = "crownGroupBox3";
            crownGroupBox3.Size = new Size(328, 164);
            crownGroupBox3.TabIndex = 57;
            crownGroupBox3.TabStop = false;
            crownGroupBox3.Text = "Controls";
            // 
            // btnOutputRecordings
            // 
            btnOutputRecordings.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            btnOutputRecordings.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnOutputRecordings.FlatStyle = FlatStyle.Flat;
            btnOutputRecordings.Font = new Font("Segoe UI", 9F);
            btnOutputRecordings.ForeColor = Color.Transparent;
            btnOutputRecordings.Image = Properties.Resources.folder_button;
            btnOutputRecordings.ImageAlign = ContentAlignment.MiddleLeft;
            btnOutputRecordings.Location = new Point(16, 108);
            btnOutputRecordings.Margin = new Padding(4, 3, 4, 3);
            btnOutputRecordings.Name = "btnOutputRecordings";
            btnOutputRecordings.Size = new Size(296, 40);
            btnOutputRecordings.TabIndex = 6;
            btnOutputRecordings.Text = " Open Recordings Folder";
            btnOutputRecordings.UseVisualStyleBackColor = true;
            btnOutputRecordings.Click += btnOutputRecordings_Click;
            // 
            // btnStartRecording
            // 
            btnStartRecording.FlatAppearance.MouseDownBackColor = Color.ForestGreen;
            btnStartRecording.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btnStartRecording.FlatStyle = FlatStyle.Flat;
            btnStartRecording.Font = new Font("Segoe UI", 9F);
            btnStartRecording.ForeColor = Color.Transparent;
            btnStartRecording.Image = Properties.Resources.voice_control;
            btnStartRecording.ImageAlign = ContentAlignment.MiddleLeft;
            btnStartRecording.Location = new Point(16, 24);
            btnStartRecording.Margin = new Padding(4, 3, 4, 3);
            btnStartRecording.Name = "btnStartRecording";
            btnStartRecording.RightToLeft = RightToLeft.No;
            btnStartRecording.Size = new Size(296, 40);
            btnStartRecording.TabIndex = 1;
            btnStartRecording.Text = "Start Recording";
            btnStartRecording.UseVisualStyleBackColor = true;
            btnStartRecording.Click += btnStartRecording_Click;
            // 
            // BtnStop
            // 
            BtnStop.FlatAppearance.MouseDownBackColor = Color.DarkViolet;
            BtnStop.FlatAppearance.MouseOverBackColor = Color.DarkViolet;
            BtnStop.FlatStyle = FlatStyle.Flat;
            BtnStop.Font = new Font("Segoe UI", 9F);
            BtnStop.ForeColor = Color.Transparent;
            BtnStop.Image = Properties.Resources.stop2b;
            BtnStop.ImageAlign = ContentAlignment.MiddleLeft;
            BtnStop.Location = new Point(16, 66);
            BtnStop.Margin = new Padding(4, 3, 4, 3);
            BtnStop.Name = "BtnStop";
            BtnStop.Size = new Size(296, 40);
            BtnStop.TabIndex = 2;
            BtnStop.Text = "Stop Recording";
            BtnStop.UseVisualStyleBackColor = true;
            BtnStop.Click += BtnStop_Click;
            // 
            // crownGroupBox2
            // 
            crownGroupBox2.BorderColor = Color.Gray;
            crownGroupBox2.Controls.Add(comboBoxAudioSourceAudio);
            crownGroupBox2.Controls.Add(label6);
            crownGroupBox2.Controls.Add(Label4);
            crownGroupBox2.Controls.Add(Label5);
            crownGroupBox2.Controls.Add(label7);
            crownGroupBox2.Controls.Add(ComboBoxMicrophone);
            crownGroupBox2.Controls.Add(ComboBoxSpeaker);
            crownGroupBox2.Font = new Font("Segoe UI", 12F);
            crownGroupBox2.Location = new Point(13, 170);
            crownGroupBox2.Name = "crownGroupBox2";
            crownGroupBox2.Size = new Size(329, 223);
            crownGroupBox2.TabIndex = 58;
            crownGroupBox2.TabStop = false;
            crownGroupBox2.Text = "Audio settings";
            // 
            // comboBoxAudioSourceAudio
            // 
            comboBoxAudioSourceAudio.DrawMode = DrawMode.OwnerDrawVariable;
            comboBoxAudioSourceAudio.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxAudioSourceAudio.FormattingEnabled = true;
            comboBoxAudioSourceAudio.Location = new Point(13, 57);
            comboBoxAudioSourceAudio.Name = "comboBoxAudioSourceAudio";
            comboBoxAudioSourceAudio.Size = new Size(221, 23);
            comboBoxAudioSourceAudio.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.RoyalBlue;
            label6.Location = new Point(10, 28);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(160, 17);
            label6.TabIndex = 40;
            label6.Text = "Audio recording method";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.BackColor = Color.Transparent;
            Label4.Font = new Font("Segoe UI", 9.75F);
            Label4.ForeColor = SystemColors.Control;
            Label4.Location = new Point(13, 169);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(138, 17);
            Label4.TabIndex = 38;
            Label4.Text = "Microphone (Mic/Aux)";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.BackColor = Color.Transparent;
            Label5.Font = new Font("Segoe UI", 9.75F);
            Label5.ForeColor = SystemColors.Control;
            Label5.Location = new Point(13, 117);
            Label5.Margin = new Padding(4, 0, 4, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(187, 17);
            Label5.TabIndex = 6;
            Label5.Text = "System sound (Desktop Audio)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label7.ForeColor = Color.RoyalBlue;
            label7.Location = new Point(10, 95);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(94, 17);
            label7.TabIndex = 41;
            label7.Text = "Audio devices";
            // 
            // ComboBoxMicrophone
            // 
            ComboBoxMicrophone.DrawMode = DrawMode.OwnerDrawVariable;
            ComboBoxMicrophone.Font = new Font("Segoe UI", 9F);
            ComboBoxMicrophone.FormattingEnabled = true;
            ComboBoxMicrophone.Location = new Point(15, 189);
            ComboBoxMicrophone.Name = "ComboBoxMicrophone";
            ComboBoxMicrophone.Size = new Size(219, 24);
            ComboBoxMicrophone.TabIndex = 5;
            // 
            // ComboBoxSpeaker
            // 
            ComboBoxSpeaker.DrawMode = DrawMode.OwnerDrawVariable;
            ComboBoxSpeaker.Font = new Font("Segoe UI", 9F);
            ComboBoxSpeaker.FormattingEnabled = true;
            ComboBoxSpeaker.Location = new Point(15, 137);
            ComboBoxSpeaker.Name = "ComboBoxSpeaker";
            ComboBoxSpeaker.Size = new Size(219, 24);
            ComboBoxSpeaker.TabIndex = 4;
            // 
            // CountRecAudio
            // 
            CountRecAudio.Tick += CountRecAudio_Tick;
            // 
            // LbTimer
            // 
            LbTimer.AutoSize = true;
            LbTimer.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            LbTimer.ForeColor = Color.White;
            LbTimer.Location = new Point(13, 410);
            LbTimer.Margin = new Padding(4, 0, 4, 0);
            LbTimer.Name = "LbTimer";
            LbTimer.Size = new Size(71, 20);
            LbTimer.TabIndex = 59;
            LbTimer.Text = "00:00:00";
            // 
            // BtnBackScreen
            // 
            BtnBackScreen.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            BtnBackScreen.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            BtnBackScreen.FlatStyle = FlatStyle.Flat;
            BtnBackScreen.Font = new Font("Segoe UI", 9F);
            BtnBackScreen.ForeColor = Color.Transparent;
            BtnBackScreen.Image = Properties.Resources.back;
            BtnBackScreen.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBackScreen.Location = new Point(199, 402);
            BtnBackScreen.Margin = new Padding(4, 3, 4, 3);
            BtnBackScreen.Name = "BtnBackScreen";
            BtnBackScreen.Size = new Size(143, 39);
            BtnBackScreen.TabIndex = 7;
            BtnBackScreen.Text = "    Back";
            BtnBackScreen.UseVisualStyleBackColor = true;
            BtnBackScreen.Click += BtnBackScreen_Click;
            // 
            // AudioRecorderMainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(355, 450);
            ControlBox = false;
            Controls.Add(BtnBackScreen);
            Controls.Add(LbTimer);
            Controls.Add(crownGroupBox2);
            Controls.Add(crownGroupBox3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(335, 200);
            MaximizeBox = false;
            Name = "AudioRecorderMainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Audio recorder";
            FormClosed += AudioRecorderMainWindow_FormClosed;
            Load += AudioRecorderMainWindow_Load;
            crownGroupBox3.ResumeLayout(false);
            crownGroupBox2.ResumeLayout(false);
            crownGroupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.CrownGroupBox crownGroupBox3;
        internal Button btnOutputRecordings;
        internal Button btnStartRecording;
        private ReaLTaiizor.Controls.CrownGroupBox crownGroupBox2;
        internal Label label6;
        internal Label Label4;
        internal Label Label5;
        internal Label label7;
        private ReaLTaiizor.Controls.CrownComboBox ComboBoxMicrophone;
        private ReaLTaiizor.Controls.CrownComboBox ComboBoxSpeaker;
        private System.Windows.Forms.Timer CountRecAudio;
        internal Label LbTimer;
        internal Button BtnStop;
        internal Button BtnBackScreen;
        private ReaLTaiizor.Controls.CrownComboBox comboBoxAudioSourceAudio;
    }
}