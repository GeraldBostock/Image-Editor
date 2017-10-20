namespace Image_Editor
{
    partial class Main
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
            System.Windows.Forms.ToolStrip toolbar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.histogramButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.invertButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mirroringDropdown = new System.Windows.Forms.ToolStripDropDownButton();
            this.yatayAynalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dikeyAynalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.rotateDropdown = new System.Windows.Forms.ToolStripDropDownButton();
            this.saatYönündeDöndürToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saatYönüTersindeDöndürToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.reopenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.resimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resizeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.colorChannelButton = new System.Windows.Forms.ToolStripMenuItem();
            this.RedChannel = new System.Windows.Forms.ToolStripMenuItem();
            this.GreenChannel = new System.Windows.Forms.ToolStripMenuItem();
            this.BlueChannel = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscalingDropdown = new System.Windows.Forms.ToolStripMenuItem();
            this.averageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desaturationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decompositionMinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decompositionMaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            toolbar = new System.Windows.Forms.ToolStrip();
            toolbar.SuspendLayout();
            this.menu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbar
            // 
            toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogramButton,
            this.toolStripSeparator1,
            this.invertButton,
            this.toolStripSeparator2,
            this.mirroringDropdown,
            this.toolStripSeparator3,
            this.rotateDropdown,
            this.toolStripSeparator4});
            toolbar.Location = new System.Drawing.Point(0, 24);
            toolbar.Name = "toolbar";
            toolbar.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            toolbar.Size = new System.Drawing.Size(1350, 33);
            toolbar.TabIndex = 0;
            toolbar.Text = "toolbar";
            // 
            // histogramButton
            // 
            this.histogramButton.Enabled = false;
            this.histogramButton.Image = ((System.Drawing.Image)(resources.GetObject("histogramButton.Image")));
            this.histogramButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.histogramButton.Name = "histogramButton";
            this.histogramButton.Size = new System.Drawing.Size(83, 20);
            this.histogramButton.Text = "Histogram";
            this.histogramButton.ToolTipText = "Görüntü Histogramı";
            this.histogramButton.Click += new System.EventHandler(this.histogramButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // invertButton
            // 
            this.invertButton.Enabled = false;
            this.invertButton.Image = ((System.Drawing.Image)(resources.GetObject("invertButton.Image")));
            this.invertButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.invertButton.Name = "invertButton";
            this.invertButton.Size = new System.Drawing.Size(74, 20);
            this.invertButton.Text = "Tersleme";
            this.invertButton.Click += new System.EventHandler(this.invertButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // mirroringDropdown
            // 
            this.mirroringDropdown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mirroringDropdown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yatayAynalaToolStripMenuItem,
            this.dikeyAynalaToolStripMenuItem});
            this.mirroringDropdown.Enabled = false;
            this.mirroringDropdown.Image = ((System.Drawing.Image)(resources.GetObject("mirroringDropdown.Image")));
            this.mirroringDropdown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mirroringDropdown.Name = "mirroringDropdown";
            this.mirroringDropdown.Size = new System.Drawing.Size(56, 20);
            this.mirroringDropdown.Text = "Aynala";
            // 
            // yatayAynalaToolStripMenuItem
            // 
            this.yatayAynalaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yatayAynalaToolStripMenuItem.Image")));
            this.yatayAynalaToolStripMenuItem.Name = "yatayAynalaToolStripMenuItem";
            this.yatayAynalaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.yatayAynalaToolStripMenuItem.Text = "Yatay Aynala";
            this.yatayAynalaToolStripMenuItem.Click += new System.EventHandler(this.horizontalMirrorButton_Click);
            // 
            // dikeyAynalaToolStripMenuItem
            // 
            this.dikeyAynalaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dikeyAynalaToolStripMenuItem.Image")));
            this.dikeyAynalaToolStripMenuItem.Name = "dikeyAynalaToolStripMenuItem";
            this.dikeyAynalaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.dikeyAynalaToolStripMenuItem.Text = "Dikey Aynala";
            this.dikeyAynalaToolStripMenuItem.Click += new System.EventHandler(this.verticalMirrorButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // rotateDropdown
            // 
            this.rotateDropdown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rotateDropdown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saatYönündeDöndürToolStripMenuItem,
            this.saatYönüTersindeDöndürToolStripMenuItem});
            this.rotateDropdown.Enabled = false;
            this.rotateDropdown.Image = ((System.Drawing.Image)(resources.GetObject("rotateDropdown.Image")));
            this.rotateDropdown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rotateDropdown.Name = "rotateDropdown";
            this.rotateDropdown.Size = new System.Drawing.Size(60, 20);
            this.rotateDropdown.Text = "Döndür";
            // 
            // saatYönündeDöndürToolStripMenuItem
            // 
            this.saatYönündeDöndürToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saatYönündeDöndürToolStripMenuItem.Image")));
            this.saatYönündeDöndürToolStripMenuItem.Name = "saatYönündeDöndürToolStripMenuItem";
            this.saatYönündeDöndürToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.saatYönündeDöndürToolStripMenuItem.Text = "Saat Yönünde Döndür";
            this.saatYönündeDöndürToolStripMenuItem.Click += new System.EventHandler(this.rotateClockwiseButton_Click);
            // 
            // saatYönüTersindeDöndürToolStripMenuItem
            // 
            this.saatYönüTersindeDöndürToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saatYönüTersindeDöndürToolStripMenuItem.Image")));
            this.saatYönüTersindeDöndürToolStripMenuItem.Name = "saatYönüTersindeDöndürToolStripMenuItem";
            this.saatYönüTersindeDöndürToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.saatYönüTersindeDöndürToolStripMenuItem.Text = "Saat Yönü Tersinde Döndür";
            this.saatYönüTersindeDöndürToolStripMenuItem.Click += new System.EventHandler(this.rotateCounterClockwiseButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.resimToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1350, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menu";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFile,
            this.reopenToolStripMenuItem,
            this.save,
            this.saveAs,
            this.exit});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // openFile
            // 
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(177, 22);
            this.openFile.Text = "Aç";
            this.openFile.Click += new System.EventHandler(this.fileOpenClick);
            // 
            // reopenToolStripMenuItem
            // 
            this.reopenToolStripMenuItem.Enabled = false;
            this.reopenToolStripMenuItem.Name = "reopenToolStripMenuItem";
            this.reopenToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.reopenToolStripMenuItem.Text = "Dosyayı Yeniden Aç";
            this.reopenToolStripMenuItem.Click += new System.EventHandler(this.reopenToolStripMenuItem_Click);
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(177, 22);
            this.save.Text = "Kaydet";
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // saveAs
            // 
            this.saveAs.Enabled = false;
            this.saveAs.Name = "saveAs";
            this.saveAs.Size = new System.Drawing.Size(177, 22);
            this.saveAs.Text = "Farklı Kaydet";
            this.saveAs.Click += new System.EventHandler(this.saveAs_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(177, 22);
            this.exit.Text = "Çıkış";
            // 
            // resimToolStripMenuItem
            // 
            this.resimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resizeButton,
            this.colorChannelButton,
            this.grayscalingDropdown});
            this.resimToolStripMenuItem.Name = "resimToolStripMenuItem";
            this.resimToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.resimToolStripMenuItem.Text = "Resim";
            // 
            // resizeButton
            // 
            this.resizeButton.Enabled = false;
            this.resizeButton.Name = "resizeButton";
            this.resizeButton.Size = new System.Drawing.Size(201, 22);
            this.resizeButton.Text = "Yeniden Boyutlandır";
            this.resizeButton.Click += new System.EventHandler(this.resizeButton_Click);
            // 
            // colorChannelButton
            // 
            this.colorChannelButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RedChannel,
            this.GreenChannel,
            this.BlueChannel});
            this.colorChannelButton.Enabled = false;
            this.colorChannelButton.Name = "colorChannelButton";
            this.colorChannelButton.Size = new System.Drawing.Size(201, 22);
            this.colorChannelButton.Text = "Renk Kanallarını Değiştir";
            // 
            // RedChannel
            // 
            this.RedChannel.Checked = true;
            this.RedChannel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RedChannel.Name = "RedChannel";
            this.RedChannel.Size = new System.Drawing.Size(110, 22);
            this.RedChannel.Text = "Kırmızı";
            this.RedChannel.Click += new System.EventHandler(this.channelClick);
            // 
            // GreenChannel
            // 
            this.GreenChannel.Checked = true;
            this.GreenChannel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GreenChannel.Name = "GreenChannel";
            this.GreenChannel.Size = new System.Drawing.Size(110, 22);
            this.GreenChannel.Text = "Yeşil";
            this.GreenChannel.Click += new System.EventHandler(this.channelClick);
            // 
            // BlueChannel
            // 
            this.BlueChannel.Checked = true;
            this.BlueChannel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BlueChannel.Name = "BlueChannel";
            this.BlueChannel.Size = new System.Drawing.Size(110, 22);
            this.BlueChannel.Text = "Mavi";
            this.BlueChannel.Click += new System.EventHandler(this.channelClick);
            // 
            // grayscalingDropdown
            // 
            this.grayscalingDropdown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.averageToolStripMenuItem,
            this.lumaToolStripMenuItem,
            this.desaturationToolStripMenuItem,
            this.decompositionMinToolStripMenuItem,
            this.decompositionMaxToolStripMenuItem});
            this.grayscalingDropdown.Enabled = false;
            this.grayscalingDropdown.Name = "grayscalingDropdown";
            this.grayscalingDropdown.Size = new System.Drawing.Size(201, 22);
            this.grayscalingDropdown.Text = "Grayscaling Uygula";
            // 
            // averageToolStripMenuItem
            // 
            this.averageToolStripMenuItem.Name = "averageToolStripMenuItem";
            this.averageToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.averageToolStripMenuItem.Text = "Average";
            this.averageToolStripMenuItem.Click += new System.EventHandler(this.grayScaling);
            // 
            // lumaToolStripMenuItem
            // 
            this.lumaToolStripMenuItem.Name = "lumaToolStripMenuItem";
            this.lumaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.lumaToolStripMenuItem.Text = "Luma";
            this.lumaToolStripMenuItem.Click += new System.EventHandler(this.grayScaling);
            // 
            // desaturationToolStripMenuItem
            // 
            this.desaturationToolStripMenuItem.Name = "desaturationToolStripMenuItem";
            this.desaturationToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.desaturationToolStripMenuItem.Text = "Desaturation";
            this.desaturationToolStripMenuItem.Click += new System.EventHandler(this.grayScaling);
            // 
            // decompositionMinToolStripMenuItem
            // 
            this.decompositionMinToolStripMenuItem.Name = "decompositionMinToolStripMenuItem";
            this.decompositionMinToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.decompositionMinToolStripMenuItem.Text = "DecompositionMin";
            this.decompositionMinToolStripMenuItem.Click += new System.EventHandler(this.grayScaling);
            // 
            // decompositionMaxToolStripMenuItem
            // 
            this.decompositionMaxToolStripMenuItem.Name = "decompositionMaxToolStripMenuItem";
            this.decompositionMaxToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.decompositionMaxToolStripMenuItem.Text = "DecompositionMax";
            this.decompositionMaxToolStripMenuItem.Click += new System.EventHandler(this.grayScaling);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 611);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1350, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 633);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(toolbar);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            toolbar.ResumeLayout(false);
            toolbar.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton histogramButton;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFile;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.ToolStripMenuItem saveAs;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripButton invertButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem resimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resizeButton;
        private System.Windows.Forms.ToolStripDropDownButton mirroringDropdown;
        private System.Windows.Forms.ToolStripMenuItem yatayAynalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dikeyAynalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton rotateDropdown;
        private System.Windows.Forms.ToolStripMenuItem saatYönündeDöndürToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saatYönüTersindeDöndürToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorChannelButton;
        private System.Windows.Forms.ToolStripMenuItem RedChannel;
        private System.Windows.Forms.ToolStripMenuItem GreenChannel;
        private System.Windows.Forms.ToolStripMenuItem BlueChannel;
        private System.Windows.Forms.ToolStripMenuItem grayscalingDropdown;
        private System.Windows.Forms.ToolStripMenuItem averageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desaturationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decompositionMinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decompositionMaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reopenToolStripMenuItem;
    }
}

