
namespace GenaratorAiG
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
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("Нахождение действительных значений");
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("Представление в показательной форме");
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("Комплексные числа", new System.Windows.Forms.TreeNode[] {
            treeNode65,
            treeNode66});
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("Число инверсий в перестановках");
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("Определитель 2-го порядка");
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("Определитель 3-его порядка");
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("Теорема о разложении 4го порядка");
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("Метод эффективного понижения 4го порядка");
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("Метод эффективного понижения 5го порядка");
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("Теорема Лапласса");
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("Детерминант", new System.Windows.Forms.TreeNode[] {
            treeNode68,
            treeNode69,
            treeNode70,
            treeNode71,
            treeNode72,
            treeNode73,
            treeNode74});
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("Произведение матриц A*B и B*A");
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("Линейные комбинации матрицы");
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("Произведение матриц A*A^T и A^T*A");
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("Найти матрицу A^n");
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("Нахождение обратной матрицы");
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("Матричные уравнения");
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("Решение СЛАУ методом Крамера");
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("Решение СЛАУ матричным методом");
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("Решение СЛАУ методом Гаусса");
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("СЛАУ", new System.Windows.Forms.TreeNode[] {
            treeNode76,
            treeNode77,
            treeNode78,
            treeNode79,
            treeNode80,
            treeNode81,
            treeNode82,
            treeNode83,
            treeNode84});
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("Скалярное произведение векторов");
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("Скалярное произведение векторов и углы между ними");
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("Угол между векторами");
            System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("Векторное произведение векторов");
            System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("Упростить выражение");
            System.Windows.Forms.TreeNode treeNode91 = new System.Windows.Forms.TreeNode("Площадь треугольника и его высота");
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("Компланарность векторов");
            System.Windows.Forms.TreeNode treeNode93 = new System.Windows.Forms.TreeNode("Векторы в плоскости");
            System.Windows.Forms.TreeNode treeNode94 = new System.Windows.Forms.TreeNode("Пересечение точкой плоскости");
            System.Windows.Forms.TreeNode treeNode95 = new System.Windows.Forms.TreeNode("Расстояние от точки до плоскости");
            System.Windows.Forms.TreeNode treeNode96 = new System.Windows.Forms.TreeNode("Аналитическая геометрия", new System.Windows.Forms.TreeNode[] {
            treeNode86,
            treeNode87,
            treeNode88,
            treeNode89,
            treeNode90,
            treeNode91,
            treeNode92,
            treeNode93,
            treeNode94,
            treeNode95});
            this.kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(this.components);
            this.GenerateButton = new Krypton.Toolkit.KryptonButton();
            this.DownloadButton = new Krypton.Toolkit.KryptonButton();
            this.PrintButton = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.kryptonTreeView1 = new Krypton.Toolkit.KryptonTreeView();
            this.ChooseLabel = new System.Windows.Forms.Label();
            this.CounterLabel = new System.Windows.Forms.Label();
            this.VariousLabel = new System.Windows.Forms.Label();
            this.VariantTextBox = new Krypton.Toolkit.KryptonMaskedTextBox();
            this.WebBrowser = new Krypton.Toolkit.KryptonWebBrowser();
            this.VariousTextBox = new Krypton.Toolkit.KryptonMaskedTextBox();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 14F;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 15;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GenerateButton.Location = new System.Drawing.Point(255, 406);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.GenerateButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.GenerateButton.OverrideDefault.Back.ColorAngle = 45F;
            this.GenerateButton.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.GenerateButton.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.GenerateButton.OverrideDefault.Border.ColorAngle = 45F;
            this.GenerateButton.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.GenerateButton.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.GenerateButton.OverrideDefault.Border.Rounding = 20F;
            this.GenerateButton.OverrideDefault.Border.Width = 1;
            this.GenerateButton.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.GenerateButton.Size = new System.Drawing.Size(155, 43);
            this.GenerateButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.GenerateButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.GenerateButton.StateCommon.Back.ColorAngle = 45F;
            this.GenerateButton.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.GenerateButton.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.GenerateButton.StateCommon.Border.ColorAngle = 45F;
            this.GenerateButton.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.GenerateButton.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.GenerateButton.StateCommon.Border.Rounding = 20F;
            this.GenerateButton.StateCommon.Border.Width = 1;
            this.GenerateButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.GenerateButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.GenerateButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateButton.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.GenerateButton.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.GenerateButton.StatePressed.Back.ColorAngle = 135F;
            this.GenerateButton.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.GenerateButton.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.GenerateButton.StatePressed.Border.ColorAngle = 135F;
            this.GenerateButton.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.GenerateButton.StatePressed.Border.Rounding = 20F;
            this.GenerateButton.StatePressed.Border.Width = 1;
            this.GenerateButton.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.GenerateButton.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.GenerateButton.StateTracking.Back.ColorAngle = 45F;
            this.GenerateButton.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.GenerateButton.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.GenerateButton.StateTracking.Border.ColorAngle = 45F;
            this.GenerateButton.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.GenerateButton.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.GenerateButton.StateTracking.Border.Rounding = 20F;
            this.GenerateButton.StateTracking.Border.Width = 1;
            this.GenerateButton.TabIndex = 5;
            this.GenerateButton.Values.Text = "Сгенерировать";
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // DownloadButton
            // 
            this.DownloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DownloadButton.Location = new System.Drawing.Point(12, 406);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.DownloadButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.DownloadButton.OverrideDefault.Back.ColorAngle = 45F;
            this.DownloadButton.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.DownloadButton.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.DownloadButton.OverrideDefault.Border.ColorAngle = 45F;
            this.DownloadButton.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DownloadButton.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.DownloadButton.OverrideDefault.Border.Rounding = 20F;
            this.DownloadButton.OverrideDefault.Border.Width = 1;
            this.DownloadButton.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.DownloadButton.Size = new System.Drawing.Size(111, 43);
            this.DownloadButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.DownloadButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.DownloadButton.StateCommon.Back.ColorAngle = 45F;
            this.DownloadButton.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.DownloadButton.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.DownloadButton.StateCommon.Border.ColorAngle = 45F;
            this.DownloadButton.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DownloadButton.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.DownloadButton.StateCommon.Border.Rounding = 20F;
            this.DownloadButton.StateCommon.Border.Width = 1;
            this.DownloadButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.DownloadButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.DownloadButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DownloadButton.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.DownloadButton.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.DownloadButton.StatePressed.Back.ColorAngle = 135F;
            this.DownloadButton.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.DownloadButton.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.DownloadButton.StatePressed.Border.ColorAngle = 135F;
            this.DownloadButton.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DownloadButton.StatePressed.Border.Rounding = 20F;
            this.DownloadButton.StatePressed.Border.Width = 1;
            this.DownloadButton.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.DownloadButton.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.DownloadButton.StateTracking.Back.ColorAngle = 45F;
            this.DownloadButton.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.DownloadButton.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.DownloadButton.StateTracking.Border.ColorAngle = 45F;
            this.DownloadButton.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DownloadButton.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.DownloadButton.StateTracking.Border.Rounding = 20F;
            this.DownloadButton.StateTracking.Border.Width = 1;
            this.DownloadButton.TabIndex = 6;
            this.DownloadButton.Values.Text = "Скачать";
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PrintButton.Location = new System.Drawing.Point(129, 406);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.PrintButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.PrintButton.OverrideDefault.Back.ColorAngle = 45F;
            this.PrintButton.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.PrintButton.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.PrintButton.OverrideDefault.Border.ColorAngle = 45F;
            this.PrintButton.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PrintButton.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.PrintButton.OverrideDefault.Border.Rounding = 20F;
            this.PrintButton.OverrideDefault.Border.Width = 1;
            this.PrintButton.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.PrintButton.Size = new System.Drawing.Size(120, 43);
            this.PrintButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.PrintButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.PrintButton.StateCommon.Back.ColorAngle = 45F;
            this.PrintButton.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.PrintButton.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.PrintButton.StateCommon.Border.ColorAngle = 45F;
            this.PrintButton.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PrintButton.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.PrintButton.StateCommon.Border.Rounding = 20F;
            this.PrintButton.StateCommon.Border.Width = 1;
            this.PrintButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.PrintButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.PrintButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintButton.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.PrintButton.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.PrintButton.StatePressed.Back.ColorAngle = 135F;
            this.PrintButton.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.PrintButton.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.PrintButton.StatePressed.Border.ColorAngle = 135F;
            this.PrintButton.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PrintButton.StatePressed.Border.Rounding = 20F;
            this.PrintButton.StatePressed.Border.Width = 1;
            this.PrintButton.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.PrintButton.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.PrintButton.StateTracking.Back.ColorAngle = 45F;
            this.PrintButton.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.PrintButton.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.PrintButton.StateTracking.Border.ColorAngle = 45F;
            this.PrintButton.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PrintButton.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.PrintButton.StateTracking.Border.Rounding = 20F;
            this.PrintButton.StateTracking.Border.Width = 1;
            this.PrintButton.TabIndex = 7;
            this.PrintButton.Values.Text = "Печать";
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(35, 353);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kryptonButton1.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonButton1.OverrideDefault.Back.ColorAngle = 45F;
            this.kryptonButton1.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kryptonButton1.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonButton1.OverrideDefault.Border.ColorAngle = 45F;
            this.kryptonButton1.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.OverrideDefault.Border.Rounding = 20F;
            this.kryptonButton1.OverrideDefault.Border.Width = 1;
            this.kryptonButton1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonButton1.Size = new System.Drawing.Size(155, 43);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonButton1.StateCommon.Back.ColorAngle = 45F;
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonButton1.StateCommon.Border.ColorAngle = 45F;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.StateCommon.Border.Rounding = 20F;
            this.kryptonButton1.StateCommon.Border.Width = 1;
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonButton1.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.kryptonButton1.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.kryptonButton1.StatePressed.Back.ColorAngle = 135F;
            this.kryptonButton1.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.kryptonButton1.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.kryptonButton1.StatePressed.Border.ColorAngle = 135F;
            this.kryptonButton1.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StatePressed.Border.Rounding = 20F;
            this.kryptonButton1.StatePressed.Border.Width = 1;
            this.kryptonButton1.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonButton1.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kryptonButton1.StateTracking.Back.ColorAngle = 45F;
            this.kryptonButton1.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kryptonButton1.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonButton1.StateTracking.Border.ColorAngle = 45F;
            this.kryptonButton1.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.StateTracking.Border.Rounding = 20F;
            this.kryptonButton1.StateTracking.Border.Width = 1;
            this.kryptonButton1.TabIndex = 7;
            this.kryptonButton1.Values.Text = "Скачать";
            // 
            // kryptonTreeView1
            // 
            this.kryptonTreeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.kryptonTreeView1.CheckBoxes = true;
            this.kryptonTreeView1.Location = new System.Drawing.Point(12, 28);
            this.kryptonTreeView1.Name = "kryptonTreeView1";
            treeNode65.Name = "Node4";
            treeNode65.Text = "Нахождение действительных значений";
            treeNode66.Name = "Node19";
            treeNode66.Text = "Представление в показательной форме";
            treeNode67.Name = "ComplexNode";
            treeNode67.Text = "Комплексные числа";
            treeNode68.Name = "Node46";
            treeNode68.Text = "Число инверсий в перестановках";
            treeNode69.Name = "Node58";
            treeNode69.Text = "Определитель 2-го порядка";
            treeNode70.Name = "Node60";
            treeNode70.Text = "Определитель 3-его порядка";
            treeNode71.Name = "Node67";
            treeNode71.Text = "Теорема о разложении 4го порядка";
            treeNode72.Name = "Node68";
            treeNode72.Text = "Метод эффективного понижения 4го порядка";
            treeNode73.Name = "Node69";
            treeNode73.Text = "Метод эффективного понижения 5го порядка";
            treeNode74.Name = "Node70";
            treeNode74.Text = "Теорема Лапласса";
            treeNode75.Name = "DeterminantsNode";
            treeNode75.Text = "Детерминант";
            treeNode76.Name = "Node72";
            treeNode76.Text = "Произведение матриц A*B и B*A";
            treeNode77.Name = "Node73";
            treeNode77.Text = "Линейные комбинации матрицы";
            treeNode78.Name = "Node74";
            treeNode78.Text = "Произведение матриц A*A^T и A^T*A";
            treeNode79.Name = "Node76";
            treeNode79.Text = "Найти матрицу A^n";
            treeNode80.Name = "Node80";
            treeNode80.Text = "Нахождение обратной матрицы";
            treeNode81.Name = "Node82";
            treeNode81.Text = "Матричные уравнения";
            treeNode82.Name = "Node87";
            treeNode82.Text = "Решение СЛАУ методом Крамера";
            treeNode83.Name = "Node88";
            treeNode83.Text = "Решение СЛАУ матричным методом";
            treeNode84.Name = "Node89";
            treeNode84.Text = "Решение СЛАУ методом Гаусса";
            treeNode85.Name = "SlaeNode";
            treeNode85.Text = "СЛАУ";
            treeNode86.Name = "Node104";
            treeNode86.Text = "Скалярное произведение векторов";
            treeNode87.Name = "Node105";
            treeNode87.Text = "Скалярное произведение векторов и углы между ними";
            treeNode88.Name = "Node108";
            treeNode88.Text = "Угол между векторами";
            treeNode89.Name = "Node117";
            treeNode89.Text = "Векторное произведение векторов";
            treeNode90.Name = "Node118";
            treeNode90.Text = "Упростить выражение";
            treeNode91.Name = "Node119";
            treeNode91.Text = "Площадь треугольника и его высота";
            treeNode92.Name = "Node125";
            treeNode92.Text = "Компланарность векторов";
            treeNode93.Name = "Node126";
            treeNode93.Text = "Векторы в плоскости";
            treeNode94.Name = "Node152";
            treeNode94.Text = "Пересечение точкой плоскости";
            treeNode95.Name = "Node160";
            treeNode95.Text = "Расстояние от точки до плоскости";
            treeNode96.Name = "AnalyticalGeometryNode";
            treeNode96.Text = "Аналитическая геометрия";
            this.kryptonTreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode67,
            treeNode75,
            treeNode85,
            treeNode96});
            this.kryptonTreeView1.Size = new System.Drawing.Size(398, 331);
            this.kryptonTreeView1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTreeView1.StateCommon.Border.Rounding = 20F;
            this.kryptonTreeView1.TabIndex = 8;
            this.kryptonTreeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.kryptonTreeView1_AfterCheck);
            // 
            // ChooseLabel
            // 
            this.ChooseLabel.AutoSize = true;
            this.ChooseLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(144)))), ((int)(((byte)(254)))));
            this.ChooseLabel.Location = new System.Drawing.Point(32, 9);
            this.ChooseLabel.Name = "ChooseLabel";
            this.ChooseLabel.Size = new System.Drawing.Size(115, 16);
            this.ChooseLabel.TabIndex = 4;
            this.ChooseLabel.Text = "Выберите темы:";
            // 
            // CounterLabel
            // 
            this.CounterLabel.AutoSize = true;
            this.CounterLabel.BackColor = System.Drawing.Color.White;
            this.CounterLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CounterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(144)))), ((int)(((byte)(254)))));
            this.CounterLabel.Location = new System.Drawing.Point(368, 38);
            this.CounterLabel.Name = "CounterLabel";
            this.CounterLabel.Size = new System.Drawing.Size(25, 25);
            this.CounterLabel.TabIndex = 9;
            this.CounterLabel.Text = "0";
            // 
            // VariousLabel
            // 
            this.VariousLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.VariousLabel.AutoSize = true;
            this.VariousLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VariousLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(144)))), ((int)(((byte)(254)))));
            this.VariousLabel.Location = new System.Drawing.Point(267, 372);
            this.VariousLabel.Name = "VariousLabel";
            this.VariousLabel.Size = new System.Drawing.Size(80, 18);
            this.VariousLabel.TabIndex = 11;
            this.VariousLabel.Text = "Варианты:";
            // 
            // VariantTextBox
            // 
            this.VariantTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.VariantTextBox.Location = new System.Drawing.Point(353, 365);
            this.VariantTextBox.Mask = "0";
            this.VariantTextBox.Name = "VariantTextBox";
            this.VariantTextBox.Size = new System.Drawing.Size(57, 35);
            this.VariantTextBox.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.VariantTextBox.StateCommon.Border.Rounding = 20F;
            this.VariantTextBox.TabIndex = 12;
            this.VariantTextBox.Text = "1";
            this.VariantTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WebBrowser
            // 
            this.WebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebBrowser.Location = new System.Drawing.Point(416, 9);
            this.WebBrowser.Name = "WebBrowser";
            this.WebBrowser.Size = new System.Drawing.Size(356, 440);
            this.WebBrowser.TabIndex = 13;
            // 
            // VariousTextBox
            // 
            this.VariousTextBox.Location = new System.Drawing.Point(353, 365);
            this.VariousTextBox.Mask = "0";
            this.VariousTextBox.Name = "VariousTextBox";
            this.VariousTextBox.Size = new System.Drawing.Size(57, 35);
            this.VariousTextBox.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.VariousTextBox.StateCommon.Border.Rounding = 20F;
            this.VariousTextBox.TabIndex = 12;
            this.VariousTextBox.Text = "1";
            this.VariousTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.WebBrowser);
            this.Controls.Add(this.VariantTextBox);
            this.Controls.Add(this.VariousLabel);
            this.Controls.Add(this.CounterLabel);
            this.Controls.Add(this.kryptonTreeView1);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.ChooseLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "Form1";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Генератор контрольных работ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Krypton.Toolkit.KryptonButton GenerateButton;
        private Krypton.Toolkit.KryptonButton DownloadButton;
        private Krypton.Toolkit.KryptonButton PrintButton;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonTreeView kryptonTreeView1;
        private System.Windows.Forms.Label ChooseLabel;
        private System.Windows.Forms.Label CounterLabel;
        private System.Windows.Forms.Label VariousLabel;
        private Krypton.Toolkit.KryptonMaskedTextBox VariantTextBox;
        private Krypton.Toolkit.KryptonWebBrowser WebBrowser;
        private Krypton.Toolkit.KryptonMaskedTextBox VariousTextBox;
    }
}