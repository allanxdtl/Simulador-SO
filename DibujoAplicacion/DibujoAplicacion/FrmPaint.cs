namespace DibujoAplicacion
{
    public partial class FrmPaint : Form
    {
        Graphics graphics;
        Boolean cursormoviendo=false;
        Pen plumacursor;
        int cursorx=-1;
        int cursory=-1;

        public FrmPaint()
        {
            InitializeComponent();
            graphics=canvas.CreateGraphics();
            plumacursor = new Pen(Color.Azure,5);
            graphics.SmoothingMode=System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            plumacursor.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            plumacursor.EndCap= System.Drawing.Drawing2D.LineCap.Round; 
        }

        private void moradoBox_Click(object sender, EventArgs e)
        {
            PictureBox color = (PictureBox)sender;
            plumacursor.Color = color.BackColor;
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            cursormoviendo = true;
            cursorx = e.X;
            cursory=e.Y;
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            cursormoviendo=false;
            cursorx = -1;
            cursory=-1; 
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (cursorx!=-1 && cursory!=-1 && cursormoviendo==true)
            {
                graphics.DrawLine(plumacursor, new Point(cursorx, cursory),e.Location);
                cursorx = e.X;
                cursory = e.Y;
            }
        }
    }
}