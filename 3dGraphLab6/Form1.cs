using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;
using Tao.Platform.Windows;

namespace _3dGraphLab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AnT.InitializeContexts();
        }
        bool once = true;
        Color color = Color.Blue;

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMaterials();
        }
        void Display()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            Gl.glMatrixMode(Gl.GL_PROJECTION);
            if (once)
            {
                Gl.glTranslated(0, 0, -6);
                once = false;
            }
            Gl.glRotated(45,1,1,1);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Glu.gluPerspective(15, (float)AnT.Width / (float)AnT.Height, 0.1, 200);
            Gl.glLoadIdentity();
        }
        void DrawWire()
        {
            Display();
            Gl.glViewport(0, 0, AnT.Width, AnT.Height);
            var random = new Random();

            Gl.glColor3d(color.R, color.G, color.B);
            Gl.glPushMatrix();
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    Glut.glutWireSphere((double)sphere_radius.Value, (int)sphere_slices.Value, (int)sphere_stacks.Value);
                    break;
                case 1:
                    Glut.glutWireCylinder((double)cyl_radius.Value, (double) cyl_height.Value,(int)cyl_slices.Value, (int)cyl_stacks.Value);
                    break;
                case 2:
                    Glut.glutWireCube((double)cube_size.Value);
                    break;
                case 3:
                    Glut.glutWireTeapot((double)tea_size.Value);
                    break;
                case 4:
                    Glut.glutWireCone((double)con_radius.Value, (double)con_height.Value, (int)con_slices.Value, (int)con_stacks.Value);
                    break;
                case 5:
                    Glut.glutWireTorus((double)tor_radius1.Value, (double)tor_radius2.Value, (int)tor_sides.Value, (int)tor_rings.Value);
                    break;
                default:
                    MessageBox.Show("Произошла ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            Gl.glPopMatrix();
            Gl.glFlush();
            AnT.Invalidate();
        }
        void DrawSolid()
        {
            Display();
            Gl.glViewport(0, 0, AnT.Width, AnT.Height);

            Gl.glColor3f(0,0,1);
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_COLOR_MATERIAL);
            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);
            Gl.glPushMatrix();

            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    Glut.glutSolidSphere((double)sphere_radius.Value, (int)sphere_slices.Value, (int)sphere_stacks.Value);
                    break;   
                case 1:      
                    Glut.glutSolidCylinder((double)cyl_radius.Value, (double)cyl_height.Value, (int)cyl_slices.Value, (int)cyl_stacks.Value);
                    break;   
                case 2:
                    Glut.glutSolidCube((double)cube_size.Value);
                    break;   
                case 3:      
                    Glut.glutSolidTeapot((double)tea_size.Value);
                    break;   
                case 4:      
                    Glut.glutSolidCone((double)con_radius.Value, (double)con_height.Value, (int)con_slices.Value, (int)con_stacks.Value);
                    break;   
                case 5:      
                    Glut.glutSolidTorus((double)tor_radius1.Value, (double)tor_radius2.Value, (int)tor_sides.Value, (int)tor_rings.Value);
                    break;
                default:
                    MessageBox.Show("Произошла ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            Gl.glPopMatrix();
            Gl.glFlush();
            AnT.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e) => DrawWire();

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {}

        private void AnT_MouseMove(object sender, MouseEventArgs e) => Display();

        private void numericUpDown2_ValueChanged(object sender, EventArgs e) => Display();

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            color = colorDialog1.Color;
            button2.BackColor = color;
        }
        public void LoadMaterials()
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
            // отчитка окна 
            Gl.glClearColor(255, 255, 255, 1);
            // установка порта вывода в соответствии с размерами элемента anT 
            Gl.glViewport(0, 0, AnT.Width, AnT.Height);
            // настройка проекции 
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45, (float)AnT.Width / (float)AnT.Height, 0.1, 200);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            // настройка параметров OpenGL для визуализации 
            button2.BackColor = color;
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_COLOR_MATERIAL);
            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);
        }
        private void button3_Click(object sender, EventArgs e) => DrawSolid();

        private void button4_Click(object sender, EventArgs e){}
    }
}
