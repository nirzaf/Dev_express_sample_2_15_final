namespace sample_2_15 {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
      this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
      this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
      this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
      this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
      this.dockPanel3 = new DevExpress.XtraBars.Docking.DockPanel();
      this.dockPanel3_Container = new DevExpress.XtraBars.Docking.ControlContainer();
      this.panelContainer1 = new DevExpress.XtraBars.Docking.DockPanel();
      ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
      this.dockPanel1.SuspendLayout();
      this.dockPanel2.SuspendLayout();
      this.dockPanel3.SuspendLayout();
      this.panelContainer1.SuspendLayout();
      this.SuspendLayout();
      // 
      // dockManager1
      // 
      this.dockManager1.Form = this;
      this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1,
            this.panelContainer1});
      this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
      // 
      // dockPanel1
      // 
      this.dockPanel1.Controls.Add(this.dockPanel1_Container);
      this.dockPanel1.CustomHeaderButtons.AddRange(new DevExpress.XtraBars.Docking2010.IButton[] {
            new DevExpress.XtraBars.Docking.CustomHeaderButton(),
            new DevExpress.XtraBars.Docking.CustomHeaderButton()});
      this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
      this.dockPanel1.ID = new System.Guid("c6e049a1-02b6-4a3e-a4bb-f1b8f8564f21");
      this.dockPanel1.Location = new System.Drawing.Point(0, 0);
      this.dockPanel1.Name = "dockPanel1";
      this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
      this.dockPanel1.Size = new System.Drawing.Size(200, 548);
      this.dockPanel1.Text = "Navigation";
      this.dockPanel1.CustomButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.dockPanel1_CustomButtonClick);
      // 
      // dockPanel1_Container
      // 
      this.dockPanel1_Container.Location = new System.Drawing.Point(3, 29);
      this.dockPanel1_Container.Name = "dockPanel1_Container";
      this.dockPanel1_Container.Size = new System.Drawing.Size(193, 516);
      this.dockPanel1_Container.TabIndex = 0;
      // 
      // dockPanel2
      // 
      this.dockPanel2.Controls.Add(this.dockPanel2_Container);
      this.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
      this.dockPanel2.ID = new System.Guid("adbbaab9-e251-44fd-ad02-f03dd4005356");
      this.dockPanel2.Location = new System.Drawing.Point(4, 26);
      this.dockPanel2.Name = "dockPanel2";
      this.dockPanel2.OriginalSize = new System.Drawing.Size(200, 200);
      this.dockPanel2.Size = new System.Drawing.Size(192, 145);
      this.dockPanel2.Text = "dockPanel2";
      // 
      // dockPanel2_Container
      // 
      this.dockPanel2_Container.Location = new System.Drawing.Point(0, 0);
      this.dockPanel2_Container.Name = "dockPanel2_Container";
      this.dockPanel2_Container.Size = new System.Drawing.Size(192, 145);
      this.dockPanel2_Container.TabIndex = 0;
      // 
      // dockPanel3
      // 
      this.dockPanel3.Controls.Add(this.dockPanel3_Container);
      this.dockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
      this.dockPanel3.ID = new System.Guid("46593472-f199-4003-b8c0-24a8e2122a4b");
      this.dockPanel3.Location = new System.Drawing.Point(4, 26);
      this.dockPanel3.Name = "dockPanel3";
      this.dockPanel3.OriginalSize = new System.Drawing.Size(200, 200);
      this.dockPanel3.Size = new System.Drawing.Size(192, 145);
      this.dockPanel3.Text = "dockPanel3";
      // 
      // dockPanel3_Container
      // 
      this.dockPanel3_Container.Location = new System.Drawing.Point(0, 0);
      this.dockPanel3_Container.Name = "dockPanel3_Container";
      this.dockPanel3_Container.Size = new System.Drawing.Size(192, 145);
      this.dockPanel3_Container.TabIndex = 0;
      // 
      // panelContainer1
      // 
      this.panelContainer1.ActiveChild = this.dockPanel3;
      this.panelContainer1.Controls.Add(this.dockPanel3);
      this.panelContainer1.Controls.Add(this.dockPanel2);
      this.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float;
      this.panelContainer1.FloatLocation = new System.Drawing.Point(864, 578);
      this.panelContainer1.ID = new System.Guid("ec7e9364-363a-4456-8f9f-1ac1f76373bf");
      this.panelContainer1.Location = new System.Drawing.Point(0, 0);
      this.panelContainer1.Name = "panelContainer1";
      this.panelContainer1.OriginalSize = new System.Drawing.Size(200, 200);
      this.panelContainer1.Size = new System.Drawing.Size(200, 200);
      this.panelContainer1.Tabbed = true;
      this.panelContainer1.Text = "panelContainer1";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(881, 548);
      this.Controls.Add(this.dockPanel1);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
      this.dockPanel1.ResumeLayout(false);
      this.dockPanel2.ResumeLayout(false);
      this.dockPanel3.ResumeLayout(false);
      this.panelContainer1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraBars.Docking.DockManager dockManager1;
    private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
    private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
    private DevExpress.XtraBars.Docking.DockPanel dockPanel2;
    private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
    private DevExpress.XtraBars.Docking.DockPanel panelContainer1;
    private DevExpress.XtraBars.Docking.DockPanel dockPanel3;
    private DevExpress.XtraBars.Docking.ControlContainer dockPanel3_Container;
  }
}

