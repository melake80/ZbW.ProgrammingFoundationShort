namespace ZbW.ProgrammingFoundationShort.Challenges.Module02.Aufgabe1_Ampelsteuerung;

partial class AmpelsteuerungForm
{
  private System.ComponentModel.IContainer components = null;

  protected override void Dispose(bool disposing)
  {
    if (disposing && (components != null))
      components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    GrpFarbe = new GroupBox();
    RadRot = new RadioButton();
    RadGelb = new RadioButton();
    RadGruen = new RadioButton();
    CmdAnzeigen = new Button();
    LblMeldung = new Label();
    LblAmpel = new Label();
    GrpFarbe.SuspendLayout();
    SuspendLayout();
    // 
    // GrpFarbe
    // 
    GrpFarbe.Controls.Add(RadRot);
    GrpFarbe.Controls.Add(RadGelb);
    GrpFarbe.Controls.Add(RadGruen);
    GrpFarbe.Location = new Point(22, 26);
    GrpFarbe.Margin = new Padding(6, 6, 6, 6);
    GrpFarbe.Name = "GrpFarbe";
    GrpFarbe.Padding = new Padding(6, 6, 6, 6);
    GrpFarbe.Size = new Size(371, 213);
    GrpFarbe.TabIndex = 0;
    GrpFarbe.TabStop = false;
    GrpFarbe.Text = "Ampelfarbe";
    // 
    // RadRot
    // 
    RadRot.AutoSize = true;
    RadRot.Checked = true;
    RadRot.Location = new Point(19, 43);
    RadRot.Margin = new Padding(6, 6, 6, 6);
    RadRot.Name = "RadRot";
    RadRot.Size = new Size(80, 36);
    RadRot.TabIndex = 0;
    RadRot.TabStop = true;
    RadRot.Text = "Rot";
    // 
    // RadGelb
    // 
    RadGelb.AutoSize = true;
    RadGelb.Location = new Point(19, 96);
    RadGelb.Margin = new Padding(6, 6, 6, 6);
    RadGelb.Name = "RadGelb";
    RadGelb.Size = new Size(94, 36);
    RadGelb.TabIndex = 1;
    RadGelb.Text = "Gelb";
    // 
    // RadGruen
    // 
    RadGruen.AutoSize = true;
    RadGruen.Location = new Point(19, 145);
    RadGruen.Margin = new Padding(6, 6, 6, 6);
    RadGruen.Name = "RadGruen";
    RadGruen.Size = new Size(97, 36);
    RadGruen.TabIndex = 2;
    RadGruen.Text = "Grün";
    // 
    // CmdAnzeigen
    // 
    CmdAnzeigen.Location = new Point(22, 256);
    CmdAnzeigen.Margin = new Padding(6, 6, 6, 6);
    CmdAnzeigen.Name = "CmdAnzeigen";
    CmdAnzeigen.Size = new Size(223, 60);
    CmdAnzeigen.TabIndex = 1;
    CmdAnzeigen.Text = "Anzeigen";
    CmdAnzeigen.Click += CmdAnzeigen_Click;
    // 
    // LblMeldung
    // 
    LblMeldung.AutoSize = true;
    LblMeldung.Location = new Point(22, 341);
    LblMeldung.Margin = new Padding(6, 0, 6, 0);
    LblMeldung.Name = "LblMeldung";
    LblMeldung.Size = new Size(0, 32);
    LblMeldung.TabIndex = 2;
    // 
    // LblAmpel
    // 
    LblAmpel.BackColor = Color.Gray;
    LblAmpel.BorderStyle = BorderStyle.FixedSingle;
    LblAmpel.Location = new Point(409, 26);
    LblAmpel.Margin = new Padding(6, 0, 6, 0);
    LblAmpel.Name = "LblAmpel";
    LblAmpel.Size = new Size(110, 126);
    LblAmpel.TabIndex = 3;
    LblAmpel.Click += LblAmpel_Click;
    // 
    // AmpelsteuerungForm
    // 
    AutoScaleDimensions = new SizeF(13F, 32F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(1228, 935);
    Controls.Add(GrpFarbe);
    Controls.Add(CmdAnzeigen);
    Controls.Add(LblMeldung);
    Controls.Add(LblAmpel);
    Margin = new Padding(6, 6, 6, 6);
    Name = "AmpelsteuerungForm";
    Text = "Ampelsteuerung – Aufgabe 1";
    GrpFarbe.ResumeLayout(false);
    GrpFarbe.PerformLayout();
    ResumeLayout(false);
    PerformLayout();
  }

  private GroupBox GrpFarbe;
  private RadioButton RadRot;
  private RadioButton RadGelb;
  private RadioButton RadGruen;
  private Button CmdAnzeigen;
  private Label LblMeldung;
  private Label LblAmpel;
}
