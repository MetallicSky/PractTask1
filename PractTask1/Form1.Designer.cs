namespace PractTask1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.colorDialogObjOutline = new System.Windows.Forms.ColorDialog();
            this.buttonObjOutline = new System.Windows.Forms.Button();
            this.buttonTrjClr = new System.Windows.Forms.Button();
            this.trackBarObjThk = new System.Windows.Forms.TrackBar();
            this.labelObjThk = new System.Windows.Forms.Label();
            this.labelTrjThk = new System.Windows.Forms.Label();
            this.trackBarTrjThk = new System.Windows.Forms.TrackBar();
            this.comboBoxObjKind = new System.Windows.Forms.ComboBox();
            this.labelObjKind = new System.Windows.Forms.Label();
            this.labelTrjKind = new System.Windows.Forms.Label();
            this.comboBoxTrjKind = new System.Windows.Forms.ComboBox();
            this.checkBoxPulse = new System.Windows.Forms.CheckBox();
            this.labelMin = new System.Windows.Forms.Label();
            this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMax = new System.Windows.Forms.NumericUpDown();
            this.labelMax = new System.Windows.Forms.Label();
            this.numericUpDownStepsPerPulse = new System.Windows.Forms.NumericUpDown();
            this.labelStepsPerPulse = new System.Windows.Forms.Label();
            this.labelStepsPerSec = new System.Windows.Forms.Label();
            this.numericUpDownStepsPerSec = new System.Windows.Forms.NumericUpDown();
            this.labelRepeats = new System.Windows.Forms.Label();
            this.checkBoxRepeatsInf = new System.Windows.Forms.CheckBox();
            this.numericUpDownRepeats = new System.Windows.Forms.NumericUpDown();
            this.labelStepLength = new System.Windows.Forms.Label();
            this.numericUpDownStepLength = new System.Windows.Forms.NumericUpDown();
            this.checkBoxRotation = new System.Windows.Forms.CheckBox();
            this.numericUpDownRotationDeg = new System.Windows.Forms.NumericUpDown();
            this.labelRotationDeg = new System.Windows.Forms.Label();
            this.labelClock = new System.Windows.Forms.Label();
            this.buttonObjInside = new System.Windows.Forms.Button();
            this.colorDialogObjInside = new System.Windows.Forms.ColorDialog();
            this.colorDialogTrjClr = new System.Windows.Forms.ColorDialog();
            this.pictureBoxTrj = new System.Windows.Forms.PictureBox();
            this.pictureBoxObj = new System.Windows.Forms.PictureBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.labelWidth = new System.Windows.Forms.Label();
            this.numericUpDownDeg = new System.Windows.Forms.NumericUpDown();
            this.labelDeg = new System.Windows.Forms.Label();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.labelBigRadius = new System.Windows.Forms.Label();
            this.numericUpDownBigRadius = new System.Windows.Forms.NumericUpDown();
            this.labelSmallRadius = new System.Windows.Forms.Label();
            this.numericUpDownSmallRadius = new System.Windows.Forms.NumericUpDown();
            this.timerFPS = new System.Windows.Forms.Timer(this.components);
            this.checkBoxClock = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarObjThk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTrjThk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStepsPerPulse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStepsPerSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStepLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotationDeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxObj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBigRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSmallRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonObjOutline
            // 
            this.buttonObjOutline.Location = new System.Drawing.Point(12, 12);
            this.buttonObjOutline.Name = "buttonObjOutline";
            this.buttonObjOutline.Size = new System.Drawing.Size(194, 23);
            this.buttonObjOutline.TabIndex = 0;
            this.buttonObjOutline.Text = "Настроить цвет контура объекта";
            this.buttonObjOutline.UseVisualStyleBackColor = true;
            this.buttonObjOutline.Click += new System.EventHandler(this.buttonObjOutline_Click);
            // 
            // buttonTrjClr
            // 
            this.buttonTrjClr.Location = new System.Drawing.Point(12, 41);
            this.buttonTrjClr.Name = "buttonTrjClr";
            this.buttonTrjClr.Size = new System.Drawing.Size(157, 23);
            this.buttonTrjClr.TabIndex = 2;
            this.buttonTrjClr.Text = "Настроить цвет траектории";
            this.buttonTrjClr.UseVisualStyleBackColor = true;
            this.buttonTrjClr.Click += new System.EventHandler(this.buttonTrjClr_Click);
            // 
            // trackBarObjThk
            // 
            this.trackBarObjThk.Location = new System.Drawing.Point(12, 86);
            this.trackBarObjThk.Minimum = 1;
            this.trackBarObjThk.Name = "trackBarObjThk";
            this.trackBarObjThk.Size = new System.Drawing.Size(315, 37);
            this.trackBarObjThk.TabIndex = 3;
            this.trackBarObjThk.Value = 1;
            this.trackBarObjThk.Scroll += new System.EventHandler(this.trackBarObjThk_Scroll);
            // 
            // labelObjThk
            // 
            this.labelObjThk.AutoSize = true;
            this.labelObjThk.Location = new System.Drawing.Point(9, 70);
            this.labelObjThk.Name = "labelObjThk";
            this.labelObjThk.Size = new System.Drawing.Size(131, 13);
            this.labelObjThk.TabIndex = 4;
            this.labelObjThk.Text = "Толщина линий объекта";
            // 
            // labelTrjThk
            // 
            this.labelTrjThk.AutoSize = true;
            this.labelTrjThk.Location = new System.Drawing.Point(9, 126);
            this.labelTrjThk.Name = "labelTrjThk";
            this.labelTrjThk.Size = new System.Drawing.Size(147, 13);
            this.labelTrjThk.TabIndex = 6;
            this.labelTrjThk.Text = "Толщина линии траектории";
            // 
            // trackBarTrjThk
            // 
            this.trackBarTrjThk.Location = new System.Drawing.Point(12, 142);
            this.trackBarTrjThk.Minimum = 1;
            this.trackBarTrjThk.Name = "trackBarTrjThk";
            this.trackBarTrjThk.Size = new System.Drawing.Size(315, 37);
            this.trackBarTrjThk.TabIndex = 5;
            this.trackBarTrjThk.Value = 1;
            this.trackBarTrjThk.Scroll += new System.EventHandler(this.trackBarTrjThk_Scroll);
            // 
            // comboBoxObjKind
            // 
            this.comboBoxObjKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxObjKind.FormattingEnabled = true;
            this.comboBoxObjKind.Items.AddRange(new object[] {
            "Сплошная",
            "Пунктирная",
            "Штриховая"});
            this.comboBoxObjKind.Location = new System.Drawing.Point(12, 198);
            this.comboBoxObjKind.Name = "comboBoxObjKind";
            this.comboBoxObjKind.Size = new System.Drawing.Size(121, 21);
            this.comboBoxObjKind.TabIndex = 7;
            this.comboBoxObjKind.SelectedIndexChanged += new System.EventHandler(this.comboBoxObjKind_SelectedIndexChanged);
            // 
            // labelObjKind
            // 
            this.labelObjKind.AutoSize = true;
            this.labelObjKind.Location = new System.Drawing.Point(9, 182);
            this.labelObjKind.Name = "labelObjKind";
            this.labelObjKind.Size = new System.Drawing.Size(104, 13);
            this.labelObjKind.TabIndex = 8;
            this.labelObjKind.Text = "Вид линий объекта";
            // 
            // labelTrjKind
            // 
            this.labelTrjKind.AutoSize = true;
            this.labelTrjKind.Location = new System.Drawing.Point(136, 182);
            this.labelTrjKind.Name = "labelTrjKind";
            this.labelTrjKind.Size = new System.Drawing.Size(120, 13);
            this.labelTrjKind.TabIndex = 10;
            this.labelTrjKind.Text = "Вид линий траектории";
            // 
            // comboBoxTrjKind
            // 
            this.comboBoxTrjKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTrjKind.FormattingEnabled = true;
            this.comboBoxTrjKind.Items.AddRange(new object[] {
            "Сплошная",
            "Пунктирная",
            "Штриховая"});
            this.comboBoxTrjKind.Location = new System.Drawing.Point(139, 198);
            this.comboBoxTrjKind.Name = "comboBoxTrjKind";
            this.comboBoxTrjKind.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTrjKind.TabIndex = 9;
            this.comboBoxTrjKind.SelectedIndexChanged += new System.EventHandler(this.comboBoxTrjKind_SelectedIndexChanged);
            // 
            // checkBoxPulse
            // 
            this.checkBoxPulse.AutoSize = true;
            this.checkBoxPulse.Location = new System.Drawing.Point(12, 225);
            this.checkBoxPulse.Name = "checkBoxPulse";
            this.checkBoxPulse.Size = new System.Drawing.Size(150, 17);
            this.checkBoxPulse.TabIndex = 12;
            this.checkBoxPulse.Text = "Пульсирование объекта";
            this.checkBoxPulse.UseVisualStyleBackColor = true;
            this.checkBoxPulse.CheckedChanged += new System.EventHandler(this.checkBoxPulse_CheckedChanged);
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Enabled = false;
            this.labelMin.Location = new System.Drawing.Point(9, 245);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(147, 13);
            this.labelMin.TabIndex = 13;
            this.labelMin.Text = "Минимальный размер (в %)";
            // 
            // numericUpDownMin
            // 
            this.numericUpDownMin.Enabled = false;
            this.numericUpDownMin.Location = new System.Drawing.Point(12, 261);
            this.numericUpDownMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMin.Name = "numericUpDownMin";
            this.numericUpDownMin.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMin.TabIndex = 14;
            this.numericUpDownMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMin.ValueChanged += new System.EventHandler(this.numericUpDownMin_ValueChanged);
            // 
            // numericUpDownMax
            // 
            this.numericUpDownMax.Enabled = false;
            this.numericUpDownMax.Location = new System.Drawing.Point(165, 261);
            this.numericUpDownMax.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownMax.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMax.Name = "numericUpDownMax";
            this.numericUpDownMax.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMax.TabIndex = 16;
            this.numericUpDownMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Enabled = false;
            this.labelMax.Location = new System.Drawing.Point(162, 245);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(153, 13);
            this.labelMax.TabIndex = 15;
            this.labelMax.Text = "Максимальный размер (в %)";
            // 
            // numericUpDownStepsPerPulse
            // 
            this.numericUpDownStepsPerPulse.Enabled = false;
            this.numericUpDownStepsPerPulse.Location = new System.Drawing.Point(12, 300);
            this.numericUpDownStepsPerPulse.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStepsPerPulse.Name = "numericUpDownStepsPerPulse";
            this.numericUpDownStepsPerPulse.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownStepsPerPulse.TabIndex = 17;
            this.numericUpDownStepsPerPulse.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // labelStepsPerPulse
            // 
            this.labelStepsPerPulse.AutoSize = true;
            this.labelStepsPerPulse.Enabled = false;
            this.labelStepsPerPulse.Location = new System.Drawing.Point(9, 284);
            this.labelStepsPerPulse.Name = "labelStepsPerPulse";
            this.labelStepsPerPulse.Size = new System.Drawing.Size(219, 13);
            this.labelStepsPerPulse.TabIndex = 18;
            this.labelStepsPerPulse.Text = "Количество шагов, требуемых для смены";
            // 
            // labelStepsPerSec
            // 
            this.labelStepsPerSec.AutoSize = true;
            this.labelStepsPerSec.Location = new System.Drawing.Point(9, 323);
            this.labelStepsPerSec.Name = "labelStepsPerSec";
            this.labelStepsPerSec.Size = new System.Drawing.Size(130, 13);
            this.labelStepsPerSec.TabIndex = 19;
            this.labelStepsPerSec.Text = "Количество шагов в сек";
            // 
            // numericUpDownStepsPerSec
            // 
            this.numericUpDownStepsPerSec.Location = new System.Drawing.Point(12, 339);
            this.numericUpDownStepsPerSec.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownStepsPerSec.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStepsPerSec.Name = "numericUpDownStepsPerSec";
            this.numericUpDownStepsPerSec.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownStepsPerSec.TabIndex = 20;
            this.numericUpDownStepsPerSec.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDownStepsPerSec.ValueChanged += new System.EventHandler(this.numericUpDownStepsPerSec_ValueChanged);
            // 
            // labelRepeats
            // 
            this.labelRepeats.AutoSize = true;
            this.labelRepeats.Location = new System.Drawing.Point(9, 362);
            this.labelRepeats.Name = "labelRepeats";
            this.labelRepeats.Size = new System.Drawing.Size(189, 13);
            this.labelRepeats.TabIndex = 21;
            this.labelRepeats.Text = "Количество повторов прохождения ";
            // 
            // checkBoxRepeatsInf
            // 
            this.checkBoxRepeatsInf.AutoSize = true;
            this.checkBoxRepeatsInf.Location = new System.Drawing.Point(138, 378);
            this.checkBoxRepeatsInf.Name = "checkBoxRepeatsInf";
            this.checkBoxRepeatsInf.Size = new System.Drawing.Size(86, 17);
            this.checkBoxRepeatsInf.TabIndex = 23;
            this.checkBoxRepeatsInf.Text = "Бесконечно";
            this.checkBoxRepeatsInf.UseVisualStyleBackColor = true;
            this.checkBoxRepeatsInf.CheckedChanged += new System.EventHandler(this.checkBoxRepeatsInf_CheckedChanged);
            // 
            // numericUpDownRepeats
            // 
            this.numericUpDownRepeats.Location = new System.Drawing.Point(12, 378);
            this.numericUpDownRepeats.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRepeats.Name = "numericUpDownRepeats";
            this.numericUpDownRepeats.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRepeats.TabIndex = 22;
            this.numericUpDownRepeats.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelStepLength
            // 
            this.labelStepLength.AutoSize = true;
            this.labelStepLength.Location = new System.Drawing.Point(9, 401);
            this.labelStepLength.Name = "labelStepLength";
            this.labelStepLength.Size = new System.Drawing.Size(68, 13);
            this.labelStepLength.TabIndex = 24;
            this.labelStepLength.Text = "Длина шага";
            // 
            // numericUpDownStepLength
            // 
            this.numericUpDownStepLength.Location = new System.Drawing.Point(12, 417);
            this.numericUpDownStepLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStepLength.Name = "numericUpDownStepLength";
            this.numericUpDownStepLength.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownStepLength.TabIndex = 25;
            this.numericUpDownStepLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBoxRotation
            // 
            this.checkBoxRotation.AutoSize = true;
            this.checkBoxRotation.Location = new System.Drawing.Point(12, 443);
            this.checkBoxRotation.Name = "checkBoxRotation";
            this.checkBoxRotation.Size = new System.Drawing.Size(123, 17);
            this.checkBoxRotation.TabIndex = 26;
            this.checkBoxRotation.Text = "Вращение объекта";
            this.checkBoxRotation.UseVisualStyleBackColor = true;
            this.checkBoxRotation.CheckedChanged += new System.EventHandler(this.checkBoxRotation_CheckedChanged);
            // 
            // numericUpDownRotationDeg
            // 
            this.numericUpDownRotationDeg.Enabled = false;
            this.numericUpDownRotationDeg.Location = new System.Drawing.Point(12, 479);
            this.numericUpDownRotationDeg.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownRotationDeg.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRotationDeg.Name = "numericUpDownRotationDeg";
            this.numericUpDownRotationDeg.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRotationDeg.TabIndex = 27;
            this.numericUpDownRotationDeg.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelRotationDeg
            // 
            this.labelRotationDeg.AutoSize = true;
            this.labelRotationDeg.Enabled = false;
            this.labelRotationDeg.Location = new System.Drawing.Point(9, 463);
            this.labelRotationDeg.Name = "labelRotationDeg";
            this.labelRotationDeg.Size = new System.Drawing.Size(123, 13);
            this.labelRotationDeg.TabIndex = 28;
            this.labelRotationDeg.Text = "Угол вращения за шаг";
            // 
            // labelClock
            // 
            this.labelClock.AutoSize = true;
            this.labelClock.Location = new System.Drawing.Point(9, 502);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(181, 13);
            this.labelClock.TabIndex = 29;
            this.labelClock.Text = "Движение объекта по траектории";
            // 
            // buttonObjInside
            // 
            this.buttonObjInside.Location = new System.Drawing.Point(212, 12);
            this.buttonObjInside.Name = "buttonObjInside";
            this.buttonObjInside.Size = new System.Drawing.Size(188, 23);
            this.buttonObjInside.TabIndex = 1;
            this.buttonObjInside.Text = "Настроить цвет заливки объекта";
            this.buttonObjInside.UseVisualStyleBackColor = true;
            this.buttonObjInside.Click += new System.EventHandler(this.buttonObjInside_Click);
            // 
            // pictureBoxTrj
            // 
            this.pictureBoxTrj.BackColor = System.Drawing.Color.White;
            this.pictureBoxTrj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxTrj.Location = new System.Drawing.Point(488, 12);
            this.pictureBoxTrj.Name = "pictureBoxTrj";
            this.pictureBoxTrj.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxTrj.TabIndex = 32;
            this.pictureBoxTrj.TabStop = false;
            this.pictureBoxTrj.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxTrj_Paint);
            // 
            // pictureBoxObj
            // 
            this.pictureBoxObj.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxObj.Location = new System.Drawing.Point(488, 12);
            this.pictureBoxObj.Name = "pictureBoxObj";
            this.pictureBoxObj.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxObj.TabIndex = 33;
            this.pictureBoxObj.TabStop = false;
            this.pictureBoxObj.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxObj_Paint);
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(485, 315);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(141, 13);
            this.labelHeight.TabIndex = 34;
            this.labelHeight.Text = "Высота параллелограмма";
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Location = new System.Drawing.Point(488, 331);
            this.numericUpDownHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownHeight.TabIndex = 35;
            this.numericUpDownHeight.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownHeight.ValueChanged += new System.EventHandler(this.numericUpDownHeight_ValueChanged);
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(635, 331);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownWidth.TabIndex = 37;
            this.numericUpDownWidth.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownWidth.ValueChanged += new System.EventHandler(this.numericUpDownWidth_ValueChanged);
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(632, 315);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(142, 13);
            this.labelWidth.TabIndex = 36;
            this.labelWidth.Text = "Ширина параллелограмма";
            // 
            // numericUpDownDeg
            // 
            this.numericUpDownDeg.Location = new System.Drawing.Point(488, 370);
            this.numericUpDownDeg.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numericUpDownDeg.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDeg.Name = "numericUpDownDeg";
            this.numericUpDownDeg.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDeg.TabIndex = 38;
            this.numericUpDownDeg.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.numericUpDownDeg.ValueChanged += new System.EventHandler(this.numericUpDownDeg_ValueChanged);
            // 
            // labelDeg
            // 
            this.labelDeg.AutoSize = true;
            this.labelDeg.Location = new System.Drawing.Point(485, 354);
            this.labelDeg.Name = "labelDeg";
            this.labelDeg.Size = new System.Drawing.Size(235, 13);
            this.labelDeg.TabIndex = 39;
            this.labelDeg.Text = "Меньший угол параллелограмма, в градусах";
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.BackColor = System.Drawing.Color.White;
            this.pictureBoxPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPreview.Location = new System.Drawing.Point(488, 396);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxPreview.TabIndex = 40;
            this.pictureBoxPreview.TabStop = false;
            this.pictureBoxPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxPreview_Paint);
            // 
            // labelBigRadius
            // 
            this.labelBigRadius.AutoSize = true;
            this.labelBigRadius.Location = new System.Drawing.Point(9, 547);
            this.labelBigRadius.Name = "labelBigRadius";
            this.labelBigRadius.Size = new System.Drawing.Size(119, 13);
            this.labelBigRadius.TabIndex = 41;
            this.labelBigRadius.Text = "Радиус a (траектория)";
            // 
            // numericUpDownBigRadius
            // 
            this.numericUpDownBigRadius.Location = new System.Drawing.Point(12, 563);
            this.numericUpDownBigRadius.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownBigRadius.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBigRadius.Name = "numericUpDownBigRadius";
            this.numericUpDownBigRadius.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownBigRadius.TabIndex = 42;
            this.numericUpDownBigRadius.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownBigRadius.ValueChanged += new System.EventHandler(this.numericUpDownBigRadius_ValueChanged);
            // 
            // labelSmallRadius
            // 
            this.labelSmallRadius.AutoSize = true;
            this.labelSmallRadius.Location = new System.Drawing.Point(9, 586);
            this.labelSmallRadius.Name = "labelSmallRadius";
            this.labelSmallRadius.Size = new System.Drawing.Size(119, 13);
            this.labelSmallRadius.TabIndex = 43;
            this.labelSmallRadius.Text = "Радиус b (траектория)";
            // 
            // numericUpDownSmallRadius
            // 
            this.numericUpDownSmallRadius.Location = new System.Drawing.Point(12, 602);
            this.numericUpDownSmallRadius.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownSmallRadius.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSmallRadius.Name = "numericUpDownSmallRadius";
            this.numericUpDownSmallRadius.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSmallRadius.TabIndex = 44;
            this.numericUpDownSmallRadius.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownSmallRadius.ValueChanged += new System.EventHandler(this.numericUpDownSmallRadius_ValueChanged);
            // 
            // timerFPS
            // 
            this.timerFPS.Tick += new System.EventHandler(this.timerFPS_Tick);
            // 
            // checkBoxClock
            // 
            this.checkBoxClock.AutoSize = true;
            this.checkBoxClock.Checked = true;
            this.checkBoxClock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxClock.Location = new System.Drawing.Point(12, 518);
            this.checkBoxClock.Name = "checkBoxClock";
            this.checkBoxClock.Size = new System.Drawing.Size(107, 17);
            this.checkBoxClock.TabIndex = 45;
            this.checkBoxClock.Text = "Против часовой";
            this.checkBoxClock.UseVisualStyleBackColor = true;
            this.checkBoxClock.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 665);
            this.Controls.Add(this.checkBoxClock);
            this.Controls.Add(this.numericUpDownSmallRadius);
            this.Controls.Add(this.labelSmallRadius);
            this.Controls.Add(this.numericUpDownBigRadius);
            this.Controls.Add(this.labelBigRadius);
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(this.labelDeg);
            this.Controls.Add(this.numericUpDownDeg);
            this.Controls.Add(this.numericUpDownWidth);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.numericUpDownHeight);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.pictureBoxObj);
            this.Controls.Add(this.buttonObjInside);
            this.Controls.Add(this.labelClock);
            this.Controls.Add(this.labelRotationDeg);
            this.Controls.Add(this.numericUpDownRotationDeg);
            this.Controls.Add(this.checkBoxRotation);
            this.Controls.Add(this.numericUpDownStepLength);
            this.Controls.Add(this.labelStepLength);
            this.Controls.Add(this.numericUpDownRepeats);
            this.Controls.Add(this.checkBoxRepeatsInf);
            this.Controls.Add(this.labelRepeats);
            this.Controls.Add(this.numericUpDownStepsPerSec);
            this.Controls.Add(this.labelStepsPerSec);
            this.Controls.Add(this.labelStepsPerPulse);
            this.Controls.Add(this.numericUpDownStepsPerPulse);
            this.Controls.Add(this.numericUpDownMax);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.numericUpDownMin);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.checkBoxPulse);
            this.Controls.Add(this.labelTrjKind);
            this.Controls.Add(this.comboBoxTrjKind);
            this.Controls.Add(this.labelObjKind);
            this.Controls.Add(this.comboBoxObjKind);
            this.Controls.Add(this.labelTrjThk);
            this.Controls.Add(this.trackBarTrjThk);
            this.Controls.Add(this.labelObjThk);
            this.Controls.Add(this.trackBarObjThk);
            this.Controls.Add(this.buttonTrjClr);
            this.Controls.Add(this.buttonObjOutline);
            this.Controls.Add(this.pictureBoxTrj);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 700);
            this.MinimumSize = new System.Drawing.Size(816, 700);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarObjThk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTrjThk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStepsPerPulse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStepsPerSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRepeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStepLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotationDeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxObj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBigRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSmallRadius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialogObjOutline;
        private System.Windows.Forms.Button buttonObjOutline;
        private System.Windows.Forms.Button buttonTrjClr;
        private System.Windows.Forms.TrackBar trackBarObjThk;
        private System.Windows.Forms.Label labelObjThk;
        private System.Windows.Forms.Label labelTrjThk;
        private System.Windows.Forms.TrackBar trackBarTrjThk;
        private System.Windows.Forms.ComboBox comboBoxObjKind;
        private System.Windows.Forms.Label labelObjKind;
        private System.Windows.Forms.Label labelTrjKind;
        private System.Windows.Forms.ComboBox comboBoxTrjKind;
        private System.Windows.Forms.CheckBox checkBoxPulse;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.NumericUpDown numericUpDownMin;
        private System.Windows.Forms.NumericUpDown numericUpDownMax;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.NumericUpDown numericUpDownStepsPerPulse;
        private System.Windows.Forms.Label labelStepsPerPulse;
        private System.Windows.Forms.Label labelStepsPerSec;
        private System.Windows.Forms.NumericUpDown numericUpDownStepsPerSec;
        private System.Windows.Forms.Label labelRepeats;
        private System.Windows.Forms.CheckBox checkBoxRepeatsInf;
        private System.Windows.Forms.NumericUpDown numericUpDownRepeats;
        private System.Windows.Forms.Label labelStepLength;
        private System.Windows.Forms.NumericUpDown numericUpDownStepLength;
        private System.Windows.Forms.CheckBox checkBoxRotation;
        private System.Windows.Forms.NumericUpDown numericUpDownRotationDeg;
        private System.Windows.Forms.Label labelRotationDeg;
        private System.Windows.Forms.Label labelClock;
        private System.Windows.Forms.Button buttonObjInside;
        private System.Windows.Forms.ColorDialog colorDialogObjInside;
        private System.Windows.Forms.ColorDialog colorDialogTrjClr;
        private System.Windows.Forms.PictureBox pictureBoxTrj;
        private System.Windows.Forms.PictureBox pictureBoxObj;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownDeg;
        private System.Windows.Forms.Label labelDeg;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.Label labelBigRadius;
        private System.Windows.Forms.NumericUpDown numericUpDownBigRadius;
        private System.Windows.Forms.Label labelSmallRadius;
        private System.Windows.Forms.NumericUpDown numericUpDownSmallRadius;
        private System.Windows.Forms.Timer timerFPS;
        private System.Windows.Forms.CheckBox checkBoxClock;
    }
}

