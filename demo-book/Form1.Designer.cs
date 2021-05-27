
namespace demo_book
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState1 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState2 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState toggleState3 = new Bunifu.UI.WinForms.BunifuToggleSwitch.ToggleState();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.btnAdd = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnCatalog = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSettings = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnAbout = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuToggleSwitch1 = new Bunifu.UI.WinForms.BunifuToggleSwitch();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 2;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.btnAbout);
            this.bunifuGradientPanel1.Controls.Add(this.btnSettings);
            this.bunifuGradientPanel1.Controls.Add(this.btnCatalog);
            this.bunifuGradientPanel1.Controls.Add(this.btnAdd);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(92)))), ((int)(((byte)(188)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DeepPink;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(60)))), ((int)(((byte)(212)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(306, 581);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.AllowAnimations = true;
            this.btnAdd.AllowMouseEffects = true;
            this.btnAdd.AllowToggling = false;
            this.btnAdd.AnimationSpeed = 200;
            this.btnAdd.AutoGenerateColors = false;
            this.btnAdd.AutoRoundBorders = false;
            this.btnAdd.AutoSizeLeftIcon = true;
            this.btnAdd.AutoSizeRightIcon = true;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackColor1 = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.ButtonText = "New Book";
            this.btnAdd.ButtonTextMarginLeft = 0;
            this.btnAdd.ColorContrastOnClick = 45;
            this.btnAdd.ColorContrastOnHover = 45;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnAdd.CustomizableEdges = borderEdges4;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAdd.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAdd.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAdd.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAdd.IconMarginLeft = 11;
            this.btnAdd.IconPadding = 10;
            this.btnAdd.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAdd.IconSize = 25;
            this.btnAdd.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.IdleBorderRadius = 10;
            this.btnAdd.IdleBorderThickness = 1;
            this.btnAdd.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnAdd.IdleIconLeftImage = null;
            this.btnAdd.IdleIconRightImage = null;
            this.btnAdd.IndicateFocus = false;
            this.btnAdd.Location = new System.Drawing.Point(62, 90);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAdd.OnDisabledState.BorderRadius = 10;
            this.btnAdd.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.OnDisabledState.BorderThickness = 1;
            this.btnAdd.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAdd.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAdd.OnDisabledState.IconLeftImage = null;
            this.btnAdd.OnDisabledState.IconRightImage = null;
            this.btnAdd.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAdd.onHoverState.BorderRadius = 10;
            this.btnAdd.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.onHoverState.BorderThickness = 1;
            this.btnAdd.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAdd.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.onHoverState.IconLeftImage = null;
            this.btnAdd.onHoverState.IconRightImage = null;
            this.btnAdd.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.OnIdleState.BorderRadius = 10;
            this.btnAdd.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.OnIdleState.BorderThickness = 1;
            this.btnAdd.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnAdd.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.OnIdleState.IconLeftImage = null;
            this.btnAdd.OnIdleState.IconRightImage = null;
            this.btnAdd.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAdd.OnPressedState.BorderRadius = 10;
            this.btnAdd.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.OnPressedState.BorderThickness = 1;
            this.btnAdd.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAdd.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.OnPressedState.IconLeftImage = null;
            this.btnAdd.OnPressedState.IconRightImage = null;
            this.btnAdd.Size = new System.Drawing.Size(173, 65);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.TabStop = false;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.TextMarginLeft = 0;
            this.btnAdd.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAdd.UseDefaultRadiusAndThickness = true;
            // 
            // btnCatalog
            // 
            this.btnCatalog.AllowAnimations = true;
            this.btnCatalog.AllowMouseEffects = true;
            this.btnCatalog.AllowToggling = false;
            this.btnCatalog.AnimationSpeed = 200;
            this.btnCatalog.AutoGenerateColors = false;
            this.btnCatalog.AutoRoundBorders = false;
            this.btnCatalog.AutoSizeLeftIcon = true;
            this.btnCatalog.AutoSizeRightIcon = true;
            this.btnCatalog.BackColor = System.Drawing.Color.Transparent;
            this.btnCatalog.BackColor1 = System.Drawing.Color.Transparent;
            this.btnCatalog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCatalog.BackgroundImage")));
            this.btnCatalog.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCatalog.ButtonText = "My Catalog";
            this.btnCatalog.ButtonTextMarginLeft = 0;
            this.btnCatalog.ColorContrastOnClick = 45;
            this.btnCatalog.ColorContrastOnHover = 45;
            this.btnCatalog.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnCatalog.CustomizableEdges = borderEdges3;
            this.btnCatalog.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCatalog.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCatalog.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCatalog.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCatalog.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCatalog.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCatalog.ForeColor = System.Drawing.Color.White;
            this.btnCatalog.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalog.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCatalog.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCatalog.IconMarginLeft = 11;
            this.btnCatalog.IconPadding = 10;
            this.btnCatalog.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCatalog.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCatalog.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCatalog.IconSize = 25;
            this.btnCatalog.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCatalog.IdleBorderRadius = 10;
            this.btnCatalog.IdleBorderThickness = 1;
            this.btnCatalog.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnCatalog.IdleIconLeftImage = null;
            this.btnCatalog.IdleIconRightImage = null;
            this.btnCatalog.IndicateFocus = false;
            this.btnCatalog.Location = new System.Drawing.Point(62, 189);
            this.btnCatalog.Name = "btnCatalog";
            this.btnCatalog.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCatalog.OnDisabledState.BorderRadius = 10;
            this.btnCatalog.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCatalog.OnDisabledState.BorderThickness = 1;
            this.btnCatalog.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCatalog.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCatalog.OnDisabledState.IconLeftImage = null;
            this.btnCatalog.OnDisabledState.IconRightImage = null;
            this.btnCatalog.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnCatalog.onHoverState.BorderRadius = 10;
            this.btnCatalog.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCatalog.onHoverState.BorderThickness = 1;
            this.btnCatalog.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnCatalog.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCatalog.onHoverState.IconLeftImage = null;
            this.btnCatalog.onHoverState.IconRightImage = null;
            this.btnCatalog.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCatalog.OnIdleState.BorderRadius = 10;
            this.btnCatalog.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCatalog.OnIdleState.BorderThickness = 1;
            this.btnCatalog.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnCatalog.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCatalog.OnIdleState.IconLeftImage = null;
            this.btnCatalog.OnIdleState.IconRightImage = null;
            this.btnCatalog.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCatalog.OnPressedState.BorderRadius = 10;
            this.btnCatalog.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCatalog.OnPressedState.BorderThickness = 1;
            this.btnCatalog.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCatalog.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCatalog.OnPressedState.IconLeftImage = null;
            this.btnCatalog.OnPressedState.IconRightImage = null;
            this.btnCatalog.Size = new System.Drawing.Size(173, 65);
            this.btnCatalog.TabIndex = 2;
            this.btnCatalog.TabStop = false;
            this.btnCatalog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCatalog.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCatalog.TextMarginLeft = 0;
            this.btnCatalog.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCatalog.UseDefaultRadiusAndThickness = true;
            // 
            // btnSettings
            // 
            this.btnSettings.AllowAnimations = true;
            this.btnSettings.AllowMouseEffects = true;
            this.btnSettings.AllowToggling = false;
            this.btnSettings.AnimationSpeed = 200;
            this.btnSettings.AutoGenerateColors = false;
            this.btnSettings.AutoRoundBorders = false;
            this.btnSettings.AutoSizeLeftIcon = true;
            this.btnSettings.AutoSizeRightIcon = true;
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BackColor1 = System.Drawing.Color.Transparent;
            this.btnSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.BackgroundImage")));
            this.btnSettings.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSettings.ButtonText = "Settings";
            this.btnSettings.ButtonTextMarginLeft = 0;
            this.btnSettings.ColorContrastOnClick = 45;
            this.btnSettings.ColorContrastOnHover = 45;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnSettings.CustomizableEdges = borderEdges2;
            this.btnSettings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSettings.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSettings.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSettings.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSettings.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSettings.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSettings.IconMarginLeft = 11;
            this.btnSettings.IconPadding = 10;
            this.btnSettings.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSettings.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSettings.IconSize = 25;
            this.btnSettings.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSettings.IdleBorderRadius = 10;
            this.btnSettings.IdleBorderThickness = 1;
            this.btnSettings.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnSettings.IdleIconLeftImage = null;
            this.btnSettings.IdleIconRightImage = null;
            this.btnSettings.IndicateFocus = false;
            this.btnSettings.Location = new System.Drawing.Point(62, 290);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSettings.OnDisabledState.BorderRadius = 10;
            this.btnSettings.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSettings.OnDisabledState.BorderThickness = 1;
            this.btnSettings.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSettings.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSettings.OnDisabledState.IconLeftImage = null;
            this.btnSettings.OnDisabledState.IconRightImage = null;
            this.btnSettings.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSettings.onHoverState.BorderRadius = 10;
            this.btnSettings.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSettings.onHoverState.BorderThickness = 1;
            this.btnSettings.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSettings.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSettings.onHoverState.IconLeftImage = null;
            this.btnSettings.onHoverState.IconRightImage = null;
            this.btnSettings.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSettings.OnIdleState.BorderRadius = 10;
            this.btnSettings.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSettings.OnIdleState.BorderThickness = 1;
            this.btnSettings.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnSettings.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSettings.OnIdleState.IconLeftImage = null;
            this.btnSettings.OnIdleState.IconRightImage = null;
            this.btnSettings.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSettings.OnPressedState.BorderRadius = 10;
            this.btnSettings.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSettings.OnPressedState.BorderThickness = 1;
            this.btnSettings.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSettings.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSettings.OnPressedState.IconLeftImage = null;
            this.btnSettings.OnPressedState.IconRightImage = null;
            this.btnSettings.Size = new System.Drawing.Size(173, 65);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.TabStop = false;
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSettings.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSettings.TextMarginLeft = 0;
            this.btnSettings.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSettings.UseDefaultRadiusAndThickness = true;
            // 
            // btnAbout
            // 
            this.btnAbout.AllowAnimations = true;
            this.btnAbout.AllowMouseEffects = true;
            this.btnAbout.AllowToggling = false;
            this.btnAbout.AnimationSpeed = 200;
            this.btnAbout.AutoGenerateColors = false;
            this.btnAbout.AutoRoundBorders = false;
            this.btnAbout.AutoSizeLeftIcon = true;
            this.btnAbout.AutoSizeRightIcon = true;
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.BackColor1 = System.Drawing.Color.Transparent;
            this.btnAbout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbout.BackgroundImage")));
            this.btnAbout.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAbout.ButtonText = "About";
            this.btnAbout.ButtonTextMarginLeft = 0;
            this.btnAbout.ColorContrastOnClick = 45;
            this.btnAbout.ColorContrastOnHover = 45;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAbout.CustomizableEdges = borderEdges1;
            this.btnAbout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAbout.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAbout.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAbout.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAbout.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAbout.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAbout.IconMarginLeft = 11;
            this.btnAbout.IconPadding = 10;
            this.btnAbout.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbout.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAbout.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAbout.IconSize = 25;
            this.btnAbout.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAbout.IdleBorderRadius = 10;
            this.btnAbout.IdleBorderThickness = 1;
            this.btnAbout.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnAbout.IdleIconLeftImage = null;
            this.btnAbout.IdleIconRightImage = null;
            this.btnAbout.IndicateFocus = false;
            this.btnAbout.Location = new System.Drawing.Point(62, 385);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAbout.OnDisabledState.BorderRadius = 10;
            this.btnAbout.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAbout.OnDisabledState.BorderThickness = 1;
            this.btnAbout.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAbout.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAbout.OnDisabledState.IconLeftImage = null;
            this.btnAbout.OnDisabledState.IconRightImage = null;
            this.btnAbout.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAbout.onHoverState.BorderRadius = 10;
            this.btnAbout.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAbout.onHoverState.BorderThickness = 1;
            this.btnAbout.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAbout.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAbout.onHoverState.IconLeftImage = null;
            this.btnAbout.onHoverState.IconRightImage = null;
            this.btnAbout.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAbout.OnIdleState.BorderRadius = 10;
            this.btnAbout.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAbout.OnIdleState.BorderThickness = 1;
            this.btnAbout.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnAbout.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAbout.OnIdleState.IconLeftImage = null;
            this.btnAbout.OnIdleState.IconRightImage = null;
            this.btnAbout.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAbout.OnPressedState.BorderRadius = 10;
            this.btnAbout.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAbout.OnPressedState.BorderThickness = 1;
            this.btnAbout.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAbout.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAbout.OnPressedState.IconLeftImage = null;
            this.btnAbout.OnPressedState.IconRightImage = null;
            this.btnAbout.Size = new System.Drawing.Size(173, 65);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.TabStop = false;
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAbout.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAbout.TextMarginLeft = 0;
            this.btnAbout.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAbout.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuToggleSwitch1
            // 
            this.bunifuToggleSwitch1.Animation = 5;
            this.bunifuToggleSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuToggleSwitch1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuToggleSwitch1.BackgroundImage")));
            this.bunifuToggleSwitch1.Checked = true;
            this.bunifuToggleSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuToggleSwitch1.InnerCirclePadding = 3;
            this.bunifuToggleSwitch1.Location = new System.Drawing.Point(618, 180);
            this.bunifuToggleSwitch1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuToggleSwitch1.Name = "bunifuToggleSwitch1";
            this.bunifuToggleSwitch1.Size = new System.Drawing.Size(32, 18);
            this.bunifuToggleSwitch1.TabIndex = 1;
            this.bunifuToggleSwitch1.ThumbMargin = 3;
            toggleState1.BackColor = System.Drawing.Color.DarkGray;
            toggleState1.BackColorInner = System.Drawing.Color.White;
            toggleState1.BorderColor = System.Drawing.Color.DarkGray;
            toggleState1.BorderColorInner = System.Drawing.Color.White;
            toggleState1.BorderRadius = 17;
            toggleState1.BorderRadiusInner = 11;
            toggleState1.BorderThickness = 1;
            toggleState1.BorderThicknessInner = 1;
            this.bunifuToggleSwitch1.ToggleStateDisabled = toggleState1;
            toggleState2.BackColor = System.Drawing.Color.Empty;
            toggleState2.BackColorInner = System.Drawing.Color.Empty;
            toggleState2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            toggleState2.BorderColorInner = System.Drawing.Color.Empty;
            toggleState2.BorderRadius = 1;
            toggleState2.BorderRadiusInner = 1;
            toggleState2.BorderThickness = 1;
            toggleState2.BorderThicknessInner = 1;
            this.bunifuToggleSwitch1.ToggleStateOff = toggleState2;
            toggleState3.BackColor = System.Drawing.Color.DodgerBlue;
            toggleState3.BackColorInner = System.Drawing.Color.White;
            toggleState3.BorderColor = System.Drawing.Color.DodgerBlue;
            toggleState3.BorderColorInner = System.Drawing.Color.White;
            toggleState3.BorderRadius = 17;
            toggleState3.BorderRadiusInner = 11;
            toggleState3.BorderThickness = 1;
            toggleState3.BorderThicknessInner = 1;
            this.bunifuToggleSwitch1.ToggleStateOn = toggleState3;
            this.bunifuToggleSwitch1.Value = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 581);
            this.Controls.Add(this.bunifuToggleSwitch1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAbout;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSettings;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCatalog;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAdd;
        private Bunifu.UI.WinForms.BunifuToggleSwitch bunifuToggleSwitch1;
    }
}

