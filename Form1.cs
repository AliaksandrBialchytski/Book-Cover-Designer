using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progr_Graf_Winforms_Lab
{
    public partial class Form1 : Form
    {
        Bitmap DrawArea;
        int widthOfPanel1;
        int heightOfPanel1;
        int widthOfForm;
        int heightOfForm;
        int CoverWidth;
        int CoverHeight;
        int SpineWidth;
        int differenceWidth;
        int differenceHeight;
        int flag = 0;
        bool flag_start = false;
        bool flag_local = true;
        int x;
        int y;
        bool activated = false;
        int[] text_x = new int[100];
        int[] text_y = new int[100];
        string[] text = new string[100];
        int[] text_size = new int[100];
        StringAlignment[] text_align = new StringAlignment[100];

        string title;
        int title_size;
        int title_x;
        int title_y;

        string author;
        int author_size;
        int author_x;
        int author_y;

        int k = 0;
        string language;

        Color color_Background;
        Color color_Text;
        public Form1()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-001");
            language = "en-001";
            InitializeComponent();
            InitializeForm();
        }
        private void InitializeForm()
        {
            if (language == "ru")
                this.Text = "Дизайнер обложки книги";
            else if(language=="en-001")
                this.Text = "Book Cover Designer";
            if (!flag_start)
            {

                heightOfPanel1 = splitContainer1.Height;
                widthOfPanel1 = splitContainer1.SplitterDistance;
                widthOfForm = 1400;
                heightOfForm = 900;

                color_Background = System.Drawing.Color.Bisque;
                color_Text = System.Drawing.Color.Black;
                flag_start = true;

                CoverWidth = 300;
                CoverHeight = 500;
                SpineWidth = 30;
            }
            DrawArea = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            pictureBox1.Image = DrawArea;
            this.Width = widthOfForm;
            this.Height = heightOfForm;
            NewStripMenuItem1.Click += NewStripMenuItem1_Click;
            RussianStripMenuItem.Click += RussianStripMenuItem_Click;
            EnglishStripMenuItem.Click += EnglishStripMenuItem_Click;
            titleTtextBox.KeyDown += Form1_KeyDown;
            AuthorTextBox.KeyDown += Form1_KeyDown;
            addTextButton.KeyDown += Form1_KeyDown;
            buttonClrBackGround.KeyDown += Form1_KeyDown;
            buttonClrText.KeyDown += Form1_KeyDown;
            splitContainer1.KeyDown += Form1_KeyDown;

            paint_cover();
        }
        private void paint_cover()
        {
            int width_1_2 = (widthOfPanel1 - 2*CoverWidth - SpineWidth) / 2;
            int height_1_2 = (heightOfPanel1 - CoverHeight) / 2;
            Graphics g;
            g = Graphics.FromImage(DrawArea);
            Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 5);
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(color_Background);

            g.FillRectangle(myBrush, width_1_2, height_1_2, CoverWidth, CoverHeight);
            g.FillRectangle(myBrush, width_1_2 + CoverWidth, height_1_2, SpineWidth, CoverHeight);
            g.FillRectangle(myBrush, width_1_2 + CoverWidth + SpineWidth, height_1_2, CoverWidth, CoverHeight);

            g.DrawRectangle(blackPen, width_1_2, height_1_2, CoverWidth, CoverHeight);
            g.DrawRectangle(blackPen, width_1_2 + CoverWidth, height_1_2, SpineWidth, CoverHeight);
            g.DrawRectangle(blackPen, width_1_2 + CoverWidth + SpineWidth, height_1_2, CoverWidth, CoverHeight);

            blackPen.Dispose();
            myBrush.Dispose();
            g.Dispose();
            paint_strings();
            pictureBox1.Refresh();
        }
        private void paint_strings()
        {
            Graphics g;
            int height_1_2 = (heightOfPanel1 - CoverHeight) / 2;
            g = Graphics.FromImage(DrawArea);
            System.Drawing.Font drawFont;
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(color_Text);
            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();     
            for (int i = 0; i < k; i++)
            {
                drawFormat.Alignment = text_align[i];
                drawFont = new System.Drawing.Font("Arial", text_size[i]);
                g.DrawString(text[i], drawFont, drawBrush, text_x[i], text_y[i], drawFormat);
                drawFont.Dispose();
            }
            drawFormat.Alignment = StringAlignment.Center;
            if (titleTtextBox.Text != "")
            {
                System.Drawing.Font drawFontTitle = new System.Drawing.Font("Arial", title_size);
                g.DrawString(title, drawFontTitle, drawBrush, title_x, title_y, drawFormat);
                drawFontTitle.Dispose();
            }
            drawFormat.Alignment = StringAlignment.Near;
            if (AuthorTextBox.Text != "")
            {             
                System.Drawing.Font drawFontAuthor = new System.Drawing.Font("Arial", author_size);
                g.DrawString(author, drawFontAuthor, drawBrush, author_x, author_y, drawFormat);
                drawFontAuthor.Dispose();
            }
            if (AuthorTextBox.Text != "")
            {
                g.TranslateTransform((float)widthOfPanel1 / 2 - SpineWidth, CoverHeight + height_1_2);
                g.RotateTransform((float)270.0);
                System.Drawing.Font drawFontAuthorSpine = new System.Drawing.Font("Arial", author_size);
                g.DrawString(author, drawFontAuthorSpine, drawBrush, 0, 0, drawFormat);
                drawFontAuthorSpine.Dispose();
            }
            drawBrush.Dispose();
            g.Dispose();
            pictureBox1.Refresh();
        }
        private void splitContainer1_Panel1_SizeChanged(object sender, EventArgs e)
        {
            {
                DrawArea = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
                pictureBox1.Image = DrawArea;
                differenceHeight = (splitContainer1.Height - heightOfPanel1) / 2;
                differenceWidth = (splitContainer1.SplitterDistance - widthOfPanel1) / 2;
                title_x += differenceWidth;
                title_y += differenceHeight;
                author_x += differenceWidth;
                author_y += differenceHeight;
                for (int i = 0; i < k; i++)
                {
                    text_x[i] += differenceWidth;
                    text_y[i] += differenceHeight;
                }
                heightOfPanel1 = splitContainer1.Height;
                widthOfPanel1 = splitContainer1.SplitterDistance;
            }
            if(flag>1)
                paint_cover();
            flag++;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (flag_local)
            {
                DrawArea = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
                pictureBox1.Image = DrawArea;
                differenceHeight = (splitContainer1.Height - heightOfPanel1) / 2;
                differenceWidth = (splitContainer1.SplitterDistance - widthOfPanel1) / 2;
                title_x += differenceWidth;
                title_y += differenceHeight;
                author_x += differenceWidth;
                author_y += differenceHeight;
                for (int i = 0; i < k; i++)
                {
                    text_x[i] += differenceWidth;
                    text_y[i] += differenceHeight;

                }
                heightOfPanel1 = splitContainer1.Height;
                widthOfPanel1 = splitContainer1.SplitterDistance;
                widthOfForm = this.Width;
                heightOfForm = this.Height;
            }
            if (flag > 1)
                paint_cover();
            flag++;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (activated)
            {
                Graphics g;
                g = Graphics.FromImage(DrawArea);
                System.Drawing.Font drawFont = new System.Drawing.Font("Arial", text_size[k]);
                System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(color_Text);
                System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
                System.Drawing.SizeF sizeOfString = g.MeasureString(text[k], drawFont);
                drawFormat.Alignment = text_align[k];
                if (text_align[k] == StringAlignment.Near)
                {
                    text_x[k] = (int)(x - sizeOfString.Width / 2);
                    text_y[k] = (int)(y - sizeOfString.Height / 2);
                }
                else if (text_align[k] == StringAlignment.Center)
                {
                    text_x[k] = (int)x;
                    text_y[k] = (int)(y - sizeOfString.Height / 2);
                }
                else
                {
                    text_x[k] = (int)(x + sizeOfString.Width / 2);
                    text_y[k] = (int)(y - sizeOfString.Height / 2);
                }
                g.DrawString(text[k], drawFont, drawBrush, text_x[k],
                                                        text_y[k], drawFormat);
                k++;
                drawFont.Dispose();
                drawBrush.Dispose();
                drawFormat.Dispose();
                g.Dispose();
                pictureBox1.Refresh();
                activated = false;
            }

        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            x = e.Location.X;
            y = e.Location.Y;
            if (activated)
                pictureBox1.Cursor = Cursors.Cross;
            else
                pictureBox1.Cursor = Cursors.Default;
        }

        private void buttonClrBackGround_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color_Background = colorDialog1.Color;
                paint_cover();
            }
        }

        private void buttonClrText_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                color_Text = colorDialog2.Color;
                paint_strings();
            }
        }
        private void NewStripMenuItem1_Click(object sender, EventArgs e)
        {
            New_Cover();
        }
        private void New_Cover()
        {
            Form3 dialogBox = new Form3(language);
            if (dialogBox.ShowDialog() == DialogResult.OK)
            {
                DisposeStrings();
                color_Background = System.Drawing.Color.Bisque;
                color_Text = System.Drawing.Color.Black;
                CoverHeight = dialogBox.GetCoverHeight();
                CoverWidth = dialogBox.GetCoverWidth();
                SpineWidth = dialogBox.GetSpineWidth();
                DrawArea = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
                pictureBox1.Image = DrawArea;
            }
            dialogBox.Dispose();
            paint_cover();
        }
        private void EnglishStripMenuItem_Click(object sender, EventArgs e)
        {
            flag_local = false;
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-001");
            language = "en-001";
            this.Controls.Clear();
            this.InitializeComponent();
            InitializeForm();
            this.titleTtextBox.Text = title;
            this.AuthorTextBox.Text = author;
            this.RussianStripMenuItem.Checked = false;
            this.EnglishStripMenuItem.Checked = true ;
            this.Height = heightOfForm;
            this.Width = widthOfForm;
            flag_local = true;
            paint_cover();
            paint_strings();       
        }
        private void RussianStripMenuItem_Click(object sender, EventArgs e)
        {
            flag_local = false;
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru");
            language = "ru";
            this.Controls.Clear();
            this.InitializeComponent();
            InitializeForm();
            this.titleTtextBox.Text = title;
            this.AuthorTextBox.Text = author;
            this.RussianStripMenuItem.Checked = true;
            this.EnglishStripMenuItem.Checked = false;
            this.Height = heightOfForm;
            this.Width = widthOfForm;
            flag_local = true;
            paint_cover();
        }
        private void DisposeStrings()
        {
            text_x = new int[100];
            text_y = new int[100];
            text = new string[100];
            text_size = new int[100];
            k = 0;
            this.titleTtextBox.Text = "";
            this.AuthorTextBox.Text = "";
        }
        private void titleTtextBox_TextChanged(object sender, EventArgs e)
        {
            int left_x = (widthOfPanel1 - 2 * CoverWidth - SpineWidth) / 2 + CoverWidth + SpineWidth;
            int left_y = (heightOfPanel1 - CoverHeight) / 2;
            Graphics g;
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(color_Text);
            g = Graphics.FromImage(DrawArea);
            for (int i = 32; i > 0; i--)
            {
                System.Drawing.Font drawFont = new System.Drawing.Font("Arial", i);
                System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
                System.Drawing.SizeF sizeOfString = g.MeasureString(titleTtextBox.Text, drawFont);
                if (sizeOfString.Width <= CoverWidth && sizeOfString.Height <= CoverHeight / 3)
                {
                    title_x = left_x + (CoverWidth) / 2;
                    title_y = left_y + (CoverHeight / 3 - (int)sizeOfString.Height) / 2;
                    title = titleTtextBox.Text;
                    title_size = i;
                    paint_cover();
                    paint_strings();
                    pictureBox1.Refresh();
                    drawFont.Dispose();
                    drawFormat.Dispose();
                    g.Dispose();
                    return;
                }
                drawFont.Dispose();
                drawFormat.Dispose();
            }
            drawBrush.Dispose();
            g.Dispose();
        }
        private void AuthorTextBox_TextChanged(object sender, EventArgs e)
        {
            int left_x = (widthOfPanel1 - 2 * CoverWidth - SpineWidth) / 2 + CoverWidth + SpineWidth;
            int left_y = (heightOfPanel1 - CoverHeight) / 2 + CoverHeight / 3;
            Graphics g;
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(color_Text);
            g = Graphics.FromImage(DrawArea);
            for (int i = 24; i > 0; i--)
            {
                System.Drawing.Font drawFont = new System.Drawing.Font("Arial", i);
                System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
                System.Drawing.SizeF sizeOfString = g.MeasureString(AuthorTextBox.Text, drawFont);
                if (sizeOfString.Width <= CoverWidth && sizeOfString.Height <= CoverHeight / 6)
                {
                    author_x = left_x + (CoverWidth - (int)sizeOfString.Width) / 2;
                    author_y = left_y + (CoverHeight / 6 - (int)sizeOfString.Height) / 2;
                    author = AuthorTextBox.Text;
                    author_size = i;
                    paint_cover();
                    paint_strings();
                    pictureBox1.Refresh();
                    drawFont.Dispose();
                    drawFormat.Dispose();
                    g.Dispose();
                    return;
                }
                drawFont.Dispose();
                drawFormat.Dispose();
            }
            drawBrush.Dispose();
            g.Dispose();
        }
        private void addTextButton_MouseClick(object sender, MouseEventArgs e)
        {
            activated = true;
            Form2 dialogBox = new Form2(language);
            if (dialogBox.ShowDialog() == DialogResult.OK)
            {
                Graphics g;
                g = Graphics.FromImage(DrawArea);
                System.Drawing.Font drawFont = new System.Drawing.Font("Arial", dialogBox.GetSize());
                text[k] = dialogBox.GetText();
                text_size[k] = dialogBox.GetSize();
                if (dialogBox.GetAlign() == HorizontalAlignment.Left)
                    text_align[k] = StringAlignment.Near;
                else if(dialogBox.GetAlign() == HorizontalAlignment.Center)
                    text_align[k] = StringAlignment.Center;
                else
                    text_align[k] = StringAlignment.Far;
                drawFont.Dispose();
                g.Dispose();
            }
            dialogBox.Dispose();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control)
            {
                if (e.KeyCode == Keys.N)
                {
                    New_Cover();
                }
            }
        }    
    }
}
