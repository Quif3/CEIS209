namespace CEIS209_Week1_Project
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.TextBox();
            this.artistText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.genreText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yearText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.urlText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.TextBox();
            this.songList = new System.Windows.Forms.ListBox();
            this.allSongsButton = new System.Windows.Forms.Button();
            this.songListLabel = new System.Windows.Forms.Label();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.webViewDisplay = new System.Windows.Forms.WebBrowser();
            this.PlayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(105, 53);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(264, 30);
            this.titleText.TabIndex = 0;
            // 
            // artistText
            // 
            this.artistText.Location = new System.Drawing.Point(105, 101);
            this.artistText.Name = "artistText";
            this.artistText.Size = new System.Drawing.Size(264, 30);
            this.artistText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Artist:";
            // 
            // genreText
            // 
            this.genreText.Location = new System.Drawing.Point(105, 153);
            this.genreText.Name = "genreText";
            this.genreText.Size = new System.Drawing.Size(264, 30);
            this.genreText.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Genre:";
            // 
            // yearText
            // 
            this.yearText.Location = new System.Drawing.Point(105, 204);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(264, 30);
            this.yearText.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Year:";
            // 
            // urlText
            // 
            this.urlText.Location = new System.Drawing.Point(105, 257);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(264, 30);
            this.urlText.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "URL:";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(49, 293);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(320, 80);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add Song";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(444, 315);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(304, 227);
            this.outputText.TabIndex = 11;
            this.outputText.TabStop = false;
            // 
            // songList
            // 
            this.songList.FormattingEnabled = true;
            this.songList.HorizontalScrollbar = true;
            this.songList.ItemHeight = 25;
            this.songList.Location = new System.Drawing.Point(444, 56);
            this.songList.Name = "songList";
            this.songList.ScrollAlwaysVisible = true;
            this.songList.Size = new System.Drawing.Size(304, 204);
            this.songList.TabIndex = 12;
            this.songList.TabStop = false;
            // 
            // allSongsButton
            // 
            this.allSongsButton.Location = new System.Drawing.Point(49, 379);
            this.allSongsButton.Name = "allSongsButton";
            this.allSongsButton.Size = new System.Drawing.Size(320, 80);
            this.allSongsButton.TabIndex = 6;
            this.allSongsButton.Text = "Show All Songs";
            this.allSongsButton.UseVisualStyleBackColor = true;
            this.allSongsButton.Click += new System.EventHandler(this.allSongsButton_Click);
            // 
            // songListLabel
            // 
            this.songListLabel.AutoSize = true;
            this.songListLabel.Location = new System.Drawing.Point(440, 28);
            this.songListLabel.Name = "songListLabel";
            this.songListLabel.Size = new System.Drawing.Size(100, 25);
            this.songListLabel.TabIndex = 14;
            this.songListLabel.Text = "Song List:";
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Location = new System.Drawing.Point(440, 287);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(77, 25);
            this.detailsLabel.TabIndex = 15;
            this.detailsLabel.Text = "Details:";
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(49, 462);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(320, 80);
            this.findButton.TabIndex = 16;
            this.findButton.Text = "Find Song";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(49, 548);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(320, 80);
            this.clearButton.TabIndex = 17;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // webViewDisplay
            // 
            this.webViewDisplay.Location = new System.Drawing.Point(793, 65);
            this.webViewDisplay.MinimumSize = new System.Drawing.Size(20, 20);
            this.webViewDisplay.Name = "webViewDisplay";
            this.webViewDisplay.Size = new System.Drawing.Size(466, 381);
            this.webViewDisplay.TabIndex = 18;
            this.webViewDisplay.Url = new System.Uri("http://www.microsoft.com", System.UriKind.Absolute);
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(793, 462);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(320, 80);
            this.PlayButton.TabIndex = 19;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 649);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.webViewDisplay);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.detailsLabel);
            this.Controls.Add(this.songListLabel);
            this.Controls.Add(this.allSongsButton);
            this.Controls.Add(this.songList);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.urlText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.genreText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.artistText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Video Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox artistText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox genreText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.ListBox songList;
        private System.Windows.Forms.Button allSongsButton;
        private System.Windows.Forms.Label songListLabel;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.WebBrowser webViewDisplay;
        private System.Windows.Forms.Button PlayButton;
    }
}

