﻿namespace Hitomi_Copy_3
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.MainTab = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.lStatusSearch = new MetroFramework.Controls.MetroLabel();
            this.pbLoad = new MetroFramework.Controls.MetroProgressBar();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.tbLang = new MetroFramework.Controls.MetroTextBox();
            this.bDownload = new MetroFramework.Controls.MetroButton();
            this.bSearch = new MetroFramework.Controls.MetroButton();
            this.tbSearch = new MetroFramework.Controls.MetroTextBox();
            this.ImagePanel = new Hitomi_Copy_2.ScrollFixLayoutPanel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.bAbort = new MetroFramework.Controls.MetroButton();
            this.lRetry = new MetroFramework.Controls.MetroLabel();
            this.lDownloadStatusSize = new MetroFramework.Controls.MetroLabel();
            this.lDownloadSize = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.lStatus = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.pbTarget = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lvStandBy = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.bSync = new MetroFramework.Controls.MetroButton();
            this.lThread = new MetroFramework.Controls.MetroLabel();
            this.pbSync = new Hitomi_Copy_3.MarqueeColorBar();
            this.vThread = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cbLanguage = new MetroFramework.Controls.MetroComboBox();
            this.tbInfo = new MetroFramework.Controls.MetroTextBox();
            this.tbExcludeTag = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tbDownloadPath = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lMemoryUsage = new MetroFramework.Controls.MetroLabel();
            this.MemoryUsageUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.MainTab.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTab.Controls.Add(this.metroTabPage1);
            this.MainTab.Controls.Add(this.metroTabPage2);
            this.MainTab.Controls.Add(this.metroTabPage3);
            this.MainTab.Location = new System.Drawing.Point(13, 59);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 2;
            this.MainTab.Size = new System.Drawing.Size(1130, 550);
            this.MainTab.Style = MetroFramework.MetroColorStyle.Pink;
            this.MainTab.TabIndex = 1;
            this.MainTab.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MainTab.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.lStatusSearch);
            this.metroTabPage1.Controls.Add(this.pbLoad);
            this.metroTabPage1.Controls.Add(this.metroButton3);
            this.metroTabPage1.Controls.Add(this.metroButton2);
            this.metroTabPage1.Controls.Add(this.metroButton1);
            this.metroTabPage1.Controls.Add(this.tbLang);
            this.metroTabPage1.Controls.Add(this.bDownload);
            this.metroTabPage1.Controls.Add(this.bSearch);
            this.metroTabPage1.Controls.Add(this.tbSearch);
            this.metroTabPage1.Controls.Add(this.ImagePanel);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 2;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1122, 508);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "검색";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // lStatusSearch
            // 
            this.lStatusSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lStatusSearch.AutoSize = true;
            this.lStatusSearch.Location = new System.Drawing.Point(99, 483);
            this.lStatusSearch.Name = "lStatusSearch";
            this.lStatusSearch.Size = new System.Drawing.Size(112, 19);
            this.lStatusSearch.TabIndex = 27;
            this.lStatusSearch.Text = "0 개 항목 검색됨";
            // 
            // pbLoad
            // 
            this.pbLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLoad.Location = new System.Drawing.Point(276, 489);
            this.pbLoad.Maximum = 0;
            this.pbLoad.Name = "pbLoad";
            this.pbLoad.Size = new System.Drawing.Size(372, 8);
            this.pbLoad.Style = MetroFramework.MetroColorStyle.Pink;
            this.pbLoad.TabIndex = 23;
            // 
            // metroButton3
            // 
            this.metroButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton3.Location = new System.Drawing.Point(883, 482);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(88, 23);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroButton3.TabIndex = 26;
            this.metroButton3.Text = "모두 선택 취소";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton3.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton2.Location = new System.Drawing.Point(800, 482);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(77, 23);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroButton2.TabIndex = 25;
            this.metroButton2.Text = "모두 선택";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.Location = new System.Drawing.Point(676, 482);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(88, 23);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroButton1.TabIndex = 24;
            this.metroButton1.Text = "정리";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.UseSelectable = true;
            // 
            // tbLang
            // 
            this.tbLang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.tbLang.CustomButton.Image = null;
            this.tbLang.CustomButton.Location = new System.Drawing.Point(43, 1);
            this.tbLang.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLang.CustomButton.Name = "";
            this.tbLang.CustomButton.Size = new System.Drawing.Size(21, 17);
            this.tbLang.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbLang.CustomButton.TabIndex = 1;
            this.tbLang.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbLang.CustomButton.UseSelectable = true;
            this.tbLang.CustomButton.Visible = false;
            this.tbLang.Lines = new string[] {
        "korean"};
            this.tbLang.Location = new System.Drawing.Point(3, 482);
            this.tbLang.MaxLength = 32767;
            this.tbLang.Name = "tbLang";
            this.tbLang.PasswordChar = '\0';
            this.tbLang.ReadOnly = true;
            this.tbLang.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbLang.SelectedText = "";
            this.tbLang.SelectionLength = 0;
            this.tbLang.SelectionStart = 0;
            this.tbLang.ShortcutsEnabled = true;
            this.tbLang.Size = new System.Drawing.Size(65, 23);
            this.tbLang.Style = MetroFramework.MetroColorStyle.Pink;
            this.tbLang.TabIndex = 7;
            this.tbLang.Text = "korean";
            this.tbLang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbLang.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbLang.UseSelectable = true;
            this.tbLang.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbLang.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bDownload
            // 
            this.bDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bDownload.Location = new System.Drawing.Point(1005, 482);
            this.bDownload.Name = "bDownload";
            this.bDownload.Size = new System.Drawing.Size(114, 23);
            this.bDownload.Style = MetroFramework.MetroColorStyle.Pink;
            this.bDownload.TabIndex = 6;
            this.bDownload.Text = "다운로드";
            this.bDownload.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bDownload.UseSelectable = true;
            this.bDownload.Click += new System.EventHandler(this.bDownload_Click);
            // 
            // bSearch
            // 
            this.bSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSearch.Enabled = false;
            this.bSearch.Location = new System.Drawing.Point(1005, 8);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(114, 23);
            this.bSearch.Style = MetroFramework.MetroColorStyle.Pink;
            this.bSearch.TabIndex = 5;
            this.bSearch.Text = "검색";
            this.bSearch.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bSearch.UseSelectable = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tbSearch.CustomButton.Image = null;
            this.tbSearch.CustomButton.Location = new System.Drawing.Point(974, 1);
            this.tbSearch.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearch.CustomButton.Name = "";
            this.tbSearch.CustomButton.Size = new System.Drawing.Size(21, 17);
            this.tbSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSearch.CustomButton.TabIndex = 1;
            this.tbSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSearch.CustomButton.UseSelectable = true;
            this.tbSearch.CustomButton.Visible = false;
            this.tbSearch.Enabled = false;
            this.tbSearch.Lines = new string[] {
        "recent:0-25"};
            this.tbSearch.Location = new System.Drawing.Point(3, 8);
            this.tbSearch.MaxLength = 32767;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSearch.SelectedText = "";
            this.tbSearch.SelectionLength = 0;
            this.tbSearch.SelectionStart = 0;
            this.tbSearch.ShortcutsEnabled = true;
            this.tbSearch.Size = new System.Drawing.Size(996, 23);
            this.tbSearch.Style = MetroFramework.MetroColorStyle.Pink;
            this.tbSearch.TabIndex = 4;
            this.tbSearch.Text = "recent:0-25";
            this.tbSearch.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSearch.UseSelectable = true;
            this.tbSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ImagePanel
            // 
            this.ImagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImagePanel.AutoScroll = true;
            this.ImagePanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ImagePanel.Location = new System.Drawing.Point(3, 37);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(1116, 439);
            this.ImagePanel.TabIndex = 3;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.bAbort);
            this.metroTabPage2.Controls.Add(this.lRetry);
            this.metroTabPage2.Controls.Add(this.lDownloadStatusSize);
            this.metroTabPage2.Controls.Add(this.lDownloadSize);
            this.metroTabPage2.Controls.Add(this.metroLabel10);
            this.metroTabPage2.Controls.Add(this.metroLabel9);
            this.metroTabPage2.Controls.Add(this.lStatus);
            this.metroTabPage2.Controls.Add(this.metroLabel8);
            this.metroTabPage2.Controls.Add(this.pbTarget);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.lvStandBy);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 2;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1122, 508);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "다운로드";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // bAbort
            // 
            this.bAbort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bAbort.Location = new System.Drawing.Point(920, 430);
            this.bAbort.Name = "bAbort";
            this.bAbort.Size = new System.Drawing.Size(162, 38);
            this.bAbort.Style = MetroFramework.MetroColorStyle.Pink;
            this.bAbort.TabIndex = 30;
            this.bAbort.Text = "선택파일 다운로드 취소";
            this.bAbort.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bAbort.UseSelectable = true;
            this.bAbort.Click += new System.EventHandler(this.bAbort_Click);
            // 
            // lRetry
            // 
            this.lRetry.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lRetry.AutoSize = true;
            this.lRetry.Location = new System.Drawing.Point(451, 430);
            this.lRetry.Name = "lRetry";
            this.lRetry.Size = new System.Drawing.Size(202, 19);
            this.lRetry.TabIndex = 29;
            this.lRetry.Text = "항목 다운로드를 재시작합니다.";
            this.lRetry.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lRetry.Visible = false;
            // 
            // lDownloadStatusSize
            // 
            this.lDownloadStatusSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lDownloadStatusSize.AutoSize = true;
            this.lDownloadStatusSize.Location = new System.Drawing.Point(156, 449);
            this.lDownloadStatusSize.Name = "lDownloadStatusSize";
            this.lDownloadStatusSize.Size = new System.Drawing.Size(40, 19);
            this.lDownloadStatusSize.TabIndex = 28;
            this.lDownloadStatusSize.Text = "0 MB";
            this.lDownloadStatusSize.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lDownloadSize
            // 
            this.lDownloadSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lDownloadSize.AutoSize = true;
            this.lDownloadSize.Location = new System.Drawing.Point(156, 430);
            this.lDownloadSize.Name = "lDownloadSize";
            this.lDownloadSize.Size = new System.Drawing.Size(40, 19);
            this.lDownloadSize.TabIndex = 27;
            this.lDownloadSize.Text = "0 MB";
            this.lDownloadSize.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel10
            // 
            this.metroLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(42, 449);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(108, 19);
            this.metroLabel10.TabIndex = 26;
            this.metroLabel10.Text = "다운받은 크기 : ";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel9
            // 
            this.metroLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(24, 430);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(126, 19);
            this.metroLabel9.TabIndex = 25;
            this.metroLabel9.Text = "총 다운로드 크기 : ";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lStatus
            // 
            this.lStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lStatus.AutoSize = true;
            this.lStatus.Location = new System.Drawing.Point(156, 399);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(36, 19);
            this.lStatus.TabIndex = 24;
            this.lStatus.Text = "0 / 0";
            this.lStatus.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel8
            // 
            this.metroLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(42, 399);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(108, 19);
            this.metroLabel8.TabIndex = 23;
            this.metroLabel8.Text = "다운로드 상태 : ";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // pbTarget
            // 
            this.pbTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbTarget.Location = new System.Drawing.Point(42, 364);
            this.pbTarget.Maximum = 0;
            this.pbTarget.Name = "pbTarget";
            this.pbTarget.Size = new System.Drawing.Size(1040, 32);
            this.pbTarget.Style = MetroFramework.MetroColorStyle.Pink;
            this.pbTarget.TabIndex = 22;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(42, 25);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(97, 19);
            this.metroLabel2.TabIndex = 21;
            this.metroLabel2.Text = "대기중인 항목";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lvStandBy
            // 
            this.lvStandBy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvStandBy.BackColor = System.Drawing.SystemColors.Window;
            this.lvStandBy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvStandBy.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvStandBy.FullRowSelect = true;
            this.lvStandBy.GridLines = true;
            this.lvStandBy.Location = new System.Drawing.Point(42, 47);
            this.lvStandBy.Name = "lvStandBy";
            this.lvStandBy.Size = new System.Drawing.Size(1040, 311);
            this.lvStandBy.TabIndex = 20;
            this.lvStandBy.UseCompatibleStateImageBehavior = false;
            this.lvStandBy.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "큐";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "제목";
            this.columnHeader2.Width = 586;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "이미지 링크";
            this.columnHeader3.Width = 351;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.bSync);
            this.metroTabPage3.Controls.Add(this.lThread);
            this.metroTabPage3.Controls.Add(this.pbSync);
            this.metroTabPage3.Controls.Add(this.vThread);
            this.metroTabPage3.Controls.Add(this.metroLabel7);
            this.metroTabPage3.Controls.Add(this.metroLabel6);
            this.metroTabPage3.Controls.Add(this.cbLanguage);
            this.metroTabPage3.Controls.Add(this.tbInfo);
            this.metroTabPage3.Controls.Add(this.tbExcludeTag);
            this.metroTabPage3.Controls.Add(this.metroLabel5);
            this.metroTabPage3.Controls.Add(this.tbDownloadPath);
            this.metroTabPage3.Controls.Add(this.metroLabel4);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 2;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1122, 508);
            this.metroTabPage3.TabIndex = 3;
            this.metroTabPage3.Text = "설정";
            this.metroTabPage3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // bSync
            // 
            this.bSync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSync.Enabled = false;
            this.bSync.Location = new System.Drawing.Point(831, 26);
            this.bSync.Name = "bSync";
            this.bSync.Size = new System.Drawing.Size(161, 32);
            this.bSync.Style = MetroFramework.MetroColorStyle.Pink;
            this.bSync.TabIndex = 16;
            this.bSync.Text = "데이터 동기화";
            this.bSync.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bSync.UseSelectable = true;
            this.bSync.Click += new System.EventHandler(this.bSync_ClickAsync);
            // 
            // lThread
            // 
            this.lThread.AutoSize = true;
            this.lThread.Location = new System.Drawing.Point(238, 136);
            this.lThread.Name = "lThread";
            this.lThread.Size = new System.Drawing.Size(23, 19);
            this.lThread.Style = MetroFramework.MetroColorStyle.Pink;
            this.lThread.TabIndex = 15;
            this.lThread.Text = "32";
            // 
            // pbSync
            // 
            this.pbSync.Location = new System.Drawing.Point(198, 427);
            this.pbSync.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbSync.Name = "pbSync";
            this.pbSync.Size = new System.Drawing.Size(709, 12);
            this.pbSync.TabIndex = 5;
            this.pbSync.Visible = false;
            // 
            // vThread
            // 
            this.vThread.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vThread.BackColor = System.Drawing.Color.Transparent;
            this.vThread.Location = new System.Drawing.Point(267, 134);
            this.vThread.Maximum = 64;
            this.vThread.Minimum = 1;
            this.vThread.Name = "vThread";
            this.vThread.Size = new System.Drawing.Size(725, 23);
            this.vThread.Style = MetroFramework.MetroColorStyle.Pink;
            this.vThread.TabIndex = 14;
            this.vThread.Text = "Thread";
            this.vThread.Value = 32;
            this.vThread.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vThread_Scroll);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(152, 136);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(80, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroLabel7.TabIndex = 13;
            this.metroLabel7.Text = "쓰레드 수 : ";
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(374, 32);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(48, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "언어 : ";
            // 
            // cbLanguage
            // 
            this.cbLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.ItemHeight = 23;
            this.cbLanguage.Location = new System.Drawing.Point(428, 26);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(227, 29);
            this.cbLanguage.Style = MetroFramework.MetroColorStyle.Pink;
            this.cbLanguage.TabIndex = 11;
            this.cbLanguage.UseSelectable = true;
            // 
            // tbInfo
            // 
            this.tbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tbInfo.CustomButton.Image = null;
            this.tbInfo.CustomButton.Location = new System.Drawing.Point(638, 2);
            this.tbInfo.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbInfo.CustomButton.Name = "";
            this.tbInfo.CustomButton.Size = new System.Drawing.Size(227, 182);
            this.tbInfo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbInfo.CustomButton.TabIndex = 1;
            this.tbInfo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbInfo.CustomButton.UseSelectable = true;
            this.tbInfo.CustomButton.Visible = false;
            this.tbInfo.Lines = new string[0];
            this.tbInfo.Location = new System.Drawing.Point(124, 158);
            this.tbInfo.MaxLength = 32767;
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.PasswordChar = '\0';
            this.tbInfo.ReadOnly = true;
            this.tbInfo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbInfo.SelectedText = "";
            this.tbInfo.SelectionLength = 0;
            this.tbInfo.SelectionStart = 0;
            this.tbInfo.ShortcutsEnabled = true;
            this.tbInfo.Size = new System.Drawing.Size(868, 232);
            this.tbInfo.Style = MetroFramework.MetroColorStyle.Pink;
            this.tbInfo.TabIndex = 10;
            this.tbInfo.UseSelectable = true;
            this.tbInfo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbInfo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbExcludeTag
            // 
            this.tbExcludeTag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tbExcludeTag.CustomButton.Image = null;
            this.tbExcludeTag.CustomButton.Location = new System.Drawing.Point(732, 1);
            this.tbExcludeTag.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbExcludeTag.CustomButton.Name = "";
            this.tbExcludeTag.CustomButton.Size = new System.Drawing.Size(21, 17);
            this.tbExcludeTag.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbExcludeTag.CustomButton.TabIndex = 1;
            this.tbExcludeTag.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbExcludeTag.CustomButton.UseSelectable = true;
            this.tbExcludeTag.CustomButton.Visible = false;
            this.tbExcludeTag.Lines = new string[] {
        "female:mother, male:anal"};
            this.tbExcludeTag.Location = new System.Drawing.Point(238, 110);
            this.tbExcludeTag.MaxLength = 32767;
            this.tbExcludeTag.Name = "tbExcludeTag";
            this.tbExcludeTag.PasswordChar = '\0';
            this.tbExcludeTag.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbExcludeTag.SelectedText = "";
            this.tbExcludeTag.SelectionLength = 0;
            this.tbExcludeTag.SelectionStart = 0;
            this.tbExcludeTag.ShortcutsEnabled = true;
            this.tbExcludeTag.Size = new System.Drawing.Size(754, 23);
            this.tbExcludeTag.Style = MetroFramework.MetroColorStyle.Pink;
            this.tbExcludeTag.TabIndex = 8;
            this.tbExcludeTag.Text = "female:mother, male:anal";
            this.tbExcludeTag.UseSelectable = true;
            this.tbExcludeTag.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbExcludeTag.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(138, 112);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(94, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "제외할 태그 : ";
            // 
            // tbDownloadPath
            // 
            this.tbDownloadPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tbDownloadPath.CustomButton.Image = null;
            this.tbDownloadPath.CustomButton.Location = new System.Drawing.Point(732, 1);
            this.tbDownloadPath.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDownloadPath.CustomButton.Name = "";
            this.tbDownloadPath.CustomButton.Size = new System.Drawing.Size(21, 17);
            this.tbDownloadPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDownloadPath.CustomButton.TabIndex = 1;
            this.tbDownloadPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDownloadPath.CustomButton.UseSelectable = true;
            this.tbDownloadPath.CustomButton.Visible = false;
            this.tbDownloadPath.Lines = new string[] {
        "C:\\Hitomi\\{Artists}\\[{Id}] {Title}\\"};
            this.tbDownloadPath.Location = new System.Drawing.Point(238, 81);
            this.tbDownloadPath.MaxLength = 32767;
            this.tbDownloadPath.Name = "tbDownloadPath";
            this.tbDownloadPath.PasswordChar = '\0';
            this.tbDownloadPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDownloadPath.SelectedText = "";
            this.tbDownloadPath.SelectionLength = 0;
            this.tbDownloadPath.SelectionStart = 0;
            this.tbDownloadPath.ShortcutsEnabled = true;
            this.tbDownloadPath.Size = new System.Drawing.Size(754, 23);
            this.tbDownloadPath.Style = MetroFramework.MetroColorStyle.Pink;
            this.tbDownloadPath.TabIndex = 6;
            this.tbDownloadPath.Text = "C:\\Hitomi\\{Artists}\\[{Id}] {Title}\\";
            this.tbDownloadPath.UseSelectable = true;
            this.tbDownloadPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDownloadPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbDownloadPath.Leave += new System.EventHandler(this.tbDownloadPath_Leave);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(124, 83);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(108, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "다운로드 경로 : ";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(675, 37);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(468, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Copyright (C) 2018. DCInside Programming Gallery Union. All Rights Reserved.";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(464, 19);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(111, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Memory Usage : ";
            // 
            // lMemoryUsage
            // 
            this.lMemoryUsage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lMemoryUsage.AutoSize = true;
            this.lMemoryUsage.Location = new System.Drawing.Point(581, 19);
            this.lMemoryUsage.Name = "lMemoryUsage";
            this.lMemoryUsage.Size = new System.Drawing.Size(35, 19);
            this.lMemoryUsage.TabIndex = 4;
            this.lMemoryUsage.Text = "0 KB";
            // 
            // MemoryUsageUpdateTimer
            // 
            this.MemoryUsageUpdateTimer.Enabled = true;
            this.MemoryUsageUpdateTimer.Interval = 1000;
            this.MemoryUsageUpdateTimer.Tick += new System.EventHandler(this.MemoryUsageUpdateTimer_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 616);
            this.Controls.Add(this.lMemoryUsage);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.MainTab);
            this.DoubleBuffered = false;
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1156, 616);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(20, 75, 20, 25);
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Hitom Copy 3.0";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MainTab.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl MainTab;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private Hitomi_Copy_2.ScrollFixLayoutPanel ImagePanel;
        private MetroFramework.Controls.MetroButton bSearch;
        private MetroFramework.Controls.MetroTextBox tbSearch;
        private MetroFramework.Controls.MetroButton bDownload;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbLang;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ListView lvStandBy;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MetroFramework.Controls.MetroProgressBar pbLoad;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroProgressBar pbTarget;
        private MetroFramework.Controls.MetroLabel lStatusSearch;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lMemoryUsage;
        private System.Windows.Forms.Timer MemoryUsageUpdateTimer;
        private MetroFramework.Controls.MetroTextBox tbDownloadPath;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox tbExcludeTag;
        private MetroFramework.Controls.MetroTextBox tbInfo;
        private MetroFramework.Controls.MetroComboBox cbLanguage;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTrackBar vThread;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel lThread;
        private MetroFramework.Controls.MetroButton bSync;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel lStatus;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel lDownloadSize;
        private MetroFramework.Controls.MetroLabel lDownloadStatusSize;
        private MetroFramework.Controls.MetroLabel lRetry;
        private MetroFramework.Controls.MetroButton bAbort;
        private MarqueeColorBar pbSync;
    }
}

