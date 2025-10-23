using VectorGraphicRedactor.Shapes;
namespace VectorGraphicRedactor.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel canvasPanel;
        private Panel toolPanel;
        private ComboBox shapeTypeComboBox;
        private Button colorButton;
        private Button delButton;
        private Button ToFrontButton;
        private Button ToBackButton;
        private Button undoButton;
        private Button redoButton;
        private PropertyGrid propertyGrid;
        private ColorDialog colorDialog;



        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Text = "VectorGraphicEditor";
            //холст
            canvasPanel = new Panel();
            canvasPanel.Dock = DockStyle.Fill;
            canvasPanel.BackColor = Color.Gray;
            canvasPanel.BorderStyle = BorderStyle.FixedSingle;
            //панель инструментов
            toolPanel = new Panel();
            toolPanel.Dock = DockStyle.Left;
            toolPanel.BackColor = Color.White;
            toolPanel.Width = 200;
            //выбор фигур
            shapeTypeComboBox = new ComboBox();
            shapeTypeComboBox.Location = new Point(10, 10);
            shapeTypeComboBox.Size = new Size(180, 25);
            shapeTypeComboBox.DataSource = Enum.GetValues(typeof(ShapeType));
            //выбор цвета
            colorButton = new Button();
            colorButton.Location = new Point(10, 45);
            colorButton.Size = new Size(180, 30);
            colorButton.Text = "Color";
            colorButton.BackColor = Color.Black;
            colorButton.ForeColor = Color.White;
            //Удаление
            delButton = new Button();
            delButton.Location = new Point(10, 85);
            delButton.Size = new Size(85, 30);
            delButton.Text = "Delete";
            //ToFront
            ToFrontButton = new Button();
            ToFrontButton.Location = new Point(105, 85);
            ToFrontButton.Size = new Size(85, 30);
            ToFrontButton.Text = "To Front";
            //BackFront
            ToBackButton = new Button();
            ToBackButton.Location = new Point(10, 125);
            ToBackButton.Size = new Size(85, 30);
            ToBackButton.Text = "To Back";
            //UndoButton
            undoButton = new Button();
            undoButton.Location = new Point(105, 125);
            undoButton.Size = new Size(85, 30);
            undoButton.Text = "Undo";
            //RedoButton
            redoButton = new Button();
            redoButton.Location = new Point(10, 165);
            redoButton.Size = new Size(85, 30);
            redoButton.Text = "Redo";
            //Property Grid
            propertyGrid = new PropertyGrid();
            propertyGrid.Location = new Point(10, 205);
            propertyGrid.Size = new Size(180, 300);
            //Добавление эл-ов на панель инструментов
            toolPanel.Controls.Add(shapeTypeComboBox);
            toolPanel.Controls.Add(colorButton);
            toolPanel.Controls.Add(delButton);
            toolPanel.Controls.Add(ToFrontButton);
            toolPanel.Controls.Add(ToBackButton);
            toolPanel.Controls.Add(undoButton);
            toolPanel.Controls.Add(redoButton);
            toolPanel.Controls.Add(propertyGrid);

            colorDialog = new ColorDialog();

            this.Controls.Add(canvasPanel);
            this.Controls.Add(toolPanel);


        }





    }
}