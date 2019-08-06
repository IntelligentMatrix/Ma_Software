using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyLibrary.MyControl
{
    public partial class PicShow : UserControl
    {

        public PicShow()
        {
            InitializeComponent();
            //注册滚轮事件
            this.PicBox.MouseWheel += new MouseEventHandler(PicBox_MouseWheel);
        }
        public Bitmap m_bmp;              //画布中的图像
        public Point m_ptCanvas;           //画布原点在设备上的坐标
        Point m_ptCanvasBuf;              //重置画布坐标计算时用的临时变量
        Point m_ptBmp;                     //图像位于画布坐标系中的坐标
        public float m_nScale = 1.0F;      //缩放比例
        Point m_ptMouseDown;               //鼠标点下是在设备坐标上的坐标
        string m_strMousePt;               //鼠标当前位置对应的坐标

        /// <summary>
        /// 获取屏幕图像
        /// </summary>
        /// <returns></returns>
        public Bitmap GetScreen()
        {
            Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                Screen.PrimaryScreen.Bounds.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(0, 0, 0, 0, bmp.Size);
            }
            return bmp;
        }
        /// <summary>
        /// 加载图像
        /// </summary>
        /// <param name="bmp"></param>
        public void LoadPic(Bitmap bmp)
        {
            if (bmp == null) return;
            m_bmp = bmp;
            ResetPicture();
        }
        /// <summary>
        /// 窗口初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicShow_Load(object sender, EventArgs e)
        {
            //Bitmap tmp = GetScreen();

            //缩放
            //PicProgressMethod.PicProgress(tmp, out m_bmp, GetRatio(tmp));
            //if (m_bmp == null) return;

            //原始
            //m_bmp = tmp;

            this.DoubleBuffered = true;
            RefreshFormSize();
        }
        /// <summary>
        /// 指定位置缩放，查看图片细节
        /// </summary>
        /// <param name="originPos"></param>
        /// <param name="ratio"></param>
        public void FocusPic(Point originPos, float ratio)
        {
            m_ptCanvas = originPos;//聚焦坐标
            m_nScale = ratio;//缩放系数
            PicBox.Invalidate();//重绘
        }
        /// <summary>
        /// Pic重绘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicBox_Paint(object sender, PaintEventArgs e)
        {
            this.Invoke((EventHandler)delegate
            {
                if (m_bmp != null)
                {
                    Graphics g = e.Graphics;                                 //读入传入的图像
                    g.TranslateTransform(m_ptCanvas.X, m_ptCanvas.Y);       //设置坐标偏移
                    g.ScaleTransform(m_nScale, m_nScale);                   //设置缩放比
                    g.DrawImage(m_bmp, m_ptBmp);                            //绘制图像
                    g.ResetTransform();  //重置坐标系

                    //绘制坐标系
                    //Pen p = new Pen(Color.Cyan, 3);
                    //g.DrawLine(p, 0, m_ptCanvas.Y, PicBox.Width, m_ptCanvas.Y);
                    //g.DrawLine(p, m_ptCanvas.X, 0, m_ptCanvas.X, PicBox.Height);
                    //p.Dispose();

                    //绘制网格线
                    //float nIncrement = (50 * m_nScale);             //网格间的间隔 根据比例绘制
                    //for (float x = m_ptCanvas.X; x > 0; x -= nIncrement)
                    //    g.DrawLine(Pens.Cyan, x, 0, x, PictureBox.Height);
                    //for (float x = m_ptCanvas.X; x < PictureBox.Width; x += nIncrement)
                    //    g.DrawLine(Pens.Cyan, x, 0, x, PictureBox.Height);
                    //for (float y = m_ptCanvas.Y; y > 0; y -= nIncrement)
                    //    g.DrawLine(Pens.Cyan, 0, y, PictureBox.Width, y);
                    //for (float y = m_ptCanvas.Y; y < PictureBox.Width; y += nIncrement)
                    //    g.DrawLine(Pens.Cyan, 0, y, PictureBox.Width, y);

                    //计算屏幕左上角 和 右下角 对应画布上的坐标
                    Size szTemp = PicBox.Size - (Size)m_ptCanvas;
                    PointF ptCanvasOnShowRectLT = new PointF(
                        -m_ptCanvas.X / m_nScale, -m_ptCanvas.Y / m_nScale);
                    PointF ptCanvasOnShowRectRB = new PointF(
                        szTemp.Width / m_nScale, szTemp.Height / m_nScale);

                    ////显示文字信息
                    //string strDraw = "Scale: " + m_nScale.ToString("F1") +
                    //    "\nOrigin: " + m_ptCanvas.ToString() +
                    //    "\nLT: " + Point.Round(ptCanvasOnShowRectLT).ToString() +
                    //    "\nRB: " + Point.Round(ptCanvasOnShowRectRB).ToString() +
                    //    "\n" + ((Size)Point.Round(ptCanvasOnShowRectRB)
                    //    - (Size)Point.Round(ptCanvasOnShowRectLT)).ToString();
                    //Size strSize = TextRenderer.MeasureText(strDraw, this.Font);

                    ////绘制文字信息
                    //SolidBrush sb = new SolidBrush(Color.FromArgb(125, 0, 0, 0));
                    //g.FillRectangle(sb, 0, 0, strSize.Width, strSize.Height);
                    //g.DrawString(strDraw, this.Font, Brushes.Yellow, 0, 0);
                    //strSize = TextRenderer.MeasureText(m_strMousePt, this.Font);
                    //g.FillRectangle(sb, PicBox.Width - strSize.Width, 0, strSize.Width, strSize.Height);
                    //g.DrawString(m_strMousePt, this.Font, Brushes.Yellow, PicBox.Width - strSize.Width, 0);
                    //sb.Dispose();
                }
            });
        }
        /// <summary>
        /// 鼠标中键按下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {      //如果中键点下    初始化计算要用的临时数据
                m_ptMouseDown = e.Location;
                m_ptCanvasBuf = m_ptCanvas;
            }
            PicBox.Focus();
        }
        /// <summary>
        /// 平移图像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {    //移动过程中 中键点下 重置画布坐标系
                //我总感觉这样写不妥 但却是方便计算  如果多次这样搞的话 还是重载操作符吧
                m_ptCanvas = (Point)((Size)m_ptCanvasBuf + ((Size)e.Location - (Size)m_ptMouseDown));
                PicBox.Invalidate();
            }
            //计算 右上角显示的坐标信息
            SizeF szSub = (Size)e.Location - (Size)m_ptCanvas;  //计算鼠标当前点对应画布中的坐标
            szSub.Width /= m_nScale;
            szSub.Height /= m_nScale;
            Size sz = TextRenderer.MeasureText(m_strMousePt, this.Font);    //获取上一次的区域并重绘
            PicBox.Invalidate(new Rectangle(PicBox.Width - sz.Width, 0, sz.Width, sz.Height));
            m_strMousePt = e.Location.ToString() + "\n" + ((Point)(szSub.ToSize())).ToString();
            sz = TextRenderer.MeasureText(m_strMousePt, this.Font);         //绘制新的区域
            PicBox.Invalidate(new Rectangle(PicBox.Width - sz.Width, 0, sz.Width, sz.Height));
        }
        //缩放图像
        private void PicBox_MouseWheel(object sender, MouseEventArgs e)
        {
            if (m_nScale <= 0.1 && e.Delta <= 0) return;        //缩小下线
            if (m_nScale >= 10 && e.Delta >= 0) return;        //放大上线
            //获取 当前点到画布坐标原点的距离
            SizeF szSub = (Size)m_ptCanvas - (Size)e.Location;
            //当前的距离差除以缩放比还原到未缩放长度
            float tempX = szSub.Width / m_nScale;           //这里
            float tempY = szSub.Height / m_nScale;          //将画布比例
            //还原上一次的偏移                               //按照当前缩放比还原到
            m_ptCanvas.X -= (int)(szSub.Width - tempX);     //没有缩放
            m_ptCanvas.Y -= (int)(szSub.Height - tempY);    //的状态
            //重置距离差为  未缩放状态                       
            szSub.Width = tempX;
            szSub.Height = tempY;
            m_nScale += e.Delta > 0 ? 0.2F : -0.2F;
            //重新计算 缩放并 重置画布原点坐标
            m_ptCanvas.X += (int)(szSub.Width * m_nScale - szSub.Width);
            m_ptCanvas.Y += (int)(szSub.Height * m_nScale - szSub.Height);
            PicBox.Invalidate();
        }
        /// <summary>
        /// 双击重绘图像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicBox_DoubleClick(object sender, EventArgs e)
        {
            ResetPicture();
        }
        /// <summary>
        /// 重置图片
        /// </summary>
        private void ResetPicture()
        {
            if (PicBox.Image != null) PicBox.Image.Dispose();//释放原图像
            m_ptCanvas = new Point(0, 0);           //画布原点在设备上的坐标
            m_ptCanvasBuf = new Point(0, 0);        //重置画布坐标计算时用的临时变量
            m_ptBmp = new Point(0, 0);               //图像位于画布坐标系中的坐标
            m_ptMouseDown = new Point(0, 0);        //鼠标点下是在设备坐标上的坐标
            RefreshFormSize();
            PicBox.Invalidate();
            //资源回收
            GC.Collect();
        }
        /// <summary>
        /// 依据控件图像大小，计算缩放比例，使图像铺满绘图框
        /// </summary>
        public void RefreshFormSize()
        {
            if (m_bmp != null)
            {
                if ((Width < m_bmp.Width) || (Height < m_bmp.Height))
                {
                    m_nScale = ((float)Width / m_bmp.Width) > ((float)Height / m_bmp.Height) ? ((float)Height / m_bmp.Height) : ((float)Width / m_bmp.Width);
                    //this.Width = (int)(m_bmp.Width * m_nScale);
                    //this.Height = (int)(m_bmp.Height * m_nScale);
                }
                else
                {
                    m_nScale = ((float)m_bmp.Width / Width) > ((float)m_bmp.Height / Height) ? ((float)m_bmp.Height / Height) : ((float)m_bmp.Width / Width);
                    //this.Width = (int)(Width * m_nScale);
                    //this.Height = (int)(Height * m_nScale);
                }
            }
            PicBox.Invalidate();
        }
        /// <summary>
        /// 依据控件图像大小，计算缩放比例，使图像铺满绘图框
        /// </summary>
        public float GetRatio(Bitmap pic)
        {
            if (pic == null) return 0;
            if ((Width < pic.Width) || (Height < pic.Height))
            {
                return ((float)Width / pic.Width) > ((float)Height / pic.Height) ? ((float)Height / pic.Height) : ((float)Width / pic.Width);
            }
            else
            {
                return ((float)pic.Width / Width) > ((float)pic.Height / Height) ? ((float)pic.Height / Height) : ((float)pic.Width / Width);
            }
        }
    }
}
